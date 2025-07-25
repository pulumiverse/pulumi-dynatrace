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

    public sealed class WebAppAnomaliesTrafficDropsTrafficDropsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Minutes the observed traffic has to stay in abnormal state before alert
        /// </summary>
        [Input("abnormalStateAbnormalState", required: true)]
        public Input<double> AbnormalStateAbnormalState { get; set; } = null!;

        /// <summary>
        /// Alert if the observed traffic is less than this percentage of the expected value
        /// </summary>
        [Input("trafficDropPercentage", required: true)]
        public Input<double> TrafficDropPercentage { get; set; } = null!;

        public WebAppAnomaliesTrafficDropsTrafficDropsArgs()
        {
        }
        public static new WebAppAnomaliesTrafficDropsTrafficDropsArgs Empty => new WebAppAnomaliesTrafficDropsTrafficDropsArgs();
    }
}
