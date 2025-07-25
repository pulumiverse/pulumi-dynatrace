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

    public sealed class OpenpipelineSystemEventsRoutingArgs : global::Pulumi.ResourceArgs
    {
        [Input("entries")]
        private InputList<Inputs.OpenpipelineSystemEventsRoutingEntryArgs>? _entries;

        /// <summary>
        /// Dynamic routing entry
        /// </summary>
        public InputList<Inputs.OpenpipelineSystemEventsRoutingEntryArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.OpenpipelineSystemEventsRoutingEntryArgs>());
            set => _entries = value;
        }

        public OpenpipelineSystemEventsRoutingArgs()
        {
        }
        public static new OpenpipelineSystemEventsRoutingArgs Empty => new OpenpipelineSystemEventsRoutingArgs();
    }
}
