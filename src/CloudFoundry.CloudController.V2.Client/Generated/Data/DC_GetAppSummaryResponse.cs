

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetAppSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_app_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetAppSummaryResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetAppSummaryResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetAppSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_app_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetAppSummaryResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Guid</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Routes</para>
        /// </summary>
        [JsonProperty("routes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Routes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Running Instances</para>
        /// </summary>
        [JsonProperty("running_instances", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningInstances
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Services</para>
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Services
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Available Domains</para>
        /// </summary>
        [JsonProperty("available_domains", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] AvailableDomains
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Production</para>
        /// </summary>
        [JsonProperty("production", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Production
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Stack Guid</para>
        /// </summary>
        [JsonProperty("stack_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StackGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Buildpack</para>
        /// </summary>
        [JsonProperty("buildpack", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Buildpack
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Detected Buildpack</para>
        /// </summary>
        [JsonProperty("detected_buildpack", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DetectedBuildpack
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Detected Buildpack Guid</para>
        /// </summary>
        [JsonProperty("detected_buildpack_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DetectedBuildpackGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Environment Json</para>
        /// </summary>
        [JsonProperty("environment_json", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic EnvironmentJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Memory</para>
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? Memory
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Instances</para>
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public int? Instances
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Disk Quota</para>
        /// </summary>
        [JsonProperty("disk_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskQuota
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Version</para>
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Version
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Command</para>
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Command
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Console</para>
        /// </summary>
        [JsonProperty("console", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Console
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Debug</para>
        /// </summary>
        [JsonProperty("debug", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Debug
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Task Id</para>
        /// </summary>
        [JsonProperty("staging_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StagingTaskId
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Package State</para>
        /// </summary>
        [JsonProperty("package_state", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageState
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Health Check Type</para>
        /// </summary>
        [JsonProperty("health_check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Health Check Timeout</para>
        /// </summary>
        [JsonProperty("health_check_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic HealthCheckTimeout
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Health Check Http Endpoint</para>
        /// </summary>
        [JsonProperty("health_check_http_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic HealthCheckHttpEndpoint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Failed Reason</para>
        /// </summary>
        [JsonProperty("staging_failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic StagingFailedReason
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Failed Description</para>
        /// </summary>
        [JsonProperty("staging_failed_description", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic StagingFailedDescription
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Diego</para>
        /// </summary>
        [JsonProperty("diego", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Diego
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Docker Image</para>
        /// </summary>
        [JsonProperty("docker_image", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DockerImage
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Package Updated At</para>
        /// </summary>
        [JsonProperty("package_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageUpdatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Detected Start Command</para>
        /// </summary>
        [JsonProperty("detected_start_command", NullValueHandling = NullValueHandling.Ignore)]
        public string DetectedStartCommand
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Enable Ssh</para>
        /// </summary>
        [JsonProperty("enable_ssh", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsh
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Docker Credentials Json</para>
        /// </summary>
        [JsonProperty("docker_credentials_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> DockerCredentialsJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Ports</para>
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Ports
        {
            get;
            set;
        }
    }
}