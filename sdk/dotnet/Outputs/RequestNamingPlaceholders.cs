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
    public sealed class RequestNamingPlaceholders
    {
        /// <summary>
        /// A custom placeholder to be used in a dimension value pattern
        /// </summary>
        public readonly ImmutableArray<Outputs.RequestNamingPlaceholdersPlaceholder> Placeholders;

        [OutputConstructor]
        private RequestNamingPlaceholders(ImmutableArray<Outputs.RequestNamingPlaceholdersPlaceholder> placeholders)
        {
            Placeholders = placeholders;
        }
    }
}
