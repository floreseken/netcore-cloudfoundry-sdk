

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SharedDomainsEndpoint.CreateSharedDomain()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/shared_domains/create_a_shared_domain.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSharedDomainResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSharedDomainResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SharedDomainsEndpoint.CreateSharedDomain()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/shared_domains/create_a_shared_domain.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSharedDomainResponse : IResponse
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
        /// <para>The Router Group Guid</para>
        /// </summary>
        [JsonProperty("router_group_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RouterGroupGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Router Group Type</para>
        /// </summary>
        [JsonProperty("router_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterGroupType
        {
            get;
            set;
        }
    }
}