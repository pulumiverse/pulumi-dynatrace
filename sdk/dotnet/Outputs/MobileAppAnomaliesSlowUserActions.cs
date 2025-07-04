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
    public sealed class MobileAppAnomaliesSlowUserActions
    {
        /// <summary>
        /// Possible Values: `Auto`, `Fixed`
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsAuto? SlowUserActionsAuto;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsFixed? SlowUserActionsFixed;

        [OutputConstructor]
        private MobileAppAnomaliesSlowUserActions(
            string? detectionMode,

            bool enabled,

            Outputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsAuto? slowUserActionsAuto,

            Outputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsFixed? slowUserActionsFixed)
        {
            DetectionMode = detectionMode;
            Enabled = enabled;
            SlowUserActionsAuto = slowUserActionsAuto;
            SlowUserActionsFixed = slowUserActionsFixed;
        }
    }
}
