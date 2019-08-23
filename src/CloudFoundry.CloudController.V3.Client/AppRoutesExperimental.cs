using CloudFoundry.CloudController.V3.Client.Model;
using CloudFoundry.CloudController.V3.Client.Helpers;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{

    public class AppRoutesExperimentalEndpoint : BaseEndpoint
    {
        public AppRoutesExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
        

        /// <summary>
        /// List routes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/list_routes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRoutesResponse>> ListRoutes(Guid? guid)
        {
            return await ListRoutes(guid, new RequestOptions());
        }

        /// <summary>
        /// List routes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/list_routes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRoutesResponse>> ListRoutes(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
 
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListRoutesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Map a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/map_a_route.html"</para>
        /// </summary>
        public async Task MapRoute(Guid? guid, MapRouteRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/routes", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus, new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json"));
        }

        /// <summary>
        /// Unmap a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/unmap_a_route.html"</para>
        /// </summary>
        public async Task UnmapRoute(Guid? guid, UnmapRouteRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/routes", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus, new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json"));
        }
    }
}
