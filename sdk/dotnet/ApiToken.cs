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
    [DynatraceResourceType("dynatrace:index/apiToken:ApiToken")]
    public partial class ApiToken : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Output("creationDate")]
        public Output<string> CreationDate { get; private set; } = null!;

        /// <summary>
        /// The token is enabled (true) or disabled (false), default disabled (false).
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The expiration date of the token.
        /// </summary>
        [Output("expirationDate")]
        public Output<string?> ExpirationDate { get; private set; } = null!;

        /// <summary>
        /// Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Output("lastUsedDate")]
        public Output<string> LastUsedDate { get; private set; } = null!;

        /// <summary>
        /// Token last used IP address.
        /// </summary>
        [Output("lastUsedIpAddress")]
        public Output<string> LastUsedIpAddress { get; private set; } = null!;

        /// <summary>
        /// Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        /// </summary>
        [Output("modifiedDate")]
        public Output<string> ModifiedDate { get; private set; } = null!;

        /// <summary>
        /// The name of the token.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The owner of the token
        /// </summary>
        [Output("owner")]
        public Output<string> Owner { get; private set; } = null!;

        /// <summary>
        /// The token is a personal access token (true) or an API token (false).
        /// </summary>
        [Output("personalAccessToken")]
        public Output<bool?> PersonalAccessToken { get; private set; } = null!;

        /// <summary>
        /// A list of the scopes to be assigned to the token.
        /// </summary>
        [Output("scopes")]
        public Output<ImmutableArray<string>> Scopes { get; private set; } = null!;

        /// <summary>
        /// The secret of the token.
        /// </summary>
        [Output("token")]
        public Output<string> Token { get; private set; } = null!;


        /// <summary>
        /// Create a ApiToken resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiToken(string name, ApiTokenArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/apiToken:ApiToken", name, args ?? new ApiTokenArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiToken(string name, Input<string> id, ApiTokenState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/apiToken:ApiToken", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ApiToken resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiToken Get(string name, Input<string> id, ApiTokenState? state = null, CustomResourceOptions? options = null)
        {
            return new ApiToken(name, id, state, options);
        }
    }

    public sealed class ApiTokenArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Input("creationDate")]
        public Input<string>? CreationDate { get; set; }

        /// <summary>
        /// The token is enabled (true) or disabled (false), default disabled (false).
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The expiration date of the token.
        /// </summary>
        [Input("expirationDate")]
        public Input<string>? ExpirationDate { get; set; }

        /// <summary>
        /// Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Input("lastUsedDate")]
        public Input<string>? LastUsedDate { get; set; }

        /// <summary>
        /// Token last used IP address.
        /// </summary>
        [Input("lastUsedIpAddress")]
        public Input<string>? LastUsedIpAddress { get; set; }

        /// <summary>
        /// Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        /// </summary>
        [Input("modifiedDate")]
        public Input<string>? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the token.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The owner of the token
        /// </summary>
        [Input("owner")]
        public Input<string>? Owner { get; set; }

        /// <summary>
        /// The token is a personal access token (true) or an API token (false).
        /// </summary>
        [Input("personalAccessToken")]
        public Input<bool>? PersonalAccessToken { get; set; }

        [Input("scopes", required: true)]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of the scopes to be assigned to the token.
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public ApiTokenArgs()
        {
        }
        public static new ApiTokenArgs Empty => new ApiTokenArgs();
    }

    public sealed class ApiTokenState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Input("creationDate")]
        public Input<string>? CreationDate { get; set; }

        /// <summary>
        /// The token is enabled (true) or disabled (false), default disabled (false).
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The expiration date of the token.
        /// </summary>
        [Input("expirationDate")]
        public Input<string>? ExpirationDate { get; set; }

        /// <summary>
        /// Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        /// </summary>
        [Input("lastUsedDate")]
        public Input<string>? LastUsedDate { get; set; }

        /// <summary>
        /// Token last used IP address.
        /// </summary>
        [Input("lastUsedIpAddress")]
        public Input<string>? LastUsedIpAddress { get; set; }

        /// <summary>
        /// Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        /// </summary>
        [Input("modifiedDate")]
        public Input<string>? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the token.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The owner of the token
        /// </summary>
        [Input("owner")]
        public Input<string>? Owner { get; set; }

        /// <summary>
        /// The token is a personal access token (true) or an API token (false).
        /// </summary>
        [Input("personalAccessToken")]
        public Input<bool>? PersonalAccessToken { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of the scopes to be assigned to the token.
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// The secret of the token.
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

        public ApiTokenState()
        {
        }
        public static new ApiTokenState Empty => new ApiTokenState();
    }
}
