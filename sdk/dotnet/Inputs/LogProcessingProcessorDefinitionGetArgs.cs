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

    public sealed class LogProcessingProcessorDefinitionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor definition
        /// </summary>
        [Input("rule", required: true)]
        public Input<string> Rule { get; set; } = null!;

        public LogProcessingProcessorDefinitionGetArgs()
        {
        }
        public static new LogProcessingProcessorDefinitionGetArgs Empty => new LogProcessingProcessorDefinitionGetArgs();
    }
}
