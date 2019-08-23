

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Jobs Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class JobsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractJobsEndpoint
    {
        internal JobsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Jobs Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractJobsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractJobsEndpoint()
        {
        }

        /// <summary>
        /// Retrieve Job with known failure
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_with_known_failure.html"</para>
        /// </summary>
        public async Task<RetrieveJobWithKnownFailureResponse> RetrieveJobWithKnownFailure(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/jobs/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobWithKnownFailureResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job with unknown failure
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_with_unknown_failure.html"</para>
        /// </summary>
        public async Task<RetrieveJobWithUnknownFailureResponse> RetrieveJobWithUnknownFailure(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/jobs/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobWithUnknownFailureResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job that is queued
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_that_is_queued.html"</para>
        /// </summary>
        public async Task<RetrieveJobThatIsQueuedResponse> RetrieveJobThatIsQueued(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/jobs/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobThatIsQueuedResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve Job that was successful
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/jobs/retrieve_job_that_was_successful.html"</para>
        /// </summary>
        public async Task<RetrieveJobThatWasSuccessfulResponse> RetrieveJobThatWasSuccessful(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/jobs/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveJobThatWasSuccessfulResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
