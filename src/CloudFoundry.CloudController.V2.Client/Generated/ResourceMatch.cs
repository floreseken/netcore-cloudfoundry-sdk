

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
    /// ResourceMatch Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ResourceMatchEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractResourceMatchEndpoint
    {
        internal ResourceMatchEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for ResourceMatch Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractResourceMatchEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractResourceMatchEndpoint()
        {
        }

        /// <summary>
        /// List all matching resources
        /// <para>This endpoint matches given resource SHA / file size pairs against the Cloud Controller cache,</para>
        /// <para>and reports the subset which describes already existing files.</para>
        /// <para>This is usually used to avoid uploading duplicate files when</para>
        /// <para>pushing an app which has only been partially changed.</para>
        /// <para>Cloud Foundry operators may set minimum / maximum file sizes to match against.</para>
        /// <para>If the file size provided is outside this range, it will not be matched against.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/resource_match/list_all_matching_resources.html"</para>
        /// </summary>
        public async Task<ListAllMatchingResourcesResponse[]> ListAllMatchingResources(ListAllMatchingResourcesRequest[] value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/resource_match";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJsonArray<ListAllMatchingResourcesResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
