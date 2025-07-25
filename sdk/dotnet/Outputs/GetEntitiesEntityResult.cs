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
    public sealed class GetEntitiesEntityResult
    {
        /// <summary>
        /// The name of the entity, displayed in the UI.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The ID of the entity.
        /// </summary>
        public readonly string? EntityId;
        /// <summary>
        /// The timestamp at which the entity was last seen, in UTC milliseconds.
        /// </summary>
        public readonly int? LastSeenTms;
        /// <summary>
        /// Properties defining the entity.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Properties;
        /// <summary>
        /// A set of tags assigned to the entity.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetEntitiesEntityTagResult> Tags;
        /// <summary>
        /// The type of the entity.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetEntitiesEntityResult(
            string? displayName,

            string? entityId,

            int? lastSeenTms,

            ImmutableDictionary<string, string> properties,

            ImmutableArray<Outputs.GetEntitiesEntityTagResult> tags,

            string? type)
        {
            DisplayName = displayName;
            EntityId = entityId;
            LastSeenTms = lastSeenTms;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
