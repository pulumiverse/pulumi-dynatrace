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

    public sealed class CustomTagsTagsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.CustomTagsTagsFilterGetArgs>? _filters;

        /// <summary>
        /// A Tag Filter
        /// </summary>
        public InputList<Inputs.CustomTagsTagsFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.CustomTagsTagsFilterGetArgs>());
            set => _filters = value;
        }

        public CustomTagsTagsGetArgs()
        {
        }
        public static new CustomTagsTagsGetArgs Empty => new CustomTagsTagsGetArgs();
    }
}
