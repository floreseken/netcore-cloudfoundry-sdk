using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{

    public class Base
    {
        public Guid? guid { get; set; }

        public string name { get; set; }

        public string created_at { get; set; }

        public User created_by { get; set; }

        public string updated_at { get; set; }

        public string state { get; set; }

        public Metadata metadata { get; set; }

        public Dictionary<string, dynamic> links { get; set; }

        public Dictionary<string, dynamic> lifecycle { get; set; }
    }
}