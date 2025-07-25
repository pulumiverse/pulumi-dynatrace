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

    public sealed class OpenpipelineSpansEndpointsEndpointProcessorsProcessorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        [Input("dqlProcessor")]
        public Input<Inputs.OpenpipelineSpansEndpointsEndpointProcessorsProcessorDqlProcessorGetArgs>? DqlProcessor { get; set; }

        /// <summary>
        /// Processor to drop the record either during the processing stage or at the endpoint
        /// </summary>
        [Input("dropProcessor")]
        public Input<Inputs.OpenpipelineSpansEndpointsEndpointProcessorsProcessorDropProcessorGetArgs>? DropProcessor { get; set; }

        /// <summary>
        /// Processor to add fields
        /// </summary>
        [Input("fieldsAddProcessor")]
        public Input<Inputs.OpenpipelineSpansEndpointsEndpointProcessorsProcessorFieldsAddProcessorGetArgs>? FieldsAddProcessor { get; set; }

        /// <summary>
        /// Processor to remove fields
        /// </summary>
        [Input("fieldsRemoveProcessor")]
        public Input<Inputs.OpenpipelineSpansEndpointsEndpointProcessorsProcessorFieldsRemoveProcessorGetArgs>? FieldsRemoveProcessor { get; set; }

        /// <summary>
        /// Processor to rename fields
        /// </summary>
        [Input("fieldsRenameProcessor")]
        public Input<Inputs.OpenpipelineSpansEndpointsEndpointProcessorsProcessorFieldsRenameProcessorGetArgs>? FieldsRenameProcessor { get; set; }

        public OpenpipelineSpansEndpointsEndpointProcessorsProcessorGetArgs()
        {
        }
        public static new OpenpipelineSpansEndpointsEndpointProcessorsProcessorGetArgs Empty => new OpenpipelineSpansEndpointsEndpointProcessorsProcessorGetArgs();
    }
}
