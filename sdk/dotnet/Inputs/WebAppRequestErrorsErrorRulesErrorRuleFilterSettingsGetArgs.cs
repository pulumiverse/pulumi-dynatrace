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

    public sealed class WebAppRequestErrorsErrorRulesErrorRuleFilterSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `BEGINS_WITH`, `CONTAINS`, `ENDS_WITH`, `EQUALS`
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public WebAppRequestErrorsErrorRulesErrorRuleFilterSettingsGetArgs()
        {
        }
        public static new WebAppRequestErrorsErrorRulesErrorRuleFilterSettingsGetArgs Empty => new WebAppRequestErrorsErrorRulesErrorRuleFilterSettingsGetArgs();
    }
}
