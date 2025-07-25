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
    public sealed class OpenpipelineMetricsRouting
    {
        /// <summary>
        /// Dynamic routing entry
        /// </summary>
        public readonly ImmutableArray<Outputs.OpenpipelineMetricsRoutingEntry> Entries;

        [OutputConstructor]
        private OpenpipelineMetricsRouting(ImmutableArray<Outputs.OpenpipelineMetricsRoutingEntry> entries)
        {
            Entries = entries;
        }
    }
}
