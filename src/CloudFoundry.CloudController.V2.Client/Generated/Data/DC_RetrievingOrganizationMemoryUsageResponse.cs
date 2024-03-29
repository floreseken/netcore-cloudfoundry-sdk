

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.RetrievingOrganizationMemoryUsage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/retrieving_organization_memory_usage.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrievingOrganizationMemoryUsageResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrievingOrganizationMemoryUsageResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.RetrievingOrganizationMemoryUsage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/retrieving_organization_memory_usage.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrievingOrganizationMemoryUsageResponse : IResponse
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
        /// <para>The Memory Usage In Mb</para>
        /// </summary>
        [JsonProperty("memory_usage_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUsageInMb
        {
            get;
            set;
        }
    }
}