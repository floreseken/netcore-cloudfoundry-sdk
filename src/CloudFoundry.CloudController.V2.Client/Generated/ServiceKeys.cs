

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
    /// ServiceKeys Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceKeysEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceKeysEndpoint
    {
        internal ServiceKeysEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceKeys Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceKeysEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceKeysEndpoint()
        {
        }

        /// <summary>
        /// List all Service Keys
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_keys/list_all_service_keys.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceKeysResponse>> ListAllServiceKeys()
        {
            return await ListAllServiceKeys(new RequestOptions());
        }

        /// <summary>
        /// List all Service Keys
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_keys/list_all_service_keys.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceKeysResponse>> ListAllServiceKeys(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_keys";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceKeysResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Create a Service Key
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_keys/create_a_service_key.html"</para>
        /// </summary>
        public async Task<CreateServiceKeyResponse> CreateServiceKey(CreateServiceKeyRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_keys";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServiceKeyResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Service Key
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_keys/retrieve_a_particular_service_key.html"</para>
        /// </summary>
        public async Task<RetrieveServiceKeyResponse> RetrieveServiceKey(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_keys/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceKeyResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Key
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_keys/delete_a_particular_service_key.html"</para>
        /// </summary>
        public async Task DeleteServiceKey(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_keys/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}
