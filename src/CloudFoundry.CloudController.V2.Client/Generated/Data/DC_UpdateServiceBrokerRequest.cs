

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceBrokersEndpoint.UpdateServiceBroker()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_brokers/update_a_service_broker.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServiceBrokerRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServiceBrokerRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceBrokersEndpoint.UpdateServiceBroker()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_brokers/update_a_service_broker.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServiceBrokerRequest
    {

        /// <summary> 
        /// <para>The username with which to authenticate against the service broker.</para>
        /// </summary>
        [JsonProperty("auth_username", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthUsername
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The password with which to authenticate against the service broker.</para>
        /// </summary>
        [JsonProperty("auth_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthPassword
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The URL of the service broker.</para>
        /// </summary>
        [JsonProperty("broker_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The name of the service broker.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
    }
}