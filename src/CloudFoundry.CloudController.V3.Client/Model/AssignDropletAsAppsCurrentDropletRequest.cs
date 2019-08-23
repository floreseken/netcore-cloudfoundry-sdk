using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Model
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.AssignDropletAsAppsCurrentDroplet()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/238/apps__experimental_/assigning_a_droplet_as_an_app's_current_droplet.html"</para>
    /// </summary>
    public class AssignDropletAsAppsCurrentDropletRequest
    {

        public AssignDropletAsAppsCurrentDropletRequest(Guid dropletGuid)
        {
            this.Data = new DropletGuid() { Guid = dropletGuid};
        }

        //{ "data": { "guid": "[droplet_guid]" } }

        /// <summary> 
        /// <para>GUID of the Staged Droplet to be used for the App</para>
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DropletGuid Data
        {
            get;
            set;
        }
    }

    public class DropletGuid
    {
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid Guid { get; set; }

    }
}