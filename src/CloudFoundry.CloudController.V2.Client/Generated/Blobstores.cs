

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
    /// Blobstores Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class BlobstoresEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractBlobstoresEndpoint
    {
        internal BlobstoresEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Blobstores Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractBlobstoresEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractBlobstoresEndpoint()
        {
        }

        /// <summary>
        /// Delete all blobs in the Buildpack cache blobstore
        /// <para>This endpoint will delete all of the existing buildpack caches in</para>
        /// <para>the blobstore. The buildpack cache is used during staging by buildpacks</para>
        /// <para>as a way to cache certain resources, e.g. downloaded Ruby gems. An admin</para>
        /// <para>who wanted to decrease the size of their blobstore could use this endpoint</para>
        /// <para>to delete unnecessary blobs.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/blobstores/delete_all_blobs_in_the_buildpack_cache_blobstore.html"</para>
        /// </summary>
        public async Task<DeleteAllBlobsInBuildpackCacheBlobstoreResponse> DeleteAllBlobsInBuildpackCacheBlobstore()
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/blobstores/buildpack_cache";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 202;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<DeleteAllBlobsInBuildpackCacheBlobstoreResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
