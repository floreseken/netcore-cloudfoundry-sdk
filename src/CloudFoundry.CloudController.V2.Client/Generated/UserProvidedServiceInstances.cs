

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
    /// UserProvidedServiceInstances Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UserProvidedServiceInstancesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractUserProvidedServiceInstancesEndpoint
    {
        internal UserProvidedServiceInstancesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for UserProvidedServiceInstances Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUserProvidedServiceInstancesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractUserProvidedServiceInstancesEndpoint()
        {
        }

        /// <summary>
        /// List all User Provided Service Instances
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_user_provided_service_instances.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse>> ListAllUserProvidedServiceInstances()
        {
            return await ListAllUserProvidedServiceInstances(new RequestOptions());
        }

        /// <summary>
        /// List all User Provided Service Instances
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_user_provided_service_instances.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse>> ListAllUserProvidedServiceInstances(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/user_provided_service_instances";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllUserProvidedServiceInstancesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Creating a User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/creating_a_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<CreateUserProvidedServiceInstanceResponse> CreateUserProvidedServiceInstance(CreateUserProvidedServiceInstanceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/user_provided_service_instances";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/delete_a_particular_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task DeleteUserProvidedServiceInstance(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Associate Route with the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/associate_route_with_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<AssociateRouteWithUserProvidedServiceInstanceResponse> AssociateRouteWithUserProvidedServiceInstance(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateRouteWithUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Service Bindings for the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_service_bindings_for_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>> ListAllServiceBindingsForUserProvidedServiceInstance(Guid? guid)
        {
            return await ListAllServiceBindingsForUserProvidedServiceInstance(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Bindings for the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_service_bindings_for_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>> ListAllServiceBindingsForUserProvidedServiceInstance(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}/service_bindings", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Updating a User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/updating_a_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<UpdateUserProvidedServiceInstanceResponse> UpdateUserProvidedServiceInstance(Guid? guid, UpdateUserProvidedServiceInstanceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/retrieve_a_particular_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<RetrieveUserProvidedServiceInstanceResponse> RetrieveUserProvidedServiceInstance(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Routes for the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_routes_for_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForUserProvidedServiceInstanceResponse>> ListAllRoutesForUserProvidedServiceInstance(Guid? guid)
        {
            return await ListAllRoutesForUserProvidedServiceInstance(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Routes for the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/list_all_routes_for_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForUserProvidedServiceInstanceResponse>> ListAllRoutesForUserProvidedServiceInstance(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instances/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllRoutesForUserProvidedServiceInstanceResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Route from the User Provided Service Instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/user_provided_service_instances/remove_route_from_the_user_provided_service_instance.html"</para>
        /// </summary>
        public async Task RemoveRouteFromUserProvidedServiceInstance(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/user_provided_service_instance/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}
