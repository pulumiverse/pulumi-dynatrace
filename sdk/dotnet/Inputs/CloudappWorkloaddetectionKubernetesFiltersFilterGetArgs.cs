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

    public sealed class CloudappWorkloaddetectionKubernetesFiltersFilterGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// ID calculation based on
        /// </summary>
        [Input("inclusionToggles", required: true)]
        public Input<Inputs.CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesGetArgs> InclusionToggles { get; set; } = null!;

        /// <summary>
        /// When namespace
        /// </summary>
        [Input("matchFilter", required: true)]
        public Input<Inputs.CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterGetArgs> MatchFilter { get; set; } = null!;

        public CloudappWorkloaddetectionKubernetesFiltersFilterGetArgs()
        {
        }
        public static new CloudappWorkloaddetectionKubernetesFiltersFilterGetArgs Empty => new CloudappWorkloaddetectionKubernetesFiltersFilterGetArgs();
    }
}