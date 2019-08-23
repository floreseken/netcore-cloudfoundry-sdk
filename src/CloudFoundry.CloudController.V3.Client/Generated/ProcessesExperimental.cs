using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V3.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Base
{
    /// <summary>
    /// Class for ProcessesExperimental Endpoint
    /// </summary>
    public class ProcessesExperimentalEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        internal ProcessesExperimentalEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }

        /// <summary>
        /// Get a Process
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/get_a_process.html"</para>
        /// </summary>
        public async Task<GetProcessResponse> GetProcess(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/processes/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
 
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetProcessResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// List all Processes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/list_all_processes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllProcessesResponse>> ListAllProcesses()
        {
            return await ListAllProcesses(new RequestOptions());
        }

        /// <summary>
        /// List all Processes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/list_all_processes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllProcessesResponse>> ListAllProcesses(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/processes";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllProcessesResponse>(await response.Content.ReadAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Scaling a Process
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/scaling_a_process.html"</para>
        /// </summary>
        public async Task<ScalingProcessResponse> ScalingProcess(Guid? guid, ScalingProcessRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/processes/{0}/scale", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;

            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus, new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json"));
            return Utilities.DeserializeJson<ScalingProcessResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Terminating a Process instance
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/terminating_a_process_instance.html"</para>
        /// </summary>
        public async Task TerminatingProcessInstance(Guid? guid, int? index)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/processes/{0}/instances/{1}", guid, index);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;

            
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Updating a Process
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/238/processes__experimental_/updating_a_process.html"</para>
        /// </summary>
        public async Task<UpdateProcessResponse> UpdateProcess(Guid? guid, UpdateProcessRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/processes/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = new HttpMethod("PATCH");
 
            
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateProcessResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
