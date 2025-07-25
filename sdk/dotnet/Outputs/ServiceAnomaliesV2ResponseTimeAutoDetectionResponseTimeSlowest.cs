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
    public sealed class ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowest
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        public readonly double SlowestDegradationMilliseconds;
        /// <summary>
        /// Relative threshold
        /// </summary>
        public readonly double SlowestDegradationPercent;

        [OutputConstructor]
        private ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowest(
            double slowestDegradationMilliseconds,

            double slowestDegradationPercent)
        {
            SlowestDegradationMilliseconds = slowestDegradationMilliseconds;
            SlowestDegradationPercent = slowestDegradationPercent;
        }
    }
}
