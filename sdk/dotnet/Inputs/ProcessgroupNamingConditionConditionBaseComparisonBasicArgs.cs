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

    public sealed class ProcessgroupNamingConditionConditionBaseComparisonBasicArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reverses the operator. For example it turns EQUALS into DOES NOT EQUAL
        /// </summary>
        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        /// <summary>
        /// The type of comparison
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Any attributes that aren't yet supported by this provider but have meanwhile gotten introduced by a newer version of the Dynatrace REST API
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public ProcessgroupNamingConditionConditionBaseComparisonBasicArgs()
        {
        }
        public static new ProcessgroupNamingConditionConditionBaseComparisonBasicArgs Empty => new ProcessgroupNamingConditionConditionBaseComparisonBasicArgs();
    }
}
