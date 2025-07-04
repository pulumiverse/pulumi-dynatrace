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
    public sealed class OpenpipelineSdlcEventsPipelinesPipeline
    {
        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineDataExtraction? DataExtraction;
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
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtraction? MetricExtraction;
        /// <summary>
        /// Processing stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineProcessing? Processing;
        /// <summary>
        /// Security context stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineSecurityContext? SecurityContext;
        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        public readonly Outputs.OpenpipelineSdlcEventsPipelinesPipelineStorage? Storage;

        [OutputConstructor]
        private OpenpipelineSdlcEventsPipelinesPipeline(
            Outputs.OpenpipelineSdlcEventsPipelinesPipelineDataExtraction? dataExtraction,

            string displayName,

            bool enabled,

            string id,

            Outputs.OpenpipelineSdlcEventsPipelinesPipelineMetricExtraction? metricExtraction,

            Outputs.OpenpipelineSdlcEventsPipelinesPipelineProcessing? processing,

            Outputs.OpenpipelineSdlcEventsPipelinesPipelineSecurityContext? securityContext,

            Outputs.OpenpipelineSdlcEventsPipelinesPipelineStorage? storage)
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
