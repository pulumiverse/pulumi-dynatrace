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
    public sealed class RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTagTagKey
    {
        /// <summary>
        /// has no documentation
        /// </summary>
        public readonly string? Context;
        /// <summary>
        /// has no documentation
        /// </summary>
        public readonly string? Key;

        [OutputConstructor]
        private RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTagTagKey(
            string? context,

            string? key)
        {
            Context = context;
            Key = key;
        }
    }
}
