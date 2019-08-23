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
    public class App : Base
    {
        public App()
        {
            
        }

        public App(string name, Guid spaceGuid)
        {
            this.name = name;

            this.relationships = new Dictionary<string, dynamic>();
            this.relationships.Add("space", new { data = new { guid = spaceGuid } } );

        }

        public Dictionary<string, dynamic> relationships { get; set; }

    }
}