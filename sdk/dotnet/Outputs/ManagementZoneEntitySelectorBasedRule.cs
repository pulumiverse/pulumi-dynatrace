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
    public sealed class ManagementZoneEntitySelectorBasedRule
    {
        /// <summary>
        /// The rule is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The entity selector string, by which the entities are selected
        /// </summary>
        public readonly string? Selector;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private ManagementZoneEntitySelectorBasedRule(
            bool? enabled,

            string? selector,

            string? unknowns)
        {
            Enabled = enabled;
            Selector = selector;
            Unknowns = unknowns;
        }
    }
}
