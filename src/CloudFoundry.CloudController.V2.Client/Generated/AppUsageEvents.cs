

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
    /// AppUsageEvents Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AppUsageEventsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractAppUsageEventsEndpoint
    {
        internal AppUsageEventsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for AppUsageEvents Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAppUsageEventsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractAppUsageEventsEndpoint()
        {
        }

        /// <summary>
        /// Retrieve a Particular App Usage Event
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/app_usage_events/retrieve_a_particular_app_usage_event.html"</para>
        /// </summary>
        public async Task<RetrieveAppUsageEventResponse> RetrieveAppUsageEvent(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/app_usage_events/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveAppUsageEventResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Purge and reseed App Usage Events
        /// <para>Destroys all existing events. Populates new usage events, one for each started app.</para>
        /// <para>All populated events will have a created_at value of current time.</para>
        /// <para></para>
        /// <para>There is the potential race condition if apps are currently being started, stopped, or scaled.</para>
        /// <para></para>
        /// <para>The seeded usage events will have the same guid as the app.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/app_usage_events/purge_and_reseed_app_usage_events.html"</para>
        /// </summary>
        public async Task PurgeAndReseedAppUsageEvents()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/app_usage_events/destructively_purge_all_and_reseed_started_apps";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all App Usage Events
        /// <para>Events are sorted by internal database IDs. This order may differ from created_at.</para>
        /// <para></para>
        /// <para>Events close to the current time should not be processed because other events may still have open</para>
        /// <para>transactions that will change their order in the results.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/app_usage_events/list_all_app_usage_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppUsageEventsResponse>> ListAllAppUsageEvents()
        {
            return await ListAllAppUsageEvents(new RequestOptions());
        }

        /// <summary>
        /// List all App Usage Events
        /// <para>Events are sorted by internal database IDs. This order may differ from created_at.</para>
        /// <para></para>
        /// <para>Events close to the current time should not be processed because other events may still have open</para>
        /// <para>transactions that will change their order in the results.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/app_usage_events/list_all_app_usage_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppUsageEventsResponse>> ListAllAppUsageEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/app_usage_events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAppUsageEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
