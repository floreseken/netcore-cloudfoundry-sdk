using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.UpdateApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/updating_an_app.html"</para>
    /// </summary>
    public class UpdateAppRequest
    {

        /// <summary> 
        /// <para>Name of the App</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Environment variables to be used for the App when running</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Lifecycle to be used when updating the app.</para>
        /// <para>Note: lifecycle type cannot be changed.</para>
        /// <para>Buildpack can be set to null to allow the backend to auto-detect the appropriate buildpack.</para>
        /// <para>Stack can be updated, but cannot be null.</para>
        /// <para>Type and Data are required fields in lifecycle, but lifecycle itself is not required.</para>
        /// </summary>
        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Lifecycle
        {
            get;
            set;
        }
    }
}