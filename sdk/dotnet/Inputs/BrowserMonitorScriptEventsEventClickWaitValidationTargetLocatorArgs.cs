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

    public sealed class BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorLocatorArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorLocatorArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorLocatorArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorArgs Empty => new BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorArgs();
    }
}
