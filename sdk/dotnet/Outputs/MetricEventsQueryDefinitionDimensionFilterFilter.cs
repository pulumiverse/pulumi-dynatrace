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
    public sealed class MetricEventsQueryDefinitionDimensionFilterFilter
    {
        /// <summary>
        /// Dimension key
        /// </summary>
        public readonly string DimensionKey;
        /// <summary>
        /// Dimension value
        /// </summary>
        public readonly string DimensionValue;
        /// <summary>
        /// Possible Values: `CONTAINS_CASE_SENSITIVE`, `DOES_NOT_CONTAIN_CASE_SENSITIVE`, `DOES_NOT_EQUAL`, `DOES_NOT_START_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        public readonly string? Operator;

        [OutputConstructor]
        private MetricEventsQueryDefinitionDimensionFilterFilter(
            string dimensionKey,

            string dimensionValue,

            string? @operator)
        {
            DimensionKey = dimensionKey;
            DimensionValue = dimensionValue;
            Operator = @operator;
        }
    }
}
