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

    public sealed class WebAppCustomErrorsErrorRulesErrorRuleCaptureSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Capture this error
        /// </summary>
        [Input("capture", required: true)]
        public Input<bool> Capture { get; set; } = null!;

        /// <summary>
        /// [View more details](https://dt-url.net/hd580p2k)
        /// </summary>
        [Input("considerForAi")]
        public Input<bool>? ConsiderForAi { get; set; }

        /// <summary>
        /// Include error in Apdex calculations
        /// </summary>
        [Input("impactApdex")]
        public Input<bool>? ImpactApdex { get; set; }

        public WebAppCustomErrorsErrorRulesErrorRuleCaptureSettingsArgs()
        {
        }
        public static new WebAppCustomErrorsErrorRulesErrorRuleCaptureSettingsArgs Empty => new WebAppCustomErrorsErrorRulesErrorRuleCaptureSettingsArgs();
    }
}
