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

    public sealed class GenericRelationshipsSourcesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("sources", required: true)]
        private InputList<Inputs.GenericRelationshipsSourcesSourceGetArgs>? _sources;
        public InputList<Inputs.GenericRelationshipsSourcesSourceGetArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.GenericRelationshipsSourcesSourceGetArgs>());
            set => _sources = value;
        }

        public GenericRelationshipsSourcesGetArgs()
        {
        }
        public static new GenericRelationshipsSourcesGetArgs Empty => new GenericRelationshipsSourcesGetArgs();
    }
}
