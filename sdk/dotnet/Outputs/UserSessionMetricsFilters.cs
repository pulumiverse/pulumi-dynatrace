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
    public sealed class UserSessionMetricsFilters
    {
        public readonly ImmutableArray<Outputs.UserSessionMetricsFiltersFilter> Filters;

        [OutputConstructor]
        private UserSessionMetricsFilters(ImmutableArray<Outputs.UserSessionMetricsFiltersFilter> filters)
        {
            Filters = filters;
        }
    }
}
