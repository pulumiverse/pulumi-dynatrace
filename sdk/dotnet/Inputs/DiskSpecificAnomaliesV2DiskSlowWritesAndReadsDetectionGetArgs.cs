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

    public sealed class DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("customThresholds")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionCustomThresholdsGetArgs>? CustomThresholds { get; set; }

        /// <summary>
        /// Detection mode for slow running disks
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// Detect slow-running disks
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionGetArgs()
        {
        }
        public static new DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionGetArgs Empty => new DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionGetArgs();
    }
}
