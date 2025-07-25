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

    public sealed class OpenpipelineUserSessionsPipelinesPipelineMetricExtractionArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineUserSessionsPipelinesPipelineMetricExtractionProcessorArgs>? _processors;

        /// <summary>
        /// Data extraction processor to use
        /// </summary>
        public InputList<Inputs.OpenpipelineUserSessionsPipelinesPipelineMetricExtractionProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineUserSessionsPipelinesPipelineMetricExtractionProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineUserSessionsPipelinesPipelineMetricExtractionArgs()
        {
        }
        public static new OpenpipelineUserSessionsPipelinesPipelineMetricExtractionArgs Empty => new OpenpipelineUserSessionsPipelinesPipelineMetricExtractionArgs();
    }
}
