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
    public sealed class ServiceFullWebRequestConditionsCondition
    {
        /// <summary>
        /// Take the value of this attribute
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// Apply this operation
        /// </summary>
        public readonly string CompareOperationType;
        /// <summary>
        /// Technology
        /// </summary>
        public readonly ImmutableArray<string> Frameworks;
        /// <summary>
        /// Ignore case sensitivity for texts.
        /// </summary>
        public readonly bool? IgnoreCase;
        /// <summary>
        /// Value
        /// </summary>
        public readonly int? IntValue;
        /// <summary>
        /// Values
        /// </summary>
        public readonly ImmutableArray<int> IntValues;
        /// <summary>
        /// From
        /// </summary>
        public readonly string? IpRangeFrom;
        /// <summary>
        /// To
        /// </summary>
        public readonly string? IpRangeTo;
        /// <summary>
        /// If multiple values are specified, at least one of them must match for the condition to match
        /// </summary>
        public readonly ImmutableArray<string> TagValues;
        /// <summary>
        /// If multiple values are specified, at least one of them must match for the condition to match
        /// </summary>
        public readonly ImmutableArray<string> TextValues;

        [OutputConstructor]
        private ServiceFullWebRequestConditionsCondition(
            string attribute,

            string compareOperationType,

            ImmutableArray<string> frameworks,

            bool? ignoreCase,

            int? intValue,

            ImmutableArray<int> intValues,

            string? ipRangeFrom,

            string? ipRangeTo,

            ImmutableArray<string> tagValues,

            ImmutableArray<string> textValues)
        {
            Attribute = attribute;
            CompareOperationType = compareOperationType;
            Frameworks = frameworks;
            IgnoreCase = ignoreCase;
            IntValue = intValue;
            IntValues = intValues;
            IpRangeFrom = ipRangeFrom;
            IpRangeTo = ipRangeTo;
            TagValues = tagValues;
            TextValues = textValues;
        }
    }
}
