

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.CreateUserProvidedServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/creating_a_user_provided_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateUserProvidedServiceInstanceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateUserProvidedServiceInstanceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.CreateUserProvidedServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/creating_a_user_provided_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateUserProvidedServiceInstanceRequest
    {

        /// <summary> 
        /// <para>The guid of the space in which the instance will be created</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A name for the service instance</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A hash exposed in the VCAP_SERVICES environment variable for bound applications.</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>URL to which logs will be streamed for bound applications.</para>
        /// </summary>
        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SyslogDrainUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>URL to which requests for bound routes will be forwarded.</para>
        /// </summary>
        [JsonProperty("route_service_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteServiceUrl
        {
            get;
            set;
        }
    }
}