

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.UpdateServicePlanVisibility()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plan_visibilities/updating_a_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServicePlanVisibilityRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServicePlanVisibilityRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.UpdateServicePlanVisibility()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plan_visibilities/updating_a_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServicePlanVisibilityRequest
    {

        /// <summary> 
        /// <para>The guid of the plan that will be made visible</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the organization the plan will be visible to</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }
    }
}