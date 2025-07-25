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

    public sealed class ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsPlaybackRulesRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The selector for the element or the attribute to be masked.
        /// </summary>
        [Input("selector", required: true)]
        public Input<string> Selector { get; set; } = null!;

        /// <summary>
        /// The type of the masking rule
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Interactions with the element are (`true`) or are not (`false) masked
        /// </summary>
        [Input("userInteractionHidden")]
        public Input<bool>? UserInteractionHidden { get; set; }

        public ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsPlaybackRulesRuleArgs()
        {
        }
        public static new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsPlaybackRulesRuleArgs Empty => new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsPlaybackRulesRuleArgs();
    }
}
