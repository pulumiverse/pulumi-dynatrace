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

    public sealed class DashboardDashboardMetadataDynamicFiltersArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters", required: true)]
        private InputList<string>? _filters;

        /// <summary>
        /// A set of all possible global dashboard filters that can be applied to a dashboard
        /// </summary>
        public InputList<string> Filters
        {
            get => _filters ?? (_filters = new InputList<string>());
            set => _filters = value;
        }

        /// <summary>
        /// A set of generic tag filters that can be applied to a dashboard
        /// </summary>
        [Input("genericTagFilters")]
        public Input<Inputs.DashboardDashboardMetadataDynamicFiltersGenericTagFiltersArgs>? GenericTagFilters { get; set; }

        [Input("tagSuggestionTypes")]
        private InputList<string>? _tagSuggestionTypes;

        /// <summary>
        /// A set of entities applied for tag filter suggestions. You can fetch the list of possible values with the [GET all entity types](https://dt-url.net/dw03s7h)request. 
        /// 
        /// Only applicable if the **filters** set includes `TAG_KEY:&lt;tagname&gt;`
        /// </summary>
        public InputList<string> TagSuggestionTypes
        {
            get => _tagSuggestionTypes ?? (_tagSuggestionTypes = new InputList<string>());
            set => _tagSuggestionTypes = value;
        }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public DashboardDashboardMetadataDynamicFiltersArgs()
        {
        }
        public static new DashboardDashboardMetadataDynamicFiltersArgs Empty => new DashboardDashboardMetadataDynamicFiltersArgs();
    }
}