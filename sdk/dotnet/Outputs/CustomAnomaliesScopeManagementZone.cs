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
    public sealed class CustomAnomaliesScopeManagementZone
    {
        /// <summary>
        /// The management zone id to match on
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private CustomAnomaliesScopeManagementZone(
            string? id,

            string? unknowns)
        {
            Id = id;
            Unknowns = unknowns;
        }
    }
}
