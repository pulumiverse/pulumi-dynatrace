// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class UpdateWindowsDailyRecurrenceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Every **X** days:
        /// * `1` = every day,
        /// * `2` = every two days,
        /// * `3` = every three days,
        /// * etc.
        /// </summary>
        [Input("every", required: true)]
        public Input<int> Every { get; set; } = null!;

        /// <summary>
        /// Recurrence range
        /// </summary>
        [Input("recurrenceRange", required: true)]
        public Input<Inputs.UpdateWindowsDailyRecurrenceRecurrenceRangeArgs> RecurrenceRange { get; set; } = null!;

        /// <summary>
        /// Update time
        /// </summary>
        [Input("updateTime", required: true)]
        public Input<Inputs.UpdateWindowsDailyRecurrenceUpdateTimeArgs> UpdateTime { get; set; } = null!;

        public UpdateWindowsDailyRecurrenceArgs()
        {
        }
        public static new UpdateWindowsDailyRecurrenceArgs Empty => new UpdateWindowsDailyRecurrenceArgs();
    }
}
