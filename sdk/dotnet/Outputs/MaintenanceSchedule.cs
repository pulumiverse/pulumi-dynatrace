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
    public sealed class MaintenanceSchedule
    {
        /// <summary>
        /// The configuration for maintenance windows occuring daily
        /// </summary>
        public readonly Outputs.MaintenanceScheduleDailyRecurrence? DailyRecurrence;
        /// <summary>
        /// The configuration for maintenance windows occuring monthly
        /// </summary>
        public readonly Outputs.MaintenanceScheduleMonthlyRecurrence? MonthlyRecurrence;
        /// <summary>
        /// The configuration for maintenance windows occuring once
        /// </summary>
        public readonly Outputs.MaintenanceScheduleOnceRecurrence? OnceRecurrence;
        /// <summary>
        /// The type maintenance window, possible values: `DAILY`, `MONTHLY`, `ONCE`, `WEEKLY`
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The configuration for maintenance windows occuring weekly
        /// </summary>
        public readonly Outputs.MaintenanceScheduleWeeklyRecurrence? WeeklyRecurrence;

        [OutputConstructor]
        private MaintenanceSchedule(
            Outputs.MaintenanceScheduleDailyRecurrence? dailyRecurrence,

            Outputs.MaintenanceScheduleMonthlyRecurrence? monthlyRecurrence,

            Outputs.MaintenanceScheduleOnceRecurrence? onceRecurrence,

            string type,

            Outputs.MaintenanceScheduleWeeklyRecurrence? weeklyRecurrence)
        {
            DailyRecurrence = dailyRecurrence;
            MonthlyRecurrence = monthlyRecurrence;
            OnceRecurrence = onceRecurrence;
            Type = type;
            WeeklyRecurrence = weeklyRecurrence;
        }
    }
}
