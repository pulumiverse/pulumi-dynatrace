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

    public sealed class BrowserMonitorScriptEventsEventNavigateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The login credentials to bypass the browser login mask
        /// </summary>
        [Input("authentication")]
        public Input<Inputs.BrowserMonitorScriptEventsEventNavigateAuthenticationArgs>? Authentication { get; set; }

        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        [Input("target")]
        public Input<Inputs.BrowserMonitorScriptEventsEventNavigateTargetArgs>? Target { get; set; }

        /// <summary>
        /// The URL to navigate to
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        [Input("validate")]
        public Input<Inputs.BrowserMonitorScriptEventsEventNavigateValidateArgs>? Validate { get; set; }

        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        [Input("wait")]
        public Input<Inputs.BrowserMonitorScriptEventsEventNavigateWaitArgs>? Wait { get; set; }

        public BrowserMonitorScriptEventsEventNavigateArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventNavigateArgs Empty => new BrowserMonitorScriptEventsEventNavigateArgs();
    }
}
