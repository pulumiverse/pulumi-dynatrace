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
    public sealed class NotificationTrello
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
        /// The application key for the Trello account
        /// </summary>
        public readonly string ApplicationKey;
        /// <summary>
        /// The application token for the Trello account
        /// </summary>
        public readonly string? AuthorizationToken;
        /// <summary>
        /// The Trello board to which the card should be assigned
        /// </summary>
        public readonly string BoardId;
        /// <summary>
        /// The description of the Trello card.   You can use same placeholders as in card text
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The Trello list to which the card should be assigned
        /// </summary>
        public readonly string ListId;
        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Trello list to which the card of the resolved problem should be assigned
        /// </summary>
        public readonly string ResolvedListId;
        /// <summary>
        /// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        public readonly string Text;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private NotificationTrello(
            bool active,

            string alertingProfile,

            string applicationKey,

            string? authorizationToken,

            string boardId,

            string description,

            string listId,

            string name,

            string resolvedListId,

            string text,

            string? unknowns)
        {
            Active = active;
            AlertingProfile = alertingProfile;
            ApplicationKey = applicationKey;
            AuthorizationToken = authorizationToken;
            BoardId = boardId;
            Description = description;
            ListId = listId;
            Name = name;
            ResolvedListId = resolvedListId;
            Text = text;
            Unknowns = unknowns;
        }
    }
}
