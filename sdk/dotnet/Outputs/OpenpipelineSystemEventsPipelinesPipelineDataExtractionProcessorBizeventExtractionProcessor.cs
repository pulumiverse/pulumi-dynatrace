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
    public sealed class OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor
    {
        /// <summary>
        /// Name or description of the processor
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Strategy to assign a value
        /// </summary>
        public readonly Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventProvider EventProvider;
        /// <summary>
        /// Strategy to assign a value
        /// </summary>
        public readonly Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventType EventType;
        /// <summary>
        /// Definition of the field extraction
        /// </summary>
        public readonly Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtraction? FieldExtraction;
        /// <summary>
        /// Identifier of the processor. Must be unique within a stage.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Matching condition to apply on incoming records
        /// </summary>
        public readonly string Matcher;
        /// <summary>
        /// Sample data related to the processor for documentation or testing
        /// </summary>
        public readonly string? SampleData;

        [OutputConstructor]
        private OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor(
            string description,

            bool enabled,

            Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventProvider eventProvider,

            Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventType eventType,

            Outputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtraction? fieldExtraction,

            string id,

            string matcher,

            string? sampleData)
        {
            Description = description;
            Enabled = enabled;
            EventProvider = eventProvider;
            EventType = eventType;
            FieldExtraction = fieldExtraction;
            Id = id;
            Matcher = matcher;
            SampleData = sampleData;
        }
    }
}
