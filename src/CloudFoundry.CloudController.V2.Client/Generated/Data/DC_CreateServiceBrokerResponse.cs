

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceBrokersEndpoint.CreateServiceBroker()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_brokers/create_a_service_broker.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateServiceBrokerResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServiceBrokerResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceBrokersEndpoint.CreateServiceBroker()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_brokers/create_a_service_broker.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServiceBrokerResponse : IResponse
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
        /// <para>The Broker Url</para>
        /// </summary>
        [JsonProperty("broker_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Auth Username</para>
        /// </summary>
        [JsonProperty("auth_username", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthUsername
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
    }
}