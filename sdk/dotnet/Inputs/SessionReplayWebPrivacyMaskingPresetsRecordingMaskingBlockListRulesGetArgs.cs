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

    public sealed class SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("blockListRules", required: true)]
        private InputList<Inputs.SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesBlockListRuleGetArgs>? _blockListRules;
        public InputList<Inputs.SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesBlockListRuleGetArgs> BlockListRules
        {
            get => _blockListRules ?? (_blockListRules = new InputList<Inputs.SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesBlockListRuleGetArgs>());
            set => _blockListRules = value;
        }

        public SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesGetArgs()
        {
        }
        public static new SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesGetArgs Empty => new SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesGetArgs();
    }
}
