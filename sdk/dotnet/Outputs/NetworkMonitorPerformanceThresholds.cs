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
    public sealed class NetworkMonitorPerformanceThresholds
    {
        /// <summary>
        /// Performance threshold is enabled (true) or disabled (false)
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The list of performance threshold rules
        /// </summary>
        public readonly Outputs.NetworkMonitorPerformanceThresholdsThresholds? Thresholds;

        [OutputConstructor]
        private NetworkMonitorPerformanceThresholds(
            bool? enabled,

            Outputs.NetworkMonitorPerformanceThresholdsThresholds? thresholds)
        {
            Enabled = enabled;
            Thresholds = thresholds;
        }
    }
}
