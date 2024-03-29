

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.SecurityGroupsEndpoint.CreateSecurityGroup()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/security_groups/creating_a_security_group.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateSecurityGroupRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateSecurityGroupRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.SecurityGroupsEndpoint.CreateSecurityGroup()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/250/security_groups/creating_a_security_group.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateSecurityGroupRequest
    {

        /// <summary> 
        /// <para>The name of the security group.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The egress rules for apps that belong to this security group.</para>
        /// <para>A rule consists of a protocol (tcp,icmp,udp,all), destination CIDR or destination range,</para>
        /// <para>port or port range (tcp,udp,all), type (control signal for icmp), code (control signal for icmp),</para>
        /// <para>log (enables logging for the egress rule), description (optional description of the rule). This field is limited to 16MB.</para>
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Rules
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The list of associated spaces.</para>
        /// </summary>
        [JsonProperty("space_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SpaceGuids
        {
            get;
            set;
        }
    }
}