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

    public sealed class BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The index of the option to be selected
        /// </summary>
        [Input("index", required: true)]
        public Input<int> Index { get; set; } = null!;

        /// <summary>
        /// The value of the option to be selected
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs Empty => new BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs();
    }
}
