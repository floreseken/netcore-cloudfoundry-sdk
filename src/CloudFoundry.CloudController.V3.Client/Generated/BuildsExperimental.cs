using CloudFoundry.CloudController.V3.Client.Data;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// BuildsExperimental Endpoint
    /// </summary>
    public partial class BuildsExperimentalEndpoint : CloudFoundry.CloudController.V3.Client.Base.AbstractBuildsExperimentalEndpoint
    {
        internal BuildsExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V3.Client.Base
{
    /// <summary>
    /// Base abstract class for BuildsExperimental Endpoint
    /// </summary>
    public abstract class AbstractBuildsExperimentalEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractBuildsExperimentalEndpoint()
        {
        }

        /// <summary>
        /// Map a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/map_a_route.html"</para>
        /// </summary>
        public async Task<CreateBuildResponse> CreateBuild(Guid packageGuid)
        {
            var request = new CreateBuildRequest(packageGuid);

            var response = await this.GetNewHttpClient().PostAsync($"/v3/builds", request);
            return JsonConvert.DeserializeObject<CreateBuildResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get a Build
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/unmap_a_route.html"</para>
        /// </summary>
        public async Task<GetBuildResponse> GetBuild(Guid guid)
        {
            var response = await this.GetNewHttpClient().GetAsync($"/v3/builds/{guid}");
            return JsonConvert.DeserializeObject<GetBuildResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
