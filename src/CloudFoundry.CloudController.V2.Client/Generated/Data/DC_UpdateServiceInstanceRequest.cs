

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.UpdateServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/update_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServiceInstanceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServiceInstanceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.UpdateServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/update_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServiceInstanceRequest
    {

        /// <summary> 
        /// <para>The new plan guid for the service instance</para>
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
        /// <para>The new name for the service instance</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A list of tags for the service instance. NOTE: Updating the tags will overwrite any old tags. Max characters: 2048.</para>
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags
        {
            get;
            set;
        }
    }
}