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

    public sealed class OpenpipelineDavisEventsPipelinesPipelineProcessingArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineDavisEventsPipelinesPipelineProcessingProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the ProcessingStage.
        /// Applicable processors are DqlProcessor, FieldsAddProcessor, FieldsRemoveProcessor, FieldsRenameProcessor, TechnologyProcessor and DropProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineDavisEventsPipelinesPipelineProcessingProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineDavisEventsPipelinesPipelineProcessingProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineDavisEventsPipelinesPipelineProcessingArgs()
        {
        }
        public static new OpenpipelineDavisEventsPipelinesPipelineProcessingArgs Empty => new OpenpipelineDavisEventsPipelinesPipelineProcessingArgs();
    }
}
