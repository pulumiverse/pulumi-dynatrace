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

    public sealed class AwsAnomaliesRdsLowStorageDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Free storage space divided by allocated storage is lower than
        /// </summary>
        [Input("freeStoragePercentage", required: true)]
        public Input<int> FreeStoragePercentage { get; set; } = null!;

        public AwsAnomaliesRdsLowStorageDetectionCustomThresholdsArgs()
        {
        }
        public static new AwsAnomaliesRdsLowStorageDetectionCustomThresholdsArgs Empty => new AwsAnomaliesRdsLowStorageDetectionCustomThresholdsArgs();
    }
}
