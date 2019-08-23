

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
    /// OrganizationQuotaDefinitions Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class OrganizationQuotaDefinitionsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractOrganizationQuotaDefinitionsEndpoint
    {
        internal OrganizationQuotaDefinitionsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for OrganizationQuotaDefinitions Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractOrganizationQuotaDefinitionsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractOrganizationQuotaDefinitionsEndpoint()
        {
        }

        /// <summary>
        /// Creating a Organization Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/creating_a_organization_quota_definition.html"</para>
        /// </summary>
        public async Task<CreateOrganizationQuotaDefinitionResponse> CreateOrganizationQuotaDefinition(CreateOrganizationQuotaDefinitionRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/quota_definitions";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Organization Quota Definitions
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/list_all_organization_quota_definitions.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse>> ListAllOrganizationQuotaDefinitions()
        {
            return await ListAllOrganizationQuotaDefinitions(new RequestOptions());
        }

        /// <summary>
        /// List all Organization Quota Definitions
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/list_all_organization_quota_definitions.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse>> ListAllOrganizationQuotaDefinitions(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/quota_definitions";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Particular Organization Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/delete_a_particular_organization_quota_definition.html"</para>
        /// </summary>
        public async Task DeleteOrganizationQuotaDefinition(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Updating a Organization Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/updating_a_organization_quota_definition.html"</para>
        /// </summary>
        public async Task<UpdateOrganizationQuotaDefinitionResponse> UpdateOrganizationQuotaDefinition(Guid? guid, UpdateOrganizationQuotaDefinitionRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Organization Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organization_quota_definitions/retrieve_a_particular_organization_quota_definition.html"</para>
        /// </summary>
        public async Task<RetrieveOrganizationQuotaDefinitionResponse> RetrieveOrganizationQuotaDefinition(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
