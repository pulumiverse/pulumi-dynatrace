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
    public sealed class BusinessEventsOneagentTriggersTriggerSource
    {
        /// <summary>
        /// Possible Values: `Request_body`, `Request_headers`, `Request_method`, `Request_parameters`, `Request_path`, `Request_url`, `Response_body`, `Response_headers`, `Response_statusCode`
        /// </summary>
        public readonly string DataSource;
        /// <summary>
        /// [See our documentation](https://dt-url.net/ei034bx)
        /// </summary>
        public readonly string? Path;

        [OutputConstructor]
        private BusinessEventsOneagentTriggersTriggerSource(
            string dataSource,

            string? path)
        {
            DataSource = dataSource;
            Path = path;
        }
    }
}
