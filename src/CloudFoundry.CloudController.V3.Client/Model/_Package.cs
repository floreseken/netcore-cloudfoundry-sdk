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
            this.type = "bits";

            this.relationships = new Dictionary<string, dynamic>();
            this.relationships.Add("app", new { data = new { guid = appGuid } });
        }

        public string type { get; set; }

        public Dictionary<string, dynamic> data { get; set; }

        public Dictionary<string, dynamic> relationships { get; set; }

    }

}