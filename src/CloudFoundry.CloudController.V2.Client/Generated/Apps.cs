

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Apps Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AppsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractAppsEndpoint
    {
        internal AppsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Apps Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAppsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractAppsEndpoint()
        {
        }

        /// <summary>
        /// Get the env for an App
        /// <para>Get the environment variables for an App using the app guid. Restricted to SpaceDeveloper role.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/get_the_env_for_an_app.html"</para>
        /// </summary>
        public async Task<GetEnvForAppResponse> GetEnvForApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/env", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetEnvForAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps()
        {
            return await ListAllApps(new RequestOptions());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAppsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Route with the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/associate_route_with_the_app.html"</para>
        /// </summary>
        public async Task<AssociateRouteWithAppResponse> AssociateRouteWithApp(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateRouteWithAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Routes for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_routes_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForAppResponse>> ListAllRoutesForApp(Guid? guid)
        {
            return await ListAllRoutesForApp(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Routes for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_routes_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForAppResponse>> ListAllRoutesForApp(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllRoutesForAppResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Uploads the bits for an App
        /// <para>Defines and uploads the bits (artifacts and dependencies) that this application needs to run, using a multipart PUT request.</para>
        /// <para>Bits that have already been uploaded can be referenced by their resource fingerprint(s).</para>
        /// <para>Bits that have not already been uploaded to Cloud Foundry must be included as a zipped binary file named "application".</para>
        /// <para>File mode bits are only presevered for applications run on a Diego backend. If left blank, mode will default to 749, which</para>
        /// <para>are also the default bits for a DEA backend. File mode bits are required to have at least the minimum permissions of 0600.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/uploads_the_bits_for_an_app.html"</para>
        /// </summary>
        public async Task<UploadsBitsForAppResponse> UploadsBitsForApp(Guid? guid, dynamic value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/bits", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            //client.ContentType = "multipart/form-data; boundary=----------XnJLe9ZIbbGUYtzPQJ16u1";
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UploadsBitsForAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get detailed stats for a STARTED App
        /// <para>Get status for each instance of an App using the app guid.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/get_detailed_stats_for_a_started_app.html"</para>
        /// </summary>
        public async Task<Dictionary<int?, GetDetailedStatsForStartedAppResponse>> GetDetailedStatsForStartedApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/stats", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<Dictionary<int?, GetDetailedStatsForStartedAppResponse>>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Bindings for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_service_bindings_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForAppResponse>> ListAllServiceBindingsForApp(Guid? guid)
        {
            return await ListAllServiceBindingsForApp(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Bindings for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/list_all_service_bindings_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForAppResponse>> ListAllServiceBindingsForApp(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/service_bindings", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsForAppResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Get the instance information for a STARTED App
        /// <para>Get status for each instance of an App using the app guid. Note: Provided example response is for apps running on Diego.</para>
        /// <para></para>
        /// <para>For apps running on DEAs, instance information will appear as follows:</para>
        /// <para>{</para>
        /// <para>"0": {</para>
        /// <para>"state": "RUNNING",</para>
        /// <para>"since": 1403140717.984577,</para>
        /// <para>"debug_ip": null,</para>
        /// <para>"debug_port": null,</para>
        /// <para>"console_ip": null,</para>
        /// <para>"console_port": null</para>
        /// <para>}</para>
        /// <para>}.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/get_the_instance_information_for_a_started_app.html"</para>
        /// </summary>
        public async Task<Dictionary<int?, GetInstanceInformationForStartedAppResponse>> GetInstanceInformationForStartedApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/instances", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<Dictionary<int?, GetInstanceInformationForStartedAppResponse>>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/retrieve_a_particular_app.html"</para>
        /// </summary>
        public async Task<RetrieveAppResponse> RetrieveApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Downloads the staged droplet for an App
        /// <para>When using a remote blobstore, such as AWS, the response is a redirect to the actual location of the bits.</para>
        /// <para>If the client is automatically following redirects, then the OAuth token that was used to communicate with Cloud Controller will be replayed on the new redirect request.</para>
        /// <para>Some blobstores may reject the request in that case. Clients may need to follow the redirect without including the OAuth token.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/downloads_the_staged_droplet_for_an_app.html"</para>
        /// </summary>
        public async Task DownloadsStagedDropletForApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/droplet/download", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 302;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Downloads the bits for an App
        /// <para>When using a remote blobstore, such as AWS, the response is a redirect to the actual location of the bits.</para>
        /// <para>If the client is automatically following redirects, then the OAuth token that was used to communicate with Cloud Controller will be replayed on the new redirect request.</para>
        /// <para>Some blobstores may reject the request in that case. Clients may need to follow the redirect without including the OAuth token.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/downloads_the_bits_for_an_app.html"</para>
        /// </summary>
        public async Task DownloadsBitsForApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/download", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 302;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Service Binding from the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/remove_service_binding_from_the_app.html"</para>
        /// </summary>
        public async Task RemoveServiceBindingFromApp(Guid? guid, Guid? service_binding_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/service_bindings/{1}", guid, service_binding_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Creating a Docker App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/creating_a_docker_app.html"</para>
        /// </summary>
        public async Task<CreateDockerAppResponse> CreateDockerApp(CreateDockerAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateDockerAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/delete_a_particular_app.html"</para>
        /// </summary>
        public async Task DeleteApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Get App summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/get_app_summary.html"</para>
        /// </summary>
        public async Task<GetAppSummaryResponse> GetAppSummary(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/summary", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetAppSummaryResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Restage an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/restage_an_app.html"</para>
        /// </summary>
        public async Task<RestageAppResponse> RestageApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/restage", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RestageAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Creating an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/creating_an_app.html"</para>
        /// </summary>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Terminate the running App Instance at the given index
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/terminate_the_running_app_instance_at_the_given_index.html"</para>
        /// </summary>
        public async Task TerminateRunningAppInstanceAtGivenIndex(Guid? guid, int? index)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/instances/{1}", guid, index);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Route from the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/remove_route_from_the_app.html"</para>
        /// </summary>
        public async Task RemoveRouteFromApp(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Updating an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/updating_an_app.html"</para>
        /// </summary>
        public async Task<UpdateAppResponse> UpdateApp(Guid? guid, UpdateAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Copy the app bits for an App
        /// <para>This endpoint will copy the package bits in the blobstore from the source app to the destination app.</para>
        /// <para>It will always return a job which you can query for success or failure.</para>
        /// <para>This operation will require the app to restart in order for the changes to take effect.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/apps/copy_the_app_bits_for_an_app.html"</para>
        /// </summary>
        public async Task<CopyAppBitsForAppResponse> CopyAppBitsForApp(Guid? guid, CopyAppBitsForAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/copy_bits", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CopyAppBitsForAppResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
