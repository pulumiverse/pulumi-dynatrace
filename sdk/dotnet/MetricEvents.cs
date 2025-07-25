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
    [DynatraceResourceType("dynatrace:index/metricEvents:MetricEvents")]
    public partial class MetricEvents : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Controls the preferred entity type used for triggered events.
        /// </summary>
        [Output("eventEntityDimensionKey")]
        public Output<string?> EventEntityDimensionKey { get; private set; } = null!;

        /// <summary>
        /// Event template
        /// </summary>
        [Output("eventTemplate")]
        public Output<Outputs.MetricEventsEventTemplate> EventTemplate { get; private set; } = null!;

        /// <summary>
        /// Config id
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

        /// <summary>
        /// Monitoring strategy
        /// </summary>
        [Output("modelProperties")]
        public Output<Outputs.MetricEventsModelProperties> ModelProperties { get; private set; } = null!;

        /// <summary>
        /// Query definition
        /// </summary>
        [Output("queryDefinition")]
        public Output<Outputs.MetricEventsQueryDefinition> QueryDefinition { get; private set; } = null!;

        /// <summary>
        /// The textual summary of the metric event entry
        /// </summary>
        [Output("summary")]
        public Output<string> Summary { get; private set; } = null!;


        /// <summary>
        /// Create a MetricEvents resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MetricEvents(string name, MetricEventsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/metricEvents:MetricEvents", name, args ?? new MetricEventsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MetricEvents(string name, Input<string> id, MetricEventsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/metricEvents:MetricEvents", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MetricEvents resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MetricEvents Get(string name, Input<string> id, MetricEventsState? state = null, CustomResourceOptions? options = null)
        {
            return new MetricEvents(name, id, state, options);
        }
    }

    public sealed class MetricEventsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Controls the preferred entity type used for triggered events.
        /// </summary>
        [Input("eventEntityDimensionKey")]
        public Input<string>? EventEntityDimensionKey { get; set; }

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate", required: true)]
        public Input<Inputs.MetricEventsEventTemplateArgs> EventTemplate { get; set; } = null!;

        /// <summary>
        /// Config id
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// Monitoring strategy
        /// </summary>
        [Input("modelProperties", required: true)]
        public Input<Inputs.MetricEventsModelPropertiesArgs> ModelProperties { get; set; } = null!;

        /// <summary>
        /// Query definition
        /// </summary>
        [Input("queryDefinition", required: true)]
        public Input<Inputs.MetricEventsQueryDefinitionArgs> QueryDefinition { get; set; } = null!;

        /// <summary>
        /// The textual summary of the metric event entry
        /// </summary>
        [Input("summary", required: true)]
        public Input<string> Summary { get; set; } = null!;

        public MetricEventsArgs()
        {
        }
        public static new MetricEventsArgs Empty => new MetricEventsArgs();
    }

    public sealed class MetricEventsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Controls the preferred entity type used for triggered events.
        /// </summary>
        [Input("eventEntityDimensionKey")]
        public Input<string>? EventEntityDimensionKey { get; set; }

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate")]
        public Input<Inputs.MetricEventsEventTemplateGetArgs>? EventTemplate { get; set; }

        /// <summary>
        /// Config id
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// Monitoring strategy
        /// </summary>
        [Input("modelProperties")]
        public Input<Inputs.MetricEventsModelPropertiesGetArgs>? ModelProperties { get; set; }

        /// <summary>
        /// Query definition
        /// </summary>
        [Input("queryDefinition")]
        public Input<Inputs.MetricEventsQueryDefinitionGetArgs>? QueryDefinition { get; set; }

        /// <summary>
        /// The textual summary of the metric event entry
        /// </summary>
        [Input("summary")]
        public Input<string>? Summary { get; set; }

        public MetricEventsState()
        {
        }
        public static new MetricEventsState Empty => new MetricEventsState();
    }
}
