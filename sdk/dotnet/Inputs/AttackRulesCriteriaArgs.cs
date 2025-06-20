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

    public sealed class AttackRulesCriteriaArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `ANY`, `CMD_INJECTION`, `JNDI_INJECTION`, `SQL_INJECTION`, `SSRF`
        /// </summary>
        [Input("attackType", required: true)]
        public Input<string> AttackType { get; set; } = null!;

        /// <summary>
        /// Process group
        /// </summary>
        [Input("processGroup")]
        public Input<string>? ProcessGroup { get; set; }

        public AttackRulesCriteriaArgs()
        {
        }
        public static new AttackRulesCriteriaArgs Empty => new AttackRulesCriteriaArgs();
    }
}
