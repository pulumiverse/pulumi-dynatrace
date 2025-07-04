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
    public sealed class WebAppAnomaliesTrafficDropsTrafficDrops
    {
        /// <summary>
        /// Minutes the observed traffic has to stay in abnormal state before alert
        /// </summary>
        public readonly double AbnormalStateAbnormalState;
        /// <summary>
        /// Alert if the observed traffic is less than this percentage of the expected value
        /// </summary>
        public readonly double TrafficDropPercentage;

        [OutputConstructor]
        private WebAppAnomaliesTrafficDropsTrafficDrops(
            double abnormalStateAbnormalState,

            double trafficDropPercentage)
        {
            AbnormalStateAbnormalState = abnormalStateAbnormalState;
            TrafficDropPercentage = trafficDropPercentage;
        }
    }
}
