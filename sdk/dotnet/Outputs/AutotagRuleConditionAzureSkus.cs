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
    public sealed class AutotagRuleConditionAzureSkus
    {
        /// <summary>
        /// Reverses the operator. For example it turns EQUALS into DOES NOT EQUAL
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// Either EQUALS or EXISTS. You can reverse it by setting **negate** to `true`
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// The value to compare to. Possible values are BASIC, DYNAMIC, FREE, PREMIUM, SHARED and STANDARD.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private AutotagRuleConditionAzureSkus(
            bool? negate,

            string @operator,

            string? unknowns,

            string? value)
        {
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
