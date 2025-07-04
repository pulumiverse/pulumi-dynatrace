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
    public sealed class BrowserMonitorScriptEventsEventClick
    {
        /// <summary>
        /// the mouse button to be used for the click
        /// </summary>
        public readonly int Button;
        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventClickTarget? Target;
        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventClickValidate? Validate;
        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventClickWait? Wait;

        [OutputConstructor]
        private BrowserMonitorScriptEventsEventClick(
            int button,

            Outputs.BrowserMonitorScriptEventsEventClickTarget? target,

            Outputs.BrowserMonitorScriptEventsEventClickValidate? validate,

            Outputs.BrowserMonitorScriptEventsEventClickWait? wait)
        {
            Button = button;
            Target = target;
            Validate = validate;
            Wait = wait;
        }
    }
}
