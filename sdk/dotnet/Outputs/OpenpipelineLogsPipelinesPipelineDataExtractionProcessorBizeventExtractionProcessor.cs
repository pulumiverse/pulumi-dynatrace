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
    public sealed class OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor
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
        public readonly Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventProvider EventProvider;
        /// <summary>
        /// Strategy to assign a value
        /// </summary>
        public readonly Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventType EventType;
        public readonly Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtraction? FieldExtraction;
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
        private OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor(
            string description,

            bool enabled,

            Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventProvider eventProvider,

            Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorEventType eventType,

            Outputs.OpenpipelineLogsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtraction? fieldExtraction,

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