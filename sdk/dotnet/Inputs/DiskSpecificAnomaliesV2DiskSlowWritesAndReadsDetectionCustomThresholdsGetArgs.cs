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

    public sealed class DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if disk read time or write time is higher than this threshold in 3 out of 5 samples
        /// </summary>
        [Input("writeAndReadTime", required: true)]
        public Input<int> WriteAndReadTime { get; set; } = null!;

        public DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionCustomThresholdsGetArgs()
        {
        }
        public static new DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionCustomThresholdsGetArgs Empty => new DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionCustomThresholdsGetArgs();
    }
}
