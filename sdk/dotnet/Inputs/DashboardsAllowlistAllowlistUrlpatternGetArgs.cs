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

    public sealed class DashboardsAllowlistAllowlistUrlpatternGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `Equals`, `StartsWith`
        /// </summary>
        [Input("rule", required: true)]
        public Input<string> Rule { get; set; } = null!;

        /// <summary>
        /// Pattern
        /// </summary>
        [Input("template", required: true)]
        public Input<string> Template { get; set; } = null!;

        public DashboardsAllowlistAllowlistUrlpatternGetArgs()
        {
        }
        public static new DashboardsAllowlistAllowlistUrlpatternGetArgs Empty => new DashboardsAllowlistAllowlistUrlpatternGetArgs();
    }
}
