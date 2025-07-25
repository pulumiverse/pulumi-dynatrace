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
    public sealed class OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessor
    {
        public readonly Outputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor? BizeventExtractionProcessor;
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        public readonly Outputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessor? DavisEventExtractionProcessor;

        [OutputConstructor]
        private OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessor(
            Outputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorBizeventExtractionProcessor? bizeventExtractionProcessor,

            Outputs.OpenpipelineUserEventsPipelinesPipelineDataExtractionProcessorDavisEventExtractionProcessor? davisEventExtractionProcessor)
        {
            BizeventExtractionProcessor = bizeventExtractionProcessor;
            DavisEventExtractionProcessor = davisEventExtractionProcessor;
        }
    }
}
