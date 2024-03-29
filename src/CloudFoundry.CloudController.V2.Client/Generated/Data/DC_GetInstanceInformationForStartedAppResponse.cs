

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetInstanceInformationForStartedApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_the_instance_information_for_a_started_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetInstanceInformationForStartedAppResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetInstanceInformationForStartedAppResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetInstanceInformationForStartedApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/get_the_instance_information_for_a_started_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetInstanceInformationForStartedAppResponse : IResponse
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
        /// <para>The Since</para>
        /// </summary>
        [JsonProperty("since", NullValueHandling = NullValueHandling.Ignore)]
        public double? Since
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Uptime</para>
        /// </summary>
        [JsonProperty("uptime", NullValueHandling = NullValueHandling.Ignore)]
        public int? Uptime
        {
            get;
            set;
        }
    }
}