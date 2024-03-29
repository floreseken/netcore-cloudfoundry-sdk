

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.DomainsDeprecatedEndpoint.CreateSharedDomainDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/domains__deprecated_/create_a_shared_domain_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSharedDomainDeprecatedRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSharedDomainDeprecatedRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.DomainsDeprecatedEndpoint.CreateSharedDomainDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/domains__deprecated_/create_a_shared_domain_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSharedDomainDeprecatedRequest
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
        /// <para>Allow routes with non-empty hosts</para>
        /// </summary>
        [JsonProperty("wildcard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wildcard
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the domain.</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The organization that owns the domain. If not specified, the domain is shared.</para>
        /// </summary>
        [JsonProperty("owning_organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OwningOrganizationGuid
        {
            get;
            set;
        }
    }
}