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
    public sealed class GetRemoteEnvironmentsRemoteEnvironmentResult
    {
        /// <summary>
        /// Name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Possible Values: `CLUSTER`, `EXTERNAL`, `INTERNAL`
        /// </summary>
        public readonly string NetworkScope;
        /// <summary>
        /// Provide a valid token created on the remote environment.
        /// </summary>
        public readonly string Token;
        /// <summary>
        /// Specify the full URI to the remote environment. Your local environment will have to be able to connect this URI on a network level.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private GetRemoteEnvironmentsRemoteEnvironmentResult(
            string name,

            string networkScope,

            string token,

            string uri)
        {
            Name = name;
            NetworkScope = networkScope;
            Token = token;
            Uri = uri;
        }
    }
}
