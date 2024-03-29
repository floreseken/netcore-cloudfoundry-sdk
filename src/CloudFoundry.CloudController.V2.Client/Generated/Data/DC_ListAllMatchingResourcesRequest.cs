

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ResourceMatchEndpoint.ListAllMatchingResources()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/resource_match/list_all_matching_resources.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllMatchingResourcesRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllMatchingResourcesRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ResourceMatchEndpoint.ListAllMatchingResources()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/resource_match/list_all_matching_resources.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllMatchingResourcesRequest
    {

        /// <summary> 
        /// <para>The Sha1</para>
        /// </summary>
        [JsonProperty("sha1", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha1
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Size</para>
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size
        {
            get;
            set;
        }
    }
}