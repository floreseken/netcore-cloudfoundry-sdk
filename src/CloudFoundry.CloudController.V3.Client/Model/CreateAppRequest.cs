using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;


namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.CreateApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/create_an_app.html"</para>
    /// </summary>
    public class CreateAppRequest
    {
        public CreateAppRequest(string name, Guid spaceGuid)
        {
            this.Name = name;

            this.Relationships = new Dictionary<string, dynamic>();
            this.Relationships.Add("space", new { data = new { guid = spaceGuid } } );

        }


        /// <summary> 
        /// <para>Name of the App</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Environment variables to be used for the App when running</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Lifecycle to be used when creating the app.</para>
        /// <para>Note: If no lifecycle is provided, lifecycle type defaults to buildpack.</para>
        /// <para>Data is a required field in lifecycle</para>
        /// </summary>
        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Lifecycle
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Guid for a particular space</para>
        /// </summary>
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Relationships
        {
            get;
            set;
        }
    }
}