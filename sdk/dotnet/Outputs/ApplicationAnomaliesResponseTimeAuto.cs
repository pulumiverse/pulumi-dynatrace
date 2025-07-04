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
    public sealed class ApplicationAnomaliesResponseTimeAuto
    {
        /// <summary>
        /// Minimal service load to detect response time degradation. Response time degradation of services with smaller load won't trigger alerts. Possible values are `FIFTEEN_REQUESTS_PER_MINUTE`, `FIVE_REQUESTS_PER_MINUTE`, `ONE_REQUEST_PER_MINUTE` and `TEN_REQUESTS_PER_MINUTE`
        /// </summary>
        public readonly string Load;
        /// <summary>
        /// Alert if the response time degrades by more than *X* milliseconds
        /// </summary>
        public readonly int Milliseconds;
        /// <summary>
        /// Alert if the response time degrades by more than *X* %
        /// </summary>
        public readonly int Percent;
        /// <summary>
        /// Alert if the response time of the slowest 10% degrades by more than *X* milliseconds
        /// </summary>
        public readonly int SlowestMilliseconds;
        /// <summary>
        /// Alert if the response time of the slowest 10% degrades by more than *X* milliseconds
        /// </summary>
        public readonly int SlowestPercent;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private ApplicationAnomaliesResponseTimeAuto(
            string load,

            int milliseconds,

            int percent,

            int slowestMilliseconds,

            int slowestPercent,

            string? unknowns)
        {
            Load = load;
            Milliseconds = milliseconds;
            Percent = percent;
            SlowestMilliseconds = slowestMilliseconds;
            SlowestPercent = slowestPercent;
            Unknowns = unknowns;
        }
    }
}
