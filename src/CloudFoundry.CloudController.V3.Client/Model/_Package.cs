using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{


    public class Package : Base
    {

        public Package()
        {
            
        }

        public Package(Guid appGuid)
        {
            this.Type = "bits";

            this.relationships = new Dictionary<string, dynamic>();
            this.relationships.Add("app", new { data = new { guid = appGuid } });
        }

        public string Type { get; set; }

        public Dictionary<string, dynamic> Data { get; set; }

        public Dictionary<string, dynamic> relationships { get; set; }

    }

}