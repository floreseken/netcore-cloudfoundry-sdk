


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.StagePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/stage_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class StagePackageRequest : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractStagePackageRequest
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.StagePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/stage_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractStagePackageRequest
    {

        /// <summary> 
        /// <para>Environment variables to use during staging.</para>
        /// <para>Environment variable names may not start with "VCAP_" or "CF_". "PORT" is not a valid environment variable.</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Lifecycle information for a droplet.  If not provided, it will default to a buildpack</para>
        /// </summary>
        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Lifecycle
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Memory limit used to stage package</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Disk limit used to stage package</para>
        /// </summary>
        [JsonProperty("disk_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskLimit
        {
            get;
            set;
        }
    }
}