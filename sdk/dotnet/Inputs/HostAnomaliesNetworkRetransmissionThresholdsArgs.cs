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

    public sealed class HostAnomaliesNetworkRetransmissionThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Retransmission rate is higher than *X*% in 3 out of 5 samples
        /// </summary>
        [Input("retransmissionRate", required: true)]
        public Input<int> RetransmissionRate { get; set; } = null!;

        /// <summary>
        /// Number of retransmitted packets is higher than *X* packets per minute in 3 out of 5 samples
        /// </summary>
        [Input("retransmittedPackets", required: true)]
        public Input<int> RetransmittedPackets { get; set; } = null!;

        public HostAnomaliesNetworkRetransmissionThresholdsArgs()
        {
        }
        public static new HostAnomaliesNetworkRetransmissionThresholdsArgs Empty => new HostAnomaliesNetworkRetransmissionThresholdsArgs();
    }
}
