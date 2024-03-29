

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.GetUserSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/get_user_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetUserSummaryResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetUserSummaryResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.GetUserSummary()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/get_user_summary.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetUserSummaryResponse : IResponse
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
        /// <para>The Organizations</para>
        /// </summary>
        [JsonProperty("organizations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Organizations
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managed Organizations</para>
        /// </summary>
        [JsonProperty("managed_organizations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] ManagedOrganizations
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Billing Managed Organizations</para>
        /// </summary>
        [JsonProperty("billing_managed_organizations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] BillingManagedOrganizations
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Audited Organizations</para>
        /// </summary>
        [JsonProperty("audited_organizations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] AuditedOrganizations
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Spaces</para>
        /// </summary>
        [JsonProperty("spaces", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Spaces
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managed Spaces</para>
        /// </summary>
        [JsonProperty("managed_spaces", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] ManagedSpaces
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Audited Spaces</para>
        /// </summary>
        [JsonProperty("audited_spaces", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] AuditedSpaces
        {
            get;
            set;
        }
    }
}