

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.BuildpacksEndpoint.EnableOrDisableBuildpack()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/buildpacks/enable_or_disable_a_buildpack.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class EnableOrDisableBuildpackRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractEnableOrDisableBuildpackRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.BuildpacksEndpoint.EnableOrDisableBuildpack()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/buildpacks/enable_or_disable_a_buildpack.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractEnableOrDisableBuildpackRequest
    {

        /// <summary> 
        /// <para>Whether or not the buildpack will be used for staging</para>
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The name of the buildpack. To be used by app buildpack field. (only alphanumeric characters)</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The order in which the buildpacks are checked during buildpack auto-detection.</para>
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Position
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Whether or not the buildpack is locked to prevent updates</para>
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Locked
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The name of the uploaded buildpack file</para>
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Filename
        {
            get;
            set;
        }
    }
}