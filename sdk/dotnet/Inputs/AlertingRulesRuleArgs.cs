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

    public sealed class AlertingRulesRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Send a notification if a problem remains open longer than *X* minutes
        /// </summary>
        [Input("delayInMinutes", required: true)]
        public Input<int> DelayInMinutes { get; set; } = null!;

        /// <summary>
        /// The filtering mode:  * `INCLUDE_ANY`: The rule applies to monitored entities that have at least one of the specified tags. You can specify up to 100 tags.  * `INCLUDE_ALL`: The rule applies to monitored entities that have **all** of the specified tags. You can specify up to 10 tags.  * `NONE`: The rule applies to all monitored entities
        /// </summary>
        [Input("includeMode", required: true)]
        public Input<string> IncludeMode { get; set; } = null!;

        /// <summary>
        /// The severity level to trigger the alert. Possible values are `AVAILABILITY`,	`CUSTOM_ALERT`,	`ERRORS`,`MONITORING_UNAVAILABLE`,`PERFORMANCE` and `RESOURCE_CONTENTION`.
        /// </summary>
        [Input("severityLevel", required: true)]
        public Input<string> SeverityLevel { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Entities which contain any/all of the configured tags will match this alerting profile. It is recommended to use manual tags.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public AlertingRulesRuleArgs()
        {
        }
        public static new AlertingRulesRuleArgs Empty => new AlertingRulesRuleArgs();
    }
}
