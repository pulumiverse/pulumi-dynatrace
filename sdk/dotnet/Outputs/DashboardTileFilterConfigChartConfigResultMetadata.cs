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
    public sealed class DashboardTileFilterConfigChartConfigResultMetadata
    {
        /// <summary>
        /// Additional metadata for charted metric
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardTileFilterConfigChartConfigResultMetadataConfig> Configs;

        [OutputConstructor]
        private DashboardTileFilterConfigChartConfigResultMetadata(ImmutableArray<Outputs.DashboardTileFilterConfigChartConfigResultMetadataConfig> configs)
        {
            Configs = configs;
        }
    }
}
