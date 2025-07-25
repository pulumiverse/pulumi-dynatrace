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

    public sealed class DavisAnomalyDetectorsAnalyzerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Input fields for the specified analyzer
        /// </summary>
        [Input("input")]
        public Input<Inputs.DavisAnomalyDetectorsAnalyzerInputGetArgs>? Input { get; set; }

        /// <summary>
        /// Fully qualified name of the analyzer
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public DavisAnomalyDetectorsAnalyzerGetArgs()
        {
        }
        public static new DavisAnomalyDetectorsAnalyzerGetArgs Empty => new DavisAnomalyDetectorsAnalyzerGetArgs();
    }
}
