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
    public sealed class CalculatedServiceMetricMetricDefinition
    {
        /// <summary>
        /// The metric to be captured. Possible values are `CPU_TIME`, `DATABASE_CHILD_CALL_COUNT`, `DATABASE_CHILD_CALL_TIME`, `DISK_IO_TIME`, `EXCEPTION_COUNT`, `FAILED_REQUEST_COUNT`, `FAILED_REQUEST_COUNT_CLIENT`, `FAILURE_RATE`, `FAILURE_RATE_CLIENT`, `HTTP_4XX_ERROR_COUNT`, `HTTP_4XX_ERROR_COUNT_CLIENT`, `HTTP_5XX_ERROR_COUNT`, `HTTP_5XX_ERROR_COUNT_CLIENT`, `IO_TIME`, `LOCK_TIME`, `NETWORK_IO_TIME`, `NON_DATABASE_CHILD_CALL_COUNT`, `NON_DATABASE_CHILD_CALL_TIME`, `PROCESSING_TIME`, `REQUEST_ATTRIBUTE`, `REQUEST_COUNT`, `RESPONSE_TIME`, `RESPONSE_TIME_CLIENT`, `SUCCESSFUL_REQUEST_COUNT`, `SUCCESSFUL_REQUEST_COUNT_CLIENT` and `WAIT_TIME`
        /// </summary>
        public readonly string Metric;
        /// <summary>
        /// The request attribute to be captured. Only applicable when the **metric** parameter is set to `REQUEST_ATTRIBUTE`
        /// </summary>
        public readonly string? RequestAttribute;

        [OutputConstructor]
        private CalculatedServiceMetricMetricDefinition(
            string metric,

            string? requestAttribute)
        {
            Metric = metric;
            RequestAttribute = requestAttribute;
        }
    }
}