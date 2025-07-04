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

    public sealed class HostAnomaliesJavaOutOfThreadsThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if the number of Java out of threads exceptions is *X* per minute or higher
        /// </summary>
        [Input("exceptionCount", required: true)]
        public Input<int> ExceptionCount { get; set; } = null!;

        public HostAnomaliesJavaOutOfThreadsThresholdsArgs()
        {
        }
        public static new HostAnomaliesJavaOutOfThreadsThresholdsArgs Empty => new HostAnomaliesJavaOutOfThreadsThresholdsArgs();
    }
}
