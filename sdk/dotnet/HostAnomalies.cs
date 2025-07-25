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
    [DynatraceResourceType("dynatrace:index/hostAnomalies:HostAnomalies")]
    public partial class HostAnomalies : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Configuration of lost connection detection
        /// </summary>
        [Output("connections")]
        public Output<Outputs.HostAnomaliesConnections?> Connections { get; private set; } = null!;

        /// <summary>
        /// Configuration of high CPU saturation detection
        /// </summary>
        [Output("cpu")]
        public Output<Outputs.HostAnomaliesCpu?> Cpu { get; private set; } = null!;

        /// <summary>
        /// Configuration of disk related anomalies
        /// </summary>
        [Output("disks")]
        public Output<Outputs.HostAnomaliesDisks?> Disks { get; private set; } = null!;

        /// <summary>
        /// Configuration of high Garbage Collector activity detection
        /// </summary>
        [Output("gc")]
        public Output<Outputs.HostAnomaliesGc?> Gc { get; private set; } = null!;

        /// <summary>
        /// Configuration of Java related anomalies
        /// </summary>
        [Output("java")]
        public Output<Outputs.HostAnomaliesJava?> Java { get; private set; } = null!;

        /// <summary>
        /// Configuration of high memory usage detection
        /// </summary>
        [Output("memory")]
        public Output<Outputs.HostAnomaliesMemory?> Memory { get; private set; } = null!;

        /// <summary>
        /// Configuration of network related anomalies
        /// </summary>
        [Output("network")]
        public Output<Outputs.HostAnomaliesNetwork?> Network { get; private set; } = null!;


        /// <summary>
        /// Create a HostAnomalies resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HostAnomalies(string name, HostAnomaliesArgs? args = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/hostAnomalies:HostAnomalies", name, args ?? new HostAnomaliesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HostAnomalies(string name, Input<string> id, HostAnomaliesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/hostAnomalies:HostAnomalies", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing HostAnomalies resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HostAnomalies Get(string name, Input<string> id, HostAnomaliesState? state = null, CustomResourceOptions? options = null)
        {
            return new HostAnomalies(name, id, state, options);
        }
    }

    public sealed class HostAnomaliesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of lost connection detection
        /// </summary>
        [Input("connections")]
        public Input<Inputs.HostAnomaliesConnectionsArgs>? Connections { get; set; }

        /// <summary>
        /// Configuration of high CPU saturation detection
        /// </summary>
        [Input("cpu")]
        public Input<Inputs.HostAnomaliesCpuArgs>? Cpu { get; set; }

        /// <summary>
        /// Configuration of disk related anomalies
        /// </summary>
        [Input("disks")]
        public Input<Inputs.HostAnomaliesDisksArgs>? Disks { get; set; }

        /// <summary>
        /// Configuration of high Garbage Collector activity detection
        /// </summary>
        [Input("gc")]
        public Input<Inputs.HostAnomaliesGcArgs>? Gc { get; set; }

        /// <summary>
        /// Configuration of Java related anomalies
        /// </summary>
        [Input("java")]
        public Input<Inputs.HostAnomaliesJavaArgs>? Java { get; set; }

        /// <summary>
        /// Configuration of high memory usage detection
        /// </summary>
        [Input("memory")]
        public Input<Inputs.HostAnomaliesMemoryArgs>? Memory { get; set; }

        /// <summary>
        /// Configuration of network related anomalies
        /// </summary>
        [Input("network")]
        public Input<Inputs.HostAnomaliesNetworkArgs>? Network { get; set; }

        public HostAnomaliesArgs()
        {
        }
        public static new HostAnomaliesArgs Empty => new HostAnomaliesArgs();
    }

    public sealed class HostAnomaliesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of lost connection detection
        /// </summary>
        [Input("connections")]
        public Input<Inputs.HostAnomaliesConnectionsGetArgs>? Connections { get; set; }

        /// <summary>
        /// Configuration of high CPU saturation detection
        /// </summary>
        [Input("cpu")]
        public Input<Inputs.HostAnomaliesCpuGetArgs>? Cpu { get; set; }

        /// <summary>
        /// Configuration of disk related anomalies
        /// </summary>
        [Input("disks")]
        public Input<Inputs.HostAnomaliesDisksGetArgs>? Disks { get; set; }

        /// <summary>
        /// Configuration of high Garbage Collector activity detection
        /// </summary>
        [Input("gc")]
        public Input<Inputs.HostAnomaliesGcGetArgs>? Gc { get; set; }

        /// <summary>
        /// Configuration of Java related anomalies
        /// </summary>
        [Input("java")]
        public Input<Inputs.HostAnomaliesJavaGetArgs>? Java { get; set; }

        /// <summary>
        /// Configuration of high memory usage detection
        /// </summary>
        [Input("memory")]
        public Input<Inputs.HostAnomaliesMemoryGetArgs>? Memory { get; set; }

        /// <summary>
        /// Configuration of network related anomalies
        /// </summary>
        [Input("network")]
        public Input<Inputs.HostAnomaliesNetworkGetArgs>? Network { get; set; }

        public HostAnomaliesState()
        {
        }
        public static new HostAnomaliesState Empty => new HostAnomaliesState();
    }
}
