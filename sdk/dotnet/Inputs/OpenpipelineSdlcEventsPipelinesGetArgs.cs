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

    public sealed class OpenpipelineSdlcEventsPipelinesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("pipelines")]
        private InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineGetArgs>? _pipelines;

        /// <summary>
        /// Definition of a single pipeline
        /// </summary>
        public InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineGetArgs> Pipelines
        {
            get => _pipelines ?? (_pipelines = new InputList<Inputs.OpenpipelineSdlcEventsPipelinesPipelineGetArgs>());
            set => _pipelines = value;
        }

        public OpenpipelineSdlcEventsPipelinesGetArgs()
        {
        }
        public static new OpenpipelineSdlcEventsPipelinesGetArgs Empty => new OpenpipelineSdlcEventsPipelinesGetArgs();
    }
}