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
    public sealed class DashboardTileFilter
    {
        /// <summary>
        /// the management zone this tile applies to
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardTileFilterManagementZone> ManagementZones;
        /// <summary>
        /// the default timeframe of the tile
        /// </summary>
        public readonly string? Timeframe;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DashboardTileFilter(
            ImmutableArray<Outputs.DashboardTileFilterManagementZone> managementZones,

            string? timeframe,

            string? unknowns)
        {
            ManagementZones = managementZones;
            Timeframe = timeframe;
            Unknowns = unknowns;
        }
    }
}
