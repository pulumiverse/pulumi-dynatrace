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
    public sealed class WebAppAnomaliesResponseTimeResponseTimeFixed
    {
        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedOverAlertingProtection OverAlertingProtection;
        /// <summary>
        /// Alert if the key performance metric of all requests degrades beyond this threshold:
        /// </summary>
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeAll ResponseTimeAll;
        /// <summary>
        /// Alert if the key performance metric of the slowest 10% of requests degrades beyond this threshold:
        /// </summary>
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeSlowest ResponseTimeSlowest;
        /// <summary>
        /// Possible Values: `Medium`, `High`, `Low`
        /// </summary>
        public readonly string Sensitivity;

        [OutputConstructor]
        private WebAppAnomaliesResponseTimeResponseTimeFixed(
            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedOverAlertingProtection overAlertingProtection,

            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeAll responseTimeAll,

            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeSlowest responseTimeSlowest,

            string sensitivity)
        {
            OverAlertingProtection = overAlertingProtection;
            ResponseTimeAll = responseTimeAll;
            ResponseTimeSlowest = responseTimeSlowest;
            Sensitivity = sensitivity;
        }
    }
}
