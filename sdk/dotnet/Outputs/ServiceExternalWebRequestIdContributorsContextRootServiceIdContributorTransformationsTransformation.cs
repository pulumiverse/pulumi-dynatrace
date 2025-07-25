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
    public sealed class ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformation
    {
        /// <summary>
        /// include hexadecimal numbers
        /// </summary>
        public readonly bool? IncludeHexNumbers;
        /// <summary>
        /// min digit count
        /// </summary>
        public readonly int? MinDigitCount;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// replacement
        /// </summary>
        public readonly string? ReplacementValue;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string? Suffix;
        /// <summary>
        /// Possible Values: `BEFORE`, `REMOVE_CREDIT_CARDS`, `REMOVE_IBANS`, `REMOVE_IPS`, `REMOVE_NUMBERS`, `REPLACE_BETWEEN`
        /// </summary>
        public readonly string TransformationType;

        [OutputConstructor]
        private ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformation(
            bool? includeHexNumbers,

            int? minDigitCount,

            string? prefix,

            string? replacementValue,

            string? suffix,

            string transformationType)
        {
            IncludeHexNumbers = includeHexNumbers;
            MinDigitCount = minDigitCount;
            Prefix = prefix;
            ReplacementValue = replacementValue;
            Suffix = suffix;
            TransformationType = transformationType;
        }
    }
}
