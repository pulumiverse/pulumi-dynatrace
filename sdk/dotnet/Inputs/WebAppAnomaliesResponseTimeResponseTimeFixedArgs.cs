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

    public sealed class WebAppAnomaliesResponseTimeResponseTimeFixedArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        [Input("overAlertingProtection", required: true)]
        public Input<Inputs.WebAppAnomaliesResponseTimeResponseTimeFixedOverAlertingProtectionArgs> OverAlertingProtection { get; set; } = null!;

        /// <summary>
        /// Alert if the key performance metric of all requests degrades beyond this threshold:
        /// </summary>
        [Input("responseTimeAll", required: true)]
        public Input<Inputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeAllArgs> ResponseTimeAll { get; set; } = null!;

        /// <summary>
        /// Alert if the key performance metric of the slowest 10% of requests degrades beyond this threshold:
        /// </summary>
        [Input("responseTimeSlowest", required: true)]
        public Input<Inputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeSlowestArgs> ResponseTimeSlowest { get; set; } = null!;

        /// <summary>
        /// Possible Values: `Medium`, `High`, `Low`
        /// </summary>
        [Input("sensitivity", required: true)]
        public Input<string> Sensitivity { get; set; } = null!;

        public WebAppAnomaliesResponseTimeResponseTimeFixedArgs()
        {
        }
        public static new WebAppAnomaliesResponseTimeResponseTimeFixedArgs Empty => new WebAppAnomaliesResponseTimeResponseTimeFixedArgs();
    }
}
