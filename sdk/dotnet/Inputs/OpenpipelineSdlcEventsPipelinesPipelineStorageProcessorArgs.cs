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

    public sealed class OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to assign a bucket
        /// </summary>
        [Input("bucketAssignmentProcessor")]
        public Input<Inputs.OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorBucketAssignmentProcessorArgs>? BucketAssignmentProcessor { get; set; }

        /// <summary>
        /// Processor to skip storage assignment
        /// </summary>
        [Input("noStorageProcessor")]
        public Input<Inputs.OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorNoStorageProcessorArgs>? NoStorageProcessor { get; set; }

        public OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorArgs()
        {
        }
        public static new OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorArgs Empty => new OpenpipelineSdlcEventsPipelinesPipelineStorageProcessorArgs();
    }
}
