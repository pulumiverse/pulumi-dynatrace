// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class BrowserMonitorScriptConfigurationBandwidth
    {
        /// <summary>
        /// The download speed of the network, in bytes per second
        /// </summary>
        public readonly int? Download;
        /// <summary>
        /// The latency of the network, in milliseconds
        /// </summary>
        public readonly int? Latency;
        /// <summary>
        /// The type of the preconfigured network—when editing in the browser, press `Crtl+Spacebar` to see the list of available networks
        /// </summary>
        public readonly string? NetworkType;
        /// <summary>
        /// The upload speed of the network, in bytes per second
        /// </summary>
        public readonly int? Upload;

        [OutputConstructor]
        private BrowserMonitorScriptConfigurationBandwidth(
            int? download,

            int? latency,

            string? networkType,

            int? upload)
        {
            Download = download;
            Latency = latency;
            NetworkType = networkType;
            Upload = upload;
        }
    }
}