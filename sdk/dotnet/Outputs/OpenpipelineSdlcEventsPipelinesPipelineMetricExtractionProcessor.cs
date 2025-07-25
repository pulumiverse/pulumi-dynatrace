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
    public sealed class OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessor
    {
        /// <summary>
        /// Processor to write the occurrences as a metric
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessor? CounterMetricExtractionProcessor;
        /// <summary>
        /// Processor to extract a value from a field as a metric
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessor? ValueMetricExtractionProcessor;

        [OutputConstructor]
        private OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessor(
            Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessorCounterMetricExtractionProcessor? counterMetricExtractionProcessor,

            Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtractionProcessorValueMetricExtractionProcessor? valueMetricExtractionProcessor)
        {
            CounterMetricExtractionProcessor = counterMetricExtractionProcessor;
            ValueMetricExtractionProcessor = valueMetricExtractionProcessor;
        }
    }
}
