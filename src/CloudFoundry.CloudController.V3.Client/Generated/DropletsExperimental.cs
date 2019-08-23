using CloudFoundry.CloudController.V3.Client.Data;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// Class for DropletsExperimental Endpoint
    /// </summary>
    public class DropletsExperimentalEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        internal DropletsExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }

        /// <summary>
        /// Delete a Droplet
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/delete_a_droplet.html"</para>
        /// </summary>
        public async Task DeleteDroplet(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/droplets/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
  
            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Filters Droplets by states, app_guids
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/filters_droplets_by_states,_app_guids.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FiltersDropletsByStatesAppGuidsResponse>> FiltersDropletsByStatesAppGuids()
        {
            return await FiltersDropletsByStatesAppGuids(new RequestOptions());
        }

        /// <summary>
        /// Filters Droplets by states, app_guids
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/filters_droplets_by_states,_app_guids.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FiltersDropletsByStatesAppGuidsResponse>> FiltersDropletsByStatesAppGuids(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/droplets";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FiltersDropletsByStatesAppGuidsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Get a Droplet
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/get_a_droplet.html"</para>
        /// </summary>
        public async Task<GetDropletResponse> GetDroplet(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/droplets/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetDropletResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/list_all_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDropletsResponse>> ListAllDroplets()
        {
            return await ListAllDroplets(new RequestOptions());
        }

        /// <summary>
        /// List all Droplets
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/droplets__experimental_/list_all_droplets.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDropletsResponse>> ListAllDroplets(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/droplets";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
 
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDropletsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
