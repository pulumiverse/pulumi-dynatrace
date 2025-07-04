// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class DashboardTileFilterConfigChartConfigResultMetadataConfig
    {
        /// <summary>
        /// The color of the metric in the chart, hex format
        /// </summary>
        public readonly string? CustomColor;
        /// <summary>
        /// A generated key by the Dynatrace Server
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// The timestamp of the last metadata modification, in UTC milliseconds
        /// </summary>
        public readonly int? LastModified;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DashboardTileFilterConfigChartConfigResultMetadataConfig(
            string? customColor,

            string? key,

            int? lastModified,

            string? unknowns)
        {
            CustomColor = customColor;
            Key = key;
            LastModified = lastModified;
            Unknowns = unknowns;
        }
    }
}
