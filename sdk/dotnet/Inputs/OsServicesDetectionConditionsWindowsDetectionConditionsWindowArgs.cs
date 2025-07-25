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

    public sealed class OsServicesDetectionConditionsWindowsDetectionConditionsWindowArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        /// <summary>
        /// Custom metadata
        /// </summary>
        [Input("hostMetadataCondition")]
        public Input<Inputs.OsServicesDetectionConditionsWindowsDetectionConditionsWindowHostMetadataConditionArgs>? HostMetadataCondition { get; set; }

        /// <summary>
        /// Possible Values: `DisplayName`, `Manufacturer`, `Path`, `ServiceName`, `StartupType`
        /// </summary>
        [Input("property")]
        public Input<string>? Property { get; set; }

        /// <summary>
        /// Possible Values: `RuleTypeHost`, `RuleTypeOsService`
        /// </summary>
        [Input("ruleType")]
        public Input<string>? RuleType { get; set; }

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// 
        /// - `$eq(manual)` – Matches services that are started manually.
        /// 
        /// Available logic operations:
        /// - `$not($eq(auto))` – Matches services with startup type different from Automatic.
        /// - `$or($eq(auto),$eq(manual))` – Matches if service's startup type is either Automatic or Manual.
        /// 
        /// Use one of the following values as a parameter for this condition:
        /// 
        /// - `manual` for Manual
        /// - `manual_trigger` for Manual (Trigger Start)
        /// - `auto` for Automatic
        /// - `auto_delay` for Automatic (Delayed Start)
        /// - `auto_trigger` for Automatic (Trigger Start)
        /// - `auto_delay_trigger` for Automatic (Delayed Start, Trigger Start)
        /// - `disabled` for Disabled
        /// </summary>
        [Input("startupCondition")]
        public Input<string>? StartupCondition { get; set; }

        public OsServicesDetectionConditionsWindowsDetectionConditionsWindowArgs()
        {
        }
        public static new OsServicesDetectionConditionsWindowsDetectionConditionsWindowArgs Empty => new OsServicesDetectionConditionsWindowsDetectionConditionsWindowArgs();
    }
}
