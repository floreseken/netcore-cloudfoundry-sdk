using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{

    public class Metadata
    {
        public Dictionary<string, dynamic> labels { get; set; }

        public Dictionary<string, dynamic> annotations { get; set; }
    }
}