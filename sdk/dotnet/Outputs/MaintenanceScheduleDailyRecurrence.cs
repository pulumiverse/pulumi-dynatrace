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
    public sealed class MaintenanceScheduleDailyRecurrence
    {
        /// <summary>
        /// The recurrence date range of the maintenance window
        /// </summary>
        public readonly Outputs.MaintenanceScheduleDailyRecurrenceRecurrenceRange RecurrenceRange;
        /// <summary>
        /// The time window of the maintenance window
        /// </summary>
        public readonly Outputs.MaintenanceScheduleDailyRecurrenceTimeWindow TimeWindow;

        [OutputConstructor]
        private MaintenanceScheduleDailyRecurrence(
            Outputs.MaintenanceScheduleDailyRecurrenceRecurrenceRange recurrenceRange,

            Outputs.MaintenanceScheduleDailyRecurrenceTimeWindow timeWindow)
        {
            RecurrenceRange = recurrenceRange;
            TimeWindow = timeWindow;
        }
    }
}
