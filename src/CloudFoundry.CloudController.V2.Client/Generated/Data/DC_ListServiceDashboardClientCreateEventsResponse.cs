

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.EventsEndpoint.ListServiceDashboardClientCreateEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_create_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListServiceDashboardClientCreateEventsResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListServiceDashboardClientCreateEventsResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.EventsEndpoint.ListServiceDashboardClientCreateEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_create_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListServiceDashboardClientCreateEventsResponse : IResponse
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
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor</para>
        /// </summary>
        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Actor
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor Type</para>
        /// </summary>
        [JsonProperty("actor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActorType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor Name</para>
        /// </summary>
        [JsonProperty("actor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActorName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee</para>
        /// </summary>
        [JsonProperty("actee", NullValueHandling = NullValueHandling.Ignore)]
        public string Actee
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee Type</para>
        /// </summary>
        [JsonProperty("actee_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActeeType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee Name</para>
        /// </summary>
        [JsonProperty("actee_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActeeName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Timestamp</para>
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Metadata</para>
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Metadata
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
        /// <para>The Organization Guid</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }
    }
}