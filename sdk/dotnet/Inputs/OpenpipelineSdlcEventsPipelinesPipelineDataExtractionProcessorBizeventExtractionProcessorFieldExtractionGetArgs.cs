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

    public sealed class OpenpipelineSdlcEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtractionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fields", required: true)]
        private InputList<string>? _fields;
        public InputList<string> Fields
        {
            get => _fields ?? (_fields = new InputList<string>());
            set => _fields = value;
        }

        [Input("semantic", required: true)]
        public Input<string> Semantic { get; set; } = null!;

        public OpenpipelineSdlcEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtractionGetArgs()
        {
        }
        public static new OpenpipelineSdlcEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtractionGetArgs Empty => new OpenpipelineSdlcEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorFieldExtractionGetArgs();
    }
}
