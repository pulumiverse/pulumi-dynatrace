// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    public static class GetSyntheticLocation
    {
        /// <summary>
        /// The synthetic location data source allows the location ID to be retrieved based off of provided parameters.
        /// 
        /// &gt; For Provider versions earlier than v1.80.0: This data source requires the API token scope **Read synthetic monitors, locations, and nodes** (`ReadSyntheticData`)
        /// &gt; For Provider versions v1.80.0 and newer: This data source requires the API token scope **Read synthetic locations** (`syntheticLocations.read`)
        /// </summary>
        public static Task<GetSyntheticLocationResult> InvokeAsync(GetSyntheticLocationArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSyntheticLocationResult>("dynatrace:index/getSyntheticLocation:getSyntheticLocation", args ?? new GetSyntheticLocationArgs(), options.WithDefaults());

        /// <summary>
        /// The synthetic location data source allows the location ID to be retrieved based off of provided parameters.
        /// 
        /// &gt; For Provider versions earlier than v1.80.0: This data source requires the API token scope **Read synthetic monitors, locations, and nodes** (`ReadSyntheticData`)
        /// &gt; For Provider versions v1.80.0 and newer: This data source requires the API token scope **Read synthetic locations** (`syntheticLocations.read`)
        /// </summary>
        public static Output<GetSyntheticLocationResult> Invoke(GetSyntheticLocationInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSyntheticLocationResult>("dynatrace:index/getSyntheticLocation:getSyntheticLocation", args ?? new GetSyntheticLocationInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// The synthetic location data source allows the location ID to be retrieved based off of provided parameters.
        /// 
        /// &gt; For Provider versions earlier than v1.80.0: This data source requires the API token scope **Read synthetic monitors, locations, and nodes** (`ReadSyntheticData`)
        /// &gt; For Provider versions v1.80.0 and newer: This data source requires the API token scope **Read synthetic locations** (`syntheticLocations.read`)
        /// </summary>
        public static Output<GetSyntheticLocationResult> Invoke(GetSyntheticLocationInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetSyntheticLocationResult>("dynatrace:index/getSyntheticLocation:getSyntheticLocation", args ?? new GetSyntheticLocationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSyntheticLocationArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The cloud provider where the location is hosted.
        /// </summary>
        [Input("cloudPlatform")]
        public string? CloudPlatform { get; set; }

        [Input("entityId")]
        public string? EntityId { get; set; }

        [Input("geoLocationId")]
        public string? GeoLocationId { get; set; }

        [Input("ips")]
        private List<string>? _ips;
        public List<string> Ips
        {
            get => _ips ?? (_ips = new List<string>());
            set => _ips = value;
        }

        [Input("name")]
        public string? Name { get; set; }

        [Input("stage")]
        public string? Stage { get; set; }

        [Input("status")]
        public string? Status { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        public GetSyntheticLocationArgs()
        {
        }
        public static new GetSyntheticLocationArgs Empty => new GetSyntheticLocationArgs();
    }

    public sealed class GetSyntheticLocationInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The cloud provider where the location is hosted.
        /// </summary>
        [Input("cloudPlatform")]
        public Input<string>? CloudPlatform { get; set; }

        [Input("entityId")]
        public Input<string>? EntityId { get; set; }

        [Input("geoLocationId")]
        public Input<string>? GeoLocationId { get; set; }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("stage")]
        public Input<string>? Stage { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetSyntheticLocationInvokeArgs()
        {
        }
        public static new GetSyntheticLocationInvokeArgs Empty => new GetSyntheticLocationInvokeArgs();
    }


    [OutputType]
    public sealed class GetSyntheticLocationResult
    {
        /// <summary>
        /// The cloud provider where the location is hosted.
        /// </summary>
        public readonly string CloudPlatform;
        public readonly string? EntityId;
        public readonly string GeoLocationId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ips;
        public readonly string? Name;
        public readonly string Stage;
        public readonly string Status;
        public readonly string? Type;

        [OutputConstructor]
        private GetSyntheticLocationResult(
            string cloudPlatform,

            string? entityId,

            string geoLocationId,

            string id,

            ImmutableArray<string> ips,

            string? name,

            string stage,

            string status,

            string? type)
        {
            CloudPlatform = cloudPlatform;
            EntityId = entityId;
            GeoLocationId = geoLocationId;
            Id = id;
            Ips = ips;
            Name = name;
            Stage = stage;
            Status = status;
            Type = type;
        }
    }
}
