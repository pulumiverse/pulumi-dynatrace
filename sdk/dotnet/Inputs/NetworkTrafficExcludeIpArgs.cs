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

    public sealed class NetworkTrafficExcludeIpArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipAddressForms", required: true)]
        private InputList<Inputs.NetworkTrafficExcludeIpIpAddressFormArgs>? _ipAddressForms;
        public InputList<Inputs.NetworkTrafficExcludeIpIpAddressFormArgs> IpAddressForms
        {
            get => _ipAddressForms ?? (_ipAddressForms = new InputList<Inputs.NetworkTrafficExcludeIpIpAddressFormArgs>());
            set => _ipAddressForms = value;
        }

        public NetworkTrafficExcludeIpArgs()
        {
        }
        public static new NetworkTrafficExcludeIpArgs Empty => new NetworkTrafficExcludeIpArgs();
    }
}
