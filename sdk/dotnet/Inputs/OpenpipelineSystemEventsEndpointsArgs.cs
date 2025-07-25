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

    public sealed class OpenpipelineSystemEventsEndpointsArgs : global::Pulumi.ResourceArgs
    {
        [Input("endpoints")]
        private InputList<Inputs.OpenpipelineSystemEventsEndpointsEndpointArgs>? _endpoints;

        /// <summary>
        /// Definition of a single ingest source
        /// </summary>
        public InputList<Inputs.OpenpipelineSystemEventsEndpointsEndpointArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.OpenpipelineSystemEventsEndpointsEndpointArgs>());
            set => _endpoints = value;
        }

        public OpenpipelineSystemEventsEndpointsArgs()
        {
        }
        public static new OpenpipelineSystemEventsEndpointsArgs Empty => new OpenpipelineSystemEventsEndpointsArgs();
    }
}
