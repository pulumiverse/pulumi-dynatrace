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

    public sealed class OpenpipelineSdlcEventsRoutingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("entries")]
        private InputList<Inputs.OpenpipelineSdlcEventsRoutingEntryGetArgs>? _entries;

        /// <summary>
        /// Dynamic routing entry
        /// </summary>
        public InputList<Inputs.OpenpipelineSdlcEventsRoutingEntryGetArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.OpenpipelineSdlcEventsRoutingEntryGetArgs>());
            set => _entries = value;
        }

        public OpenpipelineSdlcEventsRoutingGetArgs()
        {
        }
        public static new OpenpipelineSdlcEventsRoutingGetArgs Empty => new OpenpipelineSdlcEventsRoutingGetArgs();
    }
}
