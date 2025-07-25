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
    public sealed class ServiceFullWebRequestIdContributors
    {
        /// <summary>
        /// Application identifier
        /// </summary>
        public readonly Outputs.ServiceFullWebRequestIdContributorsApplicationId ApplicationId;
        /// <summary>
        /// The context root is the first segment of the request URL after the Server name. For example, in the `www.dynatrace.com/support/help/dynatrace-api/` URL the context root is `/support`. The context root value can be found on the **Service overview page** under **Properties and tags**.
        /// </summary>
        public readonly Outputs.ServiceFullWebRequestIdContributorsContextRoot ContextRoot;
        /// <summary>
        /// Server Name
        /// </summary>
        public readonly Outputs.ServiceFullWebRequestIdContributorsServerName ServerName;

        [OutputConstructor]
        private ServiceFullWebRequestIdContributors(
            Outputs.ServiceFullWebRequestIdContributorsApplicationId applicationId,

            Outputs.ServiceFullWebRequestIdContributorsContextRoot contextRoot,

            Outputs.ServiceFullWebRequestIdContributorsServerName serverName)
        {
            ApplicationId = applicationId;
            ContextRoot = contextRoot;
            ServerName = serverName;
        }
    }
}
