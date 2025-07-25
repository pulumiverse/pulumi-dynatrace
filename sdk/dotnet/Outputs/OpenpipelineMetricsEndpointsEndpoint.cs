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
    public sealed class OpenpipelineMetricsEndpointsEndpoint
    {
        /// <summary>
        /// The default bucket assigned to records for the ingest source
        /// </summary>
        public readonly string? DefaultBucket;
        /// <summary>
        /// Display name of the ingest source
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// The pre-processing done in the ingest source
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessors? Processors;
        /// <summary>
        /// Routing strategy, either dynamic or static
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointRouting Routing;
        /// <summary>
        /// The segment of the ingest source, which is applied to the base path. Must be unique within a configuration."
        /// </summary>
        public readonly string Segment;

        [OutputConstructor]
        private OpenpipelineMetricsEndpointsEndpoint(
            string? defaultBucket,

            string displayName,

            bool enabled,

            Outputs.OpenpipelineMetricsEndpointsEndpointProcessors? processors,

            Outputs.OpenpipelineMetricsEndpointsEndpointRouting routing,

            string segment)
        {
            DefaultBucket = defaultBucket;
            DisplayName = displayName;
            Enabled = enabled;
            Processors = processors;
            Routing = routing;
            Segment = segment;
        }
    }
}
