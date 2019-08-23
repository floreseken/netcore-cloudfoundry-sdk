

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
    /// Files Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class FilesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractFilesEndpoint
    {
        internal FilesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Files Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractFilesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractFilesEndpoint()
        {
        }

        /// <summary>
        /// Retrieve File
        /// <para>The endpoint does not function with Diego apps.</para>
        /// <para>Please use CF CLI command `cf ssh` for Diego apps.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/250/files/retrieve_file.html"</para>
        /// </summary>
        public async Task RetrieveFile(Guid? app_guid, int? instance_index, dynamic file_path)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/instances/{1}/files/{2}", app_guid, instance_index, file_path);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 302;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}
