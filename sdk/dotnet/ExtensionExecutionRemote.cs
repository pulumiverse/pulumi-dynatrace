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
    [DynatraceResourceType("dynatrace:index/extensionExecutionRemote:ExtensionExecutionRemote")]
    public partial class ExtensionExecutionRemote : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        /// </summary>
        [Output("performanceProfile")]
        public Output<string> PerformanceProfile { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a ExtensionExecutionRemote resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExtensionExecutionRemote(string name, ExtensionExecutionRemoteArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/extensionExecutionRemote:ExtensionExecutionRemote", name, args ?? new ExtensionExecutionRemoteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExtensionExecutionRemote(string name, Input<string> id, ExtensionExecutionRemoteState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/extensionExecutionRemote:ExtensionExecutionRemote", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ExtensionExecutionRemote resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExtensionExecutionRemote Get(string name, Input<string> id, ExtensionExecutionRemoteState? state = null, CustomResourceOptions? options = null)
        {
            return new ExtensionExecutionRemote(name, id, state, options);
        }
    }

    public sealed class ExtensionExecutionRemoteArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        /// </summary>
        [Input("performanceProfile", required: true)]
        public Input<string> PerformanceProfile { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        public ExtensionExecutionRemoteArgs()
        {
        }
        public static new ExtensionExecutionRemoteArgs Empty => new ExtensionExecutionRemoteArgs();
    }

    public sealed class ExtensionExecutionRemoteState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        /// </summary>
        [Input("performanceProfile")]
        public Input<string>? PerformanceProfile { get; set; }

        /// <summary>
        /// The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public ExtensionExecutionRemoteState()
        {
        }
        public static new ExtensionExecutionRemoteState Empty => new ExtensionExecutionRemoteState();
    }
}
