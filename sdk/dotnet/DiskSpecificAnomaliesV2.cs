// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2")]
    public partial class DiskSpecificAnomaliesV2 : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The id for the disk anomaly detection
        /// </summary>
        [Output("diskId")]
        public Output<string> DiskId { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("diskLowInodesDetection")]
        public Output<Outputs.DiskSpecificAnomaliesV2DiskLowInodesDetection?> DiskLowInodesDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("diskLowSpaceDetection")]
        public Output<Outputs.DiskSpecificAnomaliesV2DiskLowSpaceDetection?> DiskLowSpaceDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("diskSlowWritesAndReadsDetection")]
        public Output<Outputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection?> DiskSlowWritesAndReadsDetection { get; private set; } = null!;

        /// <summary>
        /// Override low disk space detection settings
        /// </summary>
        [Output("overrideDiskLowSpaceDetection")]
        public Output<bool> OverrideDiskLowSpaceDetection { get; private set; } = null!;

        /// <summary>
        /// Override low inodes detection settings
        /// </summary>
        [Output("overrideLowInodesDetection")]
        public Output<bool> OverrideLowInodesDetection { get; private set; } = null!;

        /// <summary>
        /// Override slow writes and reads detection settings
        /// </summary>
        [Output("overrideSlowWritesAndReadsDetection")]
        public Output<bool> OverrideSlowWritesAndReadsDetection { get; private set; } = null!;


        /// <summary>
        /// Create a DiskSpecificAnomaliesV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DiskSpecificAnomaliesV2(string name, DiskSpecificAnomaliesV2Args args, CustomResourceOptions? options = null)
            : base("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2", name, args ?? new DiskSpecificAnomaliesV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private DiskSpecificAnomaliesV2(string name, Input<string> id, DiskSpecificAnomaliesV2State? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DiskSpecificAnomaliesV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DiskSpecificAnomaliesV2 Get(string name, Input<string> id, DiskSpecificAnomaliesV2State? state = null, CustomResourceOptions? options = null)
        {
            return new DiskSpecificAnomaliesV2(name, id, state, options);
        }
    }

    public sealed class DiskSpecificAnomaliesV2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id for the disk anomaly detection
        /// </summary>
        [Input("diskId", required: true)]
        public Input<string> DiskId { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowInodesDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs>? DiskLowInodesDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowSpaceDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs>? DiskLowSpaceDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskSlowWritesAndReadsDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs>? DiskSlowWritesAndReadsDetection { get; set; }

        /// <summary>
        /// Override low disk space detection settings
        /// </summary>
        [Input("overrideDiskLowSpaceDetection", required: true)]
        public Input<bool> OverrideDiskLowSpaceDetection { get; set; } = null!;

        /// <summary>
        /// Override low inodes detection settings
        /// </summary>
        [Input("overrideLowInodesDetection", required: true)]
        public Input<bool> OverrideLowInodesDetection { get; set; } = null!;

        /// <summary>
        /// Override slow writes and reads detection settings
        /// </summary>
        [Input("overrideSlowWritesAndReadsDetection", required: true)]
        public Input<bool> OverrideSlowWritesAndReadsDetection { get; set; } = null!;

        public DiskSpecificAnomaliesV2Args()
        {
        }
        public static new DiskSpecificAnomaliesV2Args Empty => new DiskSpecificAnomaliesV2Args();
    }

    public sealed class DiskSpecificAnomaliesV2State : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id for the disk anomaly detection
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowInodesDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskLowInodesDetectionGetArgs>? DiskLowInodesDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskLowSpaceDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskLowSpaceDetectionGetArgs>? DiskLowSpaceDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("diskSlowWritesAndReadsDetection")]
        public Input<Inputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionGetArgs>? DiskSlowWritesAndReadsDetection { get; set; }

        /// <summary>
        /// Override low disk space detection settings
        /// </summary>
        [Input("overrideDiskLowSpaceDetection")]
        public Input<bool>? OverrideDiskLowSpaceDetection { get; set; }

        /// <summary>
        /// Override low inodes detection settings
        /// </summary>
        [Input("overrideLowInodesDetection")]
        public Input<bool>? OverrideLowInodesDetection { get; set; }

        /// <summary>
        /// Override slow writes and reads detection settings
        /// </summary>
        [Input("overrideSlowWritesAndReadsDetection")]
        public Input<bool>? OverrideSlowWritesAndReadsDetection { get; set; }

        public DiskSpecificAnomaliesV2State()
        {
        }
        public static new DiskSpecificAnomaliesV2State Empty => new DiskSpecificAnomaliesV2State();
    }
}