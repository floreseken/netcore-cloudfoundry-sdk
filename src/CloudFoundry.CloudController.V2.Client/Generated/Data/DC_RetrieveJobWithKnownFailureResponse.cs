

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.JobsEndpoint.RetrieveJobWithKnownFailure()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_with_known_failure.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveJobWithKnownFailureResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveJobWithKnownFailureResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.JobsEndpoint.RetrieveJobWithKnownFailure()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_with_known_failure.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveJobWithKnownFailureResponse : IResponse
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
        /// <para>The Guid</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Status</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error</para>
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error Details</para>
        /// </summary>
        [JsonProperty("error_details", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> ErrorDetails
        {
            get;
            set;
        }
    }
}