

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.FeatureFlagsEndpoint.GetServiceInstanceCreationFeatureFlag()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/feature_flags/get_the_service_instance_creation_feature_flag.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetServiceInstanceCreationFeatureFlagResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetServiceInstanceCreationFeatureFlagResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.FeatureFlagsEndpoint.GetServiceInstanceCreationFeatureFlag()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/feature_flags/get_the_service_instance_creation_feature_flag.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetServiceInstanceCreationFeatureFlagResponse : IResponse
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
        /// <para>The Enabled</para>
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error Message</para>
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ErrorMessage
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Url</para>
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
    }
}