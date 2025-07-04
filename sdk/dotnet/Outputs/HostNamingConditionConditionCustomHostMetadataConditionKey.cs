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
    public sealed class HostNamingConditionConditionCustomHostMetadataConditionKey
    {
        /// <summary>
        /// The attribute to be used for comparision
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// The key of the attribute, which need dynamic keys. Not applicable otherwise, as the attibute itself acts as a key
        /// </summary>
        public readonly Outputs.HostNamingConditionConditionCustomHostMetadataConditionKeyDynamicKey DynamicKey;
        /// <summary>
        /// if specified, needs to be HOST_CUSTOM_METADATA_KEY
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider but have meanwhile gotten introduced by a newer version of the Dynatrace REST API
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private HostNamingConditionConditionCustomHostMetadataConditionKey(
            string attribute,

            Outputs.HostNamingConditionConditionCustomHostMetadataConditionKeyDynamicKey dynamicKey,

            string? type,

            string? unknowns)
        {
            Attribute = attribute;
            DynamicKey = dynamicKey;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
