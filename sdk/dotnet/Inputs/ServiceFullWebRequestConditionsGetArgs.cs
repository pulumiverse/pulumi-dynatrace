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

    public sealed class ServiceFullWebRequestConditionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.ServiceFullWebRequestConditionsConditionGetArgs>? _conditions;
        public InputList<Inputs.ServiceFullWebRequestConditionsConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ServiceFullWebRequestConditionsConditionGetArgs>());
            set => _conditions = value;
        }

        public ServiceFullWebRequestConditionsGetArgs()
        {
        }
        public static new ServiceFullWebRequestConditionsGetArgs Empty => new ServiceFullWebRequestConditionsGetArgs();
    }
}
