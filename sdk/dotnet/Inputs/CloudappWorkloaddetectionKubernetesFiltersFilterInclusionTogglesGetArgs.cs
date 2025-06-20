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

    public sealed class CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// E.g. "cloud-credential-operator-" for "cloud-credential-operator-5ff6dbff57-gszgq"
        /// </summary>
        [Input("incBasepod", required: true)]
        public Input<bool> IncBasepod { get; set; } = null!;

        /// <summary>
        /// Container name
        /// </summary>
        [Input("incContainer", required: true)]
        public Input<bool> IncContainer { get; set; } = null!;

        /// <summary>
        /// Namespace name
        /// </summary>
        [Input("incNamespace", required: true)]
        public Input<bool> IncNamespace { get; set; } = null!;

        /// <summary>
        /// If Product is enabled and has no value, it defaults to Base pod name
        /// </summary>
        [Input("incProduct", required: true)]
        public Input<bool> IncProduct { get; set; } = null!;

        /// <summary>
        /// Stage
        /// </summary>
        [Input("incStage", required: true)]
        public Input<bool> IncStage { get; set; } = null!;

        public CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesGetArgs()
        {
        }
        public static new CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesGetArgs Empty => new CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesGetArgs();
    }
}
