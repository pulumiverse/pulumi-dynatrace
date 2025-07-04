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

    public sealed class ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of the masking:
        /// </summary>
        [Input("preset", required: true)]
        public Input<string> Preset { get; set; } = null!;

        /// <summary>
        /// A list of masking rules
        /// </summary>
        [Input("rules")]
        public Input<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesGetArgs>? Rules { get; set; }

        public ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingGetArgs()
        {
        }
        public static new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingGetArgs Empty => new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingGetArgs();
    }
}
