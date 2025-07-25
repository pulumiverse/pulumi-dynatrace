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
    [DynatraceResourceType("dynatrace:index/keyUserAction:KeyUserAction")]
    public partial class KeyUserAction : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the WebApplication
        /// </summary>
        [Output("applicationId")]
        public Output<string> ApplicationId { get; private set; } = null!;

        /// <summary>
        /// The domain where the action is performed
        /// </summary>
        [Output("domain")]
        public Output<string?> Domain { get; private set; } = null!;

        /// <summary>
        /// The name of the action
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The type of the action. Possible values are `Custom`, `Load` and `Xhr`
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a KeyUserAction resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KeyUserAction(string name, KeyUserActionArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/keyUserAction:KeyUserAction", name, args ?? new KeyUserActionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KeyUserAction(string name, Input<string> id, KeyUserActionState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/keyUserAction:KeyUserAction", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KeyUserAction resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KeyUserAction Get(string name, Input<string> id, KeyUserActionState? state = null, CustomResourceOptions? options = null)
        {
            return new KeyUserAction(name, id, state, options);
        }
    }

    public sealed class KeyUserActionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the WebApplication
        /// </summary>
        [Input("applicationId", required: true)]
        public Input<string> ApplicationId { get; set; } = null!;

        /// <summary>
        /// The domain where the action is performed
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The name of the action
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The type of the action. Possible values are `Custom`, `Load` and `Xhr`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public KeyUserActionArgs()
        {
        }
        public static new KeyUserActionArgs Empty => new KeyUserActionArgs();
    }

    public sealed class KeyUserActionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the WebApplication
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// The domain where the action is performed
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The name of the action
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The type of the action. Possible values are `Custom`, `Load` and `Xhr`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public KeyUserActionState()
        {
        }
        public static new KeyUserActionState Empty => new KeyUserActionState();
    }
}
