

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceUsageEventsEndpoint.ListServiceUsageEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_usage_events/list_service_usage_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListServiceUsageEventsResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListServiceUsageEventsResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceUsageEventsEndpoint.ListServiceUsageEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_usage_events/list_service_usage_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListServiceUsageEventsResponse : IResponse
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
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Org Guid</para>
        /// </summary>
        [JsonProperty("org_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrgGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Name</para>
        /// </summary>
        [JsonProperty("space_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instance Guid</para>
        /// </summary>
        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instance Name</para>
        /// </summary>
        [JsonProperty("service_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstanceName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instance Type</para>
        /// </summary>
        [JsonProperty("service_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstanceType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Guid</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Name</para>
        /// </summary>
        [JsonProperty("service_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlanName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Guid</para>
        /// </summary>
        [JsonProperty("service_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Label</para>
        /// </summary>
        [JsonProperty("service_label", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceLabel
        {
            get;
            set;
        }
    }
}