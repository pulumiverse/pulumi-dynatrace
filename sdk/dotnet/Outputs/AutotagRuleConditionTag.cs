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
    public sealed class AutotagRuleConditionTag
    {
        /// <summary>
        /// Reverses the operator. For example it turns the **begins with** into **does not begin with**
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// Operator of the comparison. Possible values are EQUALS and TAG_KEY_EQUALS. You can reverse it by setting **negate** to `true`
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// Tag of a Dynatrace entity
        /// </summary>
        public readonly Outputs.AutotagRuleConditionTagValue? Value;

        [OutputConstructor]
        private AutotagRuleConditionTag(
            bool? negate,

            string @operator,

            string? unknowns,

            Outputs.AutotagRuleConditionTagValue? value)
        {
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
