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

    public sealed class WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of the browser that is used. Possible values are `ANDROID_WEBKIT`, `BOTS_SPIDERS`, `CHROME`, `EDGE`, `FIREFOX`, `INTERNET_EXPLORER,`OPERA`and`SAFARI`
        /// </summary>
        [Input("browserType", required: true)]
        public Input<string> BrowserType { get; set; } = null!;

        /// <summary>
        /// The version of the browser that is used
        /// </summary>
        [Input("browserVersion")]
        public Input<string>? BrowserVersion { get; set; }

        /// <summary>
        /// No documentation available. Possible values are `EQUALS`, `GREATER_THAN_OR_EQUAL` and `LOWER_THAN_OR_EQUAL`.
        /// </summary>
        [Input("comparator")]
        public Input<string>? Comparator { get; set; }

        /// <summary>
        /// The platform on which the browser is being used. Possible values are `ALL`, `DESKTOP` and `MOBILE`
        /// </summary>
        [Input("platform")]
        public Input<string>? Platform { get; set; }

        public WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionGetArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionGetArgs Empty => new WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionGetArgs();
    }
}
