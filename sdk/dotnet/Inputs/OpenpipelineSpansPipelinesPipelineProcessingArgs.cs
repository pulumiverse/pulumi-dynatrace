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

    public sealed class OpenpipelineSpansPipelinesPipelineProcessingArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the ProcessingStage.
        /// Applicable processors are DqlProcessor, FieldsAddProcessor, FieldsRemoveProcessor, FieldsRenameProcessor, TechnologyProcessor and DropProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineSpansPipelinesPipelineProcessingProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineSpansPipelinesPipelineProcessingArgs()
        {
        }
        public static new OpenpipelineSpansPipelinesPipelineProcessingArgs Empty => new OpenpipelineSpansPipelinesPipelineProcessingArgs();
    }
}
