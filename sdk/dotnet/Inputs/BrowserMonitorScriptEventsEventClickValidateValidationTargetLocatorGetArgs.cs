// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorLocatorGetArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorLocatorGetArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorGetArgs Empty => new BrowserMonitorScriptEventsEventClickValidateValidationTargetLocatorGetArgs();
    }
}