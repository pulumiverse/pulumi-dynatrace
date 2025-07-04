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
    public sealed class GetPlatformSloTemplatesTemplateResult
    {
        /// <summary>
        /// ID of the SLO objective template
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the SLO objective template
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetPlatformSloTemplatesTemplateResult(
            string id,

            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
