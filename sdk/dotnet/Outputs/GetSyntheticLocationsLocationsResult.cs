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
    public sealed class GetSyntheticLocationsLocationsResult
    {
        /// <summary>
        /// The cloud provider where the location is hosted.
        /// </summary>
        public readonly string CloudPlatform;
        /// <summary>
        /// The unique ID of the location
        /// </summary>
        public readonly string? EntityId;
        /// <summary>
        /// The Dynatrace GeoLocation ID of the location
        /// </summary>
        public readonly string GeoLocationId;
        /// <summary>
        /// The list of IP addresses assigned to the location. 
        /// 
        ///  Only applicable to `PUBLIC` locations
        /// </summary>
        public readonly ImmutableArray<string> Ips;
        /// <summary>
        /// The name of the location
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The release stage of the location
        /// </summary>
        public readonly string Stage;
        /// <summary>
        /// The status of the location: 
        /// 
        /// * `ENABLED`: The location is displayed as active in the UI. You can assign monitors to the location. 
        /// * `DISABLED`: The location is displayed as inactive in the UI. You can't assign monitors to the location. Monitors already assigned to the location will stay there and will be executed from the location. 
        /// * `HIDDEN`: The location is not displayed in the UI. You can't assign monitors to the location. You can only set location as `HIDDEN` when no monitor is assigned to it
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The type of the location. Supported values are `PUBLIC`, `PRIVATE` and `CLUSTER`
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetSyntheticLocationsLocationsResult(
            string cloudPlatform,

            string? entityId,

            string geoLocationId,

            ImmutableArray<string> ips,

            string? name,

            string stage,

            string status,

            string? type)
        {
            CloudPlatform = cloudPlatform;
            EntityId = entityId;
            GeoLocationId = geoLocationId;
            Ips = ips;
            Name = name;
            Stage = stage;
            Status = status;
            Type = type;
        }
    }
}
