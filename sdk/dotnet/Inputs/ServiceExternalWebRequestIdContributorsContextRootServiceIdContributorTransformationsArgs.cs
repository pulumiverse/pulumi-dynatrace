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

    public sealed class ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsArgs : global::Pulumi.ResourceArgs
    {
        [Input("transformations", required: true)]
        private InputList<Inputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationArgs>? _transformations;
        public InputList<Inputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationArgs> Transformations
        {
            get => _transformations ?? (_transformations = new InputList<Inputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationArgs>());
            set => _transformations = value;
        }

        public ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsArgs()
        {
        }
        public static new ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsArgs Empty => new ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsArgs();
    }
}
