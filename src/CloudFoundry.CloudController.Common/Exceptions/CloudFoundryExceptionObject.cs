﻿namespace CloudFoundry.CloudController.Common.Exceptions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Json object that comes from the server
    /// </summary>
    public class CloudFoundryExceptionObject
    {
        /// <summary>
        /// Gets or sets the http status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
    }


    public class NewCloudFoundryExceptionObject
    {
        /// <summary>
        /// Gets or sets the http status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        [JsonProperty("errors")]
        public CfError[] errors { get; set; }

    }

    public class CfError
    {
        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

}
