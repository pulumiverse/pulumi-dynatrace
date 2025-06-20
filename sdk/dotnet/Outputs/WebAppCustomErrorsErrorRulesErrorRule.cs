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
    public sealed class WebAppCustomErrorsErrorRulesErrorRule
    {
        /// <summary>
        /// Capture settings
        /// </summary>
        public readonly Outputs.WebAppCustomErrorsErrorRulesErrorRuleCaptureSettings CaptureSettings;
        /// <summary>
        /// Possible Values: `ALL`, `BEGINS_WITH`, `CONTAINS`, `ENDS_WITH`, `EQUALS`
        /// </summary>
        public readonly string KeyMatcher;
        /// <summary>
        /// A case-insensitive key pattern
        /// </summary>
        public readonly string? KeyPattern;
        /// <summary>
        /// Possible Values: `ALL`, `BEGINS_WITH`, `CONTAINS`, `ENDS_WITH`, `EQUALS`
        /// </summary>
        public readonly string ValueMatcher;
        /// <summary>
        /// A case-insensitive value pattern
        /// </summary>
        public readonly string? ValuePattern;

        [OutputConstructor]
        private WebAppCustomErrorsErrorRulesErrorRule(
            Outputs.WebAppCustomErrorsErrorRulesErrorRuleCaptureSettings captureSettings,

            string keyMatcher,

            string? keyPattern,

            string valueMatcher,

            string? valuePattern)
        {
            CaptureSettings = captureSettings;
            KeyMatcher = keyMatcher;
            KeyPattern = keyPattern;
            ValueMatcher = valueMatcher;
            ValuePattern = valuePattern;
        }
    }
}
