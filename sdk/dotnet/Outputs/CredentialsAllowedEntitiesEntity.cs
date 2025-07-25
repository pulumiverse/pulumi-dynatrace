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
    public sealed class CredentialsAllowedEntitiesEntity
    {
        /// <summary>
        /// ID of the entity
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Type of entity. Possible values: `USER`, `APPLICATION`, `UNKNOWN`
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private CredentialsAllowedEntitiesEntity(
            string? id,

            string? type)
        {
            Id = id;
            Type = type;
        }
    }
}
