

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.BuildpacksEndpoint.LockOrUnlockBuildpack()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/buildpacks/lock_or_unlock_a_buildpack.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class LockOrUnlockBuildpackResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractLockOrUnlockBuildpackResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.BuildpacksEndpoint.LockOrUnlockBuildpack()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/buildpacks/lock_or_unlock_a_buildpack.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractLockOrUnlockBuildpackResponse : IResponse
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
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Position</para>
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Enabled</para>
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Locked</para>
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Filename</para>
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename
        {
            get;
            set;
        }
    }
}