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
    public sealed class AwsCredentialsSupportingServicesToMonitorMonitoredMetric
    {
        /// <summary>
        /// a list of metric's dimensions names
        /// </summary>
        public readonly ImmutableArray<string> Dimensions;
        /// <summary>
        /// the name of the metric of the supporting service
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// the statistic (aggregation) to be used for the metric. AVG*MIN*MAX value is 3 statistics at once: AVERAGE, MINIMUM and MAXIMUM
        /// </summary>
        public readonly string? Statistic;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private AwsCredentialsSupportingServicesToMonitorMonitoredMetric(
            ImmutableArray<string> dimensions,

            string? name,

            string? statistic,

            string? unknowns)
        {
            Dimensions = dimensions;
            Name = name;
            Statistic = statistic;
            Unknowns = unknowns;
        }
    }
}
