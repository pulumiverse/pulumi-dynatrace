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
    public sealed class OpenpipelineEventsEndpointsEndpointProcessorsProcessor
    {
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        public readonly Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorDqlProcessor? DqlProcessor;
        /// <summary>
        /// Processor to add fields
        /// </summary>
        public readonly Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessor? FieldsAddProcessor;
        /// <summary>
        /// Processor to remove fields
        /// </summary>
        public readonly Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsRemoveProcessor? FieldsRemoveProcessor;
        /// <summary>
        /// Processor to rename fields
        /// </summary>
        public readonly Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsRenameProcessor? FieldsRenameProcessor;

        [OutputConstructor]
        private OpenpipelineEventsEndpointsEndpointProcessorsProcessor(
            Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorDqlProcessor? dqlProcessor,

            Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsAddProcessor? fieldsAddProcessor,

            Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsRemoveProcessor? fieldsRemoveProcessor,

            Outputs.OpenpipelineEventsEndpointsEndpointProcessorsProcessorFieldsRenameProcessor? fieldsRenameProcessor)
        {
            DqlProcessor = dqlProcessor;
            FieldsAddProcessor = fieldsAddProcessor;
            FieldsRemoveProcessor = fieldsRemoveProcessor;
            FieldsRenameProcessor = fieldsRenameProcessor;
        }
    }
}
