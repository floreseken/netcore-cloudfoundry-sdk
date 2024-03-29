

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
    /// PrivateDomains Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class PrivateDomainsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractPrivateDomainsEndpoint
    {
        internal PrivateDomainsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for PrivateDomains Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractPrivateDomainsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractPrivateDomainsEndpoint()
        {
        }

        /// <summary>
        /// Filtering Private Domains by name
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/filtering_private_domains_by_name.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterPrivateDomainsByNameResponse>> FilterPrivateDomainsByName()
        {
            return await FilterPrivateDomainsByName(new RequestOptions());
        }

        /// <summary>
        /// Filtering Private Domains by name
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/filtering_private_domains_by_name.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<FilterPrivateDomainsByNameResponse>> FilterPrivateDomainsByName(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/private_domains";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Shared Organizations for the Private Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/list_all_shared_organizations_for_the_private_domain.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSharedOrganizationsForPrivateDomainResponse>> ListAllSharedOrganizationsForPrivateDomain(Guid? guid)
        {
            return await ListAllSharedOrganizationsForPrivateDomain(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Shared Organizations for the Private Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/list_all_shared_organizations_for_the_private_domain.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSharedOrganizationsForPrivateDomainResponse>> ListAllSharedOrganizationsForPrivateDomain(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/private_domains/{0}/shared_organizations", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSharedOrganizationsForPrivateDomainResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Create a Private Domain owned by the given Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/create_a_private_domain_owned_by_the_given_organization.html"</para>
        /// </summary>
        public async Task<CreatePrivateDomainOwnedByGivenOrganizationResponse> CreatePrivateDomainOwnedByGivenOrganization(CreatePrivateDomainOwnedByGivenOrganizationRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/private_domains";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Private Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/delete_a_particular_private_domain.html"</para>
        /// </summary>
        public async Task DeletePrivateDomain(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/private_domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Retrieve a Particular Private Domain
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/retrieve_a_particular_private_domain.html"</para>
        /// </summary>
        public async Task<RetrievePrivateDomainResponse> RetrievePrivateDomain(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/private_domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievePrivateDomainResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Private Domains
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/list_all_private_domains.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsResponse>> ListAllPrivateDomains()
        {
            return await ListAllPrivateDomains(new RequestOptions());
        }

        /// <summary>
        /// List all Private Domains
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/private_domains/list_all_private_domains.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsResponse>> ListAllPrivateDomains(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/private_domains";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPrivateDomainsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
