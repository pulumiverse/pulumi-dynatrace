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
    public sealed class UpdateWindowsMonthlyRecurrenceRecurrenceRange
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string End;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string Start;

        [OutputConstructor]
        private UpdateWindowsMonthlyRecurrenceRecurrenceRange(
            string end,

            string start)
        {
            End = end;
            Start = start;
        }
    }
}
