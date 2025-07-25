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

    public sealed class ManagementZoneV2RulesRuleDimensionRuleDimensionConditionsConditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `DIMENSION`, `LOG_FILE_NAME`, `METRIC_KEY`
        /// </summary>
        [Input("conditionType", required: true)]
        public Input<string> ConditionType { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Possible Values: `BEGINS_WITH`, `EQUALS`
        /// </summary>
        [Input("ruleMatcher", required: true)]
        public Input<string> RuleMatcher { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ManagementZoneV2RulesRuleDimensionRuleDimensionConditionsConditionGetArgs()
        {
        }
        public static new ManagementZoneV2RulesRuleDimensionRuleDimensionConditionsConditionGetArgs Empty => new ManagementZoneV2RulesRuleDimensionRuleDimensionConditionsConditionGetArgs();
    }
}
