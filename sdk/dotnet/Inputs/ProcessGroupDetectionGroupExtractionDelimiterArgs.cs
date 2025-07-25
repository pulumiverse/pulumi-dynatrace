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

    public sealed class ProcessGroupDetectionGroupExtractionDelimiterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Delimit from
        /// </summary>
        [Input("from")]
        public Input<string>? From { get; set; }

        /// <summary>
        /// (e.g. versions, hex, dates, and build numbers)
        /// </summary>
        [Input("removeIds", required: true)]
        public Input<bool> RemoveIds { get; set; } = null!;

        /// <summary>
        /// Delimit to
        /// </summary>
        [Input("to")]
        public Input<string>? To { get; set; }

        public ProcessGroupDetectionGroupExtractionDelimiterArgs()
        {
        }
        public static new ProcessGroupDetectionGroupExtractionDelimiterArgs Empty => new ProcessGroupDetectionGroupExtractionDelimiterArgs();
    }
}
