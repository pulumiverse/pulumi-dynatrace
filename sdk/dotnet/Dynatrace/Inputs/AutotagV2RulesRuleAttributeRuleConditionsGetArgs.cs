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

    public sealed class AutotagV2RulesRuleAttributeRuleConditionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.AutotagV2RulesRuleAttributeRuleConditionsConditionGetArgs>? _conditions;
        public InputList<Inputs.AutotagV2RulesRuleAttributeRuleConditionsConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.AutotagV2RulesRuleAttributeRuleConditionsConditionGetArgs>());
            set => _conditions = value;
        }

        public AutotagV2RulesRuleAttributeRuleConditionsGetArgs()
        {
        }
        public static new AutotagV2RulesRuleAttributeRuleConditionsGetArgs Empty => new AutotagV2RulesRuleAttributeRuleConditionsGetArgs();
    }
}