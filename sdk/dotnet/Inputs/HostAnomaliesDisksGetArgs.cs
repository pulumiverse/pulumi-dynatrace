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

    public sealed class HostAnomaliesDisksGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of low disk inodes number detection
        /// </summary>
        [Input("inodes")]
        public Input<Inputs.HostAnomaliesDisksInodesGetArgs>? Inodes { get; set; }

        /// <summary>
        /// Configuration of low disk space detection
        /// </summary>
        [Input("space")]
        public Input<Inputs.HostAnomaliesDisksSpaceGetArgs>? Space { get; set; }

        /// <summary>
        /// Configuration of slow running disks detection
        /// </summary>
        [Input("speed")]
        public Input<Inputs.HostAnomaliesDisksSpeedGetArgs>? Speed { get; set; }

        public HostAnomaliesDisksGetArgs()
        {
        }
        public static new HostAnomaliesDisksGetArgs Empty => new HostAnomaliesDisksGetArgs();
    }
}
