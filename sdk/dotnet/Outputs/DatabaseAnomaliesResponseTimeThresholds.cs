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
    public sealed class DatabaseAnomaliesResponseTimeThresholds
    {
        /// <summary>
        /// Minimal service load to detect response time degradation. Response time degradation of services with smaller load won't trigger alerts. Possible values are `FIFTEEN_REQUESTS_PER_MINUTE`, `FIVE_REQUESTS_PER_MINUTE`, `ONE_REQUEST_PER_MINUTE` and `TEN_REQUESTS_PER_MINUTE`
        /// </summary>
        public readonly string Load;
        /// <summary>
        /// Response time during any 5-minute period to trigger an alert, in milliseconds
        /// </summary>
        public readonly int Milliseconds;
        /// <summary>
        /// Sensitivity of the threshold.  With `low` sensitivity, high statistical confidence is used. Brief violations (for example, due to a surge in load) won't trigger alerts.  With `high` sensitivity, no statistical confidence is used. Each violation triggers an alert
        /// </summary>
        public readonly string Sensitivity;
        /// <summary>
        /// Response time of the 10% slowest during any 5-minute period to trigger an alert, in milliseconds
        /// </summary>
        public readonly int SlowestMilliseconds;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DatabaseAnomaliesResponseTimeThresholds(
            string load,

            int milliseconds,

            string sensitivity,

            int slowestMilliseconds,

            string? unknowns)
        {
            Load = load;
            Milliseconds = milliseconds;
            Sensitivity = sensitivity;
            SlowestMilliseconds = slowestMilliseconds;
            Unknowns = unknowns;
        }
    }
}