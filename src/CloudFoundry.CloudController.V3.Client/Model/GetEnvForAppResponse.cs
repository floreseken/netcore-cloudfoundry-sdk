using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetEnvForApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_the_env_for_an_app.html"</para>
    /// </summary>
    public class GetEnvForAppResponse
    {

        /// <summary> 
        /// <para>The Environment Variables</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
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