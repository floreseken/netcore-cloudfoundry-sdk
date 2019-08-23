namespace CloudFoundry.CloudController.Common.Http
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Exceptions;
    using CloudFoundry.CloudController.Common.Http;
    using Newtonsoft.Json;

    /// <inheritdoc/>
    public class NewSimpleHttpClient
    {

        private readonly HttpClient client = null;

        public NewSimpleHttpClient(Uri baseAddress, string token)
        {
            this.client = new HttpClient();

            this.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            this.client.BaseAddress = baseAddress;

        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, object objectToSendAsJson = null)
        {
            if (objectToSendAsJson == null)
                objectToSendAsJson = new Object();

            var content = new StringContent(JsonConvert.SerializeObject(objectToSendAsJson), Encoding.UTF8, "application/json");
            var result = await this.client.PostAsync(requestUri, content);

            if (!result.IsSuccessStatusCode)
            {
                await throwCfException(result);
            }

            return result;
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, object objectToSendAsJson = null)
        {
            if (objectToSendAsJson == null)
                objectToSendAsJson = new Object();

            var content = new StringContent(JsonConvert.SerializeObject(objectToSendAsJson), Encoding.UTF8, "application/json");
            var result = await this.client.PutAsync(requestUri, content);

            if (!result.IsSuccessStatusCode)
            {
                await throwCfException(result);
            }

            return result;
        }

        public async Task DeleteAsync(string requestUri)
        {
            var result = await this.client.DeleteAsync(requestUri);

            if (!result.IsSuccessStatusCode)
            {
                await throwCfException(result);
            }
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            var result = await this.client.GetAsync(requestUri);

            if (!result.IsSuccessStatusCode)
            {
                await throwCfException(result);
            }

            return result;
        }

        public async Task<HttpResponseMessage> PatchAsync(string requestUri, object objectToSendAsJson)
        {
            var requestMessage = new HttpRequestMessage { Method = new HttpMethod("PATCH") };

            var builder = new UriBuilder(this.client.BaseAddress);
            builder.Path = requestUri;
            requestMessage.RequestUri = builder.Uri;

            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(objectToSendAsJson), Encoding.UTF8, "application/json");

            var content = new StringContent(JsonConvert.SerializeObject(objectToSendAsJson), Encoding.UTF8, "application/json");
            var result = await this.client.SendAsync(requestMessage);

            if (!result.IsSuccessStatusCode)
            {
                await throwCfException(result);
            }

            return result;

        }

        public async Task throwCfException(HttpResponseMessage result)
        {
            try
            {
                string response = await result.Content.ReadAsStringAsync();
                var ex = JsonConvert.DeserializeObject<NewCloudFoundryExceptionObject>(response);
                //TODO: somethign with multiple errors?
                var cloudFoundryException = new CloudFoundryException($"{ex.errors[0].Code}: {ex.errors[0].Title}: {ex.errors[0].Detail} ");
                cloudFoundryException.Response = result;
                throw cloudFoundryException;
            }
            catch (CloudFoundryException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new CloudFoundryException($"An error occurred while talking to the server (status: {result.StatusCode}) {ex.Message}", ex);
            }
        }


    }
}