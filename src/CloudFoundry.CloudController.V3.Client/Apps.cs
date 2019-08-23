namespace CloudFoundry.CloudController.V3.Client
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Http;
    using CloudFoundry.CloudController.Common.PushTools;
    using CloudFoundry.CloudController.V2.Client;
    using CloudFoundry.CloudController.V2.Client.Data;
    using CloudFoundry.CloudController.V3.Client.Model;

    public partial class AppsExperimentalEndpoint
    {
        private const int StepCount = 8;

        /// <summary>
        /// Event that is raised on specific parts of the push process.
        /// </summary>
        public event EventHandler<PushProgressEventArgs> PushProgress;

        /// <summary>
        /// Pushes an application to the cloud.
        /// <remarks>
        /// </remarks>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        /// <param name="appGuid">Application guid</param>
        /// <param name="appPath">Path of origin from which the application will be deployed</param>
        /// <param name="stack">The name of the stack the app will be running on</param>
        /// <param name="buildpackGitUrl">Git URL of the buildpack</param>
        /// <param name="startApplication">True if the app should be started after upload is complete, false otherwise</param>
        /// <param name="diskLimit">Memory limit used to stage package</param>
        /// <param name="memoryLimit">Disk limit used to stage package</param>
        public async Task Push(Guid appGuid, string appPath, string stack, string buildpackGitUrl, bool startApplication, int memoryLimit, int diskLimit)
        {
            if (appPath == null)
            {
                throw new ArgumentNullException("appPath");
            }

            IAppPushTools pushTools = new AppPushTools(appPath);
            int usedSteps = 1;

            // Step 1 - Check if application exists
            this.TriggerPushProgressEvent(usedSteps, "Checking if application exists");
            var app = await this.Client.AppsExperimental.GetApp(appGuid);

            usedSteps += 1;

            // Step 2 - Create package
            var createPackage = new CreatePackageRequest(appGuid);
            CreatePackageResponse packageResponse = await this.Client.PackagesExperimental.CreatePackage(createPackage);

            Guid packageId = new Guid(packageResponse.Guid.ToString());

            if (this.CheckCancellation())
            {
                return;
            }

            usedSteps += 1;

            // Step 3 - Zip all needed files and get a stream back from the PushTools
            this.TriggerPushProgressEvent(usedSteps, "Creating zip package ...");
            using (Stream zippedPayload = pushTools.GetZippedPayload(this.Client.CancellationToken))
            {
                if (this.CheckCancellation())
                {
                    return;
                }

                usedSteps += 1;

                // Step 4 - Upload zip to CloudFoundry ...
                this.TriggerPushProgressEvent(usedSteps, "Uploading zip package ...");
                await this.Client.PackagesExperimental.UploadBits(packageId, zippedPayload);


                bool uploadProcessed = false;
                while (!uploadProcessed)
                {
                    GetPackageResponse getPackage = await this.Client.PackagesExperimental.GetPackage(packageId);
                    Console.WriteLine(getPackage.State);

                    switch (getPackage.State)
                    {

                        case "FAILED":
                            {
                                throw new Exception(string.Format(CultureInfo.InvariantCulture, "Upload failed: {0}", getPackage.Data["error"]));
                            }

                        case "READY":
                            {
                                uploadProcessed = true;
                                break;
                            }

                        default: continue;
                    }

                    if (this.CheckCancellation())
                    {
                        return;
                    }

                    Task.Delay(500).Wait();
                }

                usedSteps += 1;
            }

            var buildResponse = await this.Client.BuildsExperimental.CreateBuild(packageId);

            if (this.CheckCancellation())
            {
                return;
            }

            usedSteps += 1;
            Guid dropLetGuid;
            if (startApplication)
            {
                bool staged = false;
                while (!staged)
                {
                    var getBuild = await this.Client.BuildsExperimental.GetBuild(buildResponse.Guid.Value);

                    Console.WriteLine(getBuild.State);
                    switch (getBuild.State)
                    {
                        case "FAILED":
                            {
                                throw new Exception(string.Format(CultureInfo.InvariantCulture, "Staging failed: {0}", getBuild.Error));
                            }

                        case "STAGED":
                            {
                                staged = true;
                                dropLetGuid = getBuild.Droplet.Guid;
                                break;
                            }

                        default: continue;
                    }

                    if (this.CheckCancellation())
                    {
                        return;
                    }

                    Task.Delay(500).Wait();
                }

                //check droplets..
                using (SimpleHttpClient httpClient = new SimpleHttpClient(this.Client.CancellationToken, new TimeSpan(0, 30, 0), true))
                {
                    httpClient.SkipCertificateValidation = true;

                    httpClient.Headers.Add("Authorization", string.Format("bearer {0}", this.Client.AuthorizationToken));

                    httpClient.Uri = new Uri($"https://api.system.cf.singel.home/v3/apps/{appGuid}/droplets");
                    httpClient.Method = HttpMethod.Get;

                    //var fap = new { package = new { guid = packageId } };

                    HttpResponseMessage dropResponse = await httpClient.SendAsync();
                    var beun = dropResponse.Content.ReadAsStringAsync().Result;
                }






                // Step 6 - Assign droplet
                //var assignRequest = new AssignDropletAsAppsCurrentDropletRequest(dropLetGuid);
                var assignDroplet = await this.AssignDropletAsAppsCurrentDroplet(appGuid, dropLetGuid);

                if (this.CheckCancellation())
                {
                    return;
                }

                usedSteps += 1;

                //create route
                var routeRequest = new CreateRouteRequest();
                routeRequest.Host = "test-route";
                routeRequest.SpaceGuid = new Guid("ef1c944d-c7ec-4ceb-8177-317130a005da");
                routeRequest.DomainGuid = new Guid("ff8129d7-6304-49da-8345-9c7317ac9d02");
                var routeResponse = await this.Client.V2.Routes.CreateRoute(routeRequest);


                //map route
                // var mapRouteRequest = new MapRouteRequest();
                // mapRouteRequest.RouteGuid = routeResponse.EntityMetadata.Guid;
                await this.Client.V2.Routes.AssociateAppWithRoute(routeResponse.EntityMetadata.Guid, appGuid);


                // Step 7 - Start Application                
                StartingAppResponse response = await this.Client.AppsExperimental.StartingApp(appGuid);
                if (this.CheckCancellation())
                {
                    return;
                }

                usedSteps += 1;
            }

            // Step 8 - Done
            this.TriggerPushProgressEvent(usedSteps, "Application {0} pushed successfully", app.Name);
        }

        /// <summary>
        /// Triggers the PushProgress event
        /// </summary>
        /// <param name="currentStep">Current progress step</param>
        /// <param name="message">Message describing push progress</param>
        private void TriggerPushProgressEvent(int currentStep, string message)
        {
            if (this.PushProgress != null)
            {
                this.PushProgress(
                    this,
                    new PushProgressEventArgs()
                    {
                        Message = message,
                        Percent = (int)(((double)currentStep / (double)StepCount) * 100)
                    });
            }
        }

        /// <summary>
        /// Helper method that checks the cancellation token and triggers 
        /// the push progress event if cancellation was requested.
        /// </summary>
        /// <returns>True if cancellation was requested, false otherwise.</returns>
        private bool CheckCancellation()
        {
            if (this.Client.CancellationToken.IsCancellationRequested)
            {
                this.TriggerPushProgressEvent(StepCount, "Push cancelled");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Triggers the PushProgress event
        /// </summary>
        /// <param name="currentStep">Current progress step</param>
        /// <param name="message">Message describing push progress</param>
        /// <param name="formatParameters">Format parameters for the message</param>
        private void TriggerPushProgressEvent(int currentStep, string message, params string[] formatParameters)
        {
            this.TriggerPushProgressEvent(currentStep, string.Format(CultureInfo.InvariantCulture, message, formatParameters));
        }
    }
}