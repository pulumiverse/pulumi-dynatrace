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

    public sealed class OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessorFieldArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the field
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Value to assign to the field
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessorFieldArgs()
        {
        }
        public static new OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessorFieldArgs Empty => new OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessorFieldArgs();
    }
}
