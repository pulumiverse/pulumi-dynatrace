// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class ServiceAnomalies extends pulumi.CustomResource {
    /**
     * Get an existing ServiceAnomalies resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceAnomaliesState, opts?: pulumi.CustomResourceOptions): ServiceAnomalies {
        return new ServiceAnomalies(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/serviceAnomalies:ServiceAnomalies';

    /**
     * Returns true if the given object is an instance of ServiceAnomalies.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceAnomalies {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceAnomalies.__pulumiType;
    }

    /**
     * Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
     */
    public readonly failureRates!: pulumi.Output<outputs.ServiceAnomaliesFailureRates | undefined>;
    /**
     * The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
     */
    public readonly load!: pulumi.Output<outputs.ServiceAnomaliesLoad | undefined>;
    /**
     * The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
     */
    public readonly loadDrops!: pulumi.Output<outputs.ServiceAnomaliesLoadDrops | undefined>;
    /**
     * Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
     */
    public readonly responseTimes!: pulumi.Output<outputs.ServiceAnomaliesResponseTimes | undefined>;

    /**
     * Create a ServiceAnomalies resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ServiceAnomaliesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceAnomaliesArgs | ServiceAnomaliesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ServiceAnomaliesState | undefined;
            resourceInputs["failureRates"] = state ? state.failureRates : undefined;
            resourceInputs["load"] = state ? state.load : undefined;
            resourceInputs["loadDrops"] = state ? state.loadDrops : undefined;
            resourceInputs["responseTimes"] = state ? state.responseTimes : undefined;
        } else {
            const args = argsOrState as ServiceAnomaliesArgs | undefined;
            resourceInputs["failureRates"] = args ? args.failureRates : undefined;
            resourceInputs["load"] = args ? args.load : undefined;
            resourceInputs["loadDrops"] = args ? args.loadDrops : undefined;
            resourceInputs["responseTimes"] = args ? args.responseTimes : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ServiceAnomalies.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceAnomalies resources.
 */
export interface ServiceAnomaliesState {
    /**
     * Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
     */
    failureRates?: pulumi.Input<inputs.ServiceAnomaliesFailureRates>;
    /**
     * The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
     */
    load?: pulumi.Input<inputs.ServiceAnomaliesLoad>;
    /**
     * The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
     */
    loadDrops?: pulumi.Input<inputs.ServiceAnomaliesLoadDrops>;
    /**
     * Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
     */
    responseTimes?: pulumi.Input<inputs.ServiceAnomaliesResponseTimes>;
}

/**
 * The set of arguments for constructing a ServiceAnomalies resource.
 */
export interface ServiceAnomaliesArgs {
    /**
     * Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
     */
    failureRates?: pulumi.Input<inputs.ServiceAnomaliesFailureRates>;
    /**
     * The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
     */
    load?: pulumi.Input<inputs.ServiceAnomaliesLoad>;
    /**
     * The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
     */
    loadDrops?: pulumi.Input<inputs.ServiceAnomaliesLoadDrops>;
    /**
     * Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
     */
    responseTimes?: pulumi.Input<inputs.ServiceAnomaliesResponseTimes>;
}
