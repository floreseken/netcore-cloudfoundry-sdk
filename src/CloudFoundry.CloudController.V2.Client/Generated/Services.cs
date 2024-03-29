

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
    /// Services Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServicesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServicesEndpoint
    {
        internal ServicesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Services Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServicesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServicesEndpoint()
        {
        }

        /// <summary>
        /// Delete a Particular Service
        /// <para>Deleting with async not set to true will return a 204 status code and an empty response body.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/delete_a_particular_service.html"</para>
        /// </summary>
        public async Task<DeleteServiceResponse> DeleteService(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/services/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 202;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<DeleteServiceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Plans for the Service
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/list_all_service_plans_for_the_service.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlansForServiceResponse>> ListAllServicePlansForService(Guid? guid)
        {
            return await ListAllServicePlansForService(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Plans for the Service
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/list_all_service_plans_for_the_service.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlansForServiceResponse>> ListAllServicePlansForService(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/services/{0}/service_plans", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicePlansForServiceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Service
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/retrieve_a_particular_service.html"</para>
        /// </summary>
        public async Task<RetrieveServiceResponse> RetrieveService(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/services/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Services
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/list_all_services.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesResponse>> ListAllServices()
        {
            return await ListAllServices(new RequestOptions());
        }

        /// <summary>
        /// List all Services
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/services/list_all_services.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesResponse>> ListAllServices(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/services";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
