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

    public sealed class OpenpipelineSpansPipelinesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("pipelines")]
        private InputList<Inputs.OpenpipelineSpansPipelinesPipelineGetArgs>? _pipelines;

        /// <summary>
        /// Definition of a single pipeline
        /// </summary>
        public InputList<Inputs.OpenpipelineSpansPipelinesPipelineGetArgs> Pipelines
        {
            get => _pipelines ?? (_pipelines = new InputList<Inputs.OpenpipelineSpansPipelinesPipelineGetArgs>());
            set => _pipelines = value;
        }

        public OpenpipelineSpansPipelinesGetArgs()
        {
        }
        public static new OpenpipelineSpansPipelinesGetArgs Empty => new OpenpipelineSpansPipelinesGetArgs();
    }
}
