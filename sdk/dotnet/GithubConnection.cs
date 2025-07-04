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
    [DynatraceResourceType("dynatrace:index/githubConnection:GithubConnection")]
    public partial class GithubConnection : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the GitHub connection
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Token for the selected authentication type
        /// </summary>
        [Output("token")]
        public Output<string?> Token { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `pat`
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a GithubConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GithubConnection(string name, GithubConnectionArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/githubConnection:GithubConnection", name, args ?? new GithubConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GithubConnection(string name, Input<string> id, GithubConnectionState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/githubConnection:GithubConnection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing GithubConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GithubConnection Get(string name, Input<string> id, GithubConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new GithubConnection(name, id, state, options);
        }
    }

    public sealed class GithubConnectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the GitHub connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// Token for the selected authentication type
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
        /// Possible Values: `pat`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GithubConnectionArgs()
        {
        }
        public static new GithubConnectionArgs Empty => new GithubConnectionArgs();
    }

    public sealed class GithubConnectionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the GitHub connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// Token for the selected authentication type
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
        /// Possible Values: `pat`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GithubConnectionState()
        {
        }
        public static new GithubConnectionState Empty => new GithubConnectionState();
    }
}
