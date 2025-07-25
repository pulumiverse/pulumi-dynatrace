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

    public sealed class OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs : global::Pulumi.ResourceArgs
    {
        [Input("bizeventExtractionProcessor")]
        public Input<Inputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorArgs>? BizeventExtractionProcessor { get; set; }

        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        [Input("davisEventExtractionProcessor")]
        public Input<Inputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorArgs>? DavisEventExtractionProcessor { get; set; }

        public OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs()
        {
        }
        public static new OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs Empty => new OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorArgs();
    }
}
