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

    public sealed class DiscoveryDefaultRulesSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("muted", required: true)]
        public Input<bool> Muted { get; set; } = null!;

        public DiscoveryDefaultRulesSettingsArgs()
        {
        }
        public static new DiscoveryDefaultRulesSettingsArgs Empty => new DiscoveryDefaultRulesSettingsArgs();
    }
}
