// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class NetworkTrafficExcludeIpIpAddressFormArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// IP address
        /// </summary>
        [Input("ipAddress", required: true)]
        public Input<string> IpAddress { get; set; } = null!;

        public NetworkTrafficExcludeIpIpAddressFormArgs()
        {
        }
        public static new NetworkTrafficExcludeIpIpAddressFormArgs Empty => new NetworkTrafficExcludeIpIpAddressFormArgs();
    }
}
