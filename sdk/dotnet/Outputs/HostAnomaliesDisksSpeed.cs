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
    public sealed class HostAnomaliesDisksSpeed
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Custom thresholds for slow running disks. If not set, the automatic mode is used
        /// </summary>
        public readonly Outputs.HostAnomaliesDisksSpeedThresholds? Thresholds;

        [OutputConstructor]
        private HostAnomaliesDisksSpeed(
            bool enabled,

            Outputs.HostAnomaliesDisksSpeedThresholds? thresholds)
        {
            Enabled = enabled;
            Thresholds = thresholds;
        }
    }
}
