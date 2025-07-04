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

    public sealed class DashboardTileFilterConfigChartConfigResultMetadataGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("configs")]
        private InputList<Inputs.DashboardTileFilterConfigChartConfigResultMetadataConfigGetArgs>? _configs;

        /// <summary>
        /// Additional metadata for charted metric
        /// </summary>
        public InputList<Inputs.DashboardTileFilterConfigChartConfigResultMetadataConfigGetArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Inputs.DashboardTileFilterConfigChartConfigResultMetadataConfigGetArgs>());
            set => _configs = value;
        }

        public DashboardTileFilterConfigChartConfigResultMetadataGetArgs()
        {
        }
        public static new DashboardTileFilterConfigChartConfigResultMetadataGetArgs Empty => new DashboardTileFilterConfigChartConfigResultMetadataGetArgs();
    }
}
