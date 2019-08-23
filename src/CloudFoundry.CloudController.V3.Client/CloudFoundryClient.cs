namespace CloudFoundry.CloudController.V3.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common;
    using CloudFoundry.CloudController.Common.Http;
    using Newtonsoft.Json;

    /// <summary>
    /// This is the Cloud Foundry client. To use it, you need a Cloud Foundry endpoint.
    /// </summary>
    public sealed class CloudFoundryClient : CloudFoundry.CloudController.Common.CloudFoundryClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient"/> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken)
            : this(cloudTarget, cancellationToken, null, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient" /> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="httpProxy">The HTTP proxy.</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken, Uri httpProxy)
            : this(cloudTarget, cancellationToken, httpProxy, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient" /> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="httpProxy">The HTTP proxy.</param>
        /// <param name="skipCertificateValidation">if set to <c>true</c> it will skip TLS certificate validation for HTTP requests.</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken, Uri httpProxy, bool skipCertificateValidation)
            : this(cloudTarget, cancellationToken, httpProxy, skipCertificateValidation, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient" /> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="httpProxy">The HTTP proxy.</param>
        /// <param name="skipCertificateValidation">if set to <c>true</c> it will skip TLS certificate validation for HTTP requests.</param>
        /// <param name="authorizationUrl">Authorization Endpoint</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken, Uri httpProxy, bool skipCertificateValidation, Uri authorizationUrl)
            : this(cloudTarget, cancellationToken, httpProxy, skipCertificateValidation, authorizationUrl, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient" /> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="httpProxy">The HTTP proxy.</param>
        /// <param name="skipCertificateValidation">if set to <c>true</c> it will skip TLS certificate validation for HTTP requests.</param>
        /// <param name="authorizationUrl">Authorization Endpoint</param>
        /// <param name="useStrictStatusCodeChecking">throw exception if the successful http status code returned from the server does not match the expected code</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken, Uri httpProxy, bool skipCertificateValidation, Uri authorizationUrl, bool useStrictStatusCodeChecking)
            : this(cloudTarget, cancellationToken, httpProxy, skipCertificateValidation, authorizationUrl, useStrictStatusCodeChecking, SimpleHttpClient.DefaultTimeout)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFoundryClient" /> class.
        /// </summary>
        /// <param name="cloudTarget">The cloud target.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="httpProxy">The HTTP proxy.</param>
        /// <param name="skipCertificateValidation">if set to <c>true</c> it will skip TLS certificate validation for HTTP requests.</param>
        /// <param name="authorizationUrl">Authorization Endpoint</param>
        /// <param name="useStrictStatusCodeChecking">throw exception if the successful http status code returned from the server does not match the expected code</param>
        /// <param name="requestTimeout">Http requests timeout</param>
        public CloudFoundryClient(Uri cloudTarget, CancellationToken cancellationToken, Uri httpProxy, bool skipCertificateValidation, Uri authorizationUrl, bool useStrictStatusCodeChecking, TimeSpan requestTimeout)
            : base(cloudTarget, cancellationToken, httpProxy, skipCertificateValidation, authorizationUrl, useStrictStatusCodeChecking, requestTimeout)
        {
            this.V2 = new V2.Client.CloudFoundryClient(cloudTarget, cancellationToken, httpProxy, skipCertificateValidation, authorizationUrl, useStrictStatusCodeChecking, requestTimeout);
        }

        /// <summary>
        /// Gets the apps endpoint.
        /// </summary>
        /// <value>
        /// The apps endpoint.
        /// </value>
        public AppsExperimentalEndpoint AppsExperimental { get; private set; }

        /// <summary>
        /// Gets the approutes endpoint.
        /// </summary>
        /// <value>
        /// The app routes endpoint.
        /// </value>
        public AppRoutesExperimentalEndpoint AppRoutesExpirimental { get; private set; }


        /// <summary>
        /// Gets the builds endpoint.
        /// </summary>
        /// <value>
        /// The apps endpoint.
        /// </value>
        public BuildsExperimentalEndpoint BuildsExperimental { get; private set; }


        /// <summary>
        /// Gets the droplets endpoint.
        /// </summary>
        /// <value>
        /// The droplets endpoint.
        /// </value>
        public DropletsExperimentalEndpoint DropletsExperimental { get; private set; }

        /// <summary>
        /// Gets the packages endpoint.
        /// </summary>
        /// <value>
        /// The packages endpoint.
        /// </value>
        public PackagesExperimentalEndpoint PackagesExperimental { get; private set; }

        /// <summary>
        /// Gets the processes endpoint.
        /// </summary>
        /// <value>
        /// The processes endpoint.
        /// </value>
        public ProcessesExperimentalEndpoint ProcessesExperimental { get; private set; }
        public TaskResourceEndPoint TaskResource { get; private set; }
        /// <summary>
        /// Gets the authorization token. It returns empty string if the client is not authorized. Also this method does not verify if the current token is expired.
        /// </summary>
        /// <value>
        /// The authorization token.
        /// </value>
        public string AuthorizationToken
        {
            get
            {
                if (this.token == null)
                {
                    return string.Empty;
                }

                if (this.token.IsExpired)
                {
                    Login(this.token.RefreshToken).Wait();
                }

                return this.token.AccessToken;
            }
        }

        private Token token;

        /// <summary>
        /// Instance of CloudFoundry V2 Client 
        /// </summary>
        public CloudController.V2.Client.CloudFoundryClient V2 { get; private set; }

        /// <summary>
        /// Login using the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials.</param>
        /// <returns>Refresh Token</returns>
        public async Task Login(string username, string password)
        {
            if (this.AuthorizationEndpoint == null)
            {
                var info = await this.V2.Info.GetInfo();
                this.AuthorizationEndpoint = new Uri(info.AuthorizationEndpoint);
            }

            var authUrl = new Uri(AuthorizationEndpoint.ToString().TrimEnd('/') + "/oauth/token");

            //var client = new HttpClient();
            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("grant_type", "password"));
            data.Add(new KeyValuePair<string, string>("username", username));
            data.Add(new KeyValuePair<string, string>("password", password));

            this.token = await PostFormUrlEncoded(authUrl.AbsoluteUri, data);

            await this.V2.Login(this.token.RefreshToken);

            //if (context.IsLoggedIn)
            {
                //// Workaround for HCF. Some CC requests (e.g. dev role + bind route, update app, etc..) will fail the first time after login with 401.
                //// Calling the CC's /v2/info endpoint will prevent this misbehavior.
                await this.V2.Info.GetInfo();
            }

            //return context;
        }

        public static async Task<Token> PostFormUrlEncoded(string url, List<KeyValuePair<string, string>> postData)
        {
            using (var httpClient = new HttpClient())
            {

                var byteArray = new UTF8Encoding().GetBytes("cf:");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                using (var content = new FormUrlEncodedContent(postData))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    //content.Headers.Add("Accept", "application/json");

                    var response = await httpClient.PostAsync(url, content);

                    //return await response.Content.ReadAsStringAsync();
                    var str = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Token>(str);
                }
            }
        }

        /// <summary>
        /// Login using the specified raw token.
        /// </summary>
        /// <param name="refreshToken">A raw token.</param>
        /// <returns>Token Object</returns>
        public async Task Login(string refreshToken)
        {
            if (this.AuthorizationEndpoint == null)
            {
                var info = await this.V2.Info.GetInfo();
                this.AuthorizationEndpoint = new Uri(info.AuthorizationEndpoint);
            }

            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
            data.Add(new KeyValuePair<string, string>("refresh_token", refreshToken));

            var authUrl = new Uri(AuthorizationEndpoint.ToString().TrimEnd('/') + "/oauth/token");

            this.token = await PostFormUrlEncoded(authUrl.AbsoluteUri, data);

            await this.V2.Login(refreshToken);

            //if (context.IsLoggedIn)
            {
                //// Workaround for HCF. Some CC requests (e.g. dev role + bind route, update app, etc..) will fail the first time after login with 401.
                //// Calling the CC's /v2/info endpoint will prevent this misbehavior.
                await this.V2.Info.GetInfo();
            }

            //return context;
        }

        /// <summary>
        /// Initializes all API Endpoints
        /// </summary>
        public override void InitEndpoints()
        {
            this.AppsExperimental = new AppsExperimentalEndpoint(this);
            this.AppRoutesExpirimental = new AppRoutesExperimentalEndpoint(this);
            this.BuildsExperimental = new BuildsExperimentalEndpoint(this);
            this.DropletsExperimental = new DropletsExperimentalEndpoint(this);
            this.PackagesExperimental = new PackagesExperimentalEndpoint(this);
            this.ProcessesExperimental = new ProcessesExperimentalEndpoint(this);
            this.TaskResource = new TaskResourceEndPoint(this);
        }
    }
}