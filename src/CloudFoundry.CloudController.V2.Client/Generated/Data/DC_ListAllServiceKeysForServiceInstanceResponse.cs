

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.ListAllServiceKeysForServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_keys_for_the_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllServiceKeysForServiceInstanceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllServiceKeysForServiceInstanceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.ListAllServiceKeysForServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_keys_for_the_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllServiceKeysForServiceInstanceResponse : IResponse
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