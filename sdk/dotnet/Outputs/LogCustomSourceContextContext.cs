// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class LogCustomSourceContextContext
    {
        /// <summary>
        /// Possible Values: `Dt_entity_process_group`
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private LogCustomSourceContextContext(
            string attribute,

            ImmutableArray<string> values)
        {
            Attribute = attribute;
            Values = values;
        }
    }
}