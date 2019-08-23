


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CopyPackage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/copy_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CopyPackageResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractCopyPackageResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CopyPackage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/copy_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCopyPackageResponse
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
        /// <para>The Data</para>
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Data
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