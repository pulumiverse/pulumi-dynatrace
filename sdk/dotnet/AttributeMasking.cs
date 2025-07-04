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
    [DynatraceResourceType("dynatrace:index/attributeMasking:AttributeMasking")]
    public partial class AttributeMasking : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Key of the attribute
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`
        /// </summary>
        [Output("masking")]
        public Output<string> Masking { get; private set; } = null!;


        /// <summary>
        /// Create a AttributeMasking resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AttributeMasking(string name, AttributeMaskingArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/attributeMasking:AttributeMasking", name, args ?? new AttributeMaskingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AttributeMasking(string name, Input<string> id, AttributeMaskingState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/attributeMasking:AttributeMasking", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AttributeMasking resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AttributeMasking Get(string name, Input<string> id, AttributeMaskingState? state = null, CustomResourceOptions? options = null)
        {
            return new AttributeMasking(name, id, state, options);
        }
    }

    public sealed class AttributeMaskingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Key of the attribute
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`
        /// </summary>
        [Input("masking", required: true)]
        public Input<string> Masking { get; set; } = null!;

        public AttributeMaskingArgs()
        {
        }
        public static new AttributeMaskingArgs Empty => new AttributeMaskingArgs();
    }

    public sealed class AttributeMaskingState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Key of the attribute
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`
        /// </summary>
        [Input("masking")]
        public Input<string>? Masking { get; set; }

        public AttributeMaskingState()
        {
        }
        public static new AttributeMaskingState Empty => new AttributeMaskingState();
    }
}
