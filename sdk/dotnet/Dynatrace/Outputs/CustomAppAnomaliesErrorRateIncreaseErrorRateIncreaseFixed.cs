// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixed
    {
        public readonly string Sensitivity;
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