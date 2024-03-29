

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.RetrievingPermissionsOnServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/retrieving_permissions_on_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrievingPermissionsOnServiceInstanceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrievingPermissionsOnServiceInstanceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.RetrievingPermissionsOnServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_instances/retrieving_permissions_on_a_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrievingPermissionsOnServiceInstanceResponse : IResponse
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
        /// <para>The Manage</para>
        /// </summary>
        [JsonProperty("manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Manage
        {
            get;
            set;
        }
    }
}