

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.ListAllServiceInstancesForSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/list_all_service_instances_for_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllServiceInstancesForSpaceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllServiceInstancesForSpaceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.ListAllServiceInstancesForSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/list_all_service_instances_for_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllServiceInstancesForSpaceResponse : IResponse
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
        /// <para>The Credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
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
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Gateway Data</para>
        /// </summary>
        [JsonProperty("gateway_data", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic GatewayData
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Dashboard Url</para>
        /// </summary>
        [JsonProperty("dashboard_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DashboardUrl
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
        /// <para>The Last Operation</para>
        /// </summary>
        [JsonProperty("last_operation", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic LastOperation
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Tags</para>
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Tags
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
        /// <para>The Space Url</para>
        /// </summary>
        [JsonProperty("space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Url</para>
        /// </summary>
        [JsonProperty("service_plan_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlanUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Bindings Url</para>
        /// </summary>
        [JsonProperty("service_bindings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceBindingsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Keys Url</para>
        /// </summary>
        [JsonProperty("service_keys_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceKeysUrl
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
        /// <para>The Service Url</para>
        /// </summary>
        [JsonProperty("service_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceUrl
        {
            get;
            set;
        }
    }
}