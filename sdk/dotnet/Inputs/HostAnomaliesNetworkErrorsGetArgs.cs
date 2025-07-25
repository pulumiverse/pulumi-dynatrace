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

    public sealed class HostAnomaliesNetworkErrorsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Custom thresholds for network errors. If not set, automatic mode is used.   **All** of these conditions must be met to trigger an alert
        /// </summary>
        [Input("thresholds")]
        public Input<Inputs.HostAnomaliesNetworkErrorsThresholdsGetArgs>? Thresholds { get; set; }

        public HostAnomaliesNetworkErrorsGetArgs()
        {
        }
        public static new HostAnomaliesNetworkErrorsGetArgs Empty => new HostAnomaliesNetworkErrorsGetArgs();
    }
}
