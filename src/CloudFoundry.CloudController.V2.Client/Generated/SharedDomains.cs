

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
    /// SharedDomains Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SharedDomainsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSharedDomainsEndpoint
    {
        internal SharedDomainsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for SharedDomains Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSharedDomainsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSharedDomainsEndpoint()
        {
        }

        /// <summary>
        /// List all Shared Domains
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/list_all_shared_domains.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSharedDomainsResponse>> ListAllSharedDomains()
        {
            return await ListAllSharedDomains(new RequestOptions());
        }

        /// <summary>
        /// List all Shared Domains
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/list_all_shared_domains.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSharedDomainsResponse>> ListAllSharedDomains(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/shared_domains";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSharedDomainsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Shared Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/retrieve_a_particular_shared_domain.html"</para>
        /// </summary>
        public async Task<RetrieveSharedDomainResponse> RetrieveSharedDomain(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/shared_domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveSharedDomainResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Filtering Shared Domains by name
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/filtering_shared_domains_by_name.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterSharedDomainsByNameResponse>> FilterSharedDomainsByName()
        {
            return await FilterSharedDomainsByName(new RequestOptions());
        }

        /// <summary>
        /// Filtering Shared Domains by name
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/filtering_shared_domains_by_name.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterSharedDomainsByNameResponse>> FilterSharedDomainsByName(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/shared_domains";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FilterSharedDomainsByNameResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Create a Shared Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/create_a_shared_domain.html"</para>
        /// </summary>
        public async Task<CreateSharedDomainResponse> CreateSharedDomain(CreateSharedDomainRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/shared_domains";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSharedDomainResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Shared Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/shared_domains/delete_a_particular_shared_domain.html"</para>
        /// </summary>
        public async Task DeleteSharedDomain(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/shared_domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}
