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
    [DynatraceResourceType("dynatrace:index/hubExtensionConfig:HubExtensionConfig")]
    public partial class HubExtensionConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Active Gate Group this monitoring configuration will be defined for
        /// </summary>
        [Output("activeGateGroup")]
        public Output<string?> ActiveGateGroup { get; private set; } = null!;

        /// <summary>
        /// The ID of the host this monitoring configuration will be defined for
        /// </summary>
        [Output("host")]
        public Output<string?> Host { get; private set; } = null!;

        /// <summary>
        /// The ID of the host group this monitoring configuration will be defined for
        /// </summary>
        [Output("hostGroup")]
        public Output<string?> HostGroup { get; private set; } = null!;

        /// <summary>
        /// The name of the Management Zone this monitoring configuration will be defined for
        /// </summary>
        [Output("managementZone")]
        public Output<string?> ManagementZone { get; private set; } = null!;

        /// <summary>
        /// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `dynatrace.getHubItems`
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The JSON encoded value for this monitoring configuration
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a HubExtensionConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HubExtensionConfig(string name, HubExtensionConfigArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/hubExtensionConfig:HubExtensionConfig", name, args ?? new HubExtensionConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HubExtensionConfig(string name, Input<string> id, HubExtensionConfigState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/hubExtensionConfig:HubExtensionConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing HubExtensionConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HubExtensionConfig Get(string name, Input<string> id, HubExtensionConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new HubExtensionConfig(name, id, state, options);
        }
    }

    public sealed class HubExtensionConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Active Gate Group this monitoring configuration will be defined for
        /// </summary>
        [Input("activeGateGroup")]
        public Input<string>? ActiveGateGroup { get; set; }

        /// <summary>
        /// The ID of the host this monitoring configuration will be defined for
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The ID of the host group this monitoring configuration will be defined for
        /// </summary>
        [Input("hostGroup")]
        public Input<string>? HostGroup { get; set; }

        /// <summary>
        /// The name of the Management Zone this monitoring configuration will be defined for
        /// </summary>
        [Input("managementZone")]
        public Input<string>? ManagementZone { get; set; }

        /// <summary>
        /// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `dynatrace.getHubItems`
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The JSON encoded value for this monitoring configuration
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public HubExtensionConfigArgs()
        {
        }
        public static new HubExtensionConfigArgs Empty => new HubExtensionConfigArgs();
    }

    public sealed class HubExtensionConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Active Gate Group this monitoring configuration will be defined for
        /// </summary>
        [Input("activeGateGroup")]
        public Input<string>? ActiveGateGroup { get; set; }

        /// <summary>
        /// The ID of the host this monitoring configuration will be defined for
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The ID of the host group this monitoring configuration will be defined for
        /// </summary>
        [Input("hostGroup")]
        public Input<string>? HostGroup { get; set; }

        /// <summary>
        /// The name of the Management Zone this monitoring configuration will be defined for
        /// </summary>
        [Input("managementZone")]
        public Input<string>? ManagementZone { get; set; }

        /// <summary>
        /// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `dynatrace.getHubItems`
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The JSON encoded value for this monitoring configuration
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public HubExtensionConfigState()
        {
        }
        public static new HubExtensionConfigState Empty => new HubExtensionConfigState();
    }
}
