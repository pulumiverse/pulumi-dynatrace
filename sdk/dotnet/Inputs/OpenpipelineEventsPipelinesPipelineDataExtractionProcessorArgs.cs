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

    public sealed class OpenpipelineEventsPipelinesPipelineDataExtractionProcessorArgs : global::Pulumi.ResourceArgs
    {
        [Input("bizeventExtractionProcessor")]
        public Input<Inputs.OpenpipelineEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorArgs>? BizeventExtractionProcessor { get; set; }

        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        [Input("davisEventExtractionProcessor")]
        public Input<Inputs.OpenpipelineEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorArgs>? DavisEventExtractionProcessor { get; set; }

        public OpenpipelineEventsPipelinesPipelineDataExtractionProcessorArgs()
        {
        }
        public static new OpenpipelineEventsPipelinesPipelineDataExtractionProcessorArgs Empty => new OpenpipelineEventsPipelinesPipelineDataExtractionProcessorArgs();
    }
}