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
    public sealed class CustomAnomaliesStrategy
    {
        /// <summary>
        /// An auto-adaptive baseline strategy to detect anomalies within metrics that show a regular change over time, as the baseline is also updated automatically. An example is to detect an anomaly in the number of received network packets or within the number of user actions over time
        /// </summary>
        public readonly Outputs.CustomAnomaliesStrategyAuto? Auto;
        /// <summary>
        /// A generic monitoring strategy
        /// </summary>
        public readonly ImmutableArray<Outputs.CustomAnomaliesStrategyGeneric> Generics;
        /// <summary>
        /// A static threshold monitoring strategy to alert on hard limits within a given metric. An example is the violation of a critical memory limit
        /// </summary>
        public readonly Outputs.CustomAnomaliesStrategyStatic? Static;

        [OutputConstructor]
        private CustomAnomaliesStrategy(
            Outputs.CustomAnomaliesStrategyAuto? auto,

            ImmutableArray<Outputs.CustomAnomaliesStrategyGeneric> generics,

            Outputs.CustomAnomaliesStrategyStatic? @static)
        {
            Auto = auto;
            Generics = generics;
            Static = @static;
        }
    }
}