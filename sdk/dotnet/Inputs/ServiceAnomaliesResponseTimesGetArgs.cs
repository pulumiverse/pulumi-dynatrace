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

    public sealed class ServiceAnomaliesResponseTimesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Parameters of the response time degradation auto-detection. Violation of **any** criterion triggers an alert
        /// </summary>
        [Input("auto")]
        public Input<Inputs.ServiceAnomaliesResponseTimesAutoGetArgs>? Auto { get; set; }

        /// <summary>
        /// Fixed thresholds for response time degradation detection
        /// </summary>
        [Input("thresholds")]
        public Input<Inputs.ServiceAnomaliesResponseTimesThresholdsGetArgs>? Thresholds { get; set; }

        public ServiceAnomaliesResponseTimesGetArgs()
        {
        }
        public static new ServiceAnomaliesResponseTimesGetArgs Empty => new ServiceAnomaliesResponseTimesGetArgs();
    }
}
