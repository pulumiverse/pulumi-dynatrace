// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
