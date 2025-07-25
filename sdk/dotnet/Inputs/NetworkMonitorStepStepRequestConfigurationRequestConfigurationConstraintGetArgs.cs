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

    public sealed class NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("constraints", required: true)]
        private InputList<Inputs.NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintConstraintGetArgs>? _constraints;

        /// <summary>
        /// The network availability monitor constraint
        /// </summary>
        public InputList<Inputs.NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintConstraintGetArgs> Constraints
        {
            get => _constraints ?? (_constraints = new InputList<Inputs.NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintConstraintGetArgs>());
            set => _constraints = value;
        }

        public NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintGetArgs()
        {
        }
        public static new NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintGetArgs Empty => new NetworkMonitorStepStepRequestConfigurationRequestConfigurationConstraintGetArgs();
    }
}
