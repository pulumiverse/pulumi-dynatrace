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

    public sealed class ManagementZoneV2RulesRuleDimensionRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `ANY`, `LOG`, `METRIC`
        /// </summary>
        [Input("appliesTo", required: true)]
        public Input<string> AppliesTo { get; set; } = null!;

        /// <summary>
        /// Conditions
        /// </summary>
        [Input("dimensionConditions")]
        public Input<Inputs.ManagementZoneV2RulesRuleDimensionRuleDimensionConditionsArgs>? DimensionConditions { get; set; }

        public ManagementZoneV2RulesRuleDimensionRuleArgs()
        {
        }
        public static new ManagementZoneV2RulesRuleDimensionRuleArgs Empty => new ManagementZoneV2RulesRuleDimensionRuleArgs();
    }
}
