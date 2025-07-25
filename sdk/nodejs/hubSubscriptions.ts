// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class HubSubscriptions extends pulumi.CustomResource {
    /**
     * Get an existing HubSubscriptions resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: HubSubscriptionsState, opts?: pulumi.CustomResourceOptions): HubSubscriptions {
        return new HubSubscriptions(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/hubSubscriptions:HubSubscriptions';

    /**
     * Returns true if the given object is an instance of HubSubscriptions.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is HubSubscriptions {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === HubSubscriptions.__pulumiType;
    }

    /**
     * Subscriptions
     */
    public readonly tokenSubscriptions!: pulumi.Output<outputs.HubSubscriptionsTokenSubscriptions | undefined>;

    /**
     * Create a HubSubscriptions resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: HubSubscriptionsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: HubSubscriptionsArgs | HubSubscriptionsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as HubSubscriptionsState | undefined;
            resourceInputs["tokenSubscriptions"] = state ? state.tokenSubscriptions : undefined;
        } else {
            const args = argsOrState as HubSubscriptionsArgs | undefined;
            resourceInputs["tokenSubscriptions"] = args ? args.tokenSubscriptions : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(HubSubscriptions.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering HubSubscriptions resources.
 */
export interface HubSubscriptionsState {
    /**
     * Subscriptions
     */
    tokenSubscriptions?: pulumi.Input<inputs.HubSubscriptionsTokenSubscriptions>;
}

/**
 * The set of arguments for constructing a HubSubscriptions resource.
 */
export interface HubSubscriptionsArgs {
    /**
     * Subscriptions
     */
    tokenSubscriptions?: pulumi.Input<inputs.HubSubscriptionsTokenSubscriptions>;
}
