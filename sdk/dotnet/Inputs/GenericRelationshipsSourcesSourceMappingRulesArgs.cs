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

    public sealed class GenericRelationshipsSourcesSourceMappingRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("mappingRules", required: true)]
        private InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleArgs>? _mappingRules;
        public InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleArgs> MappingRules
        {
            get => _mappingRules ?? (_mappingRules = new InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleArgs>());
            set => _mappingRules = value;
        }

        public GenericRelationshipsSourcesSourceMappingRulesArgs()
        {
        }
        public static new GenericRelationshipsSourcesSourceMappingRulesArgs Empty => new GenericRelationshipsSourcesSourceMappingRulesArgs();
    }
}
