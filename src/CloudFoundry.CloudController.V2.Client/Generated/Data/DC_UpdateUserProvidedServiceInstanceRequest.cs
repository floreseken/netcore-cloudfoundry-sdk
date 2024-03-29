

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.UpdateUserProvidedServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/updating_a_user_provided_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateUserProvidedServiceInstanceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateUserProvidedServiceInstanceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.UpdateUserProvidedServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/updating_a_user_provided_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateUserProvidedServiceInstanceRequest
    {

        /// <summary> 
        /// <para>A hash that can be used to store credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
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
        /// <para>The url for the syslog_drain to direct to</para>
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