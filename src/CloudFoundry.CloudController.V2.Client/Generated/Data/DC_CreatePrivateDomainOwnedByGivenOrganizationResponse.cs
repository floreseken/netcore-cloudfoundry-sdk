

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.PrivateDomainsEndpoint.CreatePrivateDomainOwnedByGivenOrganization()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/private_domains/create_a_private_domain_owned_by_the_given_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreatePrivateDomainOwnedByGivenOrganizationResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreatePrivateDomainOwnedByGivenOrganizationResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.PrivateDomainsEndpoint.CreatePrivateDomainOwnedByGivenOrganization()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/private_domains/create_a_private_domain_owned_by_the_given_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreatePrivateDomainOwnedByGivenOrganizationResponse : IResponse
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
        /// <para>The Owning Organization Guid</para>
        /// </summary>
        [JsonProperty("owning_organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OwningOrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Owning Organization Url</para>
        /// </summary>
        [JsonProperty("owning_organization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OwningOrganizationUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Shared Organizations Url</para>
        /// </summary>
        [JsonProperty("shared_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedOrganizationsUrl
        {
            get;
            set;
        }
    }
}