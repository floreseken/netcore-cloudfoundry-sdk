

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.RetrieveServicePlanVisibility()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plan_visibilities/retrieve_a_particular_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveServicePlanVisibilityResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveServicePlanVisibilityResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.RetrieveServicePlanVisibility()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plan_visibilities/retrieve_a_particular_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveServicePlanVisibilityResponse : IResponse
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
        /// <para>The Service Plan Guid</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organization Guid</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Url</para>
        /// </summary>
        [JsonProperty("service_plan_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlanUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organization Url</para>
        /// </summary>
        [JsonProperty("organization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationUrl
        {
            get;
            set;
        }
    }
}