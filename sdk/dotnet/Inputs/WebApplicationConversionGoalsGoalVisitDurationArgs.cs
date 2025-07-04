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

    public sealed class WebApplicationConversionGoalsGoalVisitDurationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The duration of session to hit the conversion goal, in milliseconds
        /// </summary>
        [Input("duration", required: true)]
        public Input<int> Duration { get; set; } = null!;

        public WebApplicationConversionGoalsGoalVisitDurationArgs()
        {
        }
        public static new WebApplicationConversionGoalsGoalVisitDurationArgs Empty => new WebApplicationConversionGoalsGoalVisitDurationArgs();
    }
}
