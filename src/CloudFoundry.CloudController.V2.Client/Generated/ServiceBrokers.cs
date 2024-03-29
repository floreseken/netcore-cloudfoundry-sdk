

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
    /// ServiceBrokers Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceBrokersEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceBrokersEndpoint
    {
        internal ServiceBrokersEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceBrokers Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceBrokersEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceBrokersEndpoint()
        {
        }

        /// <summary>
        /// Retrieve a Particular Service Broker
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/retrieve_a_particular_service_broker.html"</para>
        /// </summary>
        public async Task<RetrieveServiceBrokerResponse> RetrieveServiceBroker(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_brokers/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceBrokerResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Broker
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/delete_a_particular_service_broker.html"</para>
        /// </summary>
        public async Task DeleteServiceBroker(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_brokers/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Update a Service Broker
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/update_a_service_broker.html"</para>
        /// </summary>
        public async Task<UpdateServiceBrokerResponse> UpdateServiceBroker(Guid? guid, UpdateServiceBrokerRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_brokers/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateServiceBrokerResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Create a Service Broker
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/create_a_service_broker.html"</para>
        /// </summary>
        public async Task<CreateServiceBrokerResponse> CreateServiceBroker(CreateServiceBrokerRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_brokers";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServiceBrokerResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Brokers
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/list_all_service_brokers.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBrokersResponse>> ListAllServiceBrokers()
        {
            return await ListAllServiceBrokers(new RequestOptions());
        }

        /// <summary>
        /// List all Service Brokers
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_brokers/list_all_service_brokers.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBrokersResponse>> ListAllServiceBrokers(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_brokers";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBrokersResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
