// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class NetworkMonitorStepStepRequestConfiguration
    {
        /// <summary>
        /// The configuration of a network availability monitor request
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkMonitorStepStepRequestConfigurationRequestConfiguration> RequestConfigurations;

        [OutputConstructor]
        private NetworkMonitorStepStepRequestConfiguration(ImmutableArray<Outputs.NetworkMonitorStepStepRequestConfigurationRequestConfiguration> requestConfigurations)
        {
            RequestConfigurations = requestConfigurations;
        }
    }
}