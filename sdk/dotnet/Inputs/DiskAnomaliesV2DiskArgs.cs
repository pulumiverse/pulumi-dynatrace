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

    public sealed class DiskAnomaliesV2DiskArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowInodesDetection", required: true)]
        public Input<Inputs.DiskAnomaliesV2DiskDiskLowInodesDetectionArgs> DiskLowInodesDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowSpaceDetection", required: true)]
        public Input<Inputs.DiskAnomaliesV2DiskDiskLowSpaceDetectionArgs> DiskLowSpaceDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskSlowWritesAndReadsDetection", required: true)]
        public Input<Inputs.DiskAnomaliesV2DiskDiskSlowWritesAndReadsDetectionArgs> DiskSlowWritesAndReadsDetection { get; set; } = null!;

        public DiskAnomaliesV2DiskArgs()
        {
        }
        public static new DiskAnomaliesV2DiskArgs Empty => new DiskAnomaliesV2DiskArgs();
    }
}
