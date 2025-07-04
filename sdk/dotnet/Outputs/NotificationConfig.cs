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
    public sealed class NotificationConfig
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
        /// The name of the notification configuration
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the actual set of fields depending on the value. See one of the following objects:  * `EMAIL` &gt; EmailNotificationConfig  * `PAGER_DUTY` &gt; PagerDutyNotificationConfig  * `WEBHOOK` &gt; WebHookNotificationConfig  * `SLACK` &gt; SlackNotificationConfig  * `HIPCHAT` &gt; HipChatNotificationConfig  * `VICTOROPS` &gt; VictorOpsNotificationConfig  * `SERVICE_NOW` &gt; ServiceNowNotificationConfig  * `XMATTERS` &gt; XMattersNotificationConfig  * `ANSIBLETOWER` &gt; AnsibleTowerNotificationConfig  * `OPS_GENIE` &gt; OpsGenieNotificationConfig  * `JIRA` &gt; JiraNotificationConfig  * `TRELLO` &gt; TrelloNotificationConfig
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private NotificationConfig(
            bool active,

            string alertingProfile,

            string name,

            string type,

            string? unknowns)
        {
            Active = active;
            AlertingProfile = alertingProfile;
            Name = name;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
