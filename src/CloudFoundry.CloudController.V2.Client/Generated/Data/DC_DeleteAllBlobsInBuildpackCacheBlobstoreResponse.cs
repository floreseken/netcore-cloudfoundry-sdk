

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.BlobstoresEndpoint.DeleteAllBlobsInBuildpackCacheBlobstore()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/blobstores/delete_all_blobs_in_the_buildpack_cache_blobstore.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class DeleteAllBlobsInBuildpackCacheBlobstoreResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractDeleteAllBlobsInBuildpackCacheBlobstoreResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.BlobstoresEndpoint.DeleteAllBlobsInBuildpackCacheBlobstore()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/blobstores/delete_all_blobs_in_the_buildpack_cache_blobstore.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractDeleteAllBlobsInBuildpackCacheBlobstoreResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Guid</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Status</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }
    }
}