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

    public sealed class WebAppCustomErrorsErrorRulesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("errorRules", required: true)]
        private InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleGetArgs>? _errorRules;
        public InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleGetArgs> ErrorRules
        {
            get => _errorRules ?? (_errorRules = new InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleGetArgs>());
            set => _errorRules = value;
        }

        public WebAppCustomErrorsErrorRulesGetArgs()
        {
        }
        public static new WebAppCustomErrorsErrorRulesGetArgs Empty => new WebAppCustomErrorsErrorRulesGetArgs();
    }
}
