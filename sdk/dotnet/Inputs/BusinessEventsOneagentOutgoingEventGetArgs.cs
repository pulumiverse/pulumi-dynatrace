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

    public sealed class BusinessEventsOneagentOutgoingEventGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Event category
        /// </summary>
        [Input("category", required: true)]
        public Input<Inputs.BusinessEventsOneagentOutgoingEventCategoryGetArgs> Category { get; set; } = null!;

        /// <summary>
        /// Additional attributes for the business event.
        /// </summary>
        [Input("data")]
        public Input<Inputs.BusinessEventsOneagentOutgoingEventDataGetArgs>? Data { get; set; }

        /// <summary>
        /// Event provider
        /// </summary>
        [Input("provider", required: true)]
        public Input<Inputs.BusinessEventsOneagentOutgoingEventProviderGetArgs> Provider { get; set; } = null!;

        /// <summary>
        /// Event type
        /// </summary>
        [Input("type", required: true)]
        public Input<Inputs.BusinessEventsOneagentOutgoingEventTypeGetArgs> Type { get; set; } = null!;

        public BusinessEventsOneagentOutgoingEventGetArgs()
        {
        }
        public static new BusinessEventsOneagentOutgoingEventGetArgs Empty => new BusinessEventsOneagentOutgoingEventGetArgs();
    }
}
