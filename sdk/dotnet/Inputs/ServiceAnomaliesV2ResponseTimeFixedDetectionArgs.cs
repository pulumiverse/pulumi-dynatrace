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

    public sealed class ServiceAnomaliesV2ResponseTimeFixedDetectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        [Input("overAlertingProtection", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeFixedDetectionOverAlertingProtectionArgs> OverAlertingProtection { get; set; } = null!;

        /// <summary>
        /// Alert if the median response time of all requests degrades beyond this threshold:
        /// </summary>
        [Input("responseTimeAll", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs> ResponseTimeAll { get; set; } = null!;

        /// <summary>
        /// Alert if the response time of the slowest 10% of requests degrades beyond this threshold:
        /// </summary>
        [Input("responseTimeSlowest", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeSlowestArgs> ResponseTimeSlowest { get; set; } = null!;

        /// <summary>
        /// Possible Values: `High`, `Low`, `Medium`
        /// </summary>
        [Input("sensitivity", required: true)]
        public Input<string> Sensitivity { get; set; } = null!;

        public ServiceAnomaliesV2ResponseTimeFixedDetectionArgs()
        {
        }
        public static new ServiceAnomaliesV2ResponseTimeFixedDetectionArgs Empty => new ServiceAnomaliesV2ResponseTimeFixedDetectionArgs();
    }
}
