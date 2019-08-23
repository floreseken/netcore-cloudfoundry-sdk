using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{

    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppRoutesExperimentalEndpoint.ListRoutes()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/app_routes__experimental_/list_routes.html"</para>
    /// </summary>
    public class Build : Base
    {

        public Build()
        {
        }

        public Build(Guid packageGuid)
        {
            this.package = new Package();
            this.package.guid = packageGuid;
        }

        public string error { get; set; }

        public Package package { get; set; }

        public Droplet droplet { get; set; }
    }



}