// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class DiskAnomalyRules extends pulumi.CustomResource {
    /**
     * Get an existing DiskAnomalyRules resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiskAnomalyRulesState, opts?: pulumi.CustomResourceOptions): DiskAnomalyRules {
        return new DiskAnomalyRules(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/diskAnomalyRules:DiskAnomalyRules';

    /**
     * Returns true if the given object is an instance of DiskAnomalyRules.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiskAnomalyRules {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiskAnomalyRules.__pulumiType;
    }

    /**
     * Only apply to disks whose name matches
     */
    public readonly diskNameFilter!: pulumi.Output<outputs.DiskAnomalyRulesDiskNameFilter>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly hostGroupId!: pulumi.Output<string | undefined>;
    /**
     * Possible Values: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING`, `WRITE_TIME_EXCEEDING`
     */
    public readonly metric!: pulumi.Output<string>;
    /**
     * Name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Only alert if the threshold was violated in at least *n* of the last *m* samples
     */
    public readonly sampleLimit!: pulumi.Output<outputs.DiskAnomalyRulesSampleLimit>;
    /**
     * Only apply to hosts that have the following tags
     */
    public readonly tagFilters!: pulumi.Output<string[] | undefined>;
    /**
     * Alert if higher than
     */
    public readonly thresholdMilliseconds!: pulumi.Output<number | undefined>;
    /**
     * Alert if lower than
     */
    public readonly thresholdPercent!: pulumi.Output<number | undefined>;

    /**
     * Create a DiskAnomalyRules resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskAnomalyRulesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiskAnomalyRulesArgs | DiskAnomalyRulesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DiskAnomalyRulesState | undefined;
            resourceInputs["diskNameFilter"] = state ? state.diskNameFilter : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["hostGroupId"] = state ? state.hostGroupId : undefined;
            resourceInputs["metric"] = state ? state.metric : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["sampleLimit"] = state ? state.sampleLimit : undefined;
            resourceInputs["tagFilters"] = state ? state.tagFilters : undefined;
            resourceInputs["thresholdMilliseconds"] = state ? state.thresholdMilliseconds : undefined;
            resourceInputs["thresholdPercent"] = state ? state.thresholdPercent : undefined;
        } else {
            const args = argsOrState as DiskAnomalyRulesArgs | undefined;
            if ((!args || args.diskNameFilter === undefined) && !opts.urn) {
                throw new Error("Missing required property 'diskNameFilter'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.metric === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metric'");
            }
            if ((!args || args.sampleLimit === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sampleLimit'");
            }
            resourceInputs["diskNameFilter"] = args ? args.diskNameFilter : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["hostGroupId"] = args ? args.hostGroupId : undefined;
            resourceInputs["metric"] = args ? args.metric : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["sampleLimit"] = args ? args.sampleLimit : undefined;
            resourceInputs["tagFilters"] = args ? args.tagFilters : undefined;
            resourceInputs["thresholdMilliseconds"] = args ? args.thresholdMilliseconds : undefined;
            resourceInputs["thresholdPercent"] = args ? args.thresholdPercent : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DiskAnomalyRules.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DiskAnomalyRules resources.
 */
export interface DiskAnomalyRulesState {
    /**
     * Only apply to disks whose name matches
     */
    diskNameFilter?: pulumi.Input<inputs.DiskAnomalyRulesDiskNameFilter>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostGroupId?: pulumi.Input<string>;
    /**
     * Possible Values: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING`, `WRITE_TIME_EXCEEDING`
     */
    metric?: pulumi.Input<string>;
    /**
     * Name
     */
    name?: pulumi.Input<string>;
    /**
     * Only alert if the threshold was violated in at least *n* of the last *m* samples
     */
    sampleLimit?: pulumi.Input<inputs.DiskAnomalyRulesSampleLimit>;
    /**
     * Only apply to hosts that have the following tags
     */
    tagFilters?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Alert if higher than
     */
    thresholdMilliseconds?: pulumi.Input<number>;
    /**
     * Alert if lower than
     */
    thresholdPercent?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a DiskAnomalyRules resource.
 */
export interface DiskAnomalyRulesArgs {
    /**
     * Only apply to disks whose name matches
     */
    diskNameFilter: pulumi.Input<inputs.DiskAnomalyRulesDiskNameFilter>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostGroupId?: pulumi.Input<string>;
    /**
     * Possible Values: `LOW_DISK_SPACE`, `LOW_INODES`, `READ_TIME_EXCEEDING`, `WRITE_TIME_EXCEEDING`
     */
    metric: pulumi.Input<string>;
    /**
     * Name
     */
    name?: pulumi.Input<string>;
    /**
     * Only alert if the threshold was violated in at least *n* of the last *m* samples
     */
    sampleLimit: pulumi.Input<inputs.DiskAnomalyRulesSampleLimit>;
    /**
     * Only apply to hosts that have the following tags
     */
    tagFilters?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Alert if higher than
     */
    thresholdMilliseconds?: pulumi.Input<number>;
    /**
     * Alert if lower than
     */
    thresholdPercent?: pulumi.Input<number>;
}
