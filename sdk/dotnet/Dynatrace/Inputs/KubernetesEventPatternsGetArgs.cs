// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class KubernetesEventPatternsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("eventPatterns", required: true)]
        private InputList<Inputs.KubernetesEventPatternsEventPatternGetArgs>? _eventPatterns;
        public InputList<Inputs.KubernetesEventPatternsEventPatternGetArgs> EventPatterns
        {
            get => _eventPatterns ?? (_eventPatterns = new InputList<Inputs.KubernetesEventPatternsEventPatternGetArgs>());
            set => _eventPatterns = value;
        }

        public KubernetesEventPatternsGetArgs()
        {
        }
        public static new KubernetesEventPatternsGetArgs Empty => new KubernetesEventPatternsGetArgs();
    }
}