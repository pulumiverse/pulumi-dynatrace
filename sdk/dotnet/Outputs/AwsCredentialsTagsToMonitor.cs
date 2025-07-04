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
    public sealed class AwsCredentialsTagsToMonitor
    {
        /// <summary>
        /// the key of the AWS tag.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// the value of the AWS tag
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private AwsCredentialsTagsToMonitor(
            string? name,

            string? unknowns,

            string? value)
        {
            Name = name;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
