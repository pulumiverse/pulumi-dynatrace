// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class DashboardTileFilterConfigFiltersFilterMatch
    {
        /// <summary>
        /// The entity type (e.g. HOST, SERVICE, ...)
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// the tiles this Dashboard consist of
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private DashboardTileFilterConfigFiltersFilterMatch(
            string key,

            ImmutableArray<string> values)
        {
            Key = key;
            Values = values;
        }
    }
}