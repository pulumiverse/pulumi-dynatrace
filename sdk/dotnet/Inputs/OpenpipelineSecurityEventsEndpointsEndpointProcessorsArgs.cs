// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class OpenpipelineSecurityEventsEndpointsEndpointProcessorsArgs : global::Pulumi.ResourceArgs
    {
        [Input("processors")]
        private InputList<Inputs.OpenpipelineSecurityEventsEndpointsEndpointProcessorsProcessorArgs>? _processors;

        /// <summary>
        /// Groups all processors applicable for processing in the EndpointDefinition.
        /// Applicable processors are DqlProcessor, FieldsAddProcessor, FieldsRemoveProcessor, FieldsRenameProcessor and DropProcessor.
        /// </summary>
        public InputList<Inputs.OpenpipelineSecurityEventsEndpointsEndpointProcessorsProcessorArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.OpenpipelineSecurityEventsEndpointsEndpointProcessorsProcessorArgs>());
            set => _processors = value;
        }

        public OpenpipelineSecurityEventsEndpointsEndpointProcessorsArgs()
        {
        }
        public static new OpenpipelineSecurityEventsEndpointsEndpointProcessorsArgs Empty => new OpenpipelineSecurityEventsEndpointsEndpointProcessorsArgs();
    }
}