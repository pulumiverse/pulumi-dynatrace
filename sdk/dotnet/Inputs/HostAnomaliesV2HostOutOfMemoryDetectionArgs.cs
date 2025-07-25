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

    public sealed class HostAnomaliesV2HostOutOfMemoryDetectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("customThresholds")]
        public Input<Inputs.HostAnomaliesV2HostOutOfMemoryDetectionCustomThresholdsArgs>? CustomThresholds { get; set; }

        /// <summary>
        /// Detection mode for Java out of memory problem
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// Detect Java out of memory problem
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public HostAnomaliesV2HostOutOfMemoryDetectionArgs()
        {
        }
        public static new HostAnomaliesV2HostOutOfMemoryDetectionArgs Empty => new HostAnomaliesV2HostOutOfMemoryDetectionArgs();
    }
}
