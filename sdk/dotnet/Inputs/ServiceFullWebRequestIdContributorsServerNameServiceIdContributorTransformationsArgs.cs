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

    public sealed class ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsArgs : global::Pulumi.ResourceArgs
    {
        [Input("transformations", required: true)]
        private InputList<Inputs.ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs>? _transformations;
        public InputList<Inputs.ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs> Transformations
        {
            get => _transformations ?? (_transformations = new InputList<Inputs.ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs>());
            set => _transformations = value;
        }

        public ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsArgs()
        {
        }
        public static new ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsArgs Empty => new ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsArgs();
    }
}
