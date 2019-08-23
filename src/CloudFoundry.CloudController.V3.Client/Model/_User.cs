using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{

    public class User
    {
        public string name { get; set; }

        public string email { get; set; }

        public Guid guid { get; set; }
    }


}