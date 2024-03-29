

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.UpdateServicePlan()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plans/updating_a_service_plan.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServicePlanRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServicePlanRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.UpdateServicePlan()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/service_plans/updating_a_service_plan.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServicePlanRequest
    {

        /// <summary> 
        /// <para>A boolean describing that the plan is visible to the all users</para>
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the service plan</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }
    }
}