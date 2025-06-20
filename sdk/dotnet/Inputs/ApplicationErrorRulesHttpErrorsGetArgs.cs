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

    public sealed class ApplicationErrorRulesHttpErrorsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.ApplicationErrorRulesHttpErrorsRuleGetArgs>? _rules;

        /// <summary>
        /// Configuration of the HTTP error in the web application
        /// </summary>
        public InputList<Inputs.ApplicationErrorRulesHttpErrorsRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ApplicationErrorRulesHttpErrorsRuleGetArgs>());
            set => _rules = value;
        }

        public ApplicationErrorRulesHttpErrorsGetArgs()
        {
        }
        public static new ApplicationErrorRulesHttpErrorsGetArgs Empty => new ApplicationErrorRulesHttpErrorsGetArgs();
    }
}
