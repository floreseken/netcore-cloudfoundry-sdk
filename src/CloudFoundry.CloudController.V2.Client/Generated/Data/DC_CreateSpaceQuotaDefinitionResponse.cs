

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.CreateSpaceQuotaDefinition()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/space_quota_definitions/creating_a_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSpaceQuotaDefinitionResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSpaceQuotaDefinitionResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.CreateSpaceQuotaDefinition()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/space_quota_definitions/creating_a_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSpaceQuotaDefinitionResponse : IResponse
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
        /// <para>The Non Basic Services Allowed</para>
        /// </summary>
        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Services</para>
        /// </summary>
        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServices
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Routes</para>
        /// </summary>
        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRoutes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Memory Limit</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Instance Memory Limit</para>
        /// </summary>
        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceMemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Instance Limit</para>
        /// </summary>
        [JsonProperty("app_instance_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppInstanceLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Task Limit</para>
        /// </summary>
        [JsonProperty("app_task_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppTaskLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Service Keys</para>
        /// </summary>
        [JsonProperty("total_service_keys", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServiceKeys
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Reserved Route Ports</para>
        /// </summary>
        [JsonProperty("total_reserved_route_ports", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalReservedRoutePorts
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
        /// <para>The Spaces Url</para>
        /// </summary>
        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }
    }
}