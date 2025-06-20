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
    public sealed class ApplicationErrorRulesHttpErrors
    {
        /// <summary>
        /// Configuration of the HTTP error in the web application
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationErrorRulesHttpErrorsRule> Rules;

        [OutputConstructor]
        private ApplicationErrorRulesHttpErrors(ImmutableArray<Outputs.ApplicationErrorRulesHttpErrorsRule> rules)
        {
            Rules = rules;
        }
    }
}
