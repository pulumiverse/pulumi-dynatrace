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

    public sealed class DashboardTileBoundsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the height of the tile, in pixels
        /// </summary>
        [Input("height", required: true)]
        public Input<int> Height { get; set; } = null!;

        /// <summary>
        /// the horizontal distance from the top left corner of the dashboard to the top left corner of the tile, in pixels
        /// </summary>
        [Input("left", required: true)]
        public Input<int> Left { get; set; } = null!;

        /// <summary>
        /// the vertical distance from the top left corner of the dashboard to the top left corner of the tile, in pixels
        /// </summary>
        [Input("top", required: true)]
        public Input<int> Top { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// the width of the tile, in pixels
        /// </summary>
        [Input("width", required: true)]
        public Input<int> Width { get; set; } = null!;

        public DashboardTileBoundsArgs()
        {
        }
        public static new DashboardTileBoundsArgs Empty => new DashboardTileBoundsArgs();
    }
}