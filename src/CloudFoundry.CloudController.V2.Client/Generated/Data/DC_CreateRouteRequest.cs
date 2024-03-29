

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesEndpoint.CreateRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/routes/creating_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateRouteRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateRouteRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesEndpoint.CreateRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/routes/creating_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateRouteRequest
    {

        /// <summary> 
        /// <para>The guid of the associated domain</para>
        /// </summary>
        [JsonProperty("domain_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DomainGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated space</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The port of the route. Supported for domains of TCP router groups only.</para>
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The host portion of the route. Required for shared-domains.</para>
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Host
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The path for a route as raw text. 1) Paths must be between 2 and 128 characters 2) Paths must start with a forward slash "/" 3) Paths must not contain a "?"</para>
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path
        {
            get;
            set;
        }
    }
}