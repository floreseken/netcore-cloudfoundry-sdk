

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
    /// Organizations Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class OrganizationsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractOrganizationsEndpoint
    {
        internal OrganizationsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Organizations Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractOrganizationsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractOrganizationsEndpoint()
        {
        }

        /// <summary>
        /// Retrieving organization instance usage
        /// <para>This endpoint returns a count of started app instances under an organization.</para>
        /// <para>Note that crashing apps are included in this count.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/retrieving_organization_instance_usage.html"</para>
        /// </summary>
        public async Task<RetrievingOrganizationInstanceUsageResponse> RetrievingOrganizationInstanceUsage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/instance_usage", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievingOrganizationInstanceUsageResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Manager with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_manager_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task<AssociateManagerWithOrganizationByUsernameResponse> AssociateManagerWithOrganizationByUsername(Guid? guid, AssociateManagerWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/managers", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagerWithOrganizationByUsernameResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Remove Auditor from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_auditor_from_the_organization.html"</para>
        /// </summary>
        public async Task RemoveAuditorFromOrganization(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Billing Manager from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_billing_manager_from_the_organization.html"</para>
        /// </summary>
        public async Task RemoveBillingManagerFromOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Spaces for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_spaces_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid)
        {
            return await ListAllSpacesForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_spaces_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForOrganizationResponse>> ListAllSpacesForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/spaces", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove User from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_user_from_the_organization.html"</para>
        /// </summary>
        public async Task RemoveUserFromOrganization(Guid? guid, Guid? user_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users/{1}", guid, user_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Auditor with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_auditor_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task RemoveAuditorWithOrganizationByUsername(Guid? guid, RemoveAuditorWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/auditors", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_space_quota_definitions_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid)
        {
            return await ListAllSpaceQuotaDefinitionsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Space Quota Definitions for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_space_quota_definitions_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsForOrganizationResponse>> ListAllSpaceQuotaDefinitionsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/space_quota_definitions", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpaceQuotaDefinitionsForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate User with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_user_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task<AssociateUserWithOrganizationByUsernameResponse> AssociateUserWithOrganizationByUsername(Guid? guid, AssociateUserWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/users", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateUserWithOrganizationByUsernameResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Private Domains for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_private_domains_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid)
        {
            return await ListAllPrivateDomainsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Private Domains for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_private_domains_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPrivateDomainsForOrganizationResponse>> ListAllPrivateDomainsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPrivateDomainsForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieving the roles of all Users in the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/retrieving_the_roles_of_all_users_in_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<RetrievingRolesOfAllUsersInOrganizationResponse>> RetrievingRolesOfAllUsersInOrganization(Guid? guid)
        {
            return await RetrievingRolesOfAllUsersInOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// Retrieving the roles of all Users in the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/retrieving_the_roles_of_all_users_in_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<RetrievingRolesOfAllUsersInOrganizationResponse>> RetrievingRolesOfAllUsersInOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/user_roles", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<RetrievingRolesOfAllUsersInOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Auditors for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_auditors_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid)
        {
            return await ListAllAuditorsForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Auditors for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_auditors_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForOrganizationResponse>> ListAllAuditorsForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditorsForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_domains_for_the_organization_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid)
        {
            return await ListAllDomainsForOrganizationDeprecated(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Domains for the Organization (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_domains_for_the_organization_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForOrganizationDeprecatedResponse>> ListAllDomainsForOrganizationDeprecated(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/domains", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDomainsForOrganizationDeprecatedResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieving organization memory usage
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/retrieving_organization_memory_usage.html"</para>
        /// </summary>
        public async Task<RetrievingOrganizationMemoryUsageResponse> RetrievingOrganizationMemoryUsage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/memory_usage", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievingOrganizationMemoryUsageResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Remove User with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_user_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task RemoveUserWithOrganizationByUsername(Guid? guid, RemoveUserWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/users", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Creating an Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/creating_an_organization.html"</para>
        /// </summary>
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/organizations";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Organizations
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_organizations.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations()
        {
            return await ListAllOrganizations(new RequestOptions());
        }

        /// <summary>
        /// List all Organizations
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_organizations.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationsResponse>> ListAllOrganizations(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/organizations";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllOrganizationsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Billing Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_billing_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid)
        {
            return await ListAllBillingManagersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Billing Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_billing_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBillingManagersForOrganizationResponse>> ListAllBillingManagersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllBillingManagersForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Get Organization summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/get_organization_summary.html"</para>
        /// </summary>
        public async Task<GetOrganizationSummaryResponse> GetOrganizationSummary(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/summary", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetOrganizationSummaryResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_auditor_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task<AssociateAuditorWithOrganizationByUsernameResponse> AssociateAuditorWithOrganizationByUsername(Guid? guid, AssociateAuditorWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/auditors", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditorWithOrganizationByUsernameResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Services for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_services_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid)
        {
            return await ListAllServicesForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Services for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_services_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForOrganizationResponse>> ListAllServicesForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/services", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicesForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Private Domain from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_private_domain_from_the_organization.html"</para>
        /// </summary>
        public async Task RemovePrivateDomainFromOrganization(Guid? guid, Guid? private_domain_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains/{1}", guid, private_domain_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Manager with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_manager_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task RemoveManagerWithOrganizationByUsername(Guid? guid, RemoveManagerWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/managers", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Manager from the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_manager_from_the_organization.html"</para>
        /// </summary>
        public async Task RemoveManagerFromOrganization(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Delete a Particular Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/delete_a_particular_organization.html"</para>
        /// </summary>
        public async Task DeleteOrganization(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Billing Manager with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/remove_billing_manager_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task RemoveBillingManagerWithOrganizationByUsername(Guid? guid, RemoveBillingManagerWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/billing_managers", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Update an Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/update_an_organization.html"</para>
        /// </summary>
        public async Task<UpdateOrganizationResponse> UpdateOrganization(Guid? guid, UpdateOrganizationRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Billing Manager with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_billing_manager_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateBillingManagerWithOrganizationResponse> AssociateBillingManagerWithOrganization(Guid? guid, Guid? billing_manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/billing_managers/{1}", guid, billing_manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateBillingManagerWithOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate User with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_user_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateUserWithOrganizationResponse> AssociateUserWithOrganization(Guid? guid, Guid? user_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users/{1}", guid, user_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateUserWithOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Private Domain with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_private_domain_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociatePrivateDomainWithOrganizationResponse> AssociatePrivateDomainWithOrganization(Guid? guid, Guid? private_domain_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/private_domains/{1}", guid, private_domain_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociatePrivateDomainWithOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid)
        {
            return await ListAllManagersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Managers for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_managers_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForOrganizationResponse>> ListAllManagersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagersForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/retrieve_a_particular_organization.html"</para>
        /// </summary>
        public async Task<RetrieveOrganizationResponse> RetrieveOrganization(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Manager with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_manager_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateManagerWithOrganizationResponse> AssociateManagerWithOrganization(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagerWithOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Users for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_users_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid)
        {
            return await ListAllUsersForOrganization(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Users for the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/list_all_users_for_the_organization.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUsersForOrganizationResponse>> ListAllUsersForOrganization(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/users", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUsersForOrganizationResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Billing Manager with the Organization by Username
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_billing_manager_with_the_organization_by_username.html"</para>
        /// </summary>
        public async Task<AssociateBillingManagerWithOrganizationByUsernameResponse> AssociateBillingManagerWithOrganizationByUsername(Guid? guid, AssociateBillingManagerWithOrganizationByUsernameRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "v2/organizations/{0}/billing_managers", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateBillingManagerWithOrganizationByUsernameResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Organization
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/organizations/associate_auditor_with_the_organization.html"</para>
        /// </summary>
        public async Task<AssociateAuditorWithOrganizationResponse> AssociateAuditorWithOrganization(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/organizations/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditorWithOrganizationResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
