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
    public sealed class AutomationWorkflowTriggerEventConfig
    {
        /// <summary>
        /// Contains trigger configuration based on Davis Events. Either `davis_event`, `davis_problem`, `davis_event` or `config` need to set
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerEventConfigDavisEvent? DavisEvent;
        /// <summary>
        /// Contains trigger configuration based on Davis Problems. Either `davis_event`, `davis_problem`, `davis_event` or `config` need to set
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerEventConfigDavisProblem? DavisProblem;
        /// <summary>
        /// Contains trigger configuration based on Davis Problems. Either `davis_event`, `davis_problem`, `davis_event` or `config` need to set
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerEventConfigEvent? Event;
        /// <summary>
        /// The type of the trigger configuration to expect within attribute `value`. Only required if `config` is set. Must not be set if `davis_event`, `davis_problem` or `event` are present
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Contains JSON encoded trigger configuration if the trigger type is neither `davis_event`, `davis_problem` or `event`. It requires the attribute `type` to be set in combination
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private AutomationWorkflowTriggerEventConfig(
            Outputs.AutomationWorkflowTriggerEventConfigDavisEvent? davisEvent,

            Outputs.AutomationWorkflowTriggerEventConfigDavisProblem? davisProblem,

            Outputs.AutomationWorkflowTriggerEventConfigEvent? @event,

            string? type,

            string? value)
        {
            DavisEvent = davisEvent;
            DavisProblem = davisProblem;
            Event = @event;
            Type = type;
            Value = value;
        }
    }
}
