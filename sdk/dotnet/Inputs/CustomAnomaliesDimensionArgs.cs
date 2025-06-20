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

    public sealed class CustomAnomaliesDimensionArgs : global::Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputList<Inputs.CustomAnomaliesDimensionDimensionArgs>? _dimensions;

        /// <summary>
        /// A generic definition for a filter
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionDimensionArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.CustomAnomaliesDimensionDimensionArgs>());
            set => _dimensions = value;
        }

        [Input("entities")]
        private InputList<Inputs.CustomAnomaliesDimensionEntityArgs>? _entities;

        /// <summary>
        /// A filter for the metrics entity dimensions
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionEntityArgs> Entities
        {
            get => _entities ?? (_entities = new InputList<Inputs.CustomAnomaliesDimensionEntityArgs>());
            set => _entities = value;
        }

        [Input("strings")]
        private InputList<Inputs.CustomAnomaliesDimensionStringArgs>? _strings;

        /// <summary>
        /// A filter for the metrics string dimensions
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionStringArgs> Strings
        {
            get => _strings ?? (_strings = new InputList<Inputs.CustomAnomaliesDimensionStringArgs>());
            set => _strings = value;
        }

        public CustomAnomaliesDimensionArgs()
        {
        }
        public static new CustomAnomaliesDimensionArgs Empty => new CustomAnomaliesDimensionArgs();
    }
}
