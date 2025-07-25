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

    public sealed class BrowserMonitorTagTagArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The origin of the tag. Supported values are `AWS`, `AWS_GENERIC`, `AZURE`, `CLOUD_FOUNDRY`, `CONTEXTLESS`, `ENVIRONMENT`, `GOOGLE_CLOUD` and `KUBERNETES`.
        /// </summary>
        [Input("context", required: true)]
        public Input<string> Context { get; set; } = null!;

        /// <summary>
        /// The key of the tag.
        /// 
        /// Custom tags have the tag value here.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The source of the tag. Supported values are `USER`, `RULE_BASED` and `AUTO`.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// The value of the tag.
        /// 
        /// Not applicable to custom tags.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public BrowserMonitorTagTagArgs()
        {
        }
        public static new BrowserMonitorTagTagArgs Empty => new BrowserMonitorTagTagArgs();
    }
}
