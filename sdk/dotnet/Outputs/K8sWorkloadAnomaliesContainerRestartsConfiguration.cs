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
    public sealed class K8sWorkloadAnomaliesContainerRestartsConfiguration
    {
        /// <summary>
        /// within the last
        /// </summary>
        public readonly int ObservationPeriodInMinutes;
        /// <summary>
        /// per minute, for any
        /// </summary>
        public readonly int SamplePeriodInMinutes;
        /// <summary>
        /// there is at least
        /// </summary>
        public readonly int Threshold;

        [OutputConstructor]
        private K8sWorkloadAnomaliesContainerRestartsConfiguration(
            int observationPeriodInMinutes,

            int samplePeriodInMinutes,

            int threshold)
        {
            ObservationPeriodInMinutes = observationPeriodInMinutes;
            SamplePeriodInMinutes = samplePeriodInMinutes;
            Threshold = threshold;
        }
    }
}