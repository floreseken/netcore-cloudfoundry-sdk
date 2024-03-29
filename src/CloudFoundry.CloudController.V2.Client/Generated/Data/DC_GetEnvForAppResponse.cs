

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetEnvForApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_the_env_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetEnvForAppResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetEnvForAppResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetEnvForApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_the_env_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetEnvForAppResponse : IResponse
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
        /// <para>The Staging Env Json</para>
        /// </summary>
        [JsonProperty("staging_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> StagingEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Running Env Json</para>
        /// </summary>
        [JsonProperty("running_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> RunningEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Environment Json</para>
        /// </summary>
        [JsonProperty("environment_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The System Env Json</para>
        /// </summary>
        [JsonProperty("system_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> SystemEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Application Env Json</para>
        /// </summary>
        [JsonProperty("application_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> ApplicationEnvJson
        {
            get;
            set;
        }
    }
}