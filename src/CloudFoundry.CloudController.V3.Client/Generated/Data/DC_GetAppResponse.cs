


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetAppResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractGetAppResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/get_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetAppResponse
    {

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
        /// <para>The Desired State</para>
        /// </summary>
        [JsonProperty("desired_state", NullValueHandling = NullValueHandling.Ignore)]
        public string DesiredState
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Desired Instances</para>
        /// </summary>
        [JsonProperty("total_desired_instances", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDesiredInstances
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Created At</para>
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Updated At</para>
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UpdatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Lifecycle</para>
        /// </summary>
        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Lifecycle
        {
            get;
            set;
        }

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
        /// <para>The Links</para>
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Links
        {
            get;
            set;
        }
    }
}