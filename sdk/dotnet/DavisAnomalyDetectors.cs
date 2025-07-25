// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/davisAnomalyDetectors:DavisAnomalyDetectors")]
    public partial class DavisAnomalyDetectors : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Analyzer input
        /// </summary>
        [Output("analyzer")]
        public Output<Outputs.DavisAnomalyDetectorsAnalyzer> Analyzer { get; private set; } = null!;

        /// <summary>
        /// The description of the anomaly detector
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Event template
        /// </summary>
        [Output("eventTemplate")]
        public Output<Outputs.DavisAnomalyDetectorsEventTemplate> EventTemplate { get; private set; } = null!;

        /// <summary>
        /// Execution settings
        /// </summary>
        [Output("executionSettings")]
        public Output<Outputs.DavisAnomalyDetectorsExecutionSettings> ExecutionSettings { get; private set; } = null!;

        /// <summary>
        /// Source
        /// </summary>
        [Output("source")]
        public Output<string> Source { get; private set; } = null!;

        /// <summary>
        /// The title of the anomaly detector
        /// </summary>
        [Output("title")]
        public Output<string> Title { get; private set; } = null!;


        /// <summary>
        /// Create a DavisAnomalyDetectors resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DavisAnomalyDetectors(string name, DavisAnomalyDetectorsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/davisAnomalyDetectors:DavisAnomalyDetectors", name, args ?? new DavisAnomalyDetectorsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DavisAnomalyDetectors(string name, Input<string> id, DavisAnomalyDetectorsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/davisAnomalyDetectors:DavisAnomalyDetectors", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DavisAnomalyDetectors resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DavisAnomalyDetectors Get(string name, Input<string> id, DavisAnomalyDetectorsState? state = null, CustomResourceOptions? options = null)
        {
            return new DavisAnomalyDetectors(name, id, state, options);
        }
    }

    public sealed class DavisAnomalyDetectorsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Analyzer input
        /// </summary>
        [Input("analyzer", required: true)]
        public Input<Inputs.DavisAnomalyDetectorsAnalyzerArgs> Analyzer { get; set; } = null!;

        /// <summary>
        /// The description of the anomaly detector
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate", required: true)]
        public Input<Inputs.DavisAnomalyDetectorsEventTemplateArgs> EventTemplate { get; set; } = null!;

        /// <summary>
        /// Execution settings
        /// </summary>
        [Input("executionSettings", required: true)]
        public Input<Inputs.DavisAnomalyDetectorsExecutionSettingsArgs> ExecutionSettings { get; set; } = null!;

        /// <summary>
        /// Source
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        /// <summary>
        /// The title of the anomaly detector
        /// </summary>
        [Input("title", required: true)]
        public Input<string> Title { get; set; } = null!;

        public DavisAnomalyDetectorsArgs()
        {
        }
        public static new DavisAnomalyDetectorsArgs Empty => new DavisAnomalyDetectorsArgs();
    }

    public sealed class DavisAnomalyDetectorsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Analyzer input
        /// </summary>
        [Input("analyzer")]
        public Input<Inputs.DavisAnomalyDetectorsAnalyzerGetArgs>? Analyzer { get; set; }

        /// <summary>
        /// The description of the anomaly detector
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate")]
        public Input<Inputs.DavisAnomalyDetectorsEventTemplateGetArgs>? EventTemplate { get; set; }

        /// <summary>
        /// Execution settings
        /// </summary>
        [Input("executionSettings")]
        public Input<Inputs.DavisAnomalyDetectorsExecutionSettingsGetArgs>? ExecutionSettings { get; set; }

        /// <summary>
        /// Source
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// The title of the anomaly detector
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        public DavisAnomalyDetectorsState()
        {
        }
        public static new DavisAnomalyDetectorsState Empty => new DavisAnomalyDetectorsState();
    }
}
