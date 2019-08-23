


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.BuildsExperimentalEndpoint.CreateBuild()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/Builds__experimental_/create_a_Build.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateBuildResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractCreateBuildResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.BuildsExperimentalEndpoint.CreateBuild()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/Builds__experimental_/create_a_Build.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateBuildResponse
    {

// {
//   "guid": "585bc3c1-3743-497d-88b0-403ad6b56d16",
//   "created_at": "2016-03-28T23:39:34Z",
//   "updated_at": "2016-06-08T16:41:26Z",
//   "created_by": {
//     "guid": "3cb4e243-bed4-49d5-8739-f8b45abdec1c",
//     "name": "bill",
//     "email": "bill@example.com"
//   },
//   "state": "STAGING",
//   "error": null,
//   "lifecycle": {
//     "type": "buildpack",
//     "data": {
//       "buildpacks": [ "ruby_buildpack" ],
//       "stack": "cflinuxfs3"
//     }
//   },
//   "package": {
//     "guid": "8e4da443-f255-499c-8b47-b3729b5b7432"
//   },
//   "droplet": null,
//   "metadata": {
//     "labels": { },
//     "annotations": { }
//   },
//   "links": {
//     "self": {
//       "href": "https://api.example.org/v3/builds/585bc3c1-3743-497d-88b0-403ad6b56d16"
//     },
//     "app": {
//       "href": "https://api.example.org/v3/apps/7b34f1cf-7e73-428a-bb5a-8a17a8058396"
//     }
//   }


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
        /// <para>The Created At</para>
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Updated At</para>
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UpdatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Error</para>
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Links</para>
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Links
        {
            get;
            set;
        }
    }
}