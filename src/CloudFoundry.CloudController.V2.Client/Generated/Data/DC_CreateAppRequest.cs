

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.CreateApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/creating_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateAppRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateAppRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.CreateApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/creating_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateAppRequest
    {

        /// <summary> 
        /// <para>The name of the app.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated space.</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Use diego to stage and to run when available</para>
        /// </summary>
        [JsonProperty("diego", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Diego
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Ports on which application may listen. Overwrites previously configured ports. Ports must be in range 1024-65535. Supported for Diego only.</para>
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public int?[] Ports
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The amount of memory each instance should have. In megabytes.</para>
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The number of instances of the app to run. To ensure optimal availability, ensure there are at least 2 instances.</para>
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public string Instances
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The maximum amount of disk available to an instance of an app. In megabytes.</para>
        /// </summary>
        [JsonProperty("disk_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskQuota
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated stack.</para>
        /// </summary>
        [JsonProperty("stack_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StackGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The current desired state of the app. One of STOPPED or STARTED.</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The command to start an app after it is staged, maximum length: 4096 (e.g. 'rails s -p $PORT' or 'java com.org.Server $PORT').</para>
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Command
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Buildpack to build the app. 3 options: a) Blank means autodetection; b) A Git Url pointing to a buildpack; c) Name of an installed buildpack.</para>
        /// </summary>
        [JsonProperty("buildpack", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Buildpack
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Type of health check to perform. 'none' is deprecated and an alias to 'process'.</para>
        /// </summary>
        [JsonProperty("health_check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Timeout for health checking of an staged app when starting up</para>
        /// </summary>
        [JsonProperty("health_check_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic HealthCheckTimeout
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Enable SSHing into the app. Supported for Diego only.</para>
        /// </summary>
        [JsonProperty("enable_ssh", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsh
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Name of the Docker image containing the app. The "diego_docker" feature flag must be enabled in order to create Docker image apps.</para>
        /// </summary>
        [JsonProperty("docker_image", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerImage
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Docker credentials for pulling docker image.</para>
        /// </summary>
        [JsonProperty("docker_credentials_json", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerCredentialsJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Key/value pairs of all the environment variables to run in your app. Does not include any system or service variables.</para>
        /// </summary>
        [JsonProperty("environment_json", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic EnvironmentJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Deprecated.</para>
        /// </summary>
        [JsonProperty("production", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Production
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Open the console port for the app (at $CONSOLE_PORT).</para>
        /// </summary>
        [JsonProperty("console", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Console
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Open the debug port for the app (at $DEBUG_PORT).</para>
        /// </summary>
        [JsonProperty("debug", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Debug
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Reason for application staging failures</para>
        /// </summary>
        [JsonProperty("staging_failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StagingFailedReason
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Detailed description for the staging_failed_reason</para>
        /// </summary>
        [JsonProperty("staging_failed_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StagingFailedDescription
        {
            get;
            set;
        }
    }
}