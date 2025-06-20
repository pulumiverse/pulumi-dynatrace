// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class Nettracer extends pulumi.CustomResource {
    /**
     * Get an existing Nettracer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NettracerState, opts?: pulumi.CustomResourceOptions): Nettracer {
        return new Nettracer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/nettracer:Nettracer';

    /**
     * Returns true if the given object is an instance of Nettracer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Nettracer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Nettracer.__pulumiType;
    }

    /**
     * When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
     */
    public readonly netTracer!: pulumi.Output<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;

    /**
     * Create a Nettracer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NettracerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NettracerArgs | NettracerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NettracerState | undefined;
            resourceInputs["netTracer"] = state ? state.netTracer : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
        } else {
            const args = argsOrState as NettracerArgs | undefined;
            if ((!args || args.netTracer === undefined) && !opts.urn) {
                throw new Error("Missing required property 'netTracer'");
            }
            resourceInputs["netTracer"] = args ? args.netTracer : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Nettracer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Nettracer resources.
 */
export interface NettracerState {
    /**
     * When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
     */
    netTracer?: pulumi.Input<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Nettracer resource.
 */
export interface NettracerArgs {
    /**
     * When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
     */
    netTracer: pulumi.Input<boolean>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}
