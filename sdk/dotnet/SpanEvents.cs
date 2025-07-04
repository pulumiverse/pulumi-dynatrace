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
    [DynatraceResourceType("dynatrace:index/spanEvents:SpanEvents")]
    public partial class SpanEvents : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Key of the span event attribute to store
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        /// </summary>
        [Output("masking")]
        public Output<string> Masking { get; private set; } = null!;


        /// <summary>
        /// Create a SpanEvents resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SpanEvents(string name, SpanEventsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/spanEvents:SpanEvents", name, args ?? new SpanEventsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SpanEvents(string name, Input<string> id, SpanEventsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/spanEvents:SpanEvents", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SpanEvents resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SpanEvents Get(string name, Input<string> id, SpanEventsState? state = null, CustomResourceOptions? options = null)
        {
            return new SpanEvents(name, id, state, options);
        }
    }

    public sealed class SpanEventsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key of the span event attribute to store
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        /// </summary>
        [Input("masking", required: true)]
        public Input<string> Masking { get; set; } = null!;

        public SpanEventsArgs()
        {
        }
        public static new SpanEventsArgs Empty => new SpanEventsArgs();
    }

    public sealed class SpanEventsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key of the span event attribute to store
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        /// </summary>
        [Input("masking")]
        public Input<string>? Masking { get; set; }

        public SpanEventsState()
        {
        }
        public static new SpanEventsState Empty => new SpanEventsState();
    }
}
