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
    [DynatraceResourceType("dynatrace:index/mutedRequests:MutedRequests")]
    public partial class MutedRequests : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Muted request names
        /// </summary>
        [Output("mutedRequestNames")]
        public Output<ImmutableArray<string>> MutedRequestNames { get; private set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("serviceId")]
        public Output<string> ServiceId { get; private set; } = null!;


        /// <summary>
        /// Create a MutedRequests resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MutedRequests(string name, MutedRequestsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/mutedRequests:MutedRequests", name, args ?? new MutedRequestsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MutedRequests(string name, Input<string> id, MutedRequestsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/mutedRequests:MutedRequests", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MutedRequests resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MutedRequests Get(string name, Input<string> id, MutedRequestsState? state = null, CustomResourceOptions? options = null)
        {
            return new MutedRequests(name, id, state, options);
        }
    }

    public sealed class MutedRequestsArgs : global::Pulumi.ResourceArgs
    {
        [Input("mutedRequestNames")]
        private InputList<string>? _mutedRequestNames;

        /// <summary>
        /// Muted request names
        /// </summary>
        public InputList<string> MutedRequestNames
        {
            get => _mutedRequestNames ?? (_mutedRequestNames = new InputList<string>());
            set => _mutedRequestNames = value;
        }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public MutedRequestsArgs()
        {
        }
        public static new MutedRequestsArgs Empty => new MutedRequestsArgs();
    }

    public sealed class MutedRequestsState : global::Pulumi.ResourceArgs
    {
        [Input("mutedRequestNames")]
        private InputList<string>? _mutedRequestNames;

        /// <summary>
        /// Muted request names
        /// </summary>
        public InputList<string> MutedRequestNames
        {
            get => _mutedRequestNames ?? (_mutedRequestNames = new InputList<string>());
            set => _mutedRequestNames = value;
        }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        public MutedRequestsState()
        {
        }
        public static new MutedRequestsState Empty => new MutedRequestsState();
    }
}
