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

    public sealed class DiscoveryDefaultRulesRuleActionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.DiscoveryDefaultRulesRuleActionsActionGetArgs>? _actions;
        public InputList<Inputs.DiscoveryDefaultRulesRuleActionsActionGetArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.DiscoveryDefaultRulesRuleActionsActionGetArgs>());
            set => _actions = value;
        }

        public DiscoveryDefaultRulesRuleActionsGetArgs()
        {
        }
        public static new DiscoveryDefaultRulesRuleActionsGetArgs Empty => new DiscoveryDefaultRulesRuleActionsGetArgs();
    }
}
