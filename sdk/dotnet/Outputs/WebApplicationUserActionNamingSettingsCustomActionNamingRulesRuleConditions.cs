// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditions
    {
        /// <summary>
        /// Defines the conditions when the naming rule should apply
        /// </summary>
        public readonly ImmutableArray<Outputs.WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsCondition> Conditions;

        [OutputConstructor]
        private WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditions(ImmutableArray<Outputs.WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsCondition> conditions)
        {
            Conditions = conditions;
        }
    }
}
