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

    public sealed class BusinessEventsOneagentOutgoingEventDataEventDataFieldComplexArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field name to be added to data.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("source", required: true)]
        public Input<Inputs.BusinessEventsOneagentOutgoingEventDataEventDataFieldComplexSourceArgs> Source { get; set; } = null!;

        public BusinessEventsOneagentOutgoingEventDataEventDataFieldComplexArgs()
        {
        }
        public static new BusinessEventsOneagentOutgoingEventDataEventDataFieldComplexArgs Empty => new BusinessEventsOneagentOutgoingEventDataEventDataFieldComplexArgs();
    }
}
