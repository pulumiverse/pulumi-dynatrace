// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class OpenpipelineSdlcEventsEndpointsEndpointProcessors
    {
        /// <summary>
        /// Groups all processors applicable for processing in the EndpointDefinition.
        /// Applicable processors are DqlProcessor, FieldsAddProcessor, FieldsRemoveProcessor, FieldsRenameProcessor and DropProcessor.
        /// </summary>
        public readonly ImmutableArray<Outputs.OpenpipelineSdlcEventsEndpointsEndpointProcessorsProcessor> Processors;

        [OutputConstructor]
        private OpenpipelineSdlcEventsEndpointsEndpointProcessors(ImmutableArray<Outputs.OpenpipelineSdlcEventsEndpointsEndpointProcessorsProcessor> processors)
        {
            Processors = processors;
        }
    }
}