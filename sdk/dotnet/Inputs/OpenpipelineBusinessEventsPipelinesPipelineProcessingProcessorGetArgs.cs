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

    public sealed class OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to apply a DQL script
        /// </summary>
        [Input("dqlProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorDqlProcessorGetArgs>? DqlProcessor { get; set; }

        /// <summary>
        /// Processor to add fields
        /// </summary>
        [Input("fieldsAddProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorFieldsAddProcessorGetArgs>? FieldsAddProcessor { get; set; }

        /// <summary>
        /// Processor to remove fields
        /// </summary>
        [Input("fieldsRemoveProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorFieldsRemoveProcessorGetArgs>? FieldsRemoveProcessor { get; set; }

        /// <summary>
        /// Processor to rename fields
        /// </summary>
        [Input("fieldsRenameProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorFieldsRenameProcessorGetArgs>? FieldsRenameProcessor { get; set; }

        /// <summary>
        /// Processor to apply a technology processors
        /// </summary>
        [Input("technologyProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorTechnologyProcessorGetArgs>? TechnologyProcessor { get; set; }

        public OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorGetArgs()
        {
        }
        public static new OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorGetArgs Empty => new OpenpipelineBusinessEventsPipelinesPipelineProcessingProcessorGetArgs();
    }
}