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

    public sealed class OpenpipelineDavisProblemsRoutingEntryGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Matching condition to apply on incoming records
        /// </summary>
        [Input("matcher", required: true)]
        public Input<string> Matcher { get; set; } = null!;

        /// <summary>
        /// Unique note describing the dynamic route
        /// </summary>
        [Input("note", required: true)]
        public Input<string> Note { get; set; } = null!;

        /// <summary>
        /// Identifier of the pipeline the record is routed into
        /// </summary>
        [Input("pipelineId", required: true)]
        public Input<string> PipelineId { get; set; } = null!;

        public OpenpipelineDavisProblemsRoutingEntryGetArgs()
        {
        }
        public static new OpenpipelineDavisProblemsRoutingEntryGetArgs Empty => new OpenpipelineDavisProblemsRoutingEntryGetArgs();
    }
}
