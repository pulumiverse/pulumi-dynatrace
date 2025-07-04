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

    public sealed class RequestNamingConditionsConditionComparisonStringRequestAttributeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The comparison is case-sensitive (`true`) or not case-sensitive (`false`)
        /// </summary>
        [Input("caseSensitive")]
        public Input<bool>? CaseSensitive { get; set; }

        /// <summary>
        /// If `true`, the request attribute is matched on child service calls. Default is `false`
        /// </summary>
        [Input("matchOnChildCalls")]
        public Input<bool>? MatchOnChildCalls { get; set; }

        /// <summary>
        /// Operator of the comparison. You can reverse it by setting `negate` to `true`. Possible values are `BEGINS_WITH`, `BEGINS_WITH_ANY_OF`, `CONTAINS`, `ENDS_WITH`, `ENDS_WITH_ANY_OF`, `EQUALS`, `EQUALS_ANY_OF`, `EXISTS` and `REGEX_MATCHES`
        /// </summary>
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        /// <summary>
        /// No documentation available for this attribute
        /// </summary>
        [Input("requestAttribute", required: true)]
        public Input<string> RequestAttribute { get; set; } = null!;

        /// <summary>
        /// Defines valid sources of request attributes for conditions or placeholders
        /// </summary>
        [Input("source")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonStringRequestAttributeSourceGetArgs>? Source { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The value to compare to
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// The values to compare to
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public RequestNamingConditionsConditionComparisonStringRequestAttributeGetArgs()
        {
        }
        public static new RequestNamingConditionsConditionComparisonStringRequestAttributeGetArgs Empty => new RequestNamingConditionsConditionComparisonStringRequestAttributeGetArgs();
    }
}
