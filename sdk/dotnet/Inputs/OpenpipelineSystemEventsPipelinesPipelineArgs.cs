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

    public sealed class OpenpipelineSystemEventsPipelinesPipelineArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        [Input("dataExtraction")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineDataExtractionArgs>? DataExtraction { get; set; }

        /// <summary>
        /// Display name of the pipeline
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// Indicates if the object is active
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Identifier of the pipeline
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Metric extraction stage configuration of the pipeline
        /// </summary>
        [Input("metricExtraction")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineMetricExtractionArgs>? MetricExtraction { get; set; }

        /// <summary>
        /// Processing stage configuration of the pipeline
        /// </summary>
        [Input("processing")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineProcessingArgs>? Processing { get; set; }

        /// <summary>
        /// Security context stage configuration of the pipeline
        /// </summary>
        [Input("securityContext")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineSecurityContextArgs>? SecurityContext { get; set; }

        /// <summary>
        /// Data extraction stage configuration of the pipeline
        /// </summary>
        [Input("storage")]
        public Input<Inputs.OpenpipelineSystemEventsPipelinesPipelineStorageArgs>? Storage { get; set; }

        public OpenpipelineSystemEventsPipelinesPipelineArgs()
        {
        }
        public static new OpenpipelineSystemEventsPipelinesPipelineArgs Empty => new OpenpipelineSystemEventsPipelinesPipelineArgs();
    }
}
