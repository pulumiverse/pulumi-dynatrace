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

    public sealed class HostAnomaliesV2NetworkHighNetworkDetectionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("customThresholds")]
        public Input<Inputs.HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsGetArgs>? CustomThresholds { get; set; }

        /// <summary>
        /// Detection mode for high network utilization
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// Detect high network utilization
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public HostAnomaliesV2NetworkHighNetworkDetectionGetArgs()
        {
        }
        public static new HostAnomaliesV2NetworkHighNetworkDetectionGetArgs Empty => new HostAnomaliesV2NetworkHighNetworkDetectionGetArgs();
    }
}