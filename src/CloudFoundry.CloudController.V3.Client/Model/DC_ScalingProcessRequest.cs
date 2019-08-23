


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.ScalingProcess()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/scaling_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ScalingProcessRequest : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractScalingProcessRequest
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.ScalingProcess()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/scaling_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractScalingProcessRequest
    {

        /// <summary> 
        /// <para>Number of instances</para>
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public int? Instances
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The memory in mb allocated per instance</para>
        /// </summary>
        [JsonProperty("memory_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryInMb
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The disk in mb allocated per instance</para>
        /// </summary>
        [JsonProperty("disk_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskInMb
        {
            get;
            set;
        }
    }
}