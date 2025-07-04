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

    public sealed class ManagementZoneV2RulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.ManagementZoneV2RulesRuleArgs>? _rules;

        /// <summary>
        /// A management zone rule
        /// </summary>
        public InputList<Inputs.ManagementZoneV2RulesRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ManagementZoneV2RulesRuleArgs>());
            set => _rules = value;
        }

        public ManagementZoneV2RulesArgs()
        {
        }
        public static new ManagementZoneV2RulesArgs Empty => new ManagementZoneV2RulesArgs();
    }
}
