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
    public sealed class OpenpipelineUserSessionsPipelinesPipelineMetricExtraction
    {
        /// <summary>
        /// Data extraction processor to use
        /// </summary>
        public readonly ImmutableArray<Outputs.OpenpipelineUserSessionsPipelinesPipelineMetricExtractionProcessor> Processors;

        [OutputConstructor]
        private OpenpipelineUserSessionsPipelinesPipelineMetricExtraction(ImmutableArray<Outputs.OpenpipelineUserSessionsPipelinesPipelineMetricExtractionProcessor> processors)
        {
            Processors = processors;
        }
    }
}
