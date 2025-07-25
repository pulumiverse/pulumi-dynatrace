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
    public sealed class BrowserMonitorScriptEventsEventKeystrokesTargetLocatorLocator
    {
        /// <summary>
        /// Defines where to look for an element. `css` (CSS Selector) or `dom` (Javascript code)
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The name of the element to be found
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private BrowserMonitorScriptEventsEventKeystrokesTargetLocatorLocator(
            string type,

            string value)
        {
            Type = type;
            Value = value;
        }
    }
}
