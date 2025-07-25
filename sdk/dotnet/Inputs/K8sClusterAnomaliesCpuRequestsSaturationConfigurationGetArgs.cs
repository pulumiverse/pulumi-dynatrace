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

    public sealed class K8sClusterAnomaliesCpuRequestsSaturationConfigurationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// within the last
        /// </summary>
        [Input("observationPeriodInMinutes", required: true)]
        public Input<int> ObservationPeriodInMinutes { get; set; } = null!;

        /// <summary>
        /// of cluster CPU capacity for at least
        /// </summary>
        [Input("samplePeriodInMinutes", required: true)]
        public Input<int> SamplePeriodInMinutes { get; set; } = null!;

        /// <summary>
        /// amount of requested CPU is above
        /// </summary>
        [Input("threshold", required: true)]
        public Input<int> Threshold { get; set; } = null!;

        public K8sClusterAnomaliesCpuRequestsSaturationConfigurationGetArgs()
        {
        }
        public static new K8sClusterAnomaliesCpuRequestsSaturationConfigurationGetArgs Empty => new K8sClusterAnomaliesCpuRequestsSaturationConfigurationGetArgs();
    }
}
