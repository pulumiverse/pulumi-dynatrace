// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class OwnershipTeamsAdditionalInformation
    {
        public readonly ImmutableArray<Outputs.OwnershipTeamsAdditionalInformationAdditionalInformation> AdditionalInformations;

        [OutputConstructor]
        private OwnershipTeamsAdditionalInformation(ImmutableArray<Outputs.OwnershipTeamsAdditionalInformationAdditionalInformation> additionalInformations)
        {
            AdditionalInformations = additionalInformations;
        }
    }
}
