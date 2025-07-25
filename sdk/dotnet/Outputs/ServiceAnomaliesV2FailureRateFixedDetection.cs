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
    public sealed class ServiceAnomaliesV2FailureRateFixedDetection
    {
        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        public readonly Outputs.ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection OverAlertingProtection;
        /// <summary>
        /// Possible Values: `High`, `Low`, `Medium`
        /// </summary>
        public readonly string Sensitivity;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly double Threshold;

        [OutputConstructor]
        private ServiceAnomaliesV2FailureRateFixedDetection(
            Outputs.ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection overAlertingProtection,

            string sensitivity,

            double threshold)
        {
            OverAlertingProtection = overAlertingProtection;
            Sensitivity = sensitivity;
            Threshold = threshold;
        }
    }
}
