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
    [DynatraceResourceType("dynatrace:index/processGroupRum:ProcessGroupRum")]
    public partial class ProcessGroupRum : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Allows OneAgent to: * automatically inject the RUM JavaScript tag into each page delivered by this process group *
        /// provide the necessary info to correlate RUM data with server-side PurePaths * forward beacons to the cluster * deliver
        /// the monitoring code
        /// </summary>
        [Output("enable")]
        public Output<bool> Enable { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting - PROCESS_GROUP-XXXXXXXXXXXXXXXX
        /// </summary>
        [Output("processGroupId")]
        public Output<string> ProcessGroupId { get; private set; } = null!;


        /// <summary>
        /// Create a ProcessGroupRum resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProcessGroupRum(string name, ProcessGroupRumArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/processGroupRum:ProcessGroupRum", name, args ?? new ProcessGroupRumArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProcessGroupRum(string name, Input<string> id, ProcessGroupRumState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/processGroupRum:ProcessGroupRum", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ProcessGroupRum resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProcessGroupRum Get(string name, Input<string> id, ProcessGroupRumState? state = null, CustomResourceOptions? options = null)
        {
            return new ProcessGroupRum(name, id, state, options);
        }
    }

    public sealed class ProcessGroupRumArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allows OneAgent to: * automatically inject the RUM JavaScript tag into each page delivered by this process group *
        /// provide the necessary info to correlate RUM data with server-side PurePaths * forward beacons to the cluster * deliver
        /// the monitoring code
        /// </summary>
        [Input("enable", required: true)]
        public Input<bool> Enable { get; set; } = null!;

        /// <summary>
        /// The scope of this setting - PROCESS_GROUP-XXXXXXXXXXXXXXXX
        /// </summary>
        [Input("processGroupId", required: true)]
        public Input<string> ProcessGroupId { get; set; } = null!;

        public ProcessGroupRumArgs()
        {
        }
        public static new ProcessGroupRumArgs Empty => new ProcessGroupRumArgs();
    }

    public sealed class ProcessGroupRumState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allows OneAgent to: * automatically inject the RUM JavaScript tag into each page delivered by this process group *
        /// provide the necessary info to correlate RUM data with server-side PurePaths * forward beacons to the cluster * deliver
        /// the monitoring code
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// The scope of this setting - PROCESS_GROUP-XXXXXXXXXXXXXXXX
        /// </summary>
        [Input("processGroupId")]
        public Input<string>? ProcessGroupId { get; set; }

        public ProcessGroupRumState()
        {
        }
        public static new ProcessGroupRumState Empty => new ProcessGroupRumState();
    }
}
