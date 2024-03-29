

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
    /// ServicePlans Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServicePlansEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServicePlansEndpoint
    {
        internal ServicePlansEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServicePlans Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServicePlansEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServicePlansEndpoint()
        {
        }

        /// <summary>
        /// Updating a Service Plan
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/updating_a_service_plan.html"</para>
        /// </summary>
        public async Task<UpdateServicePlanResponse> UpdateServicePlan(UpdateServicePlanRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_plans";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateServicePlanResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Instances for the Service Plan
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/list_all_service_instances_for_the_service_plan.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse>> ListAllServiceInstancesForServicePlan(Guid? guid)
        {
            return await ListAllServiceInstancesForServicePlan(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Instances for the Service Plan
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/list_all_service_instances_for_the_service_plan.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse>> ListAllServiceInstancesForServicePlan(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_plans/{0}/service_instances", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceInstancesForServicePlanResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Service Plans
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/list_all_service_plans.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlansResponse>> ListAllServicePlans()
        {
            return await ListAllServicePlans(new RequestOptions());
        }

        /// <summary>
        /// List all Service Plans
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/list_all_service_plans.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlansResponse>> ListAllServicePlans(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_plans";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicePlansResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Particular Service Plans
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/delete_a_particular_service_plans.html"</para>
        /// </summary>
        public async Task DeleteServicePlans(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_plans/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Retrieve a Particular Service Plan
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_plans/retrieve_a_particular_service_plan.html"</para>
        /// </summary>
        public async Task<RetrieveServicePlanResponse> RetrieveServicePlan(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_plans/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServicePlanResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
