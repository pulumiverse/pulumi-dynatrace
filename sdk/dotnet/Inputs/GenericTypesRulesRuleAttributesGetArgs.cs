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

    public sealed class GenericTypesRulesRuleAttributesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("attributes", required: true)]
        private InputList<Inputs.GenericTypesRulesRuleAttributesAttributeGetArgs>? _attributes;
        public InputList<Inputs.GenericTypesRulesRuleAttributesAttributeGetArgs> Attributes
        {
            get => _attributes ?? (_attributes = new InputList<Inputs.GenericTypesRulesRuleAttributesAttributeGetArgs>());
            set => _attributes = value;
        }

        public GenericTypesRulesRuleAttributesGetArgs()
        {
        }
        public static new GenericTypesRulesRuleAttributesGetArgs Empty => new GenericTypesRulesRuleAttributesGetArgs();
    }
}
