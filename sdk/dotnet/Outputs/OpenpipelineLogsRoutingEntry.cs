// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class OpenpipelineLogsRoutingEntry
    {
        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Matching condition to apply on incoming records
        /// </summary>
        public readonly string Matcher;
        /// <summary>
        /// Unique note describing the dynamic route
        /// </summary>
        public readonly string Note;
        /// <summary>
        /// Identifier of the pipeline the record is routed into
        /// </summary>
        public readonly string PipelineId;

        [OutputConstructor]
        private OpenpipelineLogsRoutingEntry(
            bool enabled,

            string matcher,

            string note,

            string pipelineId)
        {
            Enabled = enabled;
            Matcher = matcher;
            Note = note;
            PipelineId = pipelineId;
        }
    }
}