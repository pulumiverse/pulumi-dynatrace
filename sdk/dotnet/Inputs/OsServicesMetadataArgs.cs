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

    public sealed class OsServicesMetadataArgs : global::Pulumi.ResourceArgs
    {
        [Input("items", required: true)]
        private InputList<Inputs.OsServicesMetadataItemArgs>? _items;
        public InputList<Inputs.OsServicesMetadataItemArgs> Items
        {
            get => _items ?? (_items = new InputList<Inputs.OsServicesMetadataItemArgs>());
            set => _items = value;
        }

        public OsServicesMetadataArgs()
        {
        }
        public static new OsServicesMetadataArgs Empty => new OsServicesMetadataArgs();
    }
}
