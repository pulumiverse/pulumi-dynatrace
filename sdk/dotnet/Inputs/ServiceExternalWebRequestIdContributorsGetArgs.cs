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

    public sealed class ServiceExternalWebRequestIdContributorsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application identifier
        /// </summary>
        [Input("applicationId", required: true)]
        public Input<Inputs.ServiceExternalWebRequestIdContributorsApplicationIdGetArgs> ApplicationId { get; set; } = null!;

        /// <summary>
        /// URL context root
        /// </summary>
        [Input("contextRoot", required: true)]
        public Input<Inputs.ServiceExternalWebRequestIdContributorsContextRootGetArgs> ContextRoot { get; set; } = null!;

        /// <summary>
        /// Let the port contribute to the Service Id
        /// </summary>
        [Input("portForServiceId", required: true)]
        public Input<bool> PortForServiceId { get; set; } = null!;

        /// <summary>
        /// Public domain name
        /// </summary>
        [Input("publicDomainName", required: true)]
        public Input<Inputs.ServiceExternalWebRequestIdContributorsPublicDomainNameGetArgs> PublicDomainName { get; set; } = null!;

        public ServiceExternalWebRequestIdContributorsGetArgs()
        {
        }
        public static new ServiceExternalWebRequestIdContributorsGetArgs Empty => new ServiceExternalWebRequestIdContributorsGetArgs();
    }
}
