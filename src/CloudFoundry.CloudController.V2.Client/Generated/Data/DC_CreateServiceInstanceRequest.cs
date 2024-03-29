

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.CreateServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/creating_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateServiceInstanceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServiceInstanceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.CreateServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/creating_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServiceInstanceRequest
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
        /// <para>The guid of the service plan to associate with the instance</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Arbitrary parameters to pass along to the service broker. Must be a JSON object</para>
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Parameters
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A list of tags for the service instance. Max characters: 2048</para>
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Configuration information for the broker gateway in v1 services</para>
        /// </summary>
        [JsonProperty("gateway_data", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic GatewayData
        {
            get;
            set;
        }
    }
}