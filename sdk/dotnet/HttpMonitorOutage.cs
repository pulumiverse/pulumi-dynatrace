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
    [DynatraceResourceType("dynatrace:index/httpMonitorOutage:HttpMonitorOutage")]
    public partial class HttpMonitorOutage : global::Pulumi.CustomResource
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if all locations are unable to access my web application
        /// </summary>
        [Output("globalConsecutiveOutageCountThreshold")]
        public Output<int?> GlobalConsecutiveOutageCountThreshold { get; private set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable at all configured locations.
        /// </summary>
        [Output("globalOutages")]
        public Output<bool> GlobalOutages { get; private set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) are unable to access my web application
        /// </summary>
        [Output("localConsecutiveOutageCountThreshold")]
        public Output<int?> LocalConsecutiveOutageCountThreshold { get; private set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if at least
        /// </summary>
        [Output("localLocationOutageCountThreshold")]
        public Output<int?> LocalLocationOutageCountThreshold { get; private set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable for one or more consecutive runs at any location.
        /// </summary>
        [Output("localOutages")]
        public Output<bool> LocalOutages { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HTTP_CHECK). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a HttpMonitorOutage resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HttpMonitorOutage(string name, HttpMonitorOutageArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/httpMonitorOutage:HttpMonitorOutage", name, args ?? new HttpMonitorOutageArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HttpMonitorOutage(string name, Input<string> id, HttpMonitorOutageState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/httpMonitorOutage:HttpMonitorOutage", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing HttpMonitorOutage resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HttpMonitorOutage Get(string name, Input<string> id, HttpMonitorOutageState? state = null, CustomResourceOptions? options = null)
        {
            return new HttpMonitorOutage(name, id, state, options);
        }
    }

    public sealed class HttpMonitorOutageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if all locations are unable to access my web application
        /// </summary>
        [Input("globalConsecutiveOutageCountThreshold")]
        public Input<int>? GlobalConsecutiveOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable at all configured locations.
        /// </summary>
        [Input("globalOutages", required: true)]
        public Input<bool> GlobalOutages { get; set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) are unable to access my web application
        /// </summary>
        [Input("localConsecutiveOutageCountThreshold")]
        public Input<int>? LocalConsecutiveOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if at least
        /// </summary>
        [Input("localLocationOutageCountThreshold")]
        public Input<int>? LocalLocationOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable for one or more consecutive runs at any location.
        /// </summary>
        [Input("localOutages", required: true)]
        public Input<bool> LocalOutages { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (HTTP_CHECK). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public HttpMonitorOutageArgs()
        {
        }
        public static new HttpMonitorOutageArgs Empty => new HttpMonitorOutageArgs();
    }

    public sealed class HttpMonitorOutageState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if all locations are unable to access my web application
        /// </summary>
        [Input("globalConsecutiveOutageCountThreshold")]
        public Input<int>? GlobalConsecutiveOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable at all configured locations.
        /// </summary>
        [Input("globalOutages")]
        public Input<bool>? GlobalOutages { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) are unable to access my web application
        /// </summary>
        [Input("localConsecutiveOutageCountThreshold")]
        public Input<int>? LocalConsecutiveOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Alert if at least
        /// </summary>
        [Input("localLocationOutageCountThreshold")]
        public Input<int>? LocalLocationOutageCountThreshold { get; set; }

        /// <summary>
        /// (Field has overlap with `dynatrace.HttpMonitor`) Generate a problem and send an alert when the monitor is unavailable for one or more consecutive runs at any location.
        /// </summary>
        [Input("localOutages")]
        public Input<bool>? LocalOutages { get; set; }

        /// <summary>
        /// The scope of this setting (HTTP_CHECK). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public HttpMonitorOutageState()
        {
        }
        public static new HttpMonitorOutageState Empty => new HttpMonitorOutageState();
    }
}