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

    public sealed class GrailMetricsAllowlistAllowRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowRules", required: true)]
        private InputList<Inputs.GrailMetricsAllowlistAllowRulesAllowRuleArgs>? _allowRules;
        public InputList<Inputs.GrailMetricsAllowlistAllowRulesAllowRuleArgs> AllowRules
        {
            get => _allowRules ?? (_allowRules = new InputList<Inputs.GrailMetricsAllowlistAllowRulesAllowRuleArgs>());
            set => _allowRules = value;
        }

        public GrailMetricsAllowlistAllowRulesArgs()
        {
        }
        public static new GrailMetricsAllowlistAllowRulesArgs Empty => new GrailMetricsAllowlistAllowRulesArgs();
    }
}
