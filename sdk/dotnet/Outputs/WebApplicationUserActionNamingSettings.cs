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
    public sealed class WebApplicationUserActionNamingSettings
    {
        /// <summary>
        /// User action naming rules for custom actions
        /// </summary>
        public readonly Outputs.WebApplicationUserActionNamingSettingsCustomActionNamingRules? CustomActionNamingRules;
        /// <summary>
        /// Case insensitive naming
        /// </summary>
        public readonly bool? IgnoreCase;
        /// <summary>
        /// User action naming rules for loading actions
        /// </summary>
        public readonly Outputs.WebApplicationUserActionNamingSettingsLoadActionNamingRules? LoadActionNamingRules;
        /// <summary>
        /// User action placeholders
        /// </summary>
        public readonly Outputs.WebApplicationUserActionNamingSettingsPlaceholders? Placeholders;
        /// <summary>
        /// User action naming rules for custom actions. If not specified Dynatrace assumes `__sid`, `cfid`, `cftoken`, `phpsessid` and `sid`.
        /// </summary>
        public readonly ImmutableArray<string> QueryParameterCleanups;
        /// <summary>
        /// Deactivate this setting if different domains should not result in separate user actions
        /// </summary>
        public readonly bool? SplitUserActionsByDomain;
        /// <summary>
        /// First load action found under an XHR action should be used when true. Else the deepest one under the xhr action is used
        /// </summary>
        public readonly bool? UseFirstDetectedLoadAction;
        /// <summary>
        /// User action naming rules for XHR actions
        /// </summary>
        public readonly Outputs.WebApplicationUserActionNamingSettingsXhrActionNamingRules? XhrActionNamingRules;

        [OutputConstructor]
        private WebApplicationUserActionNamingSettings(
            Outputs.WebApplicationUserActionNamingSettingsCustomActionNamingRules? customActionNamingRules,

            bool? ignoreCase,

            Outputs.WebApplicationUserActionNamingSettingsLoadActionNamingRules? loadActionNamingRules,

            Outputs.WebApplicationUserActionNamingSettingsPlaceholders? placeholders,

            ImmutableArray<string> queryParameterCleanups,

            bool? splitUserActionsByDomain,

            bool? useFirstDetectedLoadAction,

            Outputs.WebApplicationUserActionNamingSettingsXhrActionNamingRules? xhrActionNamingRules)
        {
            CustomActionNamingRules = customActionNamingRules;
            IgnoreCase = ignoreCase;
            LoadActionNamingRules = loadActionNamingRules;
            Placeholders = placeholders;
            QueryParameterCleanups = queryParameterCleanups;
            SplitUserActionsByDomain = splitUserActionsByDomain;
            UseFirstDetectedLoadAction = useFirstDetectedLoadAction;
            XhrActionNamingRules = xhrActionNamingRules;
        }
    }
}
