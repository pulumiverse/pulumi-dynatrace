// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class ServiceAnomaliesV2ResponseTimeAutoDetectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Avoid over-alerting
        /// </summary>
        [Input("overAlertingProtection", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeAutoDetectionOverAlertingProtectionArgs> OverAlertingProtection { get; set; } = null!;

        /// <summary>
        /// Alert if the median response time of all requests degrades beyond **both** the absolute and relative thresholds:
        /// </summary>
        [Input("responseTimeAll", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeAllArgs> ResponseTimeAll { get; set; } = null!;

        /// <summary>
        /// Alert if the response time of the slowest 10% of requests degrades beyond **both** the absolute and relative thresholds:
        /// </summary>
        [Input("responseTimeSlowest", required: true)]
        public Input<Inputs.ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowestArgs> ResponseTimeSlowest { get; set; } = null!;

        public ServiceAnomaliesV2ResponseTimeAutoDetectionArgs()
        {
        }
        public static new ServiceAnomaliesV2ResponseTimeAutoDetectionArgs Empty => new ServiceAnomaliesV2ResponseTimeAutoDetectionArgs();
    }
}