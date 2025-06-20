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

    public sealed class MetricMetadataDimensionsDimensionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Display name
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Dimension key
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        public MetricMetadataDimensionsDimensionArgs()
        {
        }
        public static new MetricMetadataDimensionsDimensionArgs Empty => new MetricMetadataDimensionsDimensionArgs();
    }
}
