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
    public sealed class CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixed
    {
        /// <summary>
        /// Possible Values: `Low`, `Medium`, `High`
        /// </summary>
        public readonly string Sensitivity;
        /// <summary>
        /// Absolute threshold
        /// </summary>
        public readonly double ThresholdAbsolute;

        [OutputConstructor]
        private CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixed(
            string sensitivity,

            double thresholdAbsolute)
        {
            Sensitivity = sensitivity;
            ThresholdAbsolute = thresholdAbsolute;
        }
    }
}
