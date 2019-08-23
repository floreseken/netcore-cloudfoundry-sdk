


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.UpdateProcess()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateProcessRequest : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractUpdateProcessRequest
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.UpdateProcess()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateProcessRequest
    {

        /// <summary> 
        /// <para>Start command for process</para>
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command
        {
            get;
            set;
        }
    }
}