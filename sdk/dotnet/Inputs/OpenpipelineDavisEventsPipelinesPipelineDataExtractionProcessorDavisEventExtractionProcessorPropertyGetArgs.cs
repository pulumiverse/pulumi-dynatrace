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

    public sealed class OpenpipelineDavisEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorPropertyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key to set on the davis event
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The value assigned to the key
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public OpenpipelineDavisEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorPropertyGetArgs()
        {
        }
        public static new OpenpipelineDavisEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorPropertyGetArgs Empty => new OpenpipelineDavisEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorPropertyGetArgs();
    }
}
