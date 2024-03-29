

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.SetIsolationSegmentForSpaceExperimental()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/set_the_isolation_segment_for_a_space_(experimental).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SetIsolationSegmentForSpaceExperimentalRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractSetIsolationSegmentForSpaceExperimentalRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SpacesEndpoint.SetIsolationSegmentForSpaceExperimental()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/spaces/set_the_isolation_segment_for_a_space_(experimental).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSetIsolationSegmentForSpaceExperimentalRequest
    {

        /// <summary> 
        /// <para>The Isolation Segment Guid</para>
        /// </summary>
        [JsonProperty("isolation_segment_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IsolationSegmentGuid
        {
            get;
            set;
        }
    }
}