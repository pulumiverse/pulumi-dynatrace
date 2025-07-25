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
    [DynatraceResourceType("dynatrace:index/spanCaptureRule:SpanCaptureRule")]
    public partial class SpanCaptureRule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Whether to create an entry point or not
        /// </summary>
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Matching strategies for the Span
        /// </summary>
        [Output("matches")]
        public Output<Outputs.SpanCaptureRuleMatches> Matches { get; private set; } = null!;

        /// <summary>
        /// The name of the rule
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a SpanCaptureRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SpanCaptureRule(string name, SpanCaptureRuleArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/spanCaptureRule:SpanCaptureRule", name, args ?? new SpanCaptureRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SpanCaptureRule(string name, Input<string> id, SpanCaptureRuleState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/spanCaptureRule:SpanCaptureRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SpanCaptureRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SpanCaptureRule Get(string name, Input<string> id, SpanCaptureRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new SpanCaptureRule(name, id, state, options);
        }
    }

    public sealed class SpanCaptureRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to create an entry point or not
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Matching strategies for the Span
        /// </summary>
        [Input("matches", required: true)]
        public Input<Inputs.SpanCaptureRuleMatchesArgs> Matches { get; set; } = null!;

        /// <summary>
        /// The name of the rule
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public SpanCaptureRuleArgs()
        {
        }
        public static new SpanCaptureRuleArgs Empty => new SpanCaptureRuleArgs();
    }

    public sealed class SpanCaptureRuleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to create an entry point or not
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Matching strategies for the Span
        /// </summary>
        [Input("matches")]
        public Input<Inputs.SpanCaptureRuleMatchesGetArgs>? Matches { get; set; }

        /// <summary>
        /// The name of the rule
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public SpanCaptureRuleState()
        {
        }
        public static new SpanCaptureRuleState Empty => new SpanCaptureRuleState();
    }
}
