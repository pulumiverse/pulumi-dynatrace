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
    public sealed class GenericTypesRulesRuleSourcesSource
    {
        /// <summary>
        /// Specify a filter that needs to match in order for the extraction to happen.. Three different filters are supported: `$eq(value)` will ensure that the source matches exactly 'value', `$prefix(value)` will ensure that the source begins with exactly 'value', '$exists()' will ensure that any source with matching dimension filter exists.
        /// If your value contains the characters '(', ')' or '~', you need to escape them by adding a '~' in front of them.
        /// </summary>
        public readonly string? Condition;
        /// <summary>
        /// Possible Values: `BusinessEvents`, `Entities`, `Events`, `Logs`, `Metrics`, `Spans`, `Topology`
        /// </summary>
        public readonly string SourceType;

        [OutputConstructor]
        private GenericTypesRulesRuleSourcesSource(
            string? condition,

            string sourceType)
        {
            Condition = condition;
            SourceType = sourceType;
        }
    }
}
