

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.GetOrganizationSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/get_organization_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetOrganizationSummaryResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetOrganizationSummaryResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.GetOrganizationSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/get_organization_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetOrganizationSummaryResponse : IResponse
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
        /// <para>The Status</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Spaces</para>
        /// </summary>
        [JsonProperty("spaces", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Spaces
        {
            get;
            set;
        }
    }
}