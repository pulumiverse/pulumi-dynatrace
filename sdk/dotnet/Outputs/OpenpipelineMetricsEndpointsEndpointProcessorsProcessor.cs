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
    public sealed class OpenpipelineMetricsEndpointsEndpointProcessorsProcessor
    {
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorDqlProcessor? DqlProcessor;
        /// <summary>
        /// Processor to drop the record either during the processing stage or at the endpoint
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorDropProcessor? DropProcessor;
        /// <summary>
        /// Processor to add fields
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsAddProcessor? FieldsAddProcessor;
        /// <summary>
        /// Processor to remove fields
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsRemoveProcessor? FieldsRemoveProcessor;
        /// <summary>
        /// Processor to rename fields
        /// </summary>
        public readonly Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsRenameProcessor? FieldsRenameProcessor;

        [OutputConstructor]
        private OpenpipelineMetricsEndpointsEndpointProcessorsProcessor(
            Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorDqlProcessor? dqlProcessor,

            Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorDropProcessor? dropProcessor,

            Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsAddProcessor? fieldsAddProcessor,

            Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsRemoveProcessor? fieldsRemoveProcessor,

            Outputs.OpenpipelineMetricsEndpointsEndpointProcessorsProcessorFieldsRenameProcessor? fieldsRenameProcessor)
        {
            DqlProcessor = dqlProcessor;
            DropProcessor = dropProcessor;
            FieldsAddProcessor = fieldsAddProcessor;
            FieldsRemoveProcessor = fieldsRemoveProcessor;
            FieldsRenameProcessor = fieldsRenameProcessor;
        }
    }
}
