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

    public sealed class OwnershipTeamsSupplementaryIdentifiersSupplementaryIdentifierGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Supplementary Identifier
        /// </summary>
        [Input("supplementaryIdentifier", required: true)]
        public Input<string> SupplementaryIdentifier { get; set; } = null!;

        public OwnershipTeamsSupplementaryIdentifiersSupplementaryIdentifierGetArgs()
        {
        }
        public static new OwnershipTeamsSupplementaryIdentifiersSupplementaryIdentifierGetArgs Empty => new OwnershipTeamsSupplementaryIdentifiersSupplementaryIdentifierGetArgs();
    }
}
