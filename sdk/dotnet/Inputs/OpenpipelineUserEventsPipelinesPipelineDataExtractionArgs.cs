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

    public sealed class OpenpipelineUserEventsPipelinesPipelineDataExtractionArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the DataExtractionStage.
        /// Applicable processors are DavisEventExtractionProcessor and BizeventExtractionProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineUserEventsPipelinesPipelineDataExtractionArgs()
        {
        }
        public static new OpenpipelineUserEventsPipelinesPipelineDataExtractionArgs Empty => new OpenpipelineUserEventsPipelinesPipelineDataExtractionArgs();
    }
}
