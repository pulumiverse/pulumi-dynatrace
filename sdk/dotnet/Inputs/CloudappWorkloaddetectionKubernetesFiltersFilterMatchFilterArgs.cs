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

    public sealed class CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_STARTS`, `STARTS`
        /// </summary>
        [Input("matchOperator", required: true)]
        public Input<string> MatchOperator { get; set; } = null!;

        /// <summary>
        /// Namespace name
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterArgs()
        {
        }
        public static new CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterArgs Empty => new CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterArgs();
    }
}
