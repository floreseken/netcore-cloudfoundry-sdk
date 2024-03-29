

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceBindingsEndpoint.CreateServiceBinding()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_bindings/create_a_service_binding.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateServiceBindingRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServiceBindingRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceBindingsEndpoint.CreateServiceBinding()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_bindings/create_a_service_binding.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServiceBindingRequest
    {

        /// <summary> 
        /// <para>The guid of the service instance to bind</para>
        /// </summary>
        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the app to bind</para>
        /// </summary>
        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
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
        /// <para>A hash of options that are passed to v1 brokers</para>
        /// </summary>
        [JsonProperty("binding_options", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BindingOptions
        {
            get;
            set;
        }
    }
}