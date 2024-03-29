

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
    /// ServiceInstances Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ServiceInstancesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServiceInstancesEndpoint
    {
        internal ServiceInstancesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ServiceInstances Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServiceInstancesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractServiceInstancesEndpoint()
        {
        }

        /// <summary>
        /// Unbinding a service instance from a route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/unbinding_a_service_instance_from_a_route.html"</para>
        /// </summary>
        public async Task UnbindingServiceInstanceFromRoute(Guid? service_instance_guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/routes/{1}", service_instance_guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Service Instances
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_instances.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesResponse>> ListAllServiceInstances()
        {
            return await ListAllServiceInstances(new RequestOptions());
        }

        /// <summary>
        /// List all Service Instances
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_instances.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesResponse>> ListAllServiceInstances(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_instances";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceInstancesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/delete_a_service_instance.html"</para>
        /// </summary>
        public async Task<DeleteServiceInstanceResponse> DeleteServiceInstance(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 202;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<DeleteServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/retrieve_a_particular_service_instance.html"</para>
        /// </summary>
        public async Task<RetrieveServiceInstanceResponse> RetrieveServiceInstance(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Bindings for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_bindings_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse>> ListAllServiceBindingsForServiceInstance(Guid? guid)
        {
            return await ListAllServiceBindingsForServiceInstance(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Bindings for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_bindings_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse>> ListAllServiceBindingsForServiceInstance(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/service_bindings", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsForServiceInstanceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Routes for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_routes_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForServiceInstanceResponse>> ListAllRoutesForServiceInstance(Guid? guid)
        {
            return await ListAllRoutesForServiceInstance(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Routes for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_routes_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForServiceInstanceResponse>> ListAllRoutesForServiceInstance(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllRoutesForServiceInstanceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieving permissions on a Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/retrieving_permissions_on_a_service_instance.html"</para>
        /// </summary>
        public async Task<RetrievingPermissionsOnServiceInstanceResponse> RetrievingPermissionsOnServiceInstance(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/permissions", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrievingPermissionsOnServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Update a Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/update_a_service_instance.html"</para>
        /// </summary>
        public async Task<UpdateServiceInstanceResponse> UpdateServiceInstance(Guid? guid, UpdateServiceInstanceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 202;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Creating a Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/creating_a_service_instance.html"</para>
        /// </summary>
        public async Task<CreateServiceInstanceResponse> CreateServiceInstance(CreateServiceInstanceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/service_instances";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 202;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Keys for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_keys_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceKeysForServiceInstanceResponse>> ListAllServiceKeysForServiceInstance(Guid? guid)
        {
            return await ListAllServiceKeysForServiceInstance(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Keys for the Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/list_all_service_keys_for_the_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceKeysForServiceInstanceResponse>> ListAllServiceKeysForServiceInstance(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/service_keys", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceKeysForServiceInstanceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Binding a Service Instance to a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/service_instances/binding_a_service_instance_to_a_route.html"</para>
        /// </summary>
        public async Task<BindingServiceInstanceToRouteResponse> BindingServiceInstanceToRoute(Guid? service_instance_guid, Guid? route_guid, BindingServiceInstanceToRouteRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/service_instances/{0}/routes/{1}", service_instance_guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<BindingServiceInstanceToRouteResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
