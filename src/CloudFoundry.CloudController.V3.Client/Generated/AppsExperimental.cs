using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V3.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// AppsExperimental Endpoint
    /// </summary>
    public partial class AppsExperimentalEndpoint : CloudFoundry.CloudController.V3.Client.Base.AbstractAppsExperimentalEndpoint
    {
        internal AppsExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V3.Client.Base
{
    /// <summary>
    /// Base abstract class for AppsExperimental Endpoint
    /// </summary>
    public abstract class AbstractAppsExperimentalEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractAppsExperimentalEndpoint()
        {
        }

        /// <summary>
        /// Assigning a droplet as an App's current droplet
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/assigning_a_droplet_as_an_app's_current_droplet.html"</para>
        /// </summary>
        public async Task<AssignDropletAsAppsCurrentDropletResponse> AssignDropletAsAppsCurrentDroplet(Guid appGuid, Guid dropLetGuid)
        {
            var request = new AssignDropletAsAppsCurrentDropletRequest(dropLetGuid);
            var response = await this.GetNewHttpClient().PatchAsync($"/v3/apps/{appGuid}/relationships/current_droplet", request);

            return JsonConvert.DeserializeObject<AssignDropletAsAppsCurrentDropletResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Create an App
        /// <para>Creates an app in v3 of the Cloud Controller API.</para>
        /// <para>Apps must have a valid space guid for creation, which is namespaced under {"relationships": {"space": "your-space-guid"} }.</para>
        /// <para>See the example below for more information.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/create_an_app.html"</para>
        /// </summary>
        public async Task<CreateAppResponse> CreateApp(string appName, Guid spaceGuid)
        {
            var request = new CreateAppRequest(appName, spaceGuid);
            var response = await this.GetNewHttpClient().PostAsync("/v3/apps", request);

            return JsonConvert.DeserializeObject<CreateAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/delete_an_app.html"</para>
        /// </summary>
        public async Task DeleteApp(Guid guid)
        {
            await this.GetNewHttpClient().DeleteAsync($"/v3/apps/{guid}");
        }

        /// <summary>
        /// Filters Droplets by states, app_guids
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/filters_droplets_by_states,_app_guids.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FiltersDropletsByStatesAppGuidsResponse>> FiltersDropletsByStatesAppGuids(Guid? guid)
        {
            return await FiltersDropletsByStatesAppGuids(guid, new RequestOptions());
        }

        /// <summary>
        /// Filters Droplets by states, app_guids
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/filters_droplets_by_states,_app_guids.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FiltersDropletsByStatesAppGuidsResponse>> FiltersDropletsByStatesAppGuids(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/droplets", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FiltersDropletsByStatesAppGuidsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Get a Process from an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_a_process_from_an_app.html"</para>
        /// </summary>
        public async Task<GetProcessFromAppResponse> GetProcessFromApp(Guid? guid, dynamic type)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/apps/{guid}/processes/{type}");
            return JsonConvert.DeserializeObject<GetProcessFromAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_an_app.html"</para>
        /// </summary>
        public async Task<GetAppResponse> GetApp(Guid? guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/apps/{guid}");
            return JsonConvert.DeserializeObject<GetAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get the env for an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_the_env_for_an_app.html"</para>
        /// </summary>
        public async Task<GetEnvForAppResponse> GetEnvForApp(Guid guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/apps/{guid}/env");
            return JsonConvert.DeserializeObject<GetEnvForAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps()
        {
            return await ListAllApps(new RequestOptions());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/apps";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAppsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List associated droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedDropletsResponse>> ListAssociatedDroplets(Guid? guid)
        {
            return await ListAssociatedDroplets(guid, new RequestOptions());
        }

        /// <summary>
        /// List associated droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedDropletsResponse>> ListAssociatedDroplets(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/droplets", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAssociatedDropletsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List associated packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedPackagesResponse>> ListAssociatedPackages(Guid? guid)
        {
            return await ListAssociatedPackages(guid, new RequestOptions());
        }

        /// <summary>
        /// List associated packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedPackagesResponse>> ListAssociatedPackages(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/packages", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);  
            return Utilities.DeserializePage<ListAssociatedPackagesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List associated processes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_processes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedProcessesResponse>> ListAssociatedProcesses(Guid? guid)
        {
            return await ListAssociatedProcesses(guid, new RequestOptions());
        }

        /// <summary>
        /// List associated processes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/list_associated_processes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociatedProcessesResponse>> ListAssociatedProcesses(Guid? appGuid, RequestOptions options)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/apps/{appGuid}/processes");
            return Utilities.DeserializePage<ListAssociatedProcessesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Scaling a Process from its App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/scaling_a_process_from_its_app.html"</para>
        /// </summary>
        public async Task<ScalingProcessFromItsAppResponse> ScalingProcessFromItsApp(Guid? guid, dynamic type, ScalingProcessFromItsAppRequest value)
        {
            var response = await this.GetNewHttpClient().PutAsync($"/v3/apps/{guid}/processes/{type}/scale");
            return JsonConvert.DeserializeObject<ScalingProcessFromItsAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Starting an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/starting_an_app.html"</para>
        /// </summary>
        public async Task<StartingAppResponse> StartingApp(Guid guid)
        {
            var response = await this.GetNewHttpClient().PostAsync($"/v3/apps/{guid}/actions/start");
            return JsonConvert.DeserializeObject<StartingAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Stopping an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/stopping_an_app.html"</para>
        /// </summary>
        public async Task<StoppingAppResponse> StoppingApp(Guid? guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/apps/{guid}/stop");
            return JsonConvert.DeserializeObject<StoppingAppResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Terminating a Process instance from its App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/terminating_a_process_instance_from_its_app.html"</para>
        /// </summary>
        public async Task TerminatingProcessInstanceFromItsApp(Guid? guid, dynamic type, int? index)
        {
            await this.GetNewHttpClient().DeleteAsync($"/v3/apps/{guid}/processes/{type}/instances/{index}");
        }

        /// <summary>
        /// Updating an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/apps__experimental_/updating_an_app.html"</para>
        /// </summary>
        public async Task<UpdateAppResponse> UpdateApp(Guid? guid, UpdateAppRequest value)
        {
            var response = await this.GetNewHttpClient().PatchAsync($"/v3/apps/{guid}", value);
            return JsonConvert.DeserializeObject<UpdateAppResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
