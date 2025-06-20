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

    public sealed class OpenpipelineSecurityEventsRoutingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("entries")]
        private InputList<Inputs.OpenpipelineSecurityEventsRoutingEntryGetArgs>? _entries;

        /// <summary>
        /// Dynamic routing entry
        /// </summary>
        public InputList<Inputs.OpenpipelineSecurityEventsRoutingEntryGetArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.OpenpipelineSecurityEventsRoutingEntryGetArgs>());
            set => _entries = value;
        }

        public OpenpipelineSecurityEventsRoutingGetArgs()
        {
        }
        public static new OpenpipelineSecurityEventsRoutingGetArgs Empty => new OpenpipelineSecurityEventsRoutingGetArgs();
    }
}
