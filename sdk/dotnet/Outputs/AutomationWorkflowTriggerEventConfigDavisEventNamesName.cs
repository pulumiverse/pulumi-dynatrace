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
    public sealed class AutomationWorkflowTriggerEventConfigDavisEventNamesName
    {
        /// <summary>
        /// Possible values: `equals` and `contains`. The Davis event name must equal or contain the string provided in attribute `name`
        /// </summary>
        public readonly string Match;
        /// <summary>
        /// The event name
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private AutomationWorkflowTriggerEventConfigDavisEventNamesName(
            string match,

            string name)
        {
            Match = match;
            Name = name;
        }
    }
}
