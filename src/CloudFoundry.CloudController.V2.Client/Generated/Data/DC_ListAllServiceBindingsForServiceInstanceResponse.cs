

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.ListAllServiceBindingsForServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_bindings_for_the_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllServiceBindingsForServiceInstanceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllServiceBindingsForServiceInstanceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.ListAllServiceBindingsForServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_bindings_for_the_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllServiceBindingsForServiceInstanceResponse : IResponse
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
        /// <para>The App Guid</para>
        /// </summary>
        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
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
        /// <para>The Credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Binding Options</para>
        /// </summary>
        [JsonProperty("binding_options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<dynamic, dynamic> BindingOptions
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
        /// <para>The Gateway Name</para>
        /// </summary>
        [JsonProperty("gateway_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Syslog Drain Url</para>
        /// </summary>
        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SyslogDrainUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Volume Mounts</para>
        /// </summary>
        [JsonProperty("volume_mounts", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] VolumeMounts
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instance Url</para>
        /// </summary>
        [JsonProperty("service_instance_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstanceUrl
        {
            get;
            set;
        }
    }
}