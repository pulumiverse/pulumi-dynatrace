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

    public sealed class NetworkMonitorStepStepConstraintGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("constraints", required: true)]
        private InputList<Inputs.NetworkMonitorStepStepConstraintConstraintGetArgs>? _constraints;

        /// <summary>
        /// The network availability monitor constraint
        /// </summary>
        public InputList<Inputs.NetworkMonitorStepStepConstraintConstraintGetArgs> Constraints
        {
            get => _constraints ?? (_constraints = new InputList<Inputs.NetworkMonitorStepStepConstraintConstraintGetArgs>());
            set => _constraints = value;
        }

        public NetworkMonitorStepStepConstraintGetArgs()
        {
        }
        public static new NetworkMonitorStepStepConstraintGetArgs Empty => new NetworkMonitorStepStepConstraintGetArgs();
    }
}
