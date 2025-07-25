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

    public sealed class HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdArgs : global::Pulumi.ResourceArgs
    {
        [Input("thresholds", required: true)]
        private InputList<Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdArgs>? _thresholds;

        /// <summary>
        /// The list of performance threshold rules
        /// </summary>
        public InputList<Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdArgs> Thresholds
        {
            get => _thresholds ?? (_thresholds = new InputList<Inputs.HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdArgs>());
            set => _thresholds = value;
        }

        public HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdArgs()
        {
        }
        public static new HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdArgs Empty => new HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdArgs();
    }
}
