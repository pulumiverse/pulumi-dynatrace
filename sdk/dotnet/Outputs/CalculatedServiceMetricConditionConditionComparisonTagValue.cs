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
    public sealed class CalculatedServiceMetricConditionConditionComparisonTagValue
    {
        /// <summary>
        /// The origin of the tag, such as AWS or Cloud Foundry. Custom tags use the `CONTEXTLESS` value. Possible values are `AWS`, `AWS_GENERIC`, `AZURE`, `CLOUD_FOUNDRY`, `CONTEXTLESS`, `ENVIRONMENT`, `GOOGLE_CLOUD` and `KUBERNETES`
        /// </summary>
        public readonly string Context;
        /// <summary>
        /// The key of the tag. Custom tags have the tag value here
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// The value of the tag. Not applicable to custom tags
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private CalculatedServiceMetricConditionConditionComparisonTagValue(
            string context,

            string key,

            string? unknowns,

            string? value)
        {
            Context = context;
            Key = key;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
