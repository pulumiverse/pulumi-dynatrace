// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class CalculatedServiceMetricConditionConditionComparison
    {
        /// <summary>
        /// Boolean Comparison for `BOOLEAN` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonBoolean? Boolean;
        /// <summary>
        /// Type-specific comparison information for attributes of type 'ESB_INPUT_NODE_TYPE'
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonEsbInputNodeType? EsbInputNodeType;
        /// <summary>
        /// Comparison for `FAILED_STATE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonFailedState? FailedState;
        /// <summary>
        /// Comparison for `FAILURE_REASON` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonFailureReason? FailureReason;
        /// <summary>
        /// Comparison for `FAST_STRING` attributes. Use it for all service property attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonFastString? FastString;
        /// <summary>
        /// Comparison for `FLAW_STATE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonFlawState? FlawState;
        /// <summary>
        /// Comparison for `NUMBER` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonGeneric? Generic;
        /// <summary>
        /// Comparison for `HTTP_METHOD` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonHttpMethod? HttpMethod;
        /// <summary>
        /// Comparison for `HTTP_STATUS_CLASS` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonHttpStatusClass? HttpStatusClass;
        /// <summary>
        /// Comparison for `IIB_INPUT_NODE_TYPE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonIibInputNodeType? IibInputNodeType;
        /// <summary>
        /// Reverse the comparison **operator**. For example, it turns **equals** into **does not equal**
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// Comparison for `NUMBER` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonNumber? Number;
        /// <summary>
        /// Comparison for `NUMBER_REQUEST_ATTRIBUTE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonNumberRequestAttribute? NumberRequestAttribute;
        /// <summary>
        /// Comparison for `SERVICE_TYPE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonServiceType? ServiceType;
        /// <summary>
        /// Comparison for `STRING` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonString? String;
        /// <summary>
        /// Comparison for `STRING_REQUEST_ATTRIBUTE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonStringRequestAttribute? StringRequestAttribute;
        /// <summary>
        /// Comparison for `TAG` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonTag? Tag;
        /// <summary>
        /// Comparison for `ZOS_CALL_TYPE` attributes
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonZosCallType? ZosCallType;

        [OutputConstructor]
        private CalculatedServiceMetricConditionConditionComparison(
            Outputs.CalculatedServiceMetricConditionConditionComparisonBoolean? boolean,

            Outputs.CalculatedServiceMetricConditionConditionComparisonEsbInputNodeType? esbInputNodeType,

            Outputs.CalculatedServiceMetricConditionConditionComparisonFailedState? failedState,

            Outputs.CalculatedServiceMetricConditionConditionComparisonFailureReason? failureReason,

            Outputs.CalculatedServiceMetricConditionConditionComparisonFastString? fastString,

            Outputs.CalculatedServiceMetricConditionConditionComparisonFlawState? flawState,

            Outputs.CalculatedServiceMetricConditionConditionComparisonGeneric? generic,

            Outputs.CalculatedServiceMetricConditionConditionComparisonHttpMethod? httpMethod,

            Outputs.CalculatedServiceMetricConditionConditionComparisonHttpStatusClass? httpStatusClass,

            Outputs.CalculatedServiceMetricConditionConditionComparisonIibInputNodeType? iibInputNodeType,

            bool? negate,

            Outputs.CalculatedServiceMetricConditionConditionComparisonNumber? number,

            Outputs.CalculatedServiceMetricConditionConditionComparisonNumberRequestAttribute? numberRequestAttribute,

            Outputs.CalculatedServiceMetricConditionConditionComparisonServiceType? serviceType,

            Outputs.CalculatedServiceMetricConditionConditionComparisonString? @string,

            Outputs.CalculatedServiceMetricConditionConditionComparisonStringRequestAttribute? stringRequestAttribute,

            Outputs.CalculatedServiceMetricConditionConditionComparisonTag? tag,

            Outputs.CalculatedServiceMetricConditionConditionComparisonZosCallType? zosCallType)
        {
            Boolean = boolean;
            EsbInputNodeType = esbInputNodeType;
            FailedState = failedState;
            FailureReason = failureReason;
            FastString = fastString;
            FlawState = flawState;
            Generic = generic;
            HttpMethod = httpMethod;
            HttpStatusClass = httpStatusClass;
            IibInputNodeType = iibInputNodeType;
            Negate = negate;
            Number = number;
            NumberRequestAttribute = numberRequestAttribute;
            ServiceType = serviceType;
            String = @string;
            StringRequestAttribute = stringRequestAttribute;
            Tag = tag;
            ZosCallType = zosCallType;
        }
    }
}
