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

    public sealed class PlatformSloSliReferenceVariablesArgs : global::Pulumi.ResourceArgs
    {
        [Input("sliReferenceVariables", required: true)]
        private InputList<Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs>? _sliReferenceVariables;
        public InputList<Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs> SliReferenceVariables
        {
            get => _sliReferenceVariables ?? (_sliReferenceVariables = new InputList<Inputs.PlatformSloSliReferenceVariablesSliReferenceVariableArgs>());
            set => _sliReferenceVariables = value;
        }

        public PlatformSloSliReferenceVariablesArgs()
        {
        }
        public static new PlatformSloSliReferenceVariablesArgs Empty => new PlatformSloSliReferenceVariablesArgs();
    }
}
