

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.CreateUser()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/creating_a_user.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateUserResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateUserResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.CreateUser()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/creating_a_user.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateUserResponse : IResponse
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
        /// <para>The Admin</para>
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Active</para>
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Default Space Guid</para>
        /// </summary>
        [JsonProperty("default_space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultSpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Spaces Url</para>
        /// </summary>
        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organizations Url</para>
        /// </summary>
        [JsonProperty("organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managed Organizations Url</para>
        /// </summary>
        [JsonProperty("managed_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedOrganizationsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Billing Managed Organizations Url</para>
        /// </summary>
        [JsonProperty("billing_managed_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingManagedOrganizationsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Audited Organizations Url</para>
        /// </summary>
        [JsonProperty("audited_organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditedOrganizationsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managed Spaces Url</para>
        /// </summary>
        [JsonProperty("managed_spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedSpacesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Audited Spaces Url</para>
        /// </summary>
        [JsonProperty("audited_spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditedSpacesUrl
        {
            get;
            set;
        }
    }
}