

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.EnvironmentVariableGroupsEndpoint.UpdateContentsOfRunningEnvironmentVariableGroup()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/environment_variable_groups/updating_the_contents_of_the_running_environment_variable_group.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateContentsOfRunningEnvironmentVariableGroupRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateContentsOfRunningEnvironmentVariableGroupRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.EnvironmentVariableGroupsEndpoint.UpdateContentsOfRunningEnvironmentVariableGroup()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/environment_variable_groups/updating_the_contents_of_the_running_environment_variable_group.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateContentsOfRunningEnvironmentVariableGroupRequest
    {

        /// <summary> 
        /// <para>The Abc</para>
        /// </summary>
        [JsonProperty("abc", NullValueHandling = NullValueHandling.Ignore)]
        public int? Abc
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Doreme</para>
        /// </summary>
        [JsonProperty("do-re-me", NullValueHandling = NullValueHandling.Ignore)]
        public string Doreme
        {
            get;
            set;
        }
    }
}