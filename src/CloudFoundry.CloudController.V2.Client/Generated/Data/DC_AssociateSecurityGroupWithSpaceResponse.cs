

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.AssociateSecurityGroupWithSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/associate_security_group_with_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AssociateSecurityGroupWithSpaceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractAssociateSecurityGroupWithSpaceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.AssociateSecurityGroupWithSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/associate_security_group_with_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAssociateSecurityGroupWithSpaceResponse : IResponse
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
        /// <para>The Organization Guid</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Quota Definition Guid</para>
        /// </summary>
        [JsonProperty("space_quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceQuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Isolation Segment Guid</para>
        /// </summary>
        [JsonProperty("isolation_segment_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IsolationSegmentGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Allow Ssh</para>
        /// </summary>
        [JsonProperty("allow_ssh", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSsh
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organization Url</para>
        /// </summary>
        [JsonProperty("organization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Developers Url</para>
        /// </summary>
        [JsonProperty("developers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managers Url</para>
        /// </summary>
        [JsonProperty("managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Auditors Url</para>
        /// </summary>
        [JsonProperty("auditors_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditorsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Apps Url</para>
        /// </summary>
        [JsonProperty("apps_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Routes Url</para>
        /// </summary>
        [JsonProperty("routes_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Domains Url</para>
        /// </summary>
        [JsonProperty("domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instances Url</para>
        /// </summary>
        [JsonProperty("service_instances_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstancesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Events Url</para>
        /// </summary>
        [JsonProperty("app_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppEventsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Events Url</para>
        /// </summary>
        [JsonProperty("events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string EventsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Security Groups Url</para>
        /// </summary>
        [JsonProperty("security_groups_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Security Groups Url</para>
        /// </summary>
        [JsonProperty("staging_security_groups_url", NullValueHandling = NullValueHandling.Ignore)]
        public string StagingSecurityGroupsUrl
        {
            get;
            set;
        }
    }
}