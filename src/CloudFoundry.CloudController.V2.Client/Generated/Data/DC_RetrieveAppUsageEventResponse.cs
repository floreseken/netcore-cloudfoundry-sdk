

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppUsageEventsEndpoint.RetrieveAppUsageEvent()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/app_usage_events/retrieve_a_particular_app_usage_event.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveAppUsageEventResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveAppUsageEventResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppUsageEventsEndpoint.RetrieveAppUsageEvent()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/app_usage_events/retrieve_a_particular_app_usage_event.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveAppUsageEventResponse : IResponse
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
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Previous State</para>
        /// </summary>
        [JsonProperty("previous_state", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PreviousState
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Memory In Mb Per Instance</para>
        /// </summary>
        [JsonProperty("memory_in_mb_per_instance", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryInMbPerInstance
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Previous Memory In Mb Per Instance</para>
        /// </summary>
        [JsonProperty("previous_memory_in_mb_per_instance", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PreviousMemoryInMbPerInstance
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Instance Count</para>
        /// </summary>
        [JsonProperty("instance_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceCount
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Previous Instance Count</para>
        /// </summary>
        [JsonProperty("previous_instance_count", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PreviousInstanceCount
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Guid</para>
        /// </summary>
        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Name</para>
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Name</para>
        /// </summary>
        [JsonProperty("space_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Org Guid</para>
        /// </summary>
        [JsonProperty("org_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrgGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Buildpack Guid</para>
        /// </summary>
        [JsonProperty("buildpack_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? BuildpackGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Buildpack Name</para>
        /// </summary>
        [JsonProperty("buildpack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildpackName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Package State</para>
        /// </summary>
        [JsonProperty("package_state", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageState
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Previous Package State</para>
        /// </summary>
        [JsonProperty("previous_package_state", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PreviousPackageState
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Parent App Guid</para>
        /// </summary>
        [JsonProperty("parent_app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentAppGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Parent App Name</para>
        /// </summary>
        [JsonProperty("parent_app_name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ParentAppName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Process Type</para>
        /// </summary>
        [JsonProperty("process_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Task Name</para>
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TaskName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Task Guid</para>
        /// </summary>
        [JsonProperty("task_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TaskGuid
        {
            get;
            set;
        }
    }
}