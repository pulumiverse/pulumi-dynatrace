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
    public sealed class DiscoveryDefaultRulesRuleActionsAction
    {
        /// <summary>
        /// Instant action
        /// </summary>
        public readonly bool? InstantAction;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.DiscoveryDefaultRulesRuleActionsActionParameters? Parameters;

        [OutputConstructor]
        private DiscoveryDefaultRulesRuleActionsAction(
            bool? instantAction,

            string name,

            Outputs.DiscoveryDefaultRulesRuleActionsActionParameters? parameters)
        {
            InstantAction = instantAction;
            Name = name;
            Parameters = parameters;
        }
    }
}
