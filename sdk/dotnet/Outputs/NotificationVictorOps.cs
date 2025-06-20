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
    public sealed class NotificationVictorOps
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Active;
        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        public readonly string AlertingProfile;
        /// <summary>
        /// The API key for the target VictorOps account
        /// </summary>
        public readonly string? ApiKey;
        /// <summary>
        /// The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The routing key, defining the group to be notified
        /// </summary>
        public readonly string RoutingKey;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private NotificationVictorOps(
            bool active,

            string alertingProfile,

            string? apiKey,

            string message,

            string name,

            string routingKey,

            string? unknowns)
        {
            Active = active;
            AlertingProfile = alertingProfile;
            ApiKey = apiKey;
            Message = message;
            Name = name;
            RoutingKey = routingKey;
            Unknowns = unknowns;
        }
    }
}
