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
    [DynatraceResourceType("dynatrace:index/automationWorkflowSlack:AutomationWorkflowSlack")]
    public partial class AutomationWorkflowSlack : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// The name of the Slack connection
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The bot token obtained from the Slack App Management UI
        /// </summary>
        [Output("token")]
        public Output<string> Token { get; private set; } = null!;


        /// <summary>
        /// Create a AutomationWorkflowSlack resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AutomationWorkflowSlack(string name, AutomationWorkflowSlackArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/automationWorkflowSlack:AutomationWorkflowSlack", name, args ?? new AutomationWorkflowSlackArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AutomationWorkflowSlack(string name, Input<string> id, AutomationWorkflowSlackState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/automationWorkflowSlack:AutomationWorkflowSlack", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
                AdditionalSecretOutputs =
                {
                    "token",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AutomationWorkflowSlack resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AutomationWorkflowSlack Get(string name, Input<string> id, AutomationWorkflowSlackState? state = null, CustomResourceOptions? options = null)
        {
            return new AutomationWorkflowSlack(name, id, state, options);
        }
    }

    public sealed class AutomationWorkflowSlackArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The name of the Slack connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("token", required: true)]
        private Input<string>? _token;

        /// <summary>
        /// The bot token obtained from the Slack App Management UI
        /// </summary>
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AutomationWorkflowSlackArgs()
        {
        }
        public static new AutomationWorkflowSlackArgs Empty => new AutomationWorkflowSlackArgs();
    }

    public sealed class AutomationWorkflowSlackState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The name of the Slack connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// The bot token obtained from the Slack App Management UI
        /// </summary>
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AutomationWorkflowSlackState()
        {
        }
        public static new AutomationWorkflowSlackState Empty => new AutomationWorkflowSlackState();
    }
}
