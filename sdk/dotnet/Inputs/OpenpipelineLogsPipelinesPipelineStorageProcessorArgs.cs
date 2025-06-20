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

    public sealed class OpenpipelineLogsPipelinesPipelineStorageProcessorArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to assign a bucket
        /// </summary>
        [Input("bucketAssignmentProcessor")]
        public Input<Inputs.OpenpipelineLogsPipelinesPipelineStorageProcessorBucketAssignmentProcessorArgs>? BucketAssignmentProcessor { get; set; }

        /// <summary>
        /// Processor to skip storage assignment
        /// </summary>
        [Input("noStorageProcessor")]
        public Input<Inputs.OpenpipelineLogsPipelinesPipelineStorageProcessorNoStorageProcessorArgs>? NoStorageProcessor { get; set; }

        public OpenpipelineLogsPipelinesPipelineStorageProcessorArgs()
        {
        }
        public static new OpenpipelineLogsPipelinesPipelineStorageProcessorArgs Empty => new OpenpipelineLogsPipelinesPipelineStorageProcessorArgs();
    }
}
