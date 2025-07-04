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

    public sealed class OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorArgs>? _processors;

        /// <summary>
        /// Data extraction processor to use
        /// </summary>
        public InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionArgs()
        {
        }
        public static new OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionArgs Empty => new OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionArgs();
    }
}
