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

    public sealed class ServiceNamingConditionArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Inputs.ServiceNamingConditionConditionArgs>? _conditions;

        /// <summary>
        /// A conditions for the metric usage
        /// </summary>
        public InputList<Inputs.ServiceNamingConditionConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ServiceNamingConditionConditionArgs>());
            set => _conditions = value;
        }

        public ServiceNamingConditionArgs()
        {
        }
        public static new ServiceNamingConditionArgs Empty => new ServiceNamingConditionArgs();
    }
}
