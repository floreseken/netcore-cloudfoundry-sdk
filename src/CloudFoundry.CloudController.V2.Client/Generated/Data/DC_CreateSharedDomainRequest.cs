

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SharedDomainsEndpoint.CreateSharedDomain()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/shared_domains/create_a_shared_domain.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSharedDomainRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSharedDomainRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SharedDomainsEndpoint.CreateSharedDomain()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/shared_domains/create_a_shared_domain.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSharedDomainRequest
    {

        /// <summary> 
        /// <para>The name of the domain.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the router group.</para>
        /// </summary>
        [JsonProperty("router_group_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RouterGroupGuid
        {
            get;
            set;
        }
    }
}