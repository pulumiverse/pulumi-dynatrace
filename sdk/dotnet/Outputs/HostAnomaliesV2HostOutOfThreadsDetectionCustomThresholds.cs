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
    public sealed class HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholds
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsEventThresholds EventThresholds;
        /// <summary>
        /// Alert if the number of Java out-of-threads exceptions is at least this value
        /// </summary>
        public readonly int OutOfThreadsExceptionsNumber;

        [OutputConstructor]
        private HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholds(
            Outputs.HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsEventThresholds eventThresholds,

            int outOfThreadsExceptionsNumber)
        {
            EventThresholds = eventThresholds;
            OutOfThreadsExceptionsNumber = outOfThreadsExceptionsNumber;
        }
    }
}