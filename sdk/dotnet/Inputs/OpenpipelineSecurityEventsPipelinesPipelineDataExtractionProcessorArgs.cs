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

    public sealed class OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorArgs : global::Pulumi.ResourceArgs
    {
        [Input("bizeventExtractionProcessor")]
        public Input<Inputs.OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessorArgs>? BizeventExtractionProcessor { get; set; }

        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        [Input("davisEventExtractionProcessor")]
        public Input<Inputs.OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessorArgs>? DavisEventExtractionProcessor { get; set; }

        public OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorArgs()
        {
        }
        public static new OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorArgs Empty => new OpenpipelineSecurityEventsPipelinesPipelineDataExtractionProcessorArgs();
    }
}