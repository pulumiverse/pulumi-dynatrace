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
    [DynatraceResourceType("dynatrace:index/logEvents:LogEvents")]
    public partial class LogEvents : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Event template
        /// </summary>
        [Output("eventTemplate")]
        public Output<Outputs.LogEventsEventTemplate> EventTemplate { get; private set; } = null!;

        /// <summary>
        /// Log query
        /// </summary>
        [Output("query")]
        public Output<string> Query { get; private set; } = null!;

        /// <summary>
        /// The textual summary of the log event entry
        /// </summary>
        [Output("summary")]
        public Output<string> Summary { get; private set; } = null!;


        /// <summary>
        /// Create a LogEvents resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogEvents(string name, LogEventsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/logEvents:LogEvents", name, args ?? new LogEventsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogEvents(string name, Input<string> id, LogEventsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/logEvents:LogEvents", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LogEvents resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogEvents Get(string name, Input<string> id, LogEventsState? state = null, CustomResourceOptions? options = null)
        {
            return new LogEvents(name, id, state, options);
        }
    }

    public sealed class LogEventsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate", required: true)]
        public Input<Inputs.LogEventsEventTemplateArgs> EventTemplate { get; set; } = null!;

        /// <summary>
        /// Log query
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        /// <summary>
        /// The textual summary of the log event entry
        /// </summary>
        [Input("summary", required: true)]
        public Input<string> Summary { get; set; } = null!;

        public LogEventsArgs()
        {
        }
        public static new LogEventsArgs Empty => new LogEventsArgs();
    }

    public sealed class LogEventsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Event template
        /// </summary>
        [Input("eventTemplate")]
        public Input<Inputs.LogEventsEventTemplateGetArgs>? EventTemplate { get; set; }

        /// <summary>
        /// Log query
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The textual summary of the log event entry
        /// </summary>
        [Input("summary")]
        public Input<string>? Summary { get; set; }

        public LogEventsState()
        {
        }
        public static new LogEventsState Empty => new LogEventsState();
    }
}
