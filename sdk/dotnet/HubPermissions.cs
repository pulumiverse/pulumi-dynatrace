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
    [DynatraceResourceType("dynatrace:index/hubPermissions:HubPermissions")]
    public partial class HubPermissions : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Name
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Contact Email
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;


        /// <summary>
        /// Create a HubPermissions resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HubPermissions(string name, HubPermissionsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/hubPermissions:HubPermissions", name, args ?? new HubPermissionsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HubPermissions(string name, Input<string> id, HubPermissionsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/hubPermissions:HubPermissions", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing HubPermissions resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HubPermissions Get(string name, Input<string> id, HubPermissionsState? state = null, CustomResourceOptions? options = null)
        {
            return new HubPermissions(name, id, state, options);
        }
    }

    public sealed class HubPermissionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Contact Email
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        public HubPermissionsArgs()
        {
        }
        public static new HubPermissionsArgs Empty => new HubPermissionsArgs();
    }

    public sealed class HubPermissionsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Contact Email
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        public HubPermissionsState()
        {
        }
        public static new HubPermissionsState Empty => new HubPermissionsState();
    }
}
