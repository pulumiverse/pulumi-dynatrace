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

    public sealed class WebApplicationUserActionNamingSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// User action naming rules for custom actions
        /// </summary>
        [Input("customActionNamingRules")]
        public Input<Inputs.WebApplicationUserActionNamingSettingsCustomActionNamingRulesArgs>? CustomActionNamingRules { get; set; }

        /// <summary>
        /// Case insensitive naming
        /// </summary>
        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        /// <summary>
        /// User action naming rules for loading actions
        /// </summary>
        [Input("loadActionNamingRules")]
        public Input<Inputs.WebApplicationUserActionNamingSettingsLoadActionNamingRulesArgs>? LoadActionNamingRules { get; set; }

        /// <summary>
        /// User action placeholders
        /// </summary>
        [Input("placeholders")]
        public Input<Inputs.WebApplicationUserActionNamingSettingsPlaceholdersArgs>? Placeholders { get; set; }

        [Input("queryParameterCleanups")]
        private InputList<string>? _queryParameterCleanups;

        /// <summary>
        /// User action naming rules for custom actions. If not specified Dynatrace assumes `__sid`, `cfid`, `cftoken`, `phpsessid` and `sid`.
        /// </summary>
        public InputList<string> QueryParameterCleanups
        {
            get => _queryParameterCleanups ?? (_queryParameterCleanups = new InputList<string>());
            set => _queryParameterCleanups = value;
        }

        /// <summary>
        /// Deactivate this setting if different domains should not result in separate user actions
        /// </summary>
        [Input("splitUserActionsByDomain")]
        public Input<bool>? SplitUserActionsByDomain { get; set; }

        /// <summary>
        /// First load action found under an XHR action should be used when true. Else the deepest one under the xhr action is used
        /// </summary>
        [Input("useFirstDetectedLoadAction")]
        public Input<bool>? UseFirstDetectedLoadAction { get; set; }

        /// <summary>
        /// User action naming rules for XHR actions
        /// </summary>
        [Input("xhrActionNamingRules")]
        public Input<Inputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesArgs>? XhrActionNamingRules { get; set; }

        public WebApplicationUserActionNamingSettingsArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsArgs Empty => new WebApplicationUserActionNamingSettingsArgs();
    }
}
