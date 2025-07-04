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

    public sealed class DashboardTileFilterConfigFiltersArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.DashboardTileFilterConfigFiltersFilterArgs>? _filters;

        /// <summary>
        /// the tiles this Dashboard consist of
        /// </summary>
        public InputList<Inputs.DashboardTileFilterConfigFiltersFilterArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.DashboardTileFilterConfigFiltersFilterArgs>());
            set => _filters = value;
        }

        public DashboardTileFilterConfigFiltersArgs()
        {
        }
        public static new DashboardTileFilterConfigFiltersArgs Empty => new DashboardTileFilterConfigFiltersArgs();
    }
}
