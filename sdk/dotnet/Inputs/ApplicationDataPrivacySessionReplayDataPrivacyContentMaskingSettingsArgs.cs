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

    public sealed class ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.SessionReplayWebPrivacy`) Configuration of the Session Replay masking during Playback
        /// </summary>
        [Input("playback", required: true)]
        public Input<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsPlaybackArgs> Playback { get; set; } = null!;

        /// <summary>
        /// (Field has overlap with `dynatrace.SessionReplayWebPrivacy`) Configuration of the Session Replay masking during Recording
        /// </summary>
        [Input("recording", required: true)]
        public Input<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingArgs> Recording { get; set; } = null!;

        public ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsArgs()
        {
        }
        public static new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsArgs Empty => new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsArgs();
    }
}
