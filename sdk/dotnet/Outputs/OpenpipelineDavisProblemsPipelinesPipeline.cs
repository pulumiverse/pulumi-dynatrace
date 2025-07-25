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
    public sealed class OpenpipelineDavisProblemsPipelinesPipeline
    {
        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineDavisProblemsPipelinesPipelineDataExtraction? DataExtraction;
        /// <summary>
        /// Display name of the pipeline
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Identifier of the pipeline
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Metric extraction stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineDavisProblemsPipelinesPipelineMetricExtraction? MetricExtraction;
        /// <summary>
        /// Processing stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineDavisProblemsPipelinesPipelineProcessing? Processing;
        /// <summary>
        /// Security context stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineDavisProblemsPipelinesPipelineSecurityContext? SecurityContext;
        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineDavisProblemsPipelinesPipelineStorage? Storage;

        [OutputConstructor]
        private OpenpipelineDavisProblemsPipelinesPipeline(
            Outputs.OpenpipelineDavisProblemsPipelinesPipelineDataExtraction? dataExtraction,

            string displayName,

            bool enabled,

            string id,

            Outputs.OpenpipelineDavisProblemsPipelinesPipelineMetricExtraction? metricExtraction,

            Outputs.OpenpipelineDavisProblemsPipelinesPipelineProcessing? processing,

            Outputs.OpenpipelineDavisProblemsPipelinesPipelineSecurityContext? securityContext,

            Outputs.OpenpipelineDavisProblemsPipelinesPipelineStorage? storage)
        {
            DataExtraction = dataExtraction;
            DisplayName = displayName;
            Enabled = enabled;
            Id = id;
            MetricExtraction = metricExtraction;
            Processing = processing;
            SecurityContext = securityContext;
            Storage = storage;
        }
    }
}
