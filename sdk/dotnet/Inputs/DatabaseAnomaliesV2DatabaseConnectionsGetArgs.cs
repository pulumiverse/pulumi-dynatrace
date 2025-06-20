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

    public sealed class DatabaseAnomaliesV2DatabaseConnectionsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Detect failed database connects
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Threshold
        /// </summary>
        [Input("maxFailedConnects")]
        public Input<int>? MaxFailedConnects { get; set; }

        /// <summary>
        /// Time span
        /// </summary>
        [Input("timePeriod")]
        public Input<int>? TimePeriod { get; set; }

        public DatabaseAnomaliesV2DatabaseConnectionsGetArgs()
        {
        }
        public static new DatabaseAnomaliesV2DatabaseConnectionsGetArgs Empty => new DatabaseAnomaliesV2DatabaseConnectionsGetArgs();
    }
}
