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

    public sealed class ServiceFailureExceptionRulesIgnoredExceptionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("customHandledExceptions", required: true)]
        private InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs>? _customHandledExceptions;
        public InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs> CustomHandledExceptions
        {
            get => _customHandledExceptions ?? (_customHandledExceptions = new InputList<Inputs.ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs>());
            set => _customHandledExceptions = value;
        }

        public ServiceFailureExceptionRulesIgnoredExceptionsArgs()
        {
        }
        public static new ServiceFailureExceptionRulesIgnoredExceptionsArgs Empty => new ServiceFailureExceptionRulesIgnoredExceptionsArgs();
    }
}
