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
    public sealed class CustomAnomaliesDimensionDimension
    {
        /// <summary>
        /// No documentation available
        /// </summary>
        public readonly int? Index;
        /// <summary>
        /// The dimensions key on the metric
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// No documentation available
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Defines the actual set of fields depending on the value
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private CustomAnomaliesDimensionDimension(
            int? index,

            string? key,

            string? name,

            string type,

            string? unknowns)
        {
            Index = index;
            Key = key;
            Name = name;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
