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

    public sealed class ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionArgs>? _conditions;

        /// <summary>
        /// Attribute conditions
        /// </summary>
        public InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionArgs>());
            set => _conditions = value;
        }

        public ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsArgs()
        {
        }
        public static new ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsArgs Empty => new ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsArgs();
    }
}
