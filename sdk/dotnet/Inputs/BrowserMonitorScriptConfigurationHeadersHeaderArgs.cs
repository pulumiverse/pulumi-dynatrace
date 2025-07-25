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

    public sealed class BrowserMonitorScriptConfigurationHeadersHeaderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key of the header
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The value of the header
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public BrowserMonitorScriptConfigurationHeadersHeaderArgs()
        {
        }
        public static new BrowserMonitorScriptConfigurationHeadersHeaderArgs Empty => new BrowserMonitorScriptConfigurationHeadersHeaderArgs();
    }
}
