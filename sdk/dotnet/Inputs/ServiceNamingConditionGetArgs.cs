// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class ServiceNamingConditionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Inputs.ServiceNamingConditionConditionGetArgs>? _conditions;

        /// <summary>
        /// A conditions for the metric usage
        /// </summary>
        public InputList<Inputs.ServiceNamingConditionConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ServiceNamingConditionConditionGetArgs>());
            set => _conditions = value;
        }

        public ServiceNamingConditionGetArgs()
        {
        }
        public static new ServiceNamingConditionGetArgs Empty => new ServiceNamingConditionGetArgs();
    }
}