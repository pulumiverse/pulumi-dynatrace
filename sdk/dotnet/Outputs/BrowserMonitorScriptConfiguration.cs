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
    public sealed class BrowserMonitorScriptConfiguration
    {
        /// <summary>
        /// The emulated device of the monitor—holds either the parameters of the custom device or the name and orientation of the preconfigured device.
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationBandwidth? Bandwidth;
        /// <summary>
        /// Block these URLs
        /// </summary>
        public readonly ImmutableArray<string> Blocks;
        /// <summary>
        /// Bypass Content Security Policy of monitored pages
        /// </summary>
        public readonly bool? BypassCsp;
        /// <summary>
        /// These cookies are added before execution of the first step
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationCookies? Cookies;
        /// <summary>
        /// The emulated device of the monitor—holds either the parameters of the custom device or the name and orientation of the preconfigured device.
        /// 
        /// If not set, then the Desktop preconfigured device is used
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationDevice? Device;
        /// <summary>
        /// No documentation available
        /// </summary>
        public readonly bool? DisableWebSecurity;
        /// <summary>
        /// The list of HTTP headers to be sent with requests of the monitor
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationHeaders? Headers;
        /// <summary>
        /// Ignore specific status codes
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationIgnoredErrorCodes? IgnoredErrorCodes;
        /// <summary>
        /// Custom JavaScript Agent settings
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationJavascriptSetttings? JavascriptSetttings;
        /// <summary>
        /// Capture performance metrics for pages loaded in frames
        /// </summary>
        public readonly bool? MonitorFrames;
        /// <summary>
        /// The user agent of the request
        /// </summary>
        public readonly string? UserAgent;

        [OutputConstructor]
        private BrowserMonitorScriptConfiguration(
            Outputs.BrowserMonitorScriptConfigurationBandwidth? bandwidth,

            ImmutableArray<string> blocks,

            bool? bypassCsp,

            Outputs.BrowserMonitorScriptConfigurationCookies? cookies,

            Outputs.BrowserMonitorScriptConfigurationDevice? device,

            bool? disableWebSecurity,

            Outputs.BrowserMonitorScriptConfigurationHeaders? headers,

            Outputs.BrowserMonitorScriptConfigurationIgnoredErrorCodes? ignoredErrorCodes,

            Outputs.BrowserMonitorScriptConfigurationJavascriptSetttings? javascriptSetttings,

            bool? monitorFrames,

            string? userAgent)
        {
            Bandwidth = bandwidth;
            Blocks = blocks;
            BypassCsp = bypassCsp;
            Cookies = cookies;
            Device = device;
            DisableWebSecurity = disableWebSecurity;
            Headers = headers;
            IgnoredErrorCodes = ignoredErrorCodes;
            JavascriptSetttings = javascriptSetttings;
            MonitorFrames = monitorFrames;
            UserAgent = userAgent;
        }
    }
}
