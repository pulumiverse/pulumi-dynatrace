// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class HostAnomaliesV2NetworkNetworkDroppedPacketsDetectionCustomThresholds
    {
        /// <summary>
        /// Receive/transmit dropped packet percentage threshold
        /// </summary>
        public readonly int DroppedPacketsPercentage;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2NetworkNetworkDroppedPacketsDetectionCustomThresholdsEventThresholds EventThresholds;
        /// <summary>
        /// Total packets rate threshold
        /// </summary>
        public readonly int TotalPacketsRate;

        [OutputConstructor]
        private HostAnomaliesV2NetworkNetworkDroppedPacketsDetectionCustomThresholds(
            int droppedPacketsPercentage,

            Outputs.HostAnomaliesV2NetworkNetworkDroppedPacketsDetectionCustomThresholdsEventThresholds eventThresholds,

            int totalPacketsRate)
        {
            DroppedPacketsPercentage = droppedPacketsPercentage;
            EventThresholds = eventThresholds;
            TotalPacketsRate = totalPacketsRate;
        }
    }
}