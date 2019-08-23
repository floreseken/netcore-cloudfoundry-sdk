using CloudFoundry.CloudController.V3.Client.Helpers;
using CloudFoundry.CloudController.V3.Client.Model;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// Class for BuildsExperimental Endpoint
    /// </summary>
    public class BuildsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        internal BuildsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }

        /// <summary>
        /// Create a build
        /// </summary>
        public async Task<Build> CreateBuild(Guid packageGuid)
        {
            var request = new Build(packageGuid);

            var response = await this.GetNewHttpClient().PostAsync($"/v3/builds", request);
            return JsonConvert.DeserializeObject<Build>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get a Build
        /// </summary>
        public async Task<Build> GetBuild(Guid guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/builds/{guid}");
            return JsonConvert.DeserializeObject<Build>(await response.Content.ReadAsStringAsync());
        }


        // public async Task<PagedResponseCollection<ListBuildsResponse>> ListBuilds()
        // {
        //     var response = await this.GetNewHttpClient().GetAsync($"/v3/builds");
        //     //return JsonConvert.DeserializeObject<ListBuildsResponse>(await response.Content.ReadAsStringAsync());
        //     return Utilities.DeserializePage<ListBuildsResponse>(await response.Content.ReadAsStringAsync(), this.Client);

        // }

    }
}
