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

    public sealed class OpenpipelineMetricsPipelinesPipelineSecurityContextGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineMetricsPipelinesPipelineSecurityContextProcessorGetArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for the SecurityContextStage.
        /// Applicable processor is SecurityContextProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineMetricsPipelinesPipelineSecurityContextProcessorGetArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineMetricsPipelinesPipelineSecurityContextProcessorGetArgs>());
            set => _processors = value;
        }

        public OpenpipelineMetricsPipelinesPipelineSecurityContextGetArgs()
        {
        }
        public static new OpenpipelineMetricsPipelinesPipelineSecurityContextGetArgs Empty => new OpenpipelineMetricsPipelinesPipelineSecurityContextGetArgs();
    }
}
