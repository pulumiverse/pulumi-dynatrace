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

    public sealed class WebApplicationLoadActionApdexSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fallback threshold of an XHR action, defining a tolerable user experience, when the configured KPM is not available. Values between 0 and 240000 are allowed.
        /// </summary>
        [Input("frustratingFallbackThreshold")]
        public Input<int>? FrustratingFallbackThreshold { get; set; }

        /// <summary>
        /// Maximal value of apdex, which is considered as tolerable user experience. Values between 0 and 240000 are allowed.
        /// </summary>
        [Input("frustratingThreshold")]
        public Input<int>? FrustratingThreshold { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("threshold")]
        public Input<int>? Threshold { get; set; }

        /// <summary>
        /// Fallback threshold of an XHR action, defining a satisfied user experience, when the configured KPM is not available. Values between 0 and 60000 are allowed.
        /// </summary>
        [Input("toleratedFallbackThreshold")]
        public Input<int>? ToleratedFallbackThreshold { get; set; }

        /// <summary>
        /// Maximal value of apdex, which is considered as satisfied user experience. Values between 0 and 60000 are allowed.
        /// </summary>
        [Input("toleratedThreshold")]
        public Input<int>? ToleratedThreshold { get; set; }

        public WebApplicationLoadActionApdexSettingsGetArgs()
        {
        }
        public static new WebApplicationLoadActionApdexSettingsGetArgs Empty => new WebApplicationLoadActionApdexSettingsGetArgs();
    }
}