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

    public sealed class ApiDetectionConditionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.ApiDetectionConditionsConditionGetArgs>? _conditions;
        public InputList<Inputs.ApiDetectionConditionsConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ApiDetectionConditionsConditionGetArgs>());
            set => _conditions = value;
        }

        public ApiDetectionConditionsGetArgs()
        {
        }
        public static new ApiDetectionConditionsGetArgs Empty => new ApiDetectionConditionsGetArgs();
    }
}
