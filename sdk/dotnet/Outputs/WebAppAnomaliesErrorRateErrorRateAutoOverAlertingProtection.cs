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
    public sealed class WebAppAnomaliesErrorRateErrorRateAutoOverAlertingProtection
    {
        /// <summary>
        /// Only alert if there are at least
        /// </summary>
        public readonly double ActionsPerMinute;
        /// <summary>
        /// Only alert if the abnormal state remains for at least
        /// </summary>
        public readonly double MinutesAbnormalState;

        [OutputConstructor]
        private WebAppAnomaliesErrorRateErrorRateAutoOverAlertingProtection(
            double actionsPerMinute,

            double minutesAbnormalState)
        {
            ActionsPerMinute = actionsPerMinute;
            MinutesAbnormalState = minutesAbnormalState;
        }
    }
}