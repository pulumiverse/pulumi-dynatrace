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
    [DynatraceResourceType("dynatrace:index/automationWorkflowK8sConnections:AutomationWorkflowK8sConnections")]
    public partial class AutomationWorkflowK8sConnections : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// The name of the EdgeConnect deployment
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The namespace where EdgeConnect is deployed
        /// </summary>
        [Output("namespace")]
        public Output<string> Namespace { get; private set; } = null!;

        /// <summary>
        /// Token
        /// </summary>
        [Output("token")]
        public Output<string> Token { get; private set; } = null!;

        /// <summary>
        /// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
        /// </summary>
        [Output("uid")]
        public Output<string> Uid { get; private set; } = null!;


        /// <summary>
        /// Create a AutomationWorkflowK8sConnections resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AutomationWorkflowK8sConnections(string name, AutomationWorkflowK8sConnectionsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/automationWorkflowK8sConnections:AutomationWorkflowK8sConnections", name, args ?? new AutomationWorkflowK8sConnectionsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AutomationWorkflowK8sConnections(string name, Input<string> id, AutomationWorkflowK8sConnectionsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/automationWorkflowK8sConnections:AutomationWorkflowK8sConnections", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AutomationWorkflowK8sConnections resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AutomationWorkflowK8sConnections Get(string name, Input<string> id, AutomationWorkflowK8sConnectionsState? state = null, CustomResourceOptions? options = null)
        {
            return new AutomationWorkflowK8sConnections(name, id, state, options);
        }
    }

    public sealed class AutomationWorkflowK8sConnectionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The name of the EdgeConnect deployment
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The namespace where EdgeConnect is deployed
        /// </summary>
        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("token", required: true)]
        private Input<string>? _token;

        /// <summary>
        /// Token
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

        /// <summary>
        /// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
        /// </summary>
        [Input("uid", required: true)]
        public Input<string> Uid { get; set; } = null!;

        public AutomationWorkflowK8sConnectionsArgs()
        {
        }
        public static new AutomationWorkflowK8sConnectionsArgs Empty => new AutomationWorkflowK8sConnectionsArgs();
    }

    public sealed class AutomationWorkflowK8sConnectionsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The name of the EdgeConnect deployment
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The namespace where EdgeConnect is deployed
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// Token
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

        /// <summary>
        /// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
        /// </summary>
        [Input("uid")]
        public Input<string>? Uid { get; set; }

        public AutomationWorkflowK8sConnectionsState()
        {
        }
        public static new AutomationWorkflowK8sConnectionsState Empty => new AutomationWorkflowK8sConnectionsState();
    }
}
