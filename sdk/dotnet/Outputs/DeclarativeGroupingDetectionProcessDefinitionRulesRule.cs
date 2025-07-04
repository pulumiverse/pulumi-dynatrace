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
    public sealed class DeclarativeGroupingDetectionProcessDefinitionRulesRule
    {
        /// <summary>
        /// - $contains(svc) – Matches if svc appears anywhere in the process property value.
        /// - $eq(svc.exe) – Matches if svc.exe matches the process property value exactly.
        /// - $prefix(svc) – Matches if app matches the prefix of the process property value.
        /// - $suffix(svc.py) – Matches if svc.py matches the suffix of the process property value.
        /// 
        /// For example, $suffix(svc.py) would detect processes named loyaltysvc.py and paymentssvc.py.
        /// 
        /// For more details, see [Declarative process grouping](https://dt-url.net/j142w57).
        /// </summary>
        public readonly string Condition;
        /// <summary>
        /// Possible Values: `Executable`, `ExecutablePath`, `CommandLine`
        /// </summary>
        public readonly string Property;

        [OutputConstructor]
        private DeclarativeGroupingDetectionProcessDefinitionRulesRule(
            string condition,

            string property)
        {
            Condition = condition;
            Property = property;
        }
    }
}
