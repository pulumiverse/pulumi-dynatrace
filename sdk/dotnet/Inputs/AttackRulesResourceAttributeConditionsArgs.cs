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

    public sealed class AttackRulesResourceAttributeConditionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("resourceAttributeConditions", required: true)]
        private InputList<Inputs.AttackRulesResourceAttributeConditionsResourceAttributeConditionArgs>? _resourceAttributeConditions;
        public InputList<Inputs.AttackRulesResourceAttributeConditionsResourceAttributeConditionArgs> ResourceAttributeConditions
        {
            get => _resourceAttributeConditions ?? (_resourceAttributeConditions = new InputList<Inputs.AttackRulesResourceAttributeConditionsResourceAttributeConditionArgs>());
            set => _resourceAttributeConditions = value;
        }

        public AttackRulesResourceAttributeConditionsArgs()
        {
        }
        public static new AttackRulesResourceAttributeConditionsArgs Empty => new AttackRulesResourceAttributeConditionsArgs();
    }
}