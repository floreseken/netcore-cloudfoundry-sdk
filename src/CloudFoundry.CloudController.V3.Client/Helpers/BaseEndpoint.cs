namespace CloudFoundry.CloudController.V3.Client
{
    using System;
    using System.Globalization;
    using System.Net;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Exceptions;
    using CloudFoundry.CloudController.Common.Http;
    using System.Net.Http;

    /// <summary>
    /// Base class for all the Cloud Foundry endpoints.
    /// </summary>
    public class BaseEndpoint
    {
        internal CloudFoundryClient Client { get; set; }

        internal SimpleHttpClient GetHttpClient(bool authenticate = true)
        {
            var httpClient = new SimpleHttpClient(this.Client.CancellationToken, this.Client.RequestTimeout, this.Client.SkipCertificateValidation);

            try
            {
                httpClient.HttpProxy = this.Client.HttpProxy;
                httpClient.SkipCertificateValidation = this.Client.SkipCertificateValidation;

                if (authenticate)
                {
                    httpClient.AddAuthentication(this.Client.AuthorizationToken);
                }
            }
            catch
            {
                httpClient.Dispose();
                throw;
            }

            return httpClient;
        }

        internal NewSimpleHttpClient GetNewHttpClient()
        {
            var httpClient = new NewSimpleHttpClient(this.Client.CloudTarget, this.Client.AuthorizationToken);

            return httpClient;
        }

        internal async Task<HttpResponseMessage> SendAsync(SimpleHttpClient client, int expectedReturnStatus)
        {
            var result = await client.SendAsync();

            bool success = ((int)result.StatusCode) == expectedReturnStatus;
            if (!success && !this.Client.UseStrictStatusCodeChecking)
            {
                success = IsSuccessStatusCode(result.StatusCode);
            }

            if (!success)
            {
                // Check if we can deserialize the response
                CloudFoundryException cloudFoundryException;
                try
                {
                    string response = await result.Content.ReadAsStringAsync();
                    var exceptionObject = Utilities.DeserializeJson<CloudFoundryExceptionObject>(response);
                    cloudFoundryException = new CloudFoundryException(exceptionObject);
                    cloudFoundryException.Response = result;
                    throw cloudFoundryException;
                }
                catch (CloudFoundryException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new CloudFoundryException(string.Format(CultureInfo.InvariantCulture, "An error occurred while talking to the server ({0})", result.StatusCode), ex);
                }
            }

            return result;
        }
        internal async Task<HttpResponseMessage> SendAsync(SimpleHttpClient client, int expectedReturnStatus, HttpContent content)
        {
            var result = await client.SendAsync(content);

            bool success = ((int)result.StatusCode) == expectedReturnStatus;
            if (!success && !this.Client.UseStrictStatusCodeChecking)
            {
                success = IsSuccessStatusCode(result.StatusCode);
            }

            if (!success)
            {
                // Check if we can deserialize the response
                CloudFoundryException cloudFoundryException;
                try
                {
                    string response = await result.Content.ReadAsStringAsync();
                    var exceptionObject = Utilities.DeserializeJson<CloudFoundryExceptionObject>(response);
                    cloudFoundryException = new CloudFoundryException(exceptionObject);
                    cloudFoundryException.Response = result;
                    throw cloudFoundryException;
                }
                catch (CloudFoundryException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new CloudFoundryException(string.Format(CultureInfo.InvariantCulture, "An error occurred while talking to the server ({0})", result.StatusCode), ex);
                }
            }

            return result;
        }

        private static bool IsSuccessStatusCode(HttpStatusCode statusCode)
        {
            return statusCode >= HttpStatusCode.OK && statusCode < HttpStatusCode.MultipleChoices;
        }
    }
}