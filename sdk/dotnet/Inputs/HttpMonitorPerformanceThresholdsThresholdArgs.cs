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

    public sealed class HttpMonitorPerformanceThresholdsThresholdArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Request
        /// </summary>
        [Input("event", required: true)]
        public Input<string> Event { get; set; } = null!;

        /// <summary>
        /// Threshold (in seconds)
        /// </summary>
        [Input("threshold", required: true)]
        public Input<double> Threshold { get; set; } = null!;

        public HttpMonitorPerformanceThresholdsThresholdArgs()
        {
        }
        public static new HttpMonitorPerformanceThresholdsThresholdArgs Empty => new HttpMonitorPerformanceThresholdsThresholdArgs();
    }
}
