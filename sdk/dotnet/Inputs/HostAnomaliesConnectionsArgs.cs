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

    public sealed class HostAnomaliesConnectionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Alert (`true`) on graceful host shutdowns
        /// </summary>
        [Input("enabledOnGracefulShutdowns", required: true)]
        public Input<bool> EnabledOnGracefulShutdowns { get; set; } = null!;

        public HostAnomaliesConnectionsArgs()
        {
        }
        public static new HostAnomaliesConnectionsArgs Empty => new HostAnomaliesConnectionsArgs();
    }
}
