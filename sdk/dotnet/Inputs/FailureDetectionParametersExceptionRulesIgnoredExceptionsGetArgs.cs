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

    public sealed class FailureDetectionParametersExceptionRulesIgnoredExceptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customHandledExceptions", required: true)]
        private InputList<Inputs.FailureDetectionParametersExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs>? _customHandledExceptions;
        public InputList<Inputs.FailureDetectionParametersExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs> CustomHandledExceptions
        {
            get => _customHandledExceptions ?? (_customHandledExceptions = new InputList<Inputs.FailureDetectionParametersExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs>());
            set => _customHandledExceptions = value;
        }

        public FailureDetectionParametersExceptionRulesIgnoredExceptionsGetArgs()
        {
        }
        public static new FailureDetectionParametersExceptionRulesIgnoredExceptionsGetArgs Empty => new FailureDetectionParametersExceptionRulesIgnoredExceptionsGetArgs();
    }
}
