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

    public sealed class OpenpipelineSdlcEventsPipelinesPipelineProcessingArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineProcessingProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the ProcessingStage.
        /// Applicable processors are DqlProcessor, FieldsAddProcessor, FieldsRemoveProcessor, FieldsRenameProcessor, TechnologyProcessor and DropProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineProcessingProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineProcessingProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineSdlcEventsPipelinesPipelineProcessingArgs()
        {
        }
        public static new OpenpipelineSdlcEventsPipelinesPipelineProcessingArgs Empty => new OpenpipelineSdlcEventsPipelinesPipelineProcessingArgs();
    }
}