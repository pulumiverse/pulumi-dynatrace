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
    public sealed class BrowserMonitorScript
    {
        /// <summary>
        /// The setup of the monitor
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfiguration? Configuration;
        /// <summary>
        /// Steps of the clickpath—the first step must always be of the `navigate` type
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEvents? Events;
        /// <summary>
        /// The type of monitor. Possible values are `clickpath` for clickpath monitors and `availability` for single-URL browser monitors. These monitors are only allowed to have one event of the `navigate` type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BrowserMonitorScript(
            Outputs.BrowserMonitorScriptConfiguration? configuration,

            Outputs.BrowserMonitorScriptEvents? events,

            string type)
        {
            Configuration = configuration;
            Events = events;
            Type = type;
        }
    }
}
