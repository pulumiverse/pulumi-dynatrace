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
    public sealed class ApplicationErrorRulesCustomErrors
    {
        /// <summary>
        /// Configuration of the custom error in the web application
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationErrorRulesCustomErrorsRule> Rules;

        [OutputConstructor]
        private ApplicationErrorRulesCustomErrors(ImmutableArray<Outputs.ApplicationErrorRulesCustomErrorsRule> rules)
        {
            Rules = rules;
        }
    }
}
