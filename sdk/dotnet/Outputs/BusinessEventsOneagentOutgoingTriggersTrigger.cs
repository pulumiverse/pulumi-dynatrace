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
    public sealed class BusinessEventsOneagentOutgoingTriggersTrigger
    {
        /// <summary>
        /// Case sensitive
        /// </summary>
        public readonly bool? CaseSensitive;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.BusinessEventsOneagentOutgoingTriggersTriggerSource Source;
        /// <summary>
        /// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `EXISTS`, `N_CONTAINS`, `N_ENDS_WITH`, `N_EQUALS`, `N_EXISTS`, `N_STARTS_WITH`, `STARTS_WITH`
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private BusinessEventsOneagentOutgoingTriggersTrigger(
            bool? caseSensitive,

            Outputs.BusinessEventsOneagentOutgoingTriggersTriggerSource source,

            string type,

            string? value)
        {
            CaseSensitive = caseSensitive;
            Source = source;
            Type = type;
            Value = value;
        }
    }
}
