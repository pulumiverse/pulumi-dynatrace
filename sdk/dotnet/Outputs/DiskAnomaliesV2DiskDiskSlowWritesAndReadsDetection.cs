// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class DiskAnomaliesV2DiskDiskSlowWritesAndReadsDetection
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.DiskAnomaliesV2DiskDiskSlowWritesAndReadsDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for slow running disks
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect slow-running disks
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private DiskAnomaliesV2DiskDiskSlowWritesAndReadsDetection(
            Outputs.DiskAnomaliesV2DiskDiskSlowWritesAndReadsDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}
