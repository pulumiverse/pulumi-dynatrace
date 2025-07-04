// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class DavisAnomalyDetectorsAnalyzer
    {
        /// <summary>
        /// Input fields for the specified analyzer
        /// </summary>
        public readonly Outputs.DavisAnomalyDetectorsAnalyzerInput? Input;
        /// <summary>
        /// Fully qualified name of the analyzer
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private DavisAnomalyDetectorsAnalyzer(
            Outputs.DavisAnomalyDetectorsAnalyzerInput? input,

            string name)
        {
            Input = input;
            Name = name;
        }
    }
}
