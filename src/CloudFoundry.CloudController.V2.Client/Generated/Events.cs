

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
    /// Events Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class EventsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractEventsEndpoint
    {
        internal EventsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Events Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractEventsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractEventsEndpoint()
        {
        }

        /// <summary>
        /// List App Stop Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_stop_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppStopEventsResponse>> ListAppStopEvents()
        {
            return await ListAppStopEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Stop Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_stop_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppStopEventsResponse>> ListAppStopEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppStopEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Route Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteUpdateEventsResponse>> ListRouteUpdateEvents()
        {
            return await ListRouteUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Route Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteUpdateEventsResponse>> ListRouteUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListRouteUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanCreateEventsResponse>> ListServicePlanCreateEvents()
        {
            return await ListServicePlanCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanCreateEventsResponse>> ListServicePlanCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Instance Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceDeleteEventsResponse>> ListServiceInstanceDeleteEvents()
        {
            return await ListServiceInstanceDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Instance Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceDeleteEventsResponse>> ListServiceInstanceDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Key Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_key_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceKeyDeleteEventsResponse>> ListServiceKeyDeleteEvents()
        {
            return await ListServiceKeyDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Key Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_key_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceKeyDeleteEventsResponse>> ListServiceKeyDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceKeyDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceCreateEventsResponse>> ListServiceCreateEvents()
        {
            return await ListServiceCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceCreateEventsResponse>> ListServiceCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List User Provided Service Instance Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceDeleteEventsResponse>> ListUserProvidedServiceInstanceDeleteEvents()
        {
            return await ListUserProvidedServiceInstanceDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List User Provided Service Instance Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceDeleteEventsResponse>> ListUserProvidedServiceInstanceDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Event
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/retrieve_a_particular_event.html"</para>
        /// </summary>
        public async Task<RetrieveEventResponse> RetrieveEvent(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/events/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveEventResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List Service Broker Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerCreateEventsResponse>> ListServiceBrokerCreateEvents()
        {
            return await ListServiceBrokerCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Broker Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerCreateEventsResponse>> ListServiceBrokerCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Instance Unbind Route Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_unbind_route_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceUnbindRouteEventsResponse>> ListServiceInstanceUnbindRouteEvents()
        {
            return await ListServiceInstanceUnbindRouteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Instance Unbind Route Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_unbind_route_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceUnbindRouteEventsResponse>> ListServiceInstanceUnbindRouteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceUnbindRouteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Space Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceDeleteEventsResponse>> ListSpaceDeleteEvents()
        {
            return await ListSpaceDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Space Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceDeleteEventsResponse>> ListSpaceDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Space Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceUpdateEventsResponse>> ListSpaceUpdateEvents()
        {
            return await ListSpaceUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Space Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceUpdateEventsResponse>> ListSpaceUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanUpdateEventsResponse>> ListServicePlanUpdateEvents()
        {
            return await ListServicePlanUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanUpdateEventsResponse>> ListServicePlanUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppCreateEventsResponse>> ListAppCreateEvents()
        {
            return await ListAppCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppCreateEventsResponse>> ListAppCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Route Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteCreateEventsResponse>> ListRouteCreateEvents()
        {
            return await ListRouteCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Route Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteCreateEventsResponse>> ListRouteCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListRouteCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List User Provided Service Instance Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceUpdateEventsResponse>> ListUserProvidedServiceInstanceUpdateEvents()
        {
            return await ListUserProvidedServiceInstanceUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List User Provided Service Instance Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceUpdateEventsResponse>> ListUserProvidedServiceInstanceUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Broker Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerUpdateEventsResponse>> ListServiceBrokerUpdateEvents()
        {
            return await ListServiceBrokerUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Broker Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerUpdateEventsResponse>> ListServiceBrokerUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Broker Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerDeleteEventsResponse>> ListServiceBrokerDeleteEvents()
        {
            return await ListServiceBrokerDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Broker Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_broker_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerDeleteEventsResponse>> ListServiceBrokerDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Instance Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceUpdateEventsResponse>> ListServiceInstanceUpdateEvents()
        {
            return await ListServiceInstanceUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Instance Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceUpdateEventsResponse>> ListServiceInstanceUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Instance Bind Route Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_bind_route_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceBindRouteEventsResponse>> ListServiceInstanceBindRouteEvents()
        {
            return await ListServiceInstanceBindRouteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Instance Bind Route Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_bind_route_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceBindRouteEventsResponse>> ListServiceInstanceBindRouteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceBindRouteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Key Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_key_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceKeyCreateEventsResponse>> ListServiceKeyCreateEvents()
        {
            return await ListServiceKeyCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Key Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_key_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceKeyCreateEventsResponse>> ListServiceKeyCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceKeyCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List User Provided Service Instance Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceCreateEventsResponse>> ListUserProvidedServiceInstanceCreateEvents()
        {
            return await ListUserProvidedServiceInstanceCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List User Provided Service Instance Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_user_provided_service_instance_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceCreateEventsResponse>> ListUserProvidedServiceInstanceCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_all_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsResponse>> ListAllEvents()
        {
            return await ListAllEvents(new RequestOptions());
        }

        /// <summary>
        /// List all Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_all_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsResponse>> ListAllEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Remove Role Space Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_remove_role_space_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRemoveRoleSpaceEventsResponse>> ListRemoveRoleSpaceEvents()
        {
            return await ListRemoveRoleSpaceEvents(new RequestOptions());
        }

        /// <summary>
        /// List Remove Role Space Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_remove_role_space_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRemoveRoleSpaceEventsResponse>> ListRemoveRoleSpaceEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListRemoveRoleSpaceEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List events associated with an App since January 1, 2014
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_events_associated_with_an_app_since_january_1,_2014.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListEventsAssociatedWithAppSinceJanuary12014Response>> ListEventsAssociatedWithAppSinceJanuary12014()
        {
            return await ListEventsAssociatedWithAppSinceJanuary12014(new RequestOptions());
        }

        /// <summary>
        /// List events associated with an App since January 1, 2014
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_events_associated_with_an_app_since_january_1,_2014.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListEventsAssociatedWithAppSinceJanuary12014Response>> ListEventsAssociatedWithAppSinceJanuary12014(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListEventsAssociatedWithAppSinceJanuary12014Response>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Associate Role Space Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_associate_role_space_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociateRoleSpaceEventsResponse>> ListAssociateRoleSpaceEvents()
        {
            return await ListAssociateRoleSpaceEvents(new RequestOptions());
        }

        /// <summary>
        /// List Associate Role Space Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_associate_role_space_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAssociateRoleSpaceEventsResponse>> ListAssociateRoleSpaceEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAssociateRoleSpaceEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App SSH Authorized Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_ssh_authorized_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppSshAuthorizedEventsResponse>> ListAppSshAuthorizedEvents()
        {
            return await ListAppSshAuthorizedEvents(new RequestOptions());
        }

        /// <summary>
        /// List App SSH Authorized Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_ssh_authorized_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppSshAuthorizedEventsResponse>> ListAppSshAuthorizedEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppSshAuthorizedEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Binding Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_binding_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingDeleteEventsResponse>> ListServiceBindingDeleteEvents()
        {
            return await ListServiceBindingDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Binding Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_binding_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingDeleteEventsResponse>> ListServiceBindingDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBindingDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Dashboard Client Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientCreateEventsResponse>> ListServiceDashboardClientCreateEvents()
        {
            return await ListServiceDashboardClientCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Dashboard Client Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientCreateEventsResponse>> ListServiceDashboardClientCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDashboardClientCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App Exited Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_exited_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppExitedEventsResponse>> ListAppExitedEvents()
        {
            return await ListAppExitedEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Exited Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_exited_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppExitedEventsResponse>> ListAppExitedEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppExitedEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanDeleteEventsResponse>> ListServicePlanDeleteEvents()
        {
            return await ListServicePlanDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanDeleteEventsResponse>> ListServicePlanDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App SSH Unauthorized Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_ssh_unauthorized_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppSshUnauthorizedEventsResponse>> ListAppSshUnauthorizedEvents()
        {
            return await ListAppSshUnauthorizedEvents(new RequestOptions());
        }

        /// <summary>
        /// List App SSH Unauthorized Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_ssh_unauthorized_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppSshUnauthorizedEventsResponse>> ListAppSshUnauthorizedEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppSshUnauthorizedEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Visibility Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityUpdateEventsResponse>> ListServicePlanVisibilityUpdateEvents()
        {
            return await ListServicePlanVisibilityUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Visibility Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityUpdateEventsResponse>> ListServicePlanVisibilityUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceUpdateEventsResponse>> ListServiceUpdateEvents()
        {
            return await ListServiceUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceUpdateEventsResponse>> ListServiceUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Dashboard Client Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientDeleteEventsResponse>> ListServiceDashboardClientDeleteEvents()
        {
            return await ListServiceDashboardClientDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Dashboard Client Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_dashboard_client_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientDeleteEventsResponse>> ListServiceDashboardClientDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDashboardClientDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Instance Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceCreateEventsResponse>> ListServiceInstanceCreateEvents()
        {
            return await ListServiceInstanceCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Instance Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_instance_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceCreateEventsResponse>> ListServiceInstanceCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppDeleteEventsResponse>> ListAppDeleteEvents()
        {
            return await ListAppDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppDeleteEventsResponse>> ListAppDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Space Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceCreateEventsResponse>> ListSpaceCreateEvents()
        {
            return await ListSpaceCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Space Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_space_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceCreateEventsResponse>> ListSpaceCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Binding Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_binding_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingCreateEventsResponse>> ListServiceBindingCreateEvents()
        {
            return await ListServiceBindingCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Binding Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_binding_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingCreateEventsResponse>> ListServiceBindingCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBindingCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Visibility Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityDeleteEventsResponse>> ListServicePlanVisibilityDeleteEvents()
        {
            return await ListServicePlanVisibilityDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Visibility Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityDeleteEventsResponse>> ListServicePlanVisibilityDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App Start Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_start_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppStartEventsResponse>> ListAppStartEvents()
        {
            return await ListAppStartEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Start Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_start_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppStartEventsResponse>> ListAppStartEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppStartEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Plan Visibility Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityCreateEventsResponse>> ListServicePlanVisibilityCreateEvents()
        {
            return await ListServicePlanVisibilityCreateEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Plan Visibility Create Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_plan_visibility_create_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityCreateEventsResponse>> ListServicePlanVisibilityCreateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityCreateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Route Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteDeleteEventsResponse>> ListRouteDeleteEvents()
        {
            return await ListRouteDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Route Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_route_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListRouteDeleteEventsResponse>> ListRouteDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListRouteDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List Service Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDeleteEventsResponse>> ListServiceDeleteEvents()
        {
            return await ListServiceDeleteEvents(new RequestOptions());
        }

        /// <summary>
        /// List Service Delete Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_service_delete_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDeleteEventsResponse>> ListServiceDeleteEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDeleteEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List App Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppUpdateEventsResponse>> ListAppUpdateEvents()
        {
            return await ListAppUpdateEvents(new RequestOptions());
        }

        /// <summary>
        /// List App Update Events
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/events/list_app_update_events.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAppUpdateEventsResponse>> ListAppUpdateEvents(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/events";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppUpdateEventsResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }
    }
}
