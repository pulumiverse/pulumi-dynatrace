// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/ms365EmailConnection:Ms365EmailConnection")]
    public partial class Ms365EmailConnection : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Application (client) ID of your app registered in Microsoft Azure App registrations
        /// </summary>
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        /// <summary>
        /// Client secret of your app registered in Microsoft Azure App registrations
        /// </summary>
        [Output("clientSecret")]
        public Output<string?> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// The email address from which the messages will be sent
        /// </summary>
        [Output("fromAddress")]
        public Output<string> FromAddress { get; private set; } = null!;

        /// <summary>
        /// A unique name for the Microsoft 365 email connection
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Directory (tenant) ID of your Azure Active Directory
        /// </summary>
        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `client_secret`
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Ms365EmailConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Ms365EmailConnection(string name, Ms365EmailConnectionArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/ms365EmailConnection:Ms365EmailConnection", name, args ?? new Ms365EmailConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Ms365EmailConnection(string name, Input<string> id, Ms365EmailConnectionState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/ms365EmailConnection:Ms365EmailConnection", name, state, MakeResourceOptions(options, id))
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
                    "clientSecret",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Ms365EmailConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Ms365EmailConnection Get(string name, Input<string> id, Ms365EmailConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new Ms365EmailConnection(name, id, state, options);
        }
    }

    public sealed class Ms365EmailConnectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application (client) ID of your app registered in Microsoft Azure App registrations
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        [Input("clientSecret")]
        private Input<string>? _clientSecret;

        /// <summary>
        /// Client secret of your app registered in Microsoft Azure App registrations
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The email address from which the messages will be sent
        /// </summary>
        [Input("fromAddress", required: true)]
        public Input<string> FromAddress { get; set; } = null!;

        /// <summary>
        /// A unique name for the Microsoft 365 email connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Directory (tenant) ID of your Azure Active Directory
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        /// <summary>
        /// Possible Values: `client_secret`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public Ms365EmailConnectionArgs()
        {
        }
        public static new Ms365EmailConnectionArgs Empty => new Ms365EmailConnectionArgs();
    }

    public sealed class Ms365EmailConnectionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application (client) ID of your app registered in Microsoft Azure App registrations
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        [Input("clientSecret")]
        private Input<string>? _clientSecret;

        /// <summary>
        /// Client secret of your app registered in Microsoft Azure App registrations
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The email address from which the messages will be sent
        /// </summary>
        [Input("fromAddress")]
        public Input<string>? FromAddress { get; set; }

        /// <summary>
        /// A unique name for the Microsoft 365 email connection
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Directory (tenant) ID of your Azure Active Directory
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// Possible Values: `client_secret`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public Ms365EmailConnectionState()
        {
        }
        public static new Ms365EmailConnectionState Empty => new Ms365EmailConnectionState();
    }
}