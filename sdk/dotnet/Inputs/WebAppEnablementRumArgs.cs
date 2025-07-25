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

    public sealed class WebAppEnablementRumArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.WebApplication`) Percentage of user sessions captured and analyzed
        /// </summary>
        [Input("costAndTrafficControl", required: true)]
        public Input<int> CostAndTrafficControl { get; set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.WebApplication`) This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Enable Real User Monitoring powered by Grail
        /// </summary>
        [Input("enabledOnGrail")]
        public Input<bool>? EnabledOnGrail { get; set; }

        public WebAppEnablementRumArgs()
        {
        }
        public static new WebAppEnablementRumArgs Empty => new WebAppEnablementRumArgs();
    }
}
