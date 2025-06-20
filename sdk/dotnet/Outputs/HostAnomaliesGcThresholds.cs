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
    public sealed class HostAnomaliesGcThresholds
    {
        /// <summary>
        /// GC suspension is higher than *X*% in 3 out of 5 samples
        /// </summary>
        public readonly int SuspensionPercentage;
        /// <summary>
        /// GC time is higher than *X*% in 3 out of 5 samples
        /// </summary>
        public readonly int TimePercentage;

        [OutputConstructor]
        private HostAnomaliesGcThresholds(
            int suspensionPercentage,

            int timePercentage)
        {
            SuspensionPercentage = suspensionPercentage;
            TimePercentage = timePercentage;
        }
    }
}
