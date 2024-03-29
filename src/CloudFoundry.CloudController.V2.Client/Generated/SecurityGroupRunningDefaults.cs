

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
    /// SecurityGroupRunningDefaults Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SecurityGroupRunningDefaultsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSecurityGroupRunningDefaultsEndpoint
    {
        internal SecurityGroupRunningDefaultsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for SecurityGroupRunningDefaults Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSecurityGroupRunningDefaultsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSecurityGroupRunningDefaultsEndpoint()
        {
        }

        /// <summary>
        /// Set a Security Group as a default for running Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_running_defaults/set_a_security_group_as_a_default_for_running_apps.html"</para>
        /// </summary>
        public async Task<SetSecurityGroupAsDefaultForRunningAppsResponse> SetSecurityGroupAsDefaultForRunningApps(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/config/running_security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Removing a Security Group as a default for running Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_running_defaults/removing_a_security_group_as_a_default_for_running_apps.html"</para>
        /// </summary>
        public async Task RemovingSecurityGroupAsDefaultForRunningApps(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/config/running_security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Return the Security Groups used for running Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_running_defaults/return_the_security_groups_used_for_running_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse>> ReturnSecurityGroupsUsedForRunningApps()
        {
            return await ReturnSecurityGroupsUsedForRunningApps(new RequestOptions());
        }

        /// <summary>
        /// Return the Security Groups used for running Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/security_group_running_defaults/return_the_security_groups_used_for_running_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse>> ReturnSecurityGroupsUsedForRunningApps(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/running_security_groups";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
