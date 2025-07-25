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
    /// <summary>
    /// &gt; This resource requires the cluster API token scope **Service Provider API** (`ServiceProviderAPI`)
    /// 
    /// ## Dynatrace Documentation
    /// 
    /// - Manage your monitoring environments - https://docs.dynatrace.com/managed/managed-cluster/operation/manage-your-monitoring-environments
    /// 
    /// - Cluster API v2 - Environments - https://www.dynatrace.com/support/help/shortlink/cluster-api#environments
    /// </summary>
    [DynatraceResourceType("dynatrace:index/environment:Environment")]
    public partial class Environment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The display name of the environment
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Environment level consumption and quotas information
        /// </summary>
        [Output("quotas")]
        public Output<Outputs.EnvironmentQuotas?> Quotas { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Environment level storage usage and limit information
        /// </summary>
        [Output("storage")]
        public Output<Outputs.EnvironmentStorage> Storage { get; private set; } = null!;

        /// <summary>
        /// A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
        /// </summary>
        [Output("trial")]
        public Output<bool?> Trial { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/environment:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/environment:Environment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Environment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Environment Get(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Environment(name, id, state, options);
        }
    }

    public sealed class EnvironmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display name of the environment
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Environment level consumption and quotas information
        /// </summary>
        [Input("quotas")]
        public Input<Inputs.EnvironmentQuotasArgs>? Quotas { get; set; }

        /// <summary>
        /// Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
        /// </summary>
        [Input("state", required: true)]
        public Input<string> State { get; set; } = null!;

        /// <summary>
        /// Environment level storage usage and limit information
        /// </summary>
        [Input("storage", required: true)]
        public Input<Inputs.EnvironmentStorageArgs> Storage { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
        /// </summary>
        [Input("trial")]
        public Input<bool>? Trial { get; set; }

        public EnvironmentArgs()
        {
        }
        public static new EnvironmentArgs Empty => new EnvironmentArgs();
    }

    public sealed class EnvironmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display name of the environment
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Environment level consumption and quotas information
        /// </summary>
        [Input("quotas")]
        public Input<Inputs.EnvironmentQuotasGetArgs>? Quotas { get; set; }

        /// <summary>
        /// Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Environment level storage usage and limit information
        /// </summary>
        [Input("storage")]
        public Input<Inputs.EnvironmentStorageGetArgs>? Storage { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
        /// </summary>
        [Input("trial")]
        public Input<bool>? Trial { get; set; }

        public EnvironmentState()
        {
        }
        public static new EnvironmentState Empty => new EnvironmentState();
    }
}
