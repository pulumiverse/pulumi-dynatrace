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

    public sealed class OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Processor to set the security context field
        /// </summary>
        [Input("securityContextProcessor")]
        public Input<Inputs.OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorSecurityContextProcessorGetArgs>? SecurityContextProcessor { get; set; }

        public OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorGetArgs()
        {
        }
        public static new OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorGetArgs Empty => new OpenpipelineBusinessEventsPipelinesPipelineSecurityContextProcessorGetArgs();
    }
}