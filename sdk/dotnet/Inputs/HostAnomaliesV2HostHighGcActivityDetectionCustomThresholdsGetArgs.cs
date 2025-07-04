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

    public sealed class HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("eventThresholds", required: true)]
        public Input<Inputs.HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsEventThresholdsGetArgs> EventThresholds { get; set; } = null!;

        /// <summary>
        /// Alert if the GC suspension is higher than this threshold
        /// </summary>
        [Input("gcSuspensionPercentage", required: true)]
        public Input<int> GcSuspensionPercentage { get; set; } = null!;

        /// <summary>
        /// Alert if GC time is higher than this threshold
        /// </summary>
        [Input("gcTimePercentage", required: true)]
        public Input<int> GcTimePercentage { get; set; } = null!;

        public HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsGetArgs()
        {
        }
        public static new HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsGetArgs Empty => new HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsGetArgs();
    }
}
