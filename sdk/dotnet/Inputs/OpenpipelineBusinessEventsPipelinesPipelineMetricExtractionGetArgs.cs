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

    public sealed class OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorGetArgs>? _processors;

        /// <summary>
        /// Data extraction processor to use
        /// </summary>
        public InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorGetArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionProcessorGetArgs>());
            set => _processors = value;
        }

        public OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionGetArgs()
        {
        }
        public static new OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionGetArgs Empty => new OpenpipelineBusinessEventsPipelinesPipelineMetricExtractionGetArgs();
    }
}