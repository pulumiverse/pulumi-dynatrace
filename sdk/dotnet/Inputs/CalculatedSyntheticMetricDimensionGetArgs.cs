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

    public sealed class CalculatedSyntheticMetricDimensionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputList<Inputs.CalculatedSyntheticMetricDimensionDimensionGetArgs>? _dimensions;

        /// <summary>
        /// A dimensions for the metric usage
        /// </summary>
        public InputList<Inputs.CalculatedSyntheticMetricDimensionDimensionGetArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.CalculatedSyntheticMetricDimensionDimensionGetArgs>());
            set => _dimensions = value;
        }

        public CalculatedSyntheticMetricDimensionGetArgs()
        {
        }
        public static new CalculatedSyntheticMetricDimensionGetArgs Empty => new CalculatedSyntheticMetricDimensionGetArgs();
    }
}
