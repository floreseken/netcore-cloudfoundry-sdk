

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.CreateSpaceQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/space_quota_definitions/creating_a_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSpaceQuotaDefinitionRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSpaceQuotaDefinitionRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.CreateSpaceQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/space_quota_definitions/creating_a_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSpaceQuotaDefinitionRequest
    {

        /// <summary> 
        /// <para>The name for the Space Quota Definition.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If a space can have non basic services</para>
        /// </summary>
        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many services a space can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServices
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many routes a space can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRoutes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How much memory in megabytes a space can have.</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The owning organization of the space quota</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many routes a space can have that use a reserved port. These routes count toward total_routes. (-1 represents an unlimited amount; subject to org quota)</para>
        /// </summary>
        [JsonProperty("total_reserved_route_ports", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalReservedRoutePorts
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many service keys an organization can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_service_keys", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalServiceKeys
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The maximum amount of memory in megabytes an application instance can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many app instances a space can create. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("app_instance_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string AppInstanceLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The number of tasks that can be run per app. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("app_task_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string AppTaskLimit
        {
            get;
            set;
        }
    }
}