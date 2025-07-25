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
    public sealed class OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessor
    {
        /// <summary>
        /// Processor to write the occurrences as a metric
        /// </summary>
        public readonly Outputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessor? CounterMetricExtractionProcessor;
        /// <summary>
        /// Processor to extract a value from a field as a metric
        /// </summary>
        public readonly Outputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessor? ValueMetricExtractionProcessor;

        [OutputConstructor]
        private OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessor(
            Outputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessor? counterMetricExtractionProcessor,

            Outputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessor? valueMetricExtractionProcessor)
        {
            CounterMetricExtractionProcessor = counterMetricExtractionProcessor;
            ValueMetricExtractionProcessor = valueMetricExtractionProcessor;
        }
    }
}
