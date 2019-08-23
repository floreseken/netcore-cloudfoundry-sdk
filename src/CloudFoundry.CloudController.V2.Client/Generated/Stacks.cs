

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
    /// Stacks Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class StacksEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractStacksEndpoint
    {
        internal StacksEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Stacks Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractStacksEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractStacksEndpoint()
        {
        }

        /// <summary>
        /// List all Stacks
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/stacks/list_all_stacks.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllStacksResponse>> ListAllStacks()
        {
            return await ListAllStacks(new RequestOptions());
        }

        /// <summary>
        /// List all Stacks
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/stacks/list_all_stacks.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllStacksResponse>> ListAllStacks(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/stacks";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllStacksResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Particular Stack
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/stacks/delete_a_particular_stack.html"</para>
        /// </summary>
        public async Task DeleteStack(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/stacks/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Create a Stack
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/stacks/create_a_stack.html"</para>
        /// </summary>
        public async Task<CreateStackResponse> CreateStack(CreateStackRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/stacks";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateStackResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Stack
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/stacks/retrieve_a_particular_stack.html"</para>
        /// </summary>
        public async Task<RetrieveStackResponse> RetrieveStack(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/stacks/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveStackResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
