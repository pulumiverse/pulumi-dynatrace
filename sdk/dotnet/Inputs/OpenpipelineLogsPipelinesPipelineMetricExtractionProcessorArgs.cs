// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to write the occurrences as a metric
        /// </summary>
        [Input("counterMetricExtractionProcessor")]
        public Input<Inputs.OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessorArgs>? CounterMetricExtractionProcessor { get; set; }

        /// <summary>
        /// Processor to extract a value from a field as a metric
        /// </summary>
        [Input("valueMetricExtractionProcessor")]
        public Input<Inputs.OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessorArgs>? ValueMetricExtractionProcessor { get; set; }

        public OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorArgs()
        {
        }
        public static new OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorArgs Empty => new OpenpipelineLogsPipelinesPipelineMetricExtractionProcessorArgs();
    }
}