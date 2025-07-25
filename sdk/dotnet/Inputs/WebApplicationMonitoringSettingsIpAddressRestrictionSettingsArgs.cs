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

    public sealed class WebApplicationMonitoringSettingsIpAddressRestrictionSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The mode of the list of ip address restrictions. Possible values area `EXCLUDE` and `INCLUDE`.
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        /// <summary>
        /// The IP addresses or the IP address ranges to be mapped to the location
        /// </summary>
        [Input("restrictions")]
        public Input<Inputs.WebApplicationMonitoringSettingsIpAddressRestrictionSettingsRestrictionsArgs>? Restrictions { get; set; }

        public WebApplicationMonitoringSettingsIpAddressRestrictionSettingsArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsIpAddressRestrictionSettingsArgs Empty => new WebApplicationMonitoringSettingsIpAddressRestrictionSettingsArgs();
    }
}
