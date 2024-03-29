

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.InfoEndpoint.GetInfo()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/info/get_info.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetInfoResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetInfoResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.InfoEndpoint.GetInfo()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/info/get_info.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetInfoResponse : IResponse
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
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Build</para>
        /// </summary>
        [JsonProperty("build", NullValueHandling = NullValueHandling.Ignore)]
        public string Build
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Support</para>
        /// </summary>
        [JsonProperty("support", NullValueHandling = NullValueHandling.Ignore)]
        public string Support
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Version</para>
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Description</para>
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Authorization Endpoint</para>
        /// </summary>
        [JsonProperty("authorization_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Token Endpoint</para>
        /// </summary>
        [JsonProperty("token_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenEndpoint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Min Cli Version</para>
        /// </summary>
        [JsonProperty("min_cli_version", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic MinCliVersion
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Min Recommended Cli Version</para>
        /// </summary>
        [JsonProperty("min_recommended_cli_version", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic MinRecommendedCliVersion
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Api Version</para>
        /// </summary>
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Ssh Endpoint</para>
        /// </summary>
        [JsonProperty("app_ssh_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSshEndpoint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Ssh Host Key Fingerprint</para>
        /// </summary>
        [JsonProperty("app_ssh_host_key_fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSshHostKeyFingerprint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Ssh Oauth Client</para>
        /// </summary>
        [JsonProperty("app_ssh_oauth_client", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AppSshOauthClient
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Routing Endpoint</para>
        /// </summary>
        [JsonProperty("routing_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingEndpoint
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Logging Endpoint</para>
        /// </summary>
        [JsonProperty("logging_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string LoggingEndpoint
        {
            get;
            set;
        }
    }
}