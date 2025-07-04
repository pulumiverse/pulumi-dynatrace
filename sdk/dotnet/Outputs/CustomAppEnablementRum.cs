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
    public sealed class CustomAppEnablementRum
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.MobileApplication`) Percentage of user sessions captured and analyzed. By default, Dynatrace captures all user actions and user sessions for analysis. This approach ensures complete insight into your application’s performance and customer experience. You can optionally reduce the granularity of user-action and user-session analysis by capturing a lower percentage of user sessions. While this approach can reduce monitoring costs, it also results in lower visibility into how your customers are using your applications. For example, a setting of 10% results in Dynatrace analyzing only every tenth user session.
        /// </summary>
        public readonly int CostAndTrafficControl;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private CustomAppEnablementRum(
            int costAndTrafficControl,

            bool enabled)
        {
            CostAndTrafficControl = costAndTrafficControl;
            Enabled = enabled;
        }
    }
}
