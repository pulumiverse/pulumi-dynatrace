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
    public sealed class HostAnomaliesV2HostHighCpuSaturationDetection
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2HostHighCpuSaturationDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for CPU saturation
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect CPU saturation on host
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private HostAnomaliesV2HostHighCpuSaturationDetection(
            Outputs.HostAnomaliesV2HostHighCpuSaturationDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}