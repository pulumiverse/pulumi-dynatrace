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

    public sealed class MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("durationThreshold", required: true)]
        public Input<double> DurationThreshold { get; set; } = null!;

        public MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedArgs()
        {
        }
        public static new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedArgs Empty => new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedArgs();
    }
}
