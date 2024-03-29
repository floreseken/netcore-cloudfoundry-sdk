

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
    /// DomainsDeprecated Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class DomainsDeprecatedEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractDomainsDeprecatedEndpoint
    {
        internal DomainsDeprecatedEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for DomainsDeprecated Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractDomainsDeprecatedEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractDomainsDeprecatedEndpoint()
        {
        }

        /// <summary>
        /// Create a Shared Domain (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/create_a_shared_domain_(deprecated).html"</para>
        /// </summary>
        public async Task<CreateSharedDomainDeprecatedResponse> CreateSharedDomainDeprecated(CreateSharedDomainDeprecatedRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/domains";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSharedDomainDeprecatedResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Domain (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/delete_a_particular_domain_(deprecated).html"</para>
        /// </summary>
        public async Task DeleteDomainDeprecated(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Spaces for the Domain (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/list_all_spaces_for_the_domain_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForDomainDeprecatedResponse>> ListAllSpacesForDomainDeprecated(Guid? guid)
        {
            return await ListAllSpacesForDomainDeprecated(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the Domain (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/list_all_spaces_for_the_domain_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForDomainDeprecatedResponse>> ListAllSpacesForDomainDeprecated(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/domains/{0}/spaces", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForDomainDeprecatedResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Domain (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/retrieve_a_particular_domain_(deprecated).html"</para>
        /// </summary>
        public async Task<RetrieveDomainDeprecatedResponse> RetrieveDomainDeprecated(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/domains/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveDomainDeprecatedResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Create a Domain owned by the given Organization (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/create_a_domain_owned_by_the_given_organization_(deprecated).html"</para>
        /// </summary>
        public async Task<CreateDomainOwnedByGivenOrganizationDeprecatedResponse> CreateDomainOwnedByGivenOrganizationDeprecated(CreateDomainOwnedByGivenOrganizationDeprecatedRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/domains";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateDomainOwnedByGivenOrganizationDeprecatedResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Domains (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/list_all_domains_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsDeprecatedResponse>> ListAllDomainsDeprecated()
        {
            return await ListAllDomainsDeprecated(new RequestOptions());
        }

        /// <summary>
        /// List all Domains (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/domains__deprecated_/list_all_domains_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsDeprecatedResponse>> ListAllDomainsDeprecated(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/domains";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDomainsDeprecatedResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
