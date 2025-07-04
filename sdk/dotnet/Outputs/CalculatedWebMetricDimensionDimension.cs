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
    public sealed class CalculatedWebMetricDimensionDimension
    {
        /// <summary>
        /// The dimension of the metric. Possible values are `ApdexType`, `Browser`, `ErrorContext`, `ErrorOrigin`, `ErrorType`, `GeoLocation`, `StringProperty`, `UserActionType`
        /// </summary>
        public readonly string Dimension;
        /// <summary>
        /// The key of the user action property. Only applicable for the StringProperty dimension.
        /// </summary>
        public readonly string? PropertyKey;
        /// <summary>
        /// The number of top values to be calculated
        /// </summary>
        public readonly int TopX;

        [OutputConstructor]
        private CalculatedWebMetricDimensionDimension(
            string dimension,

            string? propertyKey,

            int topX)
        {
            Dimension = dimension;
            PropertyKey = propertyKey;
            TopX = topX;
        }
    }
}
