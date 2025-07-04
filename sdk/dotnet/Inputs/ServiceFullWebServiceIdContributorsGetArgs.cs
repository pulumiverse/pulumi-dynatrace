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

    public sealed class ServiceFullWebServiceIdContributorsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application identifier
        /// </summary>
        [Input("applicationId")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsApplicationIdGetArgs>? ApplicationId { get; set; }

        /// <summary>
        /// The context root is the first segment of the request URL after the Server name. For example, in the `www.dynatrace.com/support/help/dynatrace-api/` URL the context root is `/support`. The context root value can be found on the **Service overview page** under **Properties and tags**.
        /// </summary>
        [Input("contextRoot")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsContextRootGetArgs>? ContextRoot { get; set; }

        /// <summary>
        /// Detect the matching requests as full web services (false) or web request services (true).
        /// </summary>
        [Input("detectAsWebRequestService", required: true)]
        public Input<bool> DetectAsWebRequestService { get; set; } = null!;

        /// <summary>
        /// Server name
        /// </summary>
        [Input("serverName")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsServerNameGetArgs>? ServerName { get; set; }

        /// <summary>
        /// Web service name
        /// </summary>
        [Input("webServiceName")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsWebServiceNameGetArgs>? WebServiceName { get; set; }

        /// <summary>
        /// Web service namespace
        /// </summary>
        [Input("webServiceNamespace")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsWebServiceNamespaceGetArgs>? WebServiceNamespace { get; set; }

        public ServiceFullWebServiceIdContributorsGetArgs()
        {
        }
        public static new ServiceFullWebServiceIdContributorsGetArgs Empty => new ServiceFullWebServiceIdContributorsGetArgs();
    }
}
