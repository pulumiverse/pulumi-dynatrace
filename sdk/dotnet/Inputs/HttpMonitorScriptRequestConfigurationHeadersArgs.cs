// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class HttpMonitorScriptRequestConfigurationHeadersArgs : global::Pulumi.ResourceArgs
    {
        [Input("headers", required: true)]
        private InputList<Inputs.HttpMonitorScriptRequestConfigurationHeadersHeaderArgs>? _headers;

        /// <summary>
        /// contains an HTTP header of the request
        /// </summary>
        public InputList<Inputs.HttpMonitorScriptRequestConfigurationHeadersHeaderArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.HttpMonitorScriptRequestConfigurationHeadersHeaderArgs>());
            set => _headers = value;
        }

        public HttpMonitorScriptRequestConfigurationHeadersArgs()
        {
        }
        public static new HttpMonitorScriptRequestConfigurationHeadersArgs Empty => new HttpMonitorScriptRequestConfigurationHeadersArgs();
    }
}
