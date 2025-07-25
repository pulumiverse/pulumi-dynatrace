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

    public sealed class OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to write the occurrences as a metric
        /// </summary>
        [Input("counterMetricExtractionProcessor")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessorArgs>? CounterMetricExtractionProcessor { get; set; }

        /// <summary>
        /// Processor to extract a value from a field as a metric
        /// </summary>
        [Input("valueMetricExtractionProcessor")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessorArgs>? ValueMetricExtractionProcessor { get; set; }

        public OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorArgs()
        {
        }
        public static new OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorArgs Empty => new OpenpipelineSystemEventsPipelinesPipelineMetricExtractionProcessorArgs();
    }
}
