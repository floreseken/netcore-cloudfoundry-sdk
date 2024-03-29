

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
    /// EnvironmentVariableGroups Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class EnvironmentVariableGroupsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractEnvironmentVariableGroupsEndpoint
    {
        internal EnvironmentVariableGroupsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for EnvironmentVariableGroups Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractEnvironmentVariableGroupsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractEnvironmentVariableGroupsEndpoint()
        {
        }

        /// <summary>
        /// Getting the contents of the running environment variable group
        /// <para>returns the set of default environment variables available to running apps</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/environment_variable_groups/getting_the_contents_of_the_running_environment_variable_group.html"</para>
        /// </summary>
        public async Task<GettingContentsOfRunningEnvironmentVariableGroupResponse> GettingContentsOfRunningEnvironmentVariableGroup()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/environment_variable_groups/running";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GettingContentsOfRunningEnvironmentVariableGroupResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Getting the contents of the staging environment variable group
        /// <para>returns the set of default environment variables available during staging</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/environment_variable_groups/getting_the_contents_of_the_staging_environment_variable_group.html"</para>
        /// </summary>
        public async Task<GettingContentsOfStagingEnvironmentVariableGroupResponse> GettingContentsOfStagingEnvironmentVariableGroup()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/environment_variable_groups/staging";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GettingContentsOfStagingEnvironmentVariableGroupResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Updating the contents of the staging environment variable group
        /// <para>Updates the set of environment variables which will be made available during staging</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/environment_variable_groups/updating_the_contents_of_the_staging_environment_variable_group.html"</para>
        /// </summary>
        public async Task<UpdateContentsOfStagingEnvironmentVariableGroupResponse> UpdateContentsOfStagingEnvironmentVariableGroup(UpdateContentsOfStagingEnvironmentVariableGroupRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/environment_variable_groups/staging";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateContentsOfStagingEnvironmentVariableGroupResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Updating the contents of the running environment variable group
        /// <para>Updates the set of environment variables which will be made available to all running apps</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/environment_variable_groups/updating_the_contents_of_the_running_environment_variable_group.html"</para>
        /// </summary>
        public async Task<UpdateContentsOfRunningEnvironmentVariableGroupResponse> UpdateContentsOfRunningEnvironmentVariableGroup(UpdateContentsOfRunningEnvironmentVariableGroupRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/config/environment_variable_groups/running";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateContentsOfRunningEnvironmentVariableGroupResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
