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

    public sealed class DavisCopilotBlocklistEntriesArgs : global::Pulumi.ResourceArgs
    {
        [Input("blocklistEntries", required: true)]
        private InputList<Inputs.DavisCopilotBlocklistEntriesBlocklistEntryArgs>? _blocklistEntries;
        public InputList<Inputs.DavisCopilotBlocklistEntriesBlocklistEntryArgs> BlocklistEntries
        {
            get => _blocklistEntries ?? (_blocklistEntries = new InputList<Inputs.DavisCopilotBlocklistEntriesBlocklistEntryArgs>());
            set => _blocklistEntries = value;
        }

        public DavisCopilotBlocklistEntriesArgs()
        {
        }
        public static new DavisCopilotBlocklistEntriesArgs Empty => new DavisCopilotBlocklistEntriesArgs();
    }
}
