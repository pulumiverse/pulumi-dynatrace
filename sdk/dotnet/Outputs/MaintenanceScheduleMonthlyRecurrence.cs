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
    public sealed class MaintenanceScheduleMonthlyRecurrence
    {
        /// <summary>
        /// The day of the month for monthly maintenance. If the selected day does not fall within the month, the maintenance window will be active on the last day of the month.
        /// </summary>
        public readonly int DayOfMonth;
        /// <summary>
        /// The recurrence date range of the maintenance window
        /// </summary>
        public readonly Outputs.MaintenanceScheduleMonthlyRecurrenceRecurrenceRange RecurrenceRange;
        /// <summary>
        /// The time window of the maintenance window
        /// </summary>
        public readonly Outputs.MaintenanceScheduleMonthlyRecurrenceTimeWindow TimeWindow;

        [OutputConstructor]
        private MaintenanceScheduleMonthlyRecurrence(
            int dayOfMonth,

            Outputs.MaintenanceScheduleMonthlyRecurrenceRecurrenceRange recurrenceRange,

            Outputs.MaintenanceScheduleMonthlyRecurrenceTimeWindow timeWindow)
        {
            DayOfMonth = dayOfMonth;
            RecurrenceRange = recurrenceRange;
            TimeWindow = timeWindow;
        }
    }
}
