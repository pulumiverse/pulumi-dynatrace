// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class DefaultLaunchpadGroupLaunchpadsArgs : global::Pulumi.ResourceArgs
    {
        [Input("groupLaunchpads", required: true)]
        private InputList<Inputs.DefaultLaunchpadGroupLaunchpadsGroupLaunchpadArgs>? _groupLaunchpads;
        public InputList<Inputs.DefaultLaunchpadGroupLaunchpadsGroupLaunchpadArgs> GroupLaunchpads
        {
            get => _groupLaunchpads ?? (_groupLaunchpads = new InputList<Inputs.DefaultLaunchpadGroupLaunchpadsGroupLaunchpadArgs>());
            set => _groupLaunchpads = value;
        }

        public DefaultLaunchpadGroupLaunchpadsArgs()
        {
        }
        public static new DefaultLaunchpadGroupLaunchpadsArgs Empty => new DefaultLaunchpadGroupLaunchpadsArgs();
    }
}