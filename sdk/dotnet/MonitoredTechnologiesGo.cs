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
    [DynatraceResourceType("dynatrace:index/monitoredTechnologiesGo:MonitoredTechnologiesGo")]
    public partial class MonitoredTechnologiesGo : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Learn more about the [known limitations for Go static monitoring](https://www.dynatrace.com/support/help/technology-support/application-software/go/support/go-known-limitations#limitations)
        /// </summary>
        [Output("enabledGoStaticMonitoring")]
        public Output<bool?> EnabledGoStaticMonitoring { get; private set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("hostId")]
        public Output<string?> HostId { get; private set; } = null!;


        /// <summary>
        /// Create a MonitoredTechnologiesGo resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MonitoredTechnologiesGo(string name, MonitoredTechnologiesGoArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/monitoredTechnologiesGo:MonitoredTechnologiesGo", name, args ?? new MonitoredTechnologiesGoArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MonitoredTechnologiesGo(string name, Input<string> id, MonitoredTechnologiesGoState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/monitoredTechnologiesGo:MonitoredTechnologiesGo", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MonitoredTechnologiesGo resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MonitoredTechnologiesGo Get(string name, Input<string> id, MonitoredTechnologiesGoState? state = null, CustomResourceOptions? options = null)
        {
            return new MonitoredTechnologiesGo(name, id, state, options);
        }
    }

    public sealed class MonitoredTechnologiesGoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Learn more about the [known limitations for Go static monitoring](https://www.dynatrace.com/support/help/technology-support/application-software/go/support/go-known-limitations#limitations)
        /// </summary>
        [Input("enabledGoStaticMonitoring")]
        public Input<bool>? EnabledGoStaticMonitoring { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        public MonitoredTechnologiesGoArgs()
        {
        }
        public static new MonitoredTechnologiesGoArgs Empty => new MonitoredTechnologiesGoArgs();
    }

    public sealed class MonitoredTechnologiesGoState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Learn more about the [known limitations for Go static monitoring](https://www.dynatrace.com/support/help/technology-support/application-software/go/support/go-known-limitations#limitations)
        /// </summary>
        [Input("enabledGoStaticMonitoring")]
        public Input<bool>? EnabledGoStaticMonitoring { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        public MonitoredTechnologiesGoState()
        {
        }
        public static new MonitoredTechnologiesGoState Empty => new MonitoredTechnologiesGoState();
    }
}
