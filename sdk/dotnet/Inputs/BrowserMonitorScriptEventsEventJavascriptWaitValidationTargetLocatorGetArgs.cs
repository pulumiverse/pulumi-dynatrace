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

    public sealed class BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorLocatorGetArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorLocatorGetArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorGetArgs Empty => new BrowserMonitorScriptEventsEventJavascriptWaitValidationTargetLocatorGetArgs();
    }
}
