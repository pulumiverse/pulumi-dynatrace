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
    [DynatraceResourceType("dynatrace:index/servicenowConnection:ServicenowConnection")]
    public partial class ServicenowConnection : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A unique and clearly identifiable connection name to your ServiceNow instance.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Password of the ServiceNow user.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `basic`
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// URL of the ServiceNow instance.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;

        /// <summary>
        /// Username or Email address.
        /// </summary>
        [Output("user")]
        public Output<string?> User { get; private set; } = null!;


        /// <summary>
        /// Create a ServicenowConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServicenowConnection(string name, ServicenowConnectionArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/servicenowConnection:ServicenowConnection", name, args ?? new ServicenowConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServicenowConnection(string name, Input<string> id, ServicenowConnectionState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/servicenowConnection:ServicenowConnection", name, state, MakeResourceOptions(options, id))
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
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServicenowConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServicenowConnection Get(string name, Input<string> id, ServicenowConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new ServicenowConnection(name, id, state, options);
        }
    }

    public sealed class ServicenowConnectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique and clearly identifiable connection name to your ServiceNow instance.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password of the ServiceNow user.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Possible Values: `basic`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// URL of the ServiceNow instance.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// Username or Email address.
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public ServicenowConnectionArgs()
        {
        }
        public static new ServicenowConnectionArgs Empty => new ServicenowConnectionArgs();
    }

    public sealed class ServicenowConnectionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique and clearly identifiable connection name to your ServiceNow instance.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password of the ServiceNow user.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Possible Values: `basic`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// URL of the ServiceNow instance.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        /// <summary>
        /// Username or Email address.
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public ServicenowConnectionState()
        {
        }
        public static new ServicenowConnectionState Empty => new ServicenowConnectionState();
    }
}