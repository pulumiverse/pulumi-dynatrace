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

    public sealed class OpenpipelineMetricsEndpointsArgs : global::Pulumi.ResourceArgs
    {
        [Input("endpoints")]
        private InputList<Inputs.OpenpipelineMetricsEndpointsEndpointArgs>? _endpoints;

        /// <summary>
        /// Definition of a single ingest source
        /// </summary>
        public InputList<Inputs.OpenpipelineMetricsEndpointsEndpointArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.OpenpipelineMetricsEndpointsEndpointArgs>());
            set => _endpoints = value;
        }

        public OpenpipelineMetricsEndpointsArgs()
        {
        }
        public static new OpenpipelineMetricsEndpointsArgs Empty => new OpenpipelineMetricsEndpointsArgs();
    }
}
