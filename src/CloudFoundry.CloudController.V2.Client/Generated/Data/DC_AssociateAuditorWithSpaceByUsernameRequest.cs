

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.AssociateAuditorWithSpaceByUsername()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/associate_auditor_with_the_space_by_username.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AssociateAuditorWithSpaceByUsernameRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractAssociateAuditorWithSpaceByUsernameRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.AssociateAuditorWithSpaceByUsername()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/associate_auditor_with_the_space_by_username.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAssociateAuditorWithSpaceByUsernameRequest
    {

        /// <summary> 
        /// <para>The user's name</para>
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username
        {
            get;
            set;
        }
    }
}