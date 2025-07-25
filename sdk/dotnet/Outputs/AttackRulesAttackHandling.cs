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
    public sealed class AttackRulesAttackHandling
    {
        /// <summary>
        /// Possible Values: `BLOCK`, `MONITOR`, `OFF`
        /// </summary>
        public readonly string BlockingStrategy;

        [OutputConstructor]
        private AttackRulesAttackHandling(string blockingStrategy)
        {
            BlockingStrategy = blockingStrategy;
        }
    }
}
