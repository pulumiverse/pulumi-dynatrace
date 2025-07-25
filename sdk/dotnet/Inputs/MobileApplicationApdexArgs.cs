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

    public sealed class MobileApplicationApdexArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Apdex **frustrated** threshold, in milliseconds: a duration greater than or equal to this value is considered frustrated
        /// </summary>
        [Input("frustrated", required: true)]
        public Input<int> Frustrated { get; set; } = null!;

        /// <summary>
        /// Apdex error condition: if `true` the user session is considered frustrated when an error is reported
        /// </summary>
        [Input("frustratedOnError")]
        public Input<bool>? FrustratedOnError { get; set; }

        /// <summary>
        /// Apdex **tolerable** threshold, in milliseconds: a duration greater than or equal to this value is considered tolerable
        /// </summary>
        [Input("tolerable", required: true)]
        public Input<int> Tolerable { get; set; } = null!;

        public MobileApplicationApdexArgs()
        {
        }
        public static new MobileApplicationApdexArgs Empty => new MobileApplicationApdexArgs();
    }
}
