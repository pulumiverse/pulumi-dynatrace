// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class HostAnomaliesV2NetworkNetworkHighRetransmissionDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("eventThresholds", required: true)]
        public Input<Inputs.HostAnomaliesV2NetworkNetworkHighRetransmissionDetectionCustomThresholdsEventThresholdsArgs> EventThresholds { get; set; } = null!;

        /// <summary>
        /// Retransmission rate threshold
        /// </summary>
        [Input("retransmissionRatePercentage", required: true)]
        public Input<int> RetransmissionRatePercentage { get; set; } = null!;

        /// <summary>
        /// Number of retransmitted packets threshold
        /// </summary>
        [Input("retransmittedPacketsNumberPerMinute", required: true)]
        public Input<int> RetransmittedPacketsNumberPerMinute { get; set; } = null!;

        public HostAnomaliesV2NetworkNetworkHighRetransmissionDetectionCustomThresholdsArgs()
        {
        }
        public static new HostAnomaliesV2NetworkNetworkHighRetransmissionDetectionCustomThresholdsArgs Empty => new HostAnomaliesV2NetworkNetworkHighRetransmissionDetectionCustomThresholdsArgs();
    }
}