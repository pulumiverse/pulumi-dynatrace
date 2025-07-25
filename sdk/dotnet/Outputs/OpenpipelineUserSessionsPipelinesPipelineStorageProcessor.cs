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
    public sealed class OpenpipelineUserSessionsPipelinesPipelineStorageProcessor
    {
        /// <summary>
        /// Processor to assign a bucket
        /// </summary>
        public readonly Outputs.OpenpipelineUserSessionsPipelinesPipelineStorageProcessorBucketAssignmentProcessor? BucketAssignmentProcessor;
        /// <summary>
        /// Processor to skip storage assignment
        /// </summary>
        public readonly Outputs.OpenpipelineUserSessionsPipelinesPipelineStorageProcessorNoStorageProcessor? NoStorageProcessor;

        [OutputConstructor]
        private OpenpipelineUserSessionsPipelinesPipelineStorageProcessor(
            Outputs.OpenpipelineUserSessionsPipelinesPipelineStorageProcessorBucketAssignmentProcessor? bucketAssignmentProcessor,

            Outputs.OpenpipelineUserSessionsPipelinesPipelineStorageProcessorNoStorageProcessor? noStorageProcessor)
        {
            BucketAssignmentProcessor = bucketAssignmentProcessor;
            NoStorageProcessor = noStorageProcessor;
        }
    }
}
