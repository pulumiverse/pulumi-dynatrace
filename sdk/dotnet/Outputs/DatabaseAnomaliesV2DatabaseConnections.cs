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
    public sealed class DatabaseAnomaliesV2DatabaseConnections
    {
        /// <summary>
        /// Detect failed database connects
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Threshold
        /// </summary>
        public readonly int? MaxFailedConnects;
        /// <summary>
        /// Time span
        /// </summary>
        public readonly int? TimePeriod;

        [OutputConstructor]
        private DatabaseAnomaliesV2DatabaseConnections(
            bool enabled,

            int? maxFailedConnects,

            int? timePeriod)
        {
            Enabled = enabled;
            MaxFailedConnects = maxFailedConnects;
            TimePeriod = timePeriod;
        }
    }
}
