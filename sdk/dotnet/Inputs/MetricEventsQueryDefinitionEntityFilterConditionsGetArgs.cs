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

    public sealed class MetricEventsQueryDefinitionEntityFilterConditionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.MetricEventsQueryDefinitionEntityFilterConditionsConditionGetArgs>? _conditions;
        public InputList<Inputs.MetricEventsQueryDefinitionEntityFilterConditionsConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.MetricEventsQueryDefinitionEntityFilterConditionsConditionGetArgs>());
            set => _conditions = value;
        }

        public MetricEventsQueryDefinitionEntityFilterConditionsGetArgs()
        {
        }
        public static new MetricEventsQueryDefinitionEntityFilterConditionsGetArgs Empty => new MetricEventsQueryDefinitionEntityFilterConditionsGetArgs();
    }
}
