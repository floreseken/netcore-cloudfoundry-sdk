


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CreatePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/create_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreatePackageRequest : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractCreatePackageRequest
    {
        public CreatePackageRequest(Guid appGuid) : base(appGuid)
        {
        }
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CreatePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/packages__experimental_/create_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreatePackageRequest
    {


        public AbstractCreatePackageRequest(Guid appGuid)
        {
            this.Type = "bits";

            this.Relationships = new Dictionary<string, dynamic>();
            this.Relationships.Add("app", new { data = new { guid = appGuid } });
        }
        
        /// <summary> 
        /// <para>Package type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
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


        ///// <summary> 
        ///// <para>Data for docker packages.  Can be empty for bits packages.</para>
        ///// </summary>
        //[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //public Dictionary<string, dynamic> Data
        //{
        //    get;
        //    set;
        //}

        ///// <summary> 
        ///// <para>Location of docker image.  Required for docker packages.</para>
        ///// </summary>
        //[JsonProperty("data_image", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic DataImage
        //{
        //    get;
        //    set;
        //}

        ///// <summary> 
        ///// <para>Credentials for private docker image, available fields are user, password, email, login server.</para>
        ///// </summary>
        //[JsonProperty("data_credentials", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic DataCredentials
        //{
        //    get;
        //    set;
        //}

        ///// <summary> 
        ///// <para>Whether or not the backend should cache the image. defaults to false</para>
        ///// </summary>
        //[JsonProperty("data_store_image", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic DataStoreImage
        //{
        //    get;
        //    set;
        //}
    }
}