// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class BrowserMonitorScriptEventsEventTapWaitValidationTarget
    {
        /// <summary>
        /// The list of locators identifying the desired element
        /// </summary>
        public readonly ImmutableArray<Outputs.BrowserMonitorScriptEventsEventTapWaitValidationTargetLocator> Locators;
        /// <summary>
        /// The tab of the target
        /// </summary>
        public readonly string? Window;

        [OutputConstructor]
        private BrowserMonitorScriptEventsEventTapWaitValidationTarget(
            ImmutableArray<Outputs.BrowserMonitorScriptEventsEventTapWaitValidationTargetLocator> locators,

            string? window)
        {
            Locators = locators;
            Window = window;
        }
    }
}