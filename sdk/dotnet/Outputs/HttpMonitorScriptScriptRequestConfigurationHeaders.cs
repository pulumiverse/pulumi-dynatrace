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
    public sealed class HttpMonitorScriptScriptRequestConfigurationHeaders
    {
        /// <summary>
        /// contains an HTTP header of the request
        /// </summary>
        public readonly ImmutableArray<Outputs.HttpMonitorScriptScriptRequestConfigurationHeadersHeader> Headers;

        [OutputConstructor]
        private HttpMonitorScriptScriptRequestConfigurationHeaders(ImmutableArray<Outputs.HttpMonitorScriptScriptRequestConfigurationHeadersHeader> headers)
        {
            Headers = headers;
        }
    }
}
