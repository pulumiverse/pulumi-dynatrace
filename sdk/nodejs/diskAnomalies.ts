// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class DiskAnomalies extends pulumi.CustomResource {
    /**
     * Get an existing DiskAnomalies resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiskAnomaliesState, opts?: pulumi.CustomResourceOptions): DiskAnomalies {
        return new DiskAnomalies(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/diskAnomalies:DiskAnomalies';

    /**
     * Returns true if the given object is an instance of DiskAnomalies.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiskAnomalies {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiskAnomalies.__pulumiType;
    }

    /**
     * Narrows the rule usage down to disks, matching the specified criteria
     */
    public readonly diskName!: pulumi.Output<outputs.DiskAnomaliesDiskName | undefined>;
    /**
     * Disk event rule enabled/disabled
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Narrows the rule usage down to disks that run on hosts that themselves run on the specified host group
     */
    public readonly hostGroupId!: pulumi.Output<string | undefined>;
    /**
     * The metric to monitor. Possible values are: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING` and `WRITE_TIME_EXCEEDING`
     */
    public readonly metric!: pulumi.Output<string>;
    /**
     * The name of the disk event rule
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The number of samples to evaluate
     */
    public readonly samples!: pulumi.Output<number>;
    /**
     * Narrows the rule usage down to the hosts matching the specified tags
     */
    public readonly tags!: pulumi.Output<outputs.DiskAnomaliesTags | undefined>;
    /**
     * The threshold to trigger disk event.   * A percentage for `LowDiskSpace` or `LowInodes` metrics.   * In milliseconds for `ReadTimeExceeding` or `WriteTimeExceeding` metrics
     */
    public readonly threshold!: pulumi.Output<number>;
    /**
     * The number of samples that must violate the threshold to trigger an event. Must not exceed the number of evaluated samples
     */
    public readonly violatingSamples!: pulumi.Output<number>;

    /**
     * Create a DiskAnomalies resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskAnomaliesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiskAnomaliesArgs | DiskAnomaliesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DiskAnomaliesState | undefined;
            resourceInputs["diskName"] = state ? state.diskName : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["hostGroupId"] = state ? state.hostGroupId : undefined;
            resourceInputs["metric"] = state ? state.metric : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["samples"] = state ? state.samples : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["threshold"] = state ? state.threshold : undefined;
            resourceInputs["violatingSamples"] = state ? state.violatingSamples : undefined;
        } else {
            const args = argsOrState as DiskAnomaliesArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.metric === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metric'");
            }
            if ((!args || args.samples === undefined) && !opts.urn) {
                throw new Error("Missing required property 'samples'");
            }
            if ((!args || args.threshold === undefined) && !opts.urn) {
                throw new Error("Missing required property 'threshold'");
            }
            if ((!args || args.violatingSamples === undefined) && !opts.urn) {
                throw new Error("Missing required property 'violatingSamples'");
            }
            resourceInputs["diskName"] = args ? args.diskName : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["hostGroupId"] = args ? args.hostGroupId : undefined;
            resourceInputs["metric"] = args ? args.metric : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["samples"] = args ? args.samples : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["threshold"] = args ? args.threshold : undefined;
            resourceInputs["violatingSamples"] = args ? args.violatingSamples : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DiskAnomalies.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DiskAnomalies resources.
 */
export interface DiskAnomaliesState {
    /**
     * Narrows the rule usage down to disks, matching the specified criteria
     */
    diskName?: pulumi.Input<inputs.DiskAnomaliesDiskName>;
    /**
     * Disk event rule enabled/disabled
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Narrows the rule usage down to disks that run on hosts that themselves run on the specified host group
     */
    hostGroupId?: pulumi.Input<string>;
    /**
     * The metric to monitor. Possible values are: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING` and `WRITE_TIME_EXCEEDING`
     */
    metric?: pulumi.Input<string>;
    /**
     * The name of the disk event rule
     */
    name?: pulumi.Input<string>;
    /**
     * The number of samples to evaluate
     */
    samples?: pulumi.Input<number>;
    /**
     * Narrows the rule usage down to the hosts matching the specified tags
     */
    tags?: pulumi.Input<inputs.DiskAnomaliesTags>;
    /**
     * The threshold to trigger disk event.   * A percentage for `LowDiskSpace` or `LowInodes` metrics.   * In milliseconds for `ReadTimeExceeding` or `WriteTimeExceeding` metrics
     */
    threshold?: pulumi.Input<number>;
    /**
     * The number of samples that must violate the threshold to trigger an event. Must not exceed the number of evaluated samples
     */
    violatingSamples?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a DiskAnomalies resource.
 */
export interface DiskAnomaliesArgs {
    /**
     * Narrows the rule usage down to disks, matching the specified criteria
     */
    diskName?: pulumi.Input<inputs.DiskAnomaliesDiskName>;
    /**
     * Disk event rule enabled/disabled
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Narrows the rule usage down to disks that run on hosts that themselves run on the specified host group
     */
    hostGroupId?: pulumi.Input<string>;
    /**
     * The metric to monitor. Possible values are: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING` and `WRITE_TIME_EXCEEDING`
     */
    metric: pulumi.Input<string>;
    /**
     * The name of the disk event rule
     */
    name?: pulumi.Input<string>;
    /**
     * The number of samples to evaluate
     */
    samples: pulumi.Input<number>;
    /**
     * Narrows the rule usage down to the hosts matching the specified tags
     */
    tags?: pulumi.Input<inputs.DiskAnomaliesTags>;
    /**
     * The threshold to trigger disk event.   * A percentage for `LowDiskSpace` or `LowInodes` metrics.   * In milliseconds for `ReadTimeExceeding` or `WriteTimeExceeding` metrics
     */
    threshold: pulumi.Input<number>;
    /**
     * The number of samples that must violate the threshold to trigger an event. Must not exceed the number of evaluated samples
     */
    violatingSamples: pulumi.Input<number>;
}
