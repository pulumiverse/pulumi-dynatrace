// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/jiraNotification:JiraNotification")]
    public partial class JiraNotification : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("active")]
        public Output<bool> Active { get; private set; } = null!;

        /// <summary>
        /// The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
        /// </summary>
        [Output("apiToken")]
        public Output<string?> ApiToken { get; private set; } = null!;

        /// <summary>
        /// The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The type of the Jira issue to be created by this notification
        /// </summary>
        [Output("issueType")]
        public Output<string> IssueType { get; private set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Output("profile")]
        public Output<string> Profile { get; private set; } = null!;

        /// <summary>
        /// The project key of the Jira issue to be created by this notification
        /// </summary>
        [Output("projectKey")]
        public Output<string> ProjectKey { get; private set; } = null!;

        /// <summary>
        /// The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Output("summary")]
        public Output<string> Summary { get; private set; } = null!;

        /// <summary>
        /// The URL of the Jira API endpoint
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;

        /// <summary>
        /// The username of the Jira profile
        /// </summary>
        [Output("username")]
        public Output<string> Username { get; private set; } = null!;


        /// <summary>
        /// Create a JiraNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public JiraNotification(string name, JiraNotificationArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/jiraNotification:JiraNotification", name, args ?? new JiraNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private JiraNotification(string name, Input<string> id, JiraNotificationState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/jiraNotification:JiraNotification", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
                AdditionalSecretOutputs =
                {
                    "apiToken",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing JiraNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static JiraNotification Get(string name, Input<string> id, JiraNotificationState? state = null, CustomResourceOptions? options = null)
        {
            return new JiraNotification(name, id, state, options);
        }
    }

    public sealed class JiraNotificationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("apiToken")]
        private Input<string>? _apiToken;

        /// <summary>
        /// The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
        /// </summary>
        public Input<string>? ApiToken
        {
            get => _apiToken;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiToken = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// The type of the Jira issue to be created by this notification
        /// </summary>
        [Input("issueType", required: true)]
        public Input<string> IssueType { get; set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Input("profile", required: true)]
        public Input<string> Profile { get; set; } = null!;

        /// <summary>
        /// The project key of the Jira issue to be created by this notification
        /// </summary>
        [Input("projectKey", required: true)]
        public Input<string> ProjectKey { get; set; } = null!;

        /// <summary>
        /// The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Input("summary", required: true)]
        public Input<string> Summary { get; set; } = null!;

        /// <summary>
        /// The URL of the Jira API endpoint
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// The username of the Jira profile
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public JiraNotificationArgs()
        {
        }
        public static new JiraNotificationArgs Empty => new JiraNotificationArgs();
    }

    public sealed class JiraNotificationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("apiToken")]
        private Input<string>? _apiToken;

        /// <summary>
        /// The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
        /// </summary>
        public Input<string>? ApiToken
        {
            get => _apiToken;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiToken = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The type of the Jira issue to be created by this notification
        /// </summary>
        [Input("issueType")]
        public Input<string>? IssueType { get; set; }

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Input("profile")]
        public Input<string>? Profile { get; set; }

        /// <summary>
        /// The project key of the Jira issue to be created by this notification
        /// </summary>
        [Input("projectKey")]
        public Input<string>? ProjectKey { get; set; }

        /// <summary>
        /// The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Input("summary")]
        public Input<string>? Summary { get; set; }

        /// <summary>
        /// The URL of the Jira API endpoint
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        /// <summary>
        /// The username of the Jira profile
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public JiraNotificationState()
        {
        }
        public static new JiraNotificationState Empty => new JiraNotificationState();
    }
}
