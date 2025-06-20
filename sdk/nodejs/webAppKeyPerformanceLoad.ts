// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class WebAppKeyPerformanceLoad extends pulumi.CustomResource {
    /**
     * Get an existing WebAppKeyPerformanceLoad resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebAppKeyPerformanceLoadState, opts?: pulumi.CustomResourceOptions): WebAppKeyPerformanceLoad {
        return new WebAppKeyPerformanceLoad(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/webAppKeyPerformanceLoad:WebAppKeyPerformanceLoad';

    /**
     * Returns true if the given object is an instance of WebAppKeyPerformanceLoad.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppKeyPerformanceLoad {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppKeyPerformanceLoad.__pulumiType;
    }

    /**
     * If the selected key performance metric is not detected, the **User action duration** metric is used instead.
     */
    public readonly fallbackThresholds!: pulumi.Output<outputs.WebAppKeyPerformanceLoadFallbackThresholds | undefined>;
    /**
     * Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
     */
    public readonly kpm!: pulumi.Output<string>;
    /**
     * The scope of this setting (APPLICATION_METHOD, APPLICATION)
     */
    public readonly scope!: pulumi.Output<string>;
    /**
     * Set the Tolerating and Frustrated performance thresholds for this action type.
     */
    public readonly thresholds!: pulumi.Output<outputs.WebAppKeyPerformanceLoadThresholds>;

    /**
     * Create a WebAppKeyPerformanceLoad resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppKeyPerformanceLoadArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebAppKeyPerformanceLoadArgs | WebAppKeyPerformanceLoadState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WebAppKeyPerformanceLoadState | undefined;
            resourceInputs["fallbackThresholds"] = state ? state.fallbackThresholds : undefined;
            resourceInputs["kpm"] = state ? state.kpm : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["thresholds"] = state ? state.thresholds : undefined;
        } else {
            const args = argsOrState as WebAppKeyPerformanceLoadArgs | undefined;
            if ((!args || args.kpm === undefined) && !opts.urn) {
                throw new Error("Missing required property 'kpm'");
            }
            if ((!args || args.scope === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scope'");
            }
            if ((!args || args.thresholds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'thresholds'");
            }
            resourceInputs["fallbackThresholds"] = args ? args.fallbackThresholds : undefined;
            resourceInputs["kpm"] = args ? args.kpm : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["thresholds"] = args ? args.thresholds : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WebAppKeyPerformanceLoad.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebAppKeyPerformanceLoad resources.
 */
export interface WebAppKeyPerformanceLoadState {
    /**
     * If the selected key performance metric is not detected, the **User action duration** metric is used instead.
     */
    fallbackThresholds?: pulumi.Input<inputs.WebAppKeyPerformanceLoadFallbackThresholds>;
    /**
     * Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
     */
    kpm?: pulumi.Input<string>;
    /**
     * The scope of this setting (APPLICATION_METHOD, APPLICATION)
     */
    scope?: pulumi.Input<string>;
    /**
     * Set the Tolerating and Frustrated performance thresholds for this action type.
     */
    thresholds?: pulumi.Input<inputs.WebAppKeyPerformanceLoadThresholds>;
}

/**
 * The set of arguments for constructing a WebAppKeyPerformanceLoad resource.
 */
export interface WebAppKeyPerformanceLoadArgs {
    /**
     * If the selected key performance metric is not detected, the **User action duration** metric is used instead.
     */
    fallbackThresholds?: pulumi.Input<inputs.WebAppKeyPerformanceLoadFallbackThresholds>;
    /**
     * Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
     */
    kpm: pulumi.Input<string>;
    /**
     * The scope of this setting (APPLICATION_METHOD, APPLICATION)
     */
    scope: pulumi.Input<string>;
    /**
     * Set the Tolerating and Frustrated performance thresholds for this action type.
     */
    thresholds: pulumi.Input<inputs.WebAppKeyPerformanceLoadThresholds>;
}
