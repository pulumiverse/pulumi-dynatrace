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
    public sealed class ServiceNamingConditionConditionIndexedTagComparison
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
        /// if specified, needs to be INDEXED_TAG
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider but have meanwhile gotten introduced by a newer version of the Dynatrace REST API
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// Tag of a Dynatrace entity
        /// </summary>
        public readonly Outputs.ServiceNamingConditionConditionIndexedTagComparisonValue? Value;

        [OutputConstructor]
        private ServiceNamingConditionConditionIndexedTagComparison(
            bool? negate,

            string @operator,

            string? type,

            string? unknowns,

            Outputs.ServiceNamingConditionConditionIndexedTagComparisonValue? value)
        {
            Negate = negate;
            Operator = @operator;
            Type = type;
            Unknowns = unknowns;
            Value = value;
        }
    }
}