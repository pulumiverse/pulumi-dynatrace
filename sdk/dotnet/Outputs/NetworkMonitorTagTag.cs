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
    public sealed class NetworkMonitorTagTag
    {
        /// <summary>
        /// The origin of the tag, such as AWS or Cloud Foundry.
        /// </summary>
        public readonly string? Context;
        /// <summary>
        /// The key of the tag
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The source of the tag, possible values: `AUTO`, `RULE_BASED` or `USER`
        /// </summary>
        public readonly string? Source;
        /// <summary>
        /// The value of the tag
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private NetworkMonitorTagTag(
            string? context,

            string key,

            string? source,

            string? value)
        {
            Context = context;
            Key = key;
            Source = source;
            Value = value;
        }
    }
}
