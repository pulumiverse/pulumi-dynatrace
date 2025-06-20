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
    public sealed class LogCustomSourceCustomLogSourceValuesAndEnrichmentCustomLogSourceWithEnrichment
    {
        /// <summary>
        /// Optional field that allows to define attributes that will enrich logs. ${N} can be used in attribute value to expand the value matched by wildcards where N denotes the number of the wildcard the expand
        /// </summary>
        public readonly Outputs.LogCustomSourceCustomLogSourceValuesAndEnrichmentCustomLogSourceWithEnrichmentEnrichment? Enrichment;
        /// <summary>
        /// Values
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private LogCustomSourceCustomLogSourceValuesAndEnrichmentCustomLogSourceWithEnrichment(
            Outputs.LogCustomSourceCustomLogSourceValuesAndEnrichmentCustomLogSourceWithEnrichmentEnrichment? enrichment,

            string path)
        {
            Enrichment = enrichment;
            Path = path;
        }
    }
}
