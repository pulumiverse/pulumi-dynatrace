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
    public sealed class K8sPvcAnomaliesLowDiskSpaceCriticalConfiguration
    {
        /// <summary>
        /// within the last
        /// </summary>
        public readonly int ObservationPeriodInMinutes;
        /// <summary>
        /// for at least
        /// </summary>
        public readonly int SamplePeriodInMinutes;
        /// <summary>
        /// the available disk space is below
        /// </summary>
        public readonly int Threshold;

        [OutputConstructor]
        private K8sPvcAnomaliesLowDiskSpaceCriticalConfiguration(
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
