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
    public sealed class OpenpipelineUserSessionsEndpointsEndpointRouting
    {
        /// <summary>
        /// Pipeline ID of the static routing
        /// </summary>
        public readonly string? PipelineId;
        /// <summary>
        /// Type of routing, static or dynamic
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private OpenpipelineUserSessionsEndpointsEndpointRouting(
            string? pipelineId,

            string type)
        {
            PipelineId = pipelineId;
            Type = type;
        }
    }
}
