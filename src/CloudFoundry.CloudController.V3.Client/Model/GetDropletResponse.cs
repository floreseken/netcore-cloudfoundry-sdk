using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;


namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.DropletsExperimentalEndpoint.GetDroplet()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/droplets__experimental_/get_a_droplet.html"</para>
    /// </summary>
    public class GetDropletResponse
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
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error</para>
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error
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
        /// <para>The Memory Limit</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Disk Limit</para>
        /// </summary>
        [JsonProperty("disk_limit", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DiskLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Result</para>
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Result
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