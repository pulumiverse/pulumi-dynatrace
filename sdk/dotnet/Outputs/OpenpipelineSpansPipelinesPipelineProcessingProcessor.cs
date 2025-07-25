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
    public sealed class OpenpipelineSpansPipelinesPipelineProcessingProcessor
    {
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorDqlProcessor? DqlProcessor;
        /// <summary>
        /// Processor to drop the record either during the processing stage or at the endpoint
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorDropProcessor? DropProcessor;
        /// <summary>
        /// Processor to add fields
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsAddProcessor? FieldsAddProcessor;
        /// <summary>
        /// Processor to remove fields
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsRemoveProcessor? FieldsRemoveProcessor;
        /// <summary>
        /// Processor to rename fields
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsRenameProcessor? FieldsRenameProcessor;
        /// <summary>
        /// Processor to apply a technology processors
        /// </summary>
        public readonly Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorTechnologyProcessor? TechnologyProcessor;

        [OutputConstructor]
        private OpenpipelineSpansPipelinesPipelineProcessingProcessor(
            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorDqlProcessor? dqlProcessor,

            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorDropProcessor? dropProcessor,

            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsAddProcessor? fieldsAddProcessor,

            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsRemoveProcessor? fieldsRemoveProcessor,

            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorFieldsRenameProcessor? fieldsRenameProcessor,

            Outputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorTechnologyProcessor? technologyProcessor)
        {
            DqlProcessor = dqlProcessor;
            DropProcessor = dropProcessor;
            FieldsAddProcessor = fieldsAddProcessor;
            FieldsRemoveProcessor = fieldsRemoveProcessor;
            FieldsRenameProcessor = fieldsRenameProcessor;
            TechnologyProcessor = technologyProcessor;
        }
    }
}
