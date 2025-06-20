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

    public sealed class SloErrorBudgetBurnRateGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The error budget burn rate calculation is enabled (true) or disabled (false).
        /// </summary>
        [Input("burnRateVisualizationEnabled")]
        public Input<bool>? BurnRateVisualizationEnabled { get; set; }

        /// <summary>
        /// The threshold between a slow and a fast burn rate.
        /// </summary>
        [Input("fastBurnThreshold")]
        public Input<double>? FastBurnThreshold { get; set; }

        public SloErrorBudgetBurnRateGetArgs()
        {
        }
        public static new SloErrorBudgetBurnRateGetArgs Empty => new SloErrorBudgetBurnRateGetArgs();
    }
}
