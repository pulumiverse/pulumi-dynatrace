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

    public sealed class BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorArgs Empty => new BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorArgs();
    }
}
