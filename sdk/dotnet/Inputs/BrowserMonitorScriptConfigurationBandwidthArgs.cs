// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class BrowserMonitorScriptConfigurationBandwidthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The download speed of the network, in bytes per second
        /// </summary>
        [Input("download")]
        public Input<int>? Download { get; set; }

        /// <summary>
        /// The latency of the network, in milliseconds
        /// </summary>
        [Input("latency")]
        public Input<int>? Latency { get; set; }

        /// <summary>
        /// The type of the preconfigured network—when editing in the browser, press `Crtl+Spacebar` to see the list of available networks
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        /// <summary>
        /// The upload speed of the network, in bytes per second
        /// </summary>
        [Input("upload")]
        public Input<int>? Upload { get; set; }

        public BrowserMonitorScriptConfigurationBandwidthArgs()
        {
        }
        public static new BrowserMonitorScriptConfigurationBandwidthArgs Empty => new BrowserMonitorScriptConfigurationBandwidthArgs();
    }
}
