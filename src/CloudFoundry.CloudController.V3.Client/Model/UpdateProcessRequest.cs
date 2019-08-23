using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.ProcessesExperimentalEndpoint.UpdateProcess()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
    /// </summary>
    public class UpdateProcessRequest
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