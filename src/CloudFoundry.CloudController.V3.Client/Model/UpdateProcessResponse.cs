


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.UpdateProcess()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateProcessResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractUpdateProcessResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.UpdateProcess()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateProcessResponse
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
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Command</para>
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command
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
        /// <para>The Memory In Mb</para>
        /// </summary>
        [JsonProperty("memory_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryInMb
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Disk In Mb</para>
        /// </summary>
        [JsonProperty("disk_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskInMb
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
        public string UpdatedAt
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