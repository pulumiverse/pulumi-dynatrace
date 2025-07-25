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

    public sealed class WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsConditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Must be a defined placeholder wrapped in curly braces
        /// </summary>
        [Input("operand1", required: true)]
        public Input<string> Operand1 { get; set; } = null!;

        /// <summary>
        /// Must be null if operator is `IS_EMPTY`, a regex if operator is `MATCHES_REGULAR_ERPRESSION`. In all other cases the value can be a freetext or a placeholder wrapped in curly braces
        /// </summary>
        [Input("operand2")]
        public Input<string>? Operand2 { get; set; }

        /// <summary>
        /// The operator of the condition. Possible values are `CONTAINS`, `ENDS_WITH`, `EQUALS`, `IS_EMPTY`, `IS_NOT_EMPTY`, `MATCHES_REGULAR_EXPRESSION`, `NOT_CONTAINS`, `NOT_ENDS_WITH`, `NOT_EQUALS`, `NOT_MATCHES_REGULAR_EXPRESSION`, `NOT_STARTS_WITH` and `STARTS_WITH`.
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        public WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsConditionGetArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsConditionGetArgs Empty => new WebApplicationUserActionNamingSettingsCustomActionNamingRulesRuleConditionsConditionGetArgs();
    }
}
