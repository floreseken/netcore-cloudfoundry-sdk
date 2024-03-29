using CloudFoundry.CloudController.V3.Client.Helpers;
using CloudFoundry.CloudController.V3.Client.Model;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// Class for PackagesExperimental Endpoint
    /// </summary>
    public partial class PackagesExperimentalEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        internal PackagesExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }

        /// <summary>
        /// Copy a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/copy_a_package.html"</para>
        /// </summary>
        public async Task<Model.Package> CopyPackage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/packages", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;

            
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<Package>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Create a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/create_a_package.html"</para>
        /// </summary>
        public async Task<Model.Package> CreatePackage(Model.Package value)
        {
            var response = await this.GetNewHttpClient().PostAsync("/v3/packages", value);
            return JsonConvert.DeserializeObject<Model.Package>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/delete_a_package.html"</para>
        /// </summary>
        public async Task DeletePackage(Guid? guid)
        {
            await this.GetNewHttpClient().DeleteAsync($"/v3/packages/{guid}"); 
        }

        /// <summary>
        /// Get a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/get_a_package.html"</para>
        /// </summary>
        public async Task<Package> GetPackage(Guid? guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/packages/{guid}");
            return JsonConvert.DeserializeObject<Model.Package>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/list_all_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPackagesResponse>> ListAllPackages()
        {
            return await ListAllPackages(new RequestOptions());
        }

        /// <summary>
        /// List all Packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/list_all_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPackagesResponse>> ListAllPackages(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/packages";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
    
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPackagesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Stage a package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/packages__experimental_/stage_a_package.html"</para>
        /// </summary>
        public async Task<StagePackageResponse> StagePackage(Guid? guid, StagePackageRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/packages/{0}/droplets", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
 
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus, new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json"));
            return Utilities.DeserializeJson<StagePackageResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
