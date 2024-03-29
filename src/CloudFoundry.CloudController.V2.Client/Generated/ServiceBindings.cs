

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
    /// ServiceBindings Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceBindingsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceBindingsEndpoint
    {
        internal ServiceBindingsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceBindings Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceBindingsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceBindingsEndpoint()
        {
        }

        /// <summary>
        /// List all Service Bindings
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_bindings/list_all_service_bindings.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsResponse>> ListAllServiceBindings()
        {
            return await ListAllServiceBindings(new RequestOptions());
        }

        /// <summary>
        /// List all Service Bindings
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_bindings/list_all_service_bindings.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsResponse>> ListAllServiceBindings(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_bindings";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Service Binding
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_bindings/retrieve_a_particular_service_binding.html"</para>
        /// </summary>
        public async Task<RetrieveServiceBindingResponse> RetrieveServiceBinding(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_bindings/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceBindingResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Binding
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_bindings/delete_a_particular_service_binding.html"</para>
        /// </summary>
        public async Task DeleteServiceBinding(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_bindings/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Create a Service Binding
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_bindings/create_a_service_binding.html"</para>
        /// </summary>
        public async Task<CreateServiceBindingResponse> CreateServiceBinding(CreateServiceBindingRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_bindings";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServiceBindingResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
