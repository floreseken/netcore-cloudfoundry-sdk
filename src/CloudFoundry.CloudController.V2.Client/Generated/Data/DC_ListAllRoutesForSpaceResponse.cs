

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.ListAllRoutesForSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/list_all_routes_for_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllRoutesForSpaceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllRoutesForSpaceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.ListAllRoutesForSpace()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/list_all_routes_for_the_space.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllRoutesForSpaceResponse : IResponse
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
        /// <para>The Host</para>
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Path</para>
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Domain Guid</para>
        /// </summary>
        [JsonProperty("domain_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DomainGuid
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
        /// <para>The Service Instance Guid</para>
        /// </summary>
        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Port</para>
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Port
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Domain Url</para>
        /// </summary>
        [JsonProperty("domain_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainUrl
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
        /// <para>The Apps Url</para>
        /// </summary>
        [JsonProperty("apps_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Route Mappings Url</para>
        /// </summary>
        [JsonProperty("route_mappings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteMappingsUrl
        {
            get;
            set;
        }
    }
}