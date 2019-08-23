using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;


namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.BuildsExperimentalEndpoint.CreateBuild()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/Builds__experimental_/create_a_Build.html"</para>
    /// </summary>
    public class CreateBuildRequest
    {


        public CreateBuildRequest(Guid packageGuid)
        {

            this.Package = new Package();
            this.Package.PackGuid = packageGuid;
        }
        
        /// <summary> 
        /// <para>Build type</para>
        /// </summary>
        [JsonProperty("package", NullValueHandling = NullValueHandling.Ignore)]
        public Package Package
        {
            get;
            set;
        }

    }

    public class Package
    {
        /// <summary> 
        /// <para>Guid for a particular space</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid PackGuid
        {
            get;
            set;
        }

    }
}