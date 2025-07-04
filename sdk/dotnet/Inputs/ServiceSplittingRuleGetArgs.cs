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

    public sealed class ServiceSplittingRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Limits the scope of the service splitting rule using [DQL matcher](https://dt-url.net/l603wby) conditions on resource attributes..  A rule is applied only if the condition matches, otherwise the ruleset evaluation continues.
        /// </summary>
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// Define the entire set of resource attributes that should split your services in the matching scope.. Each attribute that exists will contribute to the final service ID.
        /// </summary>
        [Input("serviceSplittingAttributes")]
        public Input<Inputs.ServiceSplittingRuleServiceSplittingAttributesGetArgs>? ServiceSplittingAttributes { get; set; }

        public ServiceSplittingRuleGetArgs()
        {
        }
        public static new ServiceSplittingRuleGetArgs Empty => new ServiceSplittingRuleGetArgs();
    }
}
