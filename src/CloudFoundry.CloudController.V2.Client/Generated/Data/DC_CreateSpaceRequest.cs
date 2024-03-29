

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.CreateSpace()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/creating_a_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSpaceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSpaceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.CreateSpace()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/creating_a_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSpaceRequest
    {

        /// <summary> 
        /// <para>The name of the space</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated organization</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of the associated developers</para>
        /// </summary>
        [JsonProperty("developer_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DeveloperGuids
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of the associated managers</para>
        /// </summary>
        [JsonProperty("manager_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ManagerGuids
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of the associated auditors</para>
        /// </summary>
        [JsonProperty("auditor_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AuditorGuids
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of the associated domains</para>
        /// </summary>
        [JsonProperty("domain_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DomainGuids
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of the associated security groups</para>
        /// </summary>
        [JsonProperty("security_group_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SecurityGroupGuids
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated space quota definition</para>
        /// </summary>
        [JsonProperty("space_quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceQuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Whether or not Space Developers can enable ssh on apps in the space</para>
        /// </summary>
        [JsonProperty("allow_ssh", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AllowSsh
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid for the isolation segment</para>
        /// </summary>
        [JsonProperty("isolation_segment_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IsolationSegmentGuid
        {
            get;
            set;
        }
    }
}