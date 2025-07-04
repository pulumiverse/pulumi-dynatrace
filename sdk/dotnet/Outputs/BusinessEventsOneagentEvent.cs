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
    public sealed class BusinessEventsOneagentEvent
    {
        /// <summary>
        /// Event category
        /// </summary>
        public readonly Outputs.BusinessEventsOneagentEventCategory Category;
        /// <summary>
        /// Additional attributes for the business event.
        /// </summary>
        public readonly Outputs.BusinessEventsOneagentEventData? Data;
        /// <summary>
        /// Event provider
        /// </summary>
        public readonly Outputs.BusinessEventsOneagentEventProvider Provider;
        /// <summary>
        /// Event type
        /// </summary>
        public readonly Outputs.BusinessEventsOneagentEventType Type;

        [OutputConstructor]
        private BusinessEventsOneagentEvent(
            Outputs.BusinessEventsOneagentEventCategory category,

            Outputs.BusinessEventsOneagentEventData? data,

            Outputs.BusinessEventsOneagentEventProvider provider,

            Outputs.BusinessEventsOneagentEventType type)
        {
            Category = category;
            Data = data;
            Provider = provider;
            Type = type;
        }
    }
}
