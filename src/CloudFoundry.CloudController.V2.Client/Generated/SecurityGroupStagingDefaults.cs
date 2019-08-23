

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
    /// SecurityGroupStagingDefaults Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SecurityGroupStagingDefaultsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSecurityGroupStagingDefaultsEndpoint
    {
        internal SecurityGroupStagingDefaultsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for SecurityGroupStagingDefaults Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSecurityGroupStagingDefaultsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSecurityGroupStagingDefaultsEndpoint()
        {
        }

        /// <summary>
        /// Removing a Security Group as a default for staging
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_staging_defaults/removing_a_security_group_as_a_default_for_staging.html"</para>
        /// </summary>
        public async Task RemovingSecurityGroupAsDefaultForStaging(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/config/staging_security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Return the Security Groups used for staging
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_staging_defaults/return_the_security_groups_used_for_staging.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse>> ReturnSecurityGroupsUsedForStaging()
        {
            return await ReturnSecurityGroupsUsedForStaging(new RequestOptions());
        }

        /// <summary>
        /// Return the Security Groups used for staging
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_staging_defaults/return_the_security_groups_used_for_staging.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse>> ReturnSecurityGroupsUsedForStaging(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/staging_security_groups";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ReturnSecurityGroupsUsedForStagingResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Set a Security Group as a default for staging
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_staging_defaults/set_a_security_group_as_a_default_for_staging.html"</para>
        /// </summary>
        public async Task<SetSecurityGroupAsDefaultForStagingResponse> SetSecurityGroupAsDefaultForStaging(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/config/staging_security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
