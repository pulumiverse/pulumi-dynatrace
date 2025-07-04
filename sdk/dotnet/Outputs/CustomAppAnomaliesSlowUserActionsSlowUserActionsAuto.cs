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
    public sealed class CustomAppAnomaliesSlowUserActionsSlowUserActionsAuto
    {
        /// <summary>
        /// To avoid over-alerting do not alert for low traffic applications with less than
        /// </summary>
        public readonly Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralerting DurationAvoidOveralerting;
        /// <summary>
        /// Alert if the action duration of all user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        public readonly Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdAll DurationThresholdAll;
        /// <summary>
        /// Alert if the action duration of the slowest 10% of user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        public readonly Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowest DurationThresholdSlowest;

        [OutputConstructor]
        private CustomAppAnomaliesSlowUserActionsSlowUserActionsAuto(
            Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralerting durationAvoidOveralerting,

            Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdAll durationThresholdAll,

            Outputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowest durationThresholdSlowest)
        {
            DurationAvoidOveralerting = durationAvoidOveralerting;
            DurationThresholdAll = durationThresholdAll;
            DurationThresholdSlowest = durationThresholdSlowest;
        }
    }
}
