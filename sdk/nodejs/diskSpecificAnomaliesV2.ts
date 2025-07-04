// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class DiskSpecificAnomaliesV2 extends pulumi.CustomResource {
    /**
     * Get an existing DiskSpecificAnomaliesV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiskSpecificAnomaliesV2State, opts?: pulumi.CustomResourceOptions): DiskSpecificAnomaliesV2 {
        return new DiskSpecificAnomaliesV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2';

    /**
     * Returns true if the given object is an instance of DiskSpecificAnomaliesV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiskSpecificAnomaliesV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiskSpecificAnomaliesV2.__pulumiType;
    }

    /**
     * The id for the disk anomaly detection
     */
    public readonly diskId!: pulumi.Output<string>;
    /**
     * no documentation available
     */
    public readonly diskLowInodesDetection!: pulumi.Output<outputs.DiskSpecificAnomaliesV2DiskLowInodesDetection | undefined>;
    /**
     * no documentation available
     */
    public readonly diskLowSpaceDetection!: pulumi.Output<outputs.DiskSpecificAnomaliesV2DiskLowSpaceDetection | undefined>;
    /**
     * no documentation available
     */
    public readonly diskSlowWritesAndReadsDetection!: pulumi.Output<outputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection | undefined>;
    /**
     * Override low disk space detection settings
     */
    public readonly overrideDiskLowSpaceDetection!: pulumi.Output<boolean>;
    /**
     * Override low inodes detection settings
     */
    public readonly overrideLowInodesDetection!: pulumi.Output<boolean>;
    /**
     * Override slow writes and reads detection settings
     */
    public readonly overrideSlowWritesAndReadsDetection!: pulumi.Output<boolean>;

    /**
     * Create a DiskSpecificAnomaliesV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskSpecificAnomaliesV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiskSpecificAnomaliesV2Args | DiskSpecificAnomaliesV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DiskSpecificAnomaliesV2State | undefined;
            resourceInputs["diskId"] = state ? state.diskId : undefined;
            resourceInputs["diskLowInodesDetection"] = state ? state.diskLowInodesDetection : undefined;
            resourceInputs["diskLowSpaceDetection"] = state ? state.diskLowSpaceDetection : undefined;
            resourceInputs["diskSlowWritesAndReadsDetection"] = state ? state.diskSlowWritesAndReadsDetection : undefined;
            resourceInputs["overrideDiskLowSpaceDetection"] = state ? state.overrideDiskLowSpaceDetection : undefined;
            resourceInputs["overrideLowInodesDetection"] = state ? state.overrideLowInodesDetection : undefined;
            resourceInputs["overrideSlowWritesAndReadsDetection"] = state ? state.overrideSlowWritesAndReadsDetection : undefined;
        } else {
            const args = argsOrState as DiskSpecificAnomaliesV2Args | undefined;
            if ((!args || args.diskId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'diskId'");
            }
            if ((!args || args.overrideDiskLowSpaceDetection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'overrideDiskLowSpaceDetection'");
            }
            if ((!args || args.overrideLowInodesDetection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'overrideLowInodesDetection'");
            }
            if ((!args || args.overrideSlowWritesAndReadsDetection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'overrideSlowWritesAndReadsDetection'");
            }
            resourceInputs["diskId"] = args ? args.diskId : undefined;
            resourceInputs["diskLowInodesDetection"] = args ? args.diskLowInodesDetection : undefined;
            resourceInputs["diskLowSpaceDetection"] = args ? args.diskLowSpaceDetection : undefined;
            resourceInputs["diskSlowWritesAndReadsDetection"] = args ? args.diskSlowWritesAndReadsDetection : undefined;
            resourceInputs["overrideDiskLowSpaceDetection"] = args ? args.overrideDiskLowSpaceDetection : undefined;
            resourceInputs["overrideLowInodesDetection"] = args ? args.overrideLowInodesDetection : undefined;
            resourceInputs["overrideSlowWritesAndReadsDetection"] = args ? args.overrideSlowWritesAndReadsDetection : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DiskSpecificAnomaliesV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DiskSpecificAnomaliesV2 resources.
 */
export interface DiskSpecificAnomaliesV2State {
    /**
     * The id for the disk anomaly detection
     */
    diskId?: pulumi.Input<string>;
    /**
     * no documentation available
     */
    diskLowInodesDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskLowInodesDetection>;
    /**
     * no documentation available
     */
    diskLowSpaceDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskLowSpaceDetection>;
    /**
     * no documentation available
     */
    diskSlowWritesAndReadsDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection>;
    /**
     * Override low disk space detection settings
     */
    overrideDiskLowSpaceDetection?: pulumi.Input<boolean>;
    /**
     * Override low inodes detection settings
     */
    overrideLowInodesDetection?: pulumi.Input<boolean>;
    /**
     * Override slow writes and reads detection settings
     */
    overrideSlowWritesAndReadsDetection?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a DiskSpecificAnomaliesV2 resource.
 */
export interface DiskSpecificAnomaliesV2Args {
    /**
     * The id for the disk anomaly detection
     */
    diskId: pulumi.Input<string>;
    /**
     * no documentation available
     */
    diskLowInodesDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskLowInodesDetection>;
    /**
     * no documentation available
     */
    diskLowSpaceDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskLowSpaceDetection>;
    /**
     * no documentation available
     */
    diskSlowWritesAndReadsDetection?: pulumi.Input<inputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection>;
    /**
     * Override low disk space detection settings
     */
    overrideDiskLowSpaceDetection: pulumi.Input<boolean>;
    /**
     * Override low inodes detection settings
     */
    overrideLowInodesDetection: pulumi.Input<boolean>;
    /**
     * Override slow writes and reads detection settings
     */
    overrideSlowWritesAndReadsDetection: pulumi.Input<boolean>;
}
