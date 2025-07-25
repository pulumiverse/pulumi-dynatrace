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

    public sealed class DatabaseAnomaliesV2ResponseTimeAutoDetectionResponseTimeAllArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("degradationMilliseconds", required: true)]
        public Input<double> DegradationMilliseconds { get; set; } = null!;

        /// <summary>
        /// Relative threshold
        /// </summary>
        [Input("degradationPercent", required: true)]
        public Input<double> DegradationPercent { get; set; } = null!;

        public DatabaseAnomaliesV2ResponseTimeAutoDetectionResponseTimeAllArgs()
        {
        }
        public static new DatabaseAnomaliesV2ResponseTimeAutoDetectionResponseTimeAllArgs Empty => new DatabaseAnomaliesV2ResponseTimeAutoDetectionResponseTimeAllArgs();
    }
}
