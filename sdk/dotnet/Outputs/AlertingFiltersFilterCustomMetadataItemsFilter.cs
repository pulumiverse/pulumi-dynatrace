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
    public sealed class AlertingFiltersFilterCustomMetadataItemsFilter
    {
        /// <summary>
        /// GET /api/v2/eventProperties for list of available keys
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// Value
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private AlertingFiltersFilterCustomMetadataItemsFilter(
            string key,

            bool? negate,

            string value)
        {
            Key = key;
            Negate = negate;
            Value = value;
        }
    }
}
