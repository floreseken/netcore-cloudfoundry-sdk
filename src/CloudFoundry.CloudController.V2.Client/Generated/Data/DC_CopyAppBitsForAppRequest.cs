

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.CopyAppBitsForApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/copy_the_app_bits_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CopyAppBitsForAppRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCopyAppBitsForAppRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.CopyAppBitsForApp()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/apps/copy_the_app_bits_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCopyAppBitsForAppRequest
    {

        /// <summary> 
        /// <para>The guid for the source app</para>
        /// </summary>
        [JsonProperty("source_app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SourceAppGuid
        {
            get;
            set;
        }
    }
}