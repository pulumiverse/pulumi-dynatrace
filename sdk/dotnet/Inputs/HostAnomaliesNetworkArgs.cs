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

    public sealed class HostAnomaliesNetworkArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of TCP connectivity problems detection
        /// </summary>
        [Input("connectivity")]
        public Input<Inputs.HostAnomaliesNetworkConnectivityArgs>? Connectivity { get; set; }

        /// <summary>
        /// Configuration of high number of dropped packets detection
        /// </summary>
        [Input("droppedPackets")]
        public Input<Inputs.HostAnomaliesNetworkDroppedPacketsArgs>? DroppedPackets { get; set; }

        /// <summary>
        /// Configuration of high number of network errors detection
        /// </summary>
        [Input("errors")]
        public Input<Inputs.HostAnomaliesNetworkErrorsArgs>? Errors { get; set; }

        /// <summary>
        /// Configuration of high retransmission rate detection
        /// </summary>
        [Input("retransmission")]
        public Input<Inputs.HostAnomaliesNetworkRetransmissionArgs>? Retransmission { get; set; }

        /// <summary>
        /// Configuration of high network utilization detection
        /// </summary>
        [Input("utilization")]
        public Input<Inputs.HostAnomaliesNetworkUtilizationArgs>? Utilization { get; set; }

        public HostAnomaliesNetworkArgs()
        {
        }
        public static new HostAnomaliesNetworkArgs Empty => new HostAnomaliesNetworkArgs();
    }
}
