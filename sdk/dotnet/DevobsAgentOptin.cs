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
    [DynatraceResourceType("dynatrace:index/devobsAgentOptin:DevobsAgentOptin")]
    public partial class DevobsAgentOptin : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (PROCESS*GROUP, CLOUD*APPLICATION*NAMESPACE, KUBERNETES*CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a DevobsAgentOptin resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DevobsAgentOptin(string name, DevobsAgentOptinArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/devobsAgentOptin:DevobsAgentOptin", name, args ?? new DevobsAgentOptinArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DevobsAgentOptin(string name, Input<string> id, DevobsAgentOptinState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/devobsAgentOptin:DevobsAgentOptin", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DevobsAgentOptin resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DevobsAgentOptin Get(string name, Input<string> id, DevobsAgentOptinState? state = null, CustomResourceOptions? options = null)
        {
            return new DevobsAgentOptin(name, id, state, options);
        }
    }

    public sealed class DevobsAgentOptinArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (PROCESS*GROUP, CLOUD*APPLICATION*NAMESPACE, KUBERNETES*CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public DevobsAgentOptinArgs()
        {
        }
        public static new DevobsAgentOptinArgs Empty => new DevobsAgentOptinArgs();
    }

    public sealed class DevobsAgentOptinState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The scope of this setting (PROCESS*GROUP, CLOUD*APPLICATION*NAMESPACE, KUBERNETES*CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public DevobsAgentOptinState()
        {
        }
        public static new DevobsAgentOptinState Empty => new DevobsAgentOptinState();
    }
}
