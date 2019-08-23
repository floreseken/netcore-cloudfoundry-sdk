using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.AppRoutesExperimentalEndpoint.MapRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/map_a_route.html"</para>
    /// </summary>
    public class MapRouteRequest
    {

        /// <summary> 
        /// <para>GUID of the route</para>
        /// </summary>
        [JsonProperty("route_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RouteGuid
        {
            get;
            set;
        }
    }
}