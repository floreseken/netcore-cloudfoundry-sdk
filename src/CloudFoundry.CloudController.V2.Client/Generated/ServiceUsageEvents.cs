

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
    /// ServiceUsageEvents Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceUsageEventsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceUsageEventsEndpoint
    {
        internal ServiceUsageEventsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceUsageEvents Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceUsageEventsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceUsageEventsEndpoint()
        {
        }

        /// <summary>
        /// Purge and reseed Service Usage Events
        /// <para>Destroys all existing events. Populates new usage events, one for each existing service instance.</para>
        /// <para>All populated events will have a created_at value of current time.</para>
        /// <para></para>
        /// <para>There is the potential race condition if service instances are currently being created or deleted.</para>
        /// <para></para>
        /// <para>The seeded usage events will have the same guid as the service instance.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_usage_events/purge_and_reseed_service_usage_events.html"</para>
        /// </summary>
        public async Task PurgeAndReseedServiceUsageEvents()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_usage_events/destructively_purge_all_and_reseed_existing_instances";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List Service Usage Events
        /// <para>Events are sorted by internal database IDs. This order may differ from created_at.</para>
        /// <para></para>
        /// <para>Events close to the current time should not be processed because other events may still have open</para>
        /// <para>transactions that will change their order in the results.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_usage_events/list_service_usage_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceUsageEventsResponse>> ListServiceUsageEvents()
        {
            return await ListServiceUsageEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Usage Events
        /// <para>Events are sorted by internal database IDs. This order may differ from created_at.</para>
        /// <para></para>
        /// <para>Events close to the current time should not be processed because other events may still have open</para>
        /// <para>transactions that will change their order in the results.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_usage_events/list_service_usage_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceUsageEventsResponse>> ListServiceUsageEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_usage_events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceUsageEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Service Usage Event
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_usage_events/retrieve_a_particular_service_usage_event.html"</para>
        /// </summary>
        public async Task<RetrieveServiceUsageEventResponse> RetrieveServiceUsageEvent(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_usage_events/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceUsageEventResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
