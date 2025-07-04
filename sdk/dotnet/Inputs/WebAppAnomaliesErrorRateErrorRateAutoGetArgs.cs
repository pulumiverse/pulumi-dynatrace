// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class WebAppAnomaliesErrorRateErrorRateAutoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("absoluteIncrease", required: true)]
        public Input<double> AbsoluteIncrease { get; set; } = null!;

        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        [Input("overAlertingProtection", required: true)]
        public Input<Inputs.WebAppAnomaliesErrorRateErrorRateAutoOverAlertingProtectionGetArgs> OverAlertingProtection { get; set; } = null!;

        /// <summary>
        /// Relative threshold
        /// </summary>
        [Input("relativeIncrease", required: true)]
        public Input<double> RelativeIncrease { get; set; } = null!;

        public WebAppAnomaliesErrorRateErrorRateAutoGetArgs()
        {
        }
        public static new WebAppAnomaliesErrorRateErrorRateAutoGetArgs Empty => new WebAppAnomaliesErrorRateErrorRateAutoGetArgs();
    }
}
