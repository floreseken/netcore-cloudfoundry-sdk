

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.CreateOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/creating_an_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateOrganizationRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateOrganizationRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.CreateOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/organizations/creating_an_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateOrganizationRequest
    {

        /// <summary> 
        /// <para>The name of the organization</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of quota to associate with this organization</para>
        /// </summary>
        [JsonProperty("quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? QuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Status of the organization</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If billing is enabled for this organization</para>
        /// </summary>
        [JsonProperty("billing_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BillingEnabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid for the default isolation segment</para>
        /// </summary>
        [JsonProperty("default_isolation_segment_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultIsolationSegmentGuid
        {
            get;
            set;
        }
    }
}