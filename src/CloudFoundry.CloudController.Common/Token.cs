namespace CloudFoundry.CloudController.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// Class that represents a token items from Oauth v2.
    /// </summary>
    public class Token
    {
        private DateTime created;

        public Token()
        {
            this.created = DateTime.UtcNow;   
        }

        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenType { get; set; }


        /// <summary>
        /// Gets a value indicating whether this token is expired.
        /// </summary>
        /// <value>
        /// <c>true</c> if this token is expired; otherwise, <c>false</c>.
        /// </value>
        public bool IsExpired
        {
            get
            {
                if (DateTime.UtcNow > created.AddSeconds(this.ExpiresIn - 15))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

  
    }
}
