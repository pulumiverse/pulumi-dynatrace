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

    public sealed class DiscoveryDefaultRulesRuleActionsActionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instant action
        /// </summary>
        [Input("instantAction")]
        public Input<bool>? InstantAction { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("parameters")]
        public Input<Inputs.DiscoveryDefaultRulesRuleActionsActionParametersGetArgs>? Parameters { get; set; }

        public DiscoveryDefaultRulesRuleActionsActionGetArgs()
        {
        }
        public static new DiscoveryDefaultRulesRuleActionsActionGetArgs Empty => new DiscoveryDefaultRulesRuleActionsActionGetArgs();
    }
}
