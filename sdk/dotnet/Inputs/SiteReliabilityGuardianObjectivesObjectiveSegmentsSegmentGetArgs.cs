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

    public sealed class SiteReliabilityGuardianObjectivesObjectiveSegmentsSegmentGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Segment ID
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Segment Variables
        /// </summary>
        [Input("variables")]
        public Input<Inputs.SiteReliabilityGuardianObjectivesObjectiveSegmentsSegmentVariablesGetArgs>? Variables { get; set; }

        public SiteReliabilityGuardianObjectivesObjectiveSegmentsSegmentGetArgs()
        {
        }
        public static new SiteReliabilityGuardianObjectivesObjectiveSegmentsSegmentGetArgs Empty => new SiteReliabilityGuardianObjectivesObjectiveSegmentsSegmentGetArgs();
    }
}
