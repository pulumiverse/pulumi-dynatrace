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
    [DynatraceResourceType("dynatrace:index/webAppJavascriptUpdates:WebAppJavascriptUpdates")]
    public partial class WebAppJavascriptUpdates : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("applicationId")]
        public Output<string?> ApplicationId { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `CUSTOM`, `LATEST_IE7_10_SUPPORTED`, `LATEST_STABLE`, `PREVIOUS_STABLE`
        /// </summary>
        [Output("javascriptVersion")]
        public Output<string> JavascriptVersion { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppJavascriptUpdates resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppJavascriptUpdates(string name, WebAppJavascriptUpdatesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppJavascriptUpdates:WebAppJavascriptUpdates", name, args ?? new WebAppJavascriptUpdatesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppJavascriptUpdates(string name, Input<string> id, WebAppJavascriptUpdatesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppJavascriptUpdates:WebAppJavascriptUpdates", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WebAppJavascriptUpdates resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppJavascriptUpdates Get(string name, Input<string> id, WebAppJavascriptUpdatesState? state = null, CustomResourceOptions? options = null)
        {
            return new WebAppJavascriptUpdates(name, id, state, options);
        }
    }

    public sealed class WebAppJavascriptUpdatesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// Possible Values: `CUSTOM`, `LATEST_IE7_10_SUPPORTED`, `LATEST_STABLE`, `PREVIOUS_STABLE`
        /// </summary>
        [Input("javascriptVersion", required: true)]
        public Input<string> JavascriptVersion { get; set; } = null!;

        public WebAppJavascriptUpdatesArgs()
        {
        }
        public static new WebAppJavascriptUpdatesArgs Empty => new WebAppJavascriptUpdatesArgs();
    }

    public sealed class WebAppJavascriptUpdatesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// Possible Values: `CUSTOM`, `LATEST_IE7_10_SUPPORTED`, `LATEST_STABLE`, `PREVIOUS_STABLE`
        /// </summary>
        [Input("javascriptVersion")]
        public Input<string>? JavascriptVersion { get; set; }

        public WebAppJavascriptUpdatesState()
        {
        }
        public static new WebAppJavascriptUpdatesState Empty => new WebAppJavascriptUpdatesState();
    }
}