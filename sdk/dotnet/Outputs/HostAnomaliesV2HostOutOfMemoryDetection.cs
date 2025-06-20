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
    public sealed class HostAnomaliesV2HostOutOfMemoryDetection
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2HostOutOfMemoryDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for Java out of memory problem
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect Java out of memory problem
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private HostAnomaliesV2HostOutOfMemoryDetection(
            Outputs.HostAnomaliesV2HostOutOfMemoryDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}
