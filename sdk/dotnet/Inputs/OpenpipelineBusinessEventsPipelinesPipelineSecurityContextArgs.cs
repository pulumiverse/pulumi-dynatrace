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

    public sealed class OpenpipelineBusinessEventsPipelinesPipelineSecurityContextArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the SecurityContextStage.
        /// Applicable processor is SecurityContextProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineBusinessEventsPipelinesPipelineSecurityContextArgs()
        {
        }
        public static new OpenpipelineBusinessEventsPipelinesPipelineSecurityContextArgs Empty => new OpenpipelineBusinessEventsPipelinesPipelineSecurityContextArgs();
    }
}