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

    public sealed class BrowserMonitorScriptEventsEventTapWaitValidationTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators")]
        private InputList<Inputs.BrowserMonitorScriptEventsEventTapWaitValidationTargetLocatorArgs>? _locators;

        /// <summary>
        /// The list of locators identifying the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventTapWaitValidationTargetLocatorArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventTapWaitValidationTargetLocatorArgs>());
            set => _locators = value;
        }

        /// <summary>
        /// The tab of the target
        /// </summary>
        [Input("window")]
        public Input<string>? Window { get; set; }

        public BrowserMonitorScriptEventsEventTapWaitValidationTargetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventTapWaitValidationTargetArgs Empty => new BrowserMonitorScriptEventsEventTapWaitValidationTargetArgs();
    }
}
