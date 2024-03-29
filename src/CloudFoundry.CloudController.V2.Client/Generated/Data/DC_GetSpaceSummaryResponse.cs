

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.GetSpaceSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/get_space_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetSpaceSummaryResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetSpaceSummaryResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.GetSpaceSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/get_space_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetSpaceSummaryResponse : IResponse
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
        /// <para>The Apps</para>
        /// </summary>
        [JsonProperty("apps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Apps
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Services</para>
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Services
        {
            get;
            set;
        }
    }
}