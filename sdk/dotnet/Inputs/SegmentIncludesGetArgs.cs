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

    public sealed class SegmentIncludesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("items")]
        private InputList<Inputs.SegmentIncludesItemGetArgs>? _items;

        /// <summary>
        /// TODO: No documentation available
        /// </summary>
        public InputList<Inputs.SegmentIncludesItemGetArgs> Items
        {
            get => _items ?? (_items = new InputList<Inputs.SegmentIncludesItemGetArgs>());
            set => _items = value;
        }

        public SegmentIncludesGetArgs()
        {
        }
        public static new SegmentIncludesGetArgs Empty => new SegmentIncludesGetArgs();
    }
}
