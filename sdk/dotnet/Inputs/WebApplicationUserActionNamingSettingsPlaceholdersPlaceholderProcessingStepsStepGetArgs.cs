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

    public sealed class WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to `true`: Returns the input if `patternBefore` or `patternAfter` cannot be found and the `type` is `SUBSTRING`. Returns the input if `regularExpression` doesn't match and `type` is `EXTRACT_BY_REGULAR_EXPRESSION`.
        /// </summary>
        [Input("fallbackToInput")]
        public Input<bool>? FallbackToInput { get; set; }

        /// <summary>
        /// The pattern after the required value. It will be removed.
        /// </summary>
        [Input("patternAfter")]
        public Input<string>? PatternAfter { get; set; }

        /// <summary>
        /// The required occurrence of **patternAfter**. Possible values are `FIRST` and `LAST`.
        /// </summary>
        [Input("patternAfterSearchType")]
        public Input<string>? PatternAfterSearchType { get; set; }

        /// <summary>
        /// The pattern before the required value. It will be removed.
        /// </summary>
        [Input("patternBefore")]
        public Input<string>? PatternBefore { get; set; }

        /// <summary>
        /// The required occurrence of **patternBefore**. Possible values are `FIRST` and `LAST`.
        /// </summary>
        [Input("patternBeforeSearchType")]
        public Input<string>? PatternBeforeSearchType { get; set; }

        /// <summary>
        /// The pattern to be replaced. 
        /// 
        ///  Only applicable if the `type` is `REPLACE_WITH_PATTERN`.
        /// </summary>
        [Input("patternToReplace")]
        public Input<string>? PatternToReplace { get; set; }

        /// <summary>
        /// A regular expression for the string to be extracted or replaced. Only applicable if the `type` is `EXTRACT_BY_REGULAR_EXPRESSION` or `REPLACE_WITH_REGULAR_EXPRESSION`.
        /// </summary>
        [Input("regularExpression")]
        public Input<string>? RegularExpression { get; set; }

        /// <summary>
        /// Replacement for the original value
        /// </summary>
        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        /// <summary>
        /// An action to be taken by the processing:
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepGetArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepGetArgs Empty => new WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepGetArgs();
    }
}
