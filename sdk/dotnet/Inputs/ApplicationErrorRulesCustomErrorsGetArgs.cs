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

    public sealed class ApplicationErrorRulesCustomErrorsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.ApplicationErrorRulesCustomErrorsRuleGetArgs>? _rules;

        /// <summary>
        /// Configuration of the custom error in the web application
        /// </summary>
        public InputList<Inputs.ApplicationErrorRulesCustomErrorsRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ApplicationErrorRulesCustomErrorsRuleGetArgs>());
            set => _rules = value;
        }

        public ApplicationErrorRulesCustomErrorsGetArgs()
        {
        }
        public static new ApplicationErrorRulesCustomErrorsGetArgs Empty => new ApplicationErrorRulesCustomErrorsGetArgs();
    }
}
