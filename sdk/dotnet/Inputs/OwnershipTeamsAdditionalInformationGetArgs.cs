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

    public sealed class OwnershipTeamsAdditionalInformationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("additionalInformations", required: true)]
        private InputList<Inputs.OwnershipTeamsAdditionalInformationAdditionalInformationGetArgs>? _additionalInformations;
        public InputList<Inputs.OwnershipTeamsAdditionalInformationAdditionalInformationGetArgs> AdditionalInformations
        {
            get => _additionalInformations ?? (_additionalInformations = new InputList<Inputs.OwnershipTeamsAdditionalInformationAdditionalInformationGetArgs>());
            set => _additionalInformations = value;
        }

        public OwnershipTeamsAdditionalInformationGetArgs()
        {
        }
        public static new OwnershipTeamsAdditionalInformationGetArgs Empty => new OwnershipTeamsAdditionalInformationGetArgs();
    }
}