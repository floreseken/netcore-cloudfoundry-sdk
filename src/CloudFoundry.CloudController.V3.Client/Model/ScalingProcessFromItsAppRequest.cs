using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.ScalingProcessFromItsApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/scaling_a_process_from_its_app.html"</para>
    /// </summary>
    public class ScalingProcessFromItsAppRequest
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