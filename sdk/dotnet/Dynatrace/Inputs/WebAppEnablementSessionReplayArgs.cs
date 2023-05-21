// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class WebAppEnablementSessionReplayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.WebApplication`) [Percentage of user sessions recorded with Session Replay](https://dt-url.net/sr-cost-traffic-control). For example, if you have 50% for RUM and 50% for Session Replay, it results in 25% of sessions recorded with Session Replay.
        /// </summary>
        [Input("costAndTrafficControl", required: true)]
        public Input<int> CostAndTrafficControl { get; set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.WebApplication`) This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public WebAppEnablementSessionReplayArgs()
        {
        }
        public static new WebAppEnablementSessionReplayArgs Empty => new WebAppEnablementSessionReplayArgs();
    }
}