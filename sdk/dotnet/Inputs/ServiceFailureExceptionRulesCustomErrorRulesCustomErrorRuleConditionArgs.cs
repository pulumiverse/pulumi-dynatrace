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

    public sealed class ServiceFailureExceptionRulesCustomErrorRulesCustomErrorRuleConditionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Case sensitive
        /// </summary>
        [Input("caseSensitive")]
        public Input<bool>? CaseSensitive { get; set; }

        /// <summary>
        /// Apply this comparison
        /// </summary>
        [Input("compareOperationType", required: true)]
        public Input<string> CompareOperationType { get; set; } = null!;

        /// <summary>
        /// Value
        /// </summary>
        [Input("doubleValue")]
        public Input<double>? DoubleValue { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [Input("intValue")]
        public Input<int>? IntValue { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [Input("textValue")]
        public Input<string>? TextValue { get; set; }

        public ServiceFailureExceptionRulesCustomErrorRulesCustomErrorRuleConditionArgs()
        {
        }
        public static new ServiceFailureExceptionRulesCustomErrorRulesCustomErrorRuleConditionArgs Empty => new ServiceFailureExceptionRulesCustomErrorRulesCustomErrorRuleConditionArgs();
    }
}
