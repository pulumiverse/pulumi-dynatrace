// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class OpenpipelineLogsRoutingArgs : global::Pulumi.ResourceArgs
    {
        [Input("entries")]
        private InputList<Inputs.OpenpipelineLogsRoutingEntryArgs>? _entries;

        /// <summary>
        /// Dynamic routing entry
        /// </summary>
        public InputList<Inputs.OpenpipelineLogsRoutingEntryArgs> Entries
        {
            get => _entries ?? (_entries = new InputList<Inputs.OpenpipelineLogsRoutingEntryArgs>());
            set => _entries = value;
        }

        public OpenpipelineLogsRoutingArgs()
        {
        }
        public static new OpenpipelineLogsRoutingArgs Empty => new OpenpipelineLogsRoutingArgs();
    }
}