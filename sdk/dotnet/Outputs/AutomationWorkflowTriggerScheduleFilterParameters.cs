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
    public sealed class AutomationWorkflowTriggerScheduleFilterParameters
    {
        /// <summary>
        /// If specified, the schedule will end triggering executions af the given amount of executions. Minimum: 1, Maximum: 10
        /// </summary>
        public readonly int? Count;
        /// <summary>
        /// If specified, the schedule won't trigger executions before the given date
        /// </summary>
        public readonly string? EarliestStart;
        /// <summary>
        /// If specified, the schedule won't trigger executions before the given time
        /// </summary>
        public readonly string? EarliestStartTime;
        /// <summary>
        /// If specified, the schedule won't trigger exeuctions on the given dates
        /// </summary>
        public readonly ImmutableArray<string> ExcludeDates;
        /// <summary>
        /// If specified, the schedule will trigger executions on the given dates, even if the main configuration prohibits it
        /// </summary>
        public readonly ImmutableArray<string> IncludeDates;
        /// <summary>
        /// If specified, the schedule won't trigger executions after the given date
        /// </summary>
        public readonly string? Until;

        [OutputConstructor]
        private AutomationWorkflowTriggerScheduleFilterParameters(
            int? count,

            string? earliestStart,

            string? earliestStartTime,

            ImmutableArray<string> excludeDates,

            ImmutableArray<string> includeDates,

            string? until)
        {
            Count = count;
            EarliestStart = earliestStart;
            EarliestStartTime = earliestStartTime;
            ExcludeDates = excludeDates;
            IncludeDates = includeDates;
            Until = until;
        }
    }
}