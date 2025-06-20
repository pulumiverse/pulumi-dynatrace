// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class MutedRequests extends pulumi.CustomResource {
    /**
     * Get an existing MutedRequests resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MutedRequestsState, opts?: pulumi.CustomResourceOptions): MutedRequests {
        return new MutedRequests(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/mutedRequests:MutedRequests';

    /**
     * Returns true if the given object is an instance of MutedRequests.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MutedRequests {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MutedRequests.__pulumiType;
    }

    /**
     * Muted request names
     */
    public readonly mutedRequestNames!: pulumi.Output<string[] | undefined>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a MutedRequests resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MutedRequestsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MutedRequestsArgs | MutedRequestsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MutedRequestsState | undefined;
            resourceInputs["mutedRequestNames"] = state ? state.mutedRequestNames : undefined;
            resourceInputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as MutedRequestsArgs | undefined;
            if ((!args || args.serviceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceId'");
            }
            resourceInputs["mutedRequestNames"] = args ? args.mutedRequestNames : undefined;
            resourceInputs["serviceId"] = args ? args.serviceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MutedRequests.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MutedRequests resources.
 */
export interface MutedRequestsState {
    /**
     * Muted request names
     */
    mutedRequestNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MutedRequests resource.
 */
export interface MutedRequestsArgs {
    /**
     * Muted request names
     */
    mutedRequestNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    serviceId: pulumi.Input<string>;
}
