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

    public sealed class ServiceFailureExceptionRulesIgnoredExceptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customHandledExceptions", required: true)]
        private InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs>? _customHandledExceptions;
        public InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs> CustomHandledExceptions
        {
            get => _customHandledExceptions ?? (_customHandledExceptions = new InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionGetArgs>());
            set => _customHandledExceptions = value;
        }

        public ServiceFailureExceptionRulesIgnoredExceptionsGetArgs()
        {
        }
        public static new ServiceFailureExceptionRulesIgnoredExceptionsGetArgs Empty => new ServiceFailureExceptionRulesIgnoredExceptionsGetArgs();
    }
}
