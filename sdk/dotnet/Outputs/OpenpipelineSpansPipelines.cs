// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class OpenpipelineSpansPipelines
    {
        /// <summary>
        /// Definition of a single pipeline
        /// </summary>
        public readonly ImmutableArray<Outputs.OpenpipelineSpansPipelinesPipeline> Pipelines;

        [OutputConstructor]
        private OpenpipelineSpansPipelines(ImmutableArray<Outputs.OpenpipelineSpansPipelinesPipeline> pipelines)
        {
            Pipelines = pipelines;
        }
    }
}
