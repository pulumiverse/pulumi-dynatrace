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
    public sealed class AlertingFiltersFilterCustomMetadata
    {
        /// <summary>
        /// Define filters for event properties. A maximum of 20 properties is allowed.
        /// </summary>
        public readonly Outputs.AlertingFiltersFilterCustomMetadataItems Items;

        [OutputConstructor]
        private AlertingFiltersFilterCustomMetadata(Outputs.AlertingFiltersFilterCustomMetadataItems items)
        {
            Items = items;
        }
    }
}
