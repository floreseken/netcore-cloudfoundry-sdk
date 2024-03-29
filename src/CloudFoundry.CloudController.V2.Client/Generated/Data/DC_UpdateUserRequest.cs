

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.UpdateUser()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/updating_a_user.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateUserRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateUserRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.UsersEndpoint.UpdateUser()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/users/updating_a_user.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateUserRequest
    {

        /// <summary> 
        /// <para>The guid of the default space for apps created by this user.</para>
        /// </summary>
        [JsonProperty("default_space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultSpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Whether the user is an admin (Use UAA instead).</para>
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Admin
        {
            get;
            set;
        }
    }
}