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
    [DynatraceResourceType("dynatrace:index/dashboardsPresets:DashboardsPresets")]
    public partial class DashboardsPresets : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Show selected preset to respective user group only.
        /// </summary>
        [Output("dashboardPresetsList")]
        public Output<Outputs.DashboardsPresetsDashboardPresetsList?> DashboardPresetsList { get; private set; } = null!;

        /// <summary>
        /// Dashboard presets are visible to all users by default. For a pristine environment you may disable them entirely or opt to manually limit visibility to selected user groups.
        /// </summary>
        [Output("enableDashboardPresets")]
        public Output<bool> EnableDashboardPresets { get; private set; } = null!;


        /// <summary>
        /// Create a DashboardsPresets resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DashboardsPresets(string name, DashboardsPresetsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/dashboardsPresets:DashboardsPresets", name, args ?? new DashboardsPresetsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DashboardsPresets(string name, Input<string> id, DashboardsPresetsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/dashboardsPresets:DashboardsPresets", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DashboardsPresets resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DashboardsPresets Get(string name, Input<string> id, DashboardsPresetsState? state = null, CustomResourceOptions? options = null)
        {
            return new DashboardsPresets(name, id, state, options);
        }
    }

    public sealed class DashboardsPresetsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Show selected preset to respective user group only.
        /// </summary>
        [Input("dashboardPresetsList")]
        public Input<Inputs.DashboardsPresetsDashboardPresetsListArgs>? DashboardPresetsList { get; set; }

        /// <summary>
        /// Dashboard presets are visible to all users by default. For a pristine environment you may disable them entirely or opt to manually limit visibility to selected user groups.
        /// </summary>
        [Input("enableDashboardPresets", required: true)]
        public Input<bool> EnableDashboardPresets { get; set; } = null!;

        public DashboardsPresetsArgs()
        {
        }
        public static new DashboardsPresetsArgs Empty => new DashboardsPresetsArgs();
    }

    public sealed class DashboardsPresetsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Show selected preset to respective user group only.
        /// </summary>
        [Input("dashboardPresetsList")]
        public Input<Inputs.DashboardsPresetsDashboardPresetsListGetArgs>? DashboardPresetsList { get; set; }

        /// <summary>
        /// Dashboard presets are visible to all users by default. For a pristine environment you may disable them entirely or opt to manually limit visibility to selected user groups.
        /// </summary>
        [Input("enableDashboardPresets")]
        public Input<bool>? EnableDashboardPresets { get; set; }

        public DashboardsPresetsState()
        {
        }
        public static new DashboardsPresetsState Empty => new DashboardsPresetsState();
    }
}
