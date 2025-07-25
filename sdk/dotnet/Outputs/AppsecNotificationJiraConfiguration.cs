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
    public sealed class AppsecNotificationJiraConfiguration
    {
        /// <summary>
        /// The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
        /// </summary>
        public readonly string ApiToken;
        /// <summary>
        /// The type of the Jira issue to be created by this notification.
        /// 
        /// To find all available issue types or create your own, in Jira, go to Project settings &gt; Issue types.
        /// </summary>
        public readonly string IssueType;
        /// <summary>
        /// The project key of the Jira issue to be created by this notification.
        /// </summary>
        public readonly string ProjectKey;
        /// <summary>
        /// The URL of the Jira API endpoint.
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// The username of the Jira profile.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private AppsecNotificationJiraConfiguration(
            string apiToken,

            string issueType,

            string projectKey,

            string url,

            string username)
        {
            ApiToken = apiToken;
            IssueType = issueType;
            ProjectKey = projectKey;
            Url = url;
            Username = username;
        }
    }
}
