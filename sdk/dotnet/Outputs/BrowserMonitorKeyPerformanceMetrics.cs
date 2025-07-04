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
    public sealed class BrowserMonitorKeyPerformanceMetrics
    {
        /// <summary>
        /// Defines the key performance metric for load actions. Supported values are `VISUALLY_COMPLETE`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `TIME_TO_FIRST_BYTE`, `HTML_DOWNLOADED`, `DOM_INTERACTIVE`, `LOAD_EVENT_START` and `LOAD_EVENT_END`.
        /// </summary>
        public readonly string LoadActionKpm;
        /// <summary>
        /// Defines the key performance metric for XHR actions. Supported values are `VISUALLY_COMPLETE`, `USER_ACTION_DURATION`, `TIME_TO_FIRST_BYTE` and `RESPONSE_END`.
        /// </summary>
        public readonly string XhrActionKpm;

        [OutputConstructor]
        private BrowserMonitorKeyPerformanceMetrics(
            string loadActionKpm,

            string xhrActionKpm)
        {
            LoadActionKpm = loadActionKpm;
            XhrActionKpm = xhrActionKpm;
        }
    }
}
