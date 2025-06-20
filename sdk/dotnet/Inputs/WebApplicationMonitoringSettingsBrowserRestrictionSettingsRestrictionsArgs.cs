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

    public sealed class WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("restrictions", required: true)]
        private InputList<Inputs.WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionArgs>? _restrictions;

        /// <summary>
        /// Browser exclusion rules for the browsers that are to be excluded
        /// </summary>
        public InputList<Inputs.WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionArgs> Restrictions
        {
            get => _restrictions ?? (_restrictions = new InputList<Inputs.WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsRestrictionArgs>());
            set => _restrictions = value;
        }

        public WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsArgs Empty => new WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsArgs();
    }
}
