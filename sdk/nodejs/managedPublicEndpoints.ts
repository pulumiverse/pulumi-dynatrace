// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class ManagedPublicEndpoints extends pulumi.CustomResource {
    /**
     * Get an existing ManagedPublicEndpoints resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ManagedPublicEndpointsState, opts?: pulumi.CustomResourceOptions): ManagedPublicEndpoints {
        return new ManagedPublicEndpoints(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints';

    /**
     * Returns true if the given object is an instance of ManagedPublicEndpoints.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ManagedPublicEndpoints {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ManagedPublicEndpoints.__pulumiType;
    }

    /**
     * Additional web UI addresses
     */
    public readonly additionalWebUiAddresses!: pulumi.Output<string[] | undefined>;
    /**
     * Beacon forwarder address
     */
    public readonly beaconForwarderAddress!: pulumi.Output<string | undefined>;
    /**
     * CDN address
     */
    public readonly cdnAddress!: pulumi.Output<string | undefined>;
    /**
     * Web UI address
     */
    public readonly webUiAddress!: pulumi.Output<string | undefined>;

    /**
     * Create a ManagedPublicEndpoints resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ManagedPublicEndpointsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ManagedPublicEndpointsArgs | ManagedPublicEndpointsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ManagedPublicEndpointsState | undefined;
            resourceInputs["additionalWebUiAddresses"] = state ? state.additionalWebUiAddresses : undefined;
            resourceInputs["beaconForwarderAddress"] = state ? state.beaconForwarderAddress : undefined;
            resourceInputs["cdnAddress"] = state ? state.cdnAddress : undefined;
            resourceInputs["webUiAddress"] = state ? state.webUiAddress : undefined;
        } else {
            const args = argsOrState as ManagedPublicEndpointsArgs | undefined;
            resourceInputs["additionalWebUiAddresses"] = args ? args.additionalWebUiAddresses : undefined;
            resourceInputs["beaconForwarderAddress"] = args ? args.beaconForwarderAddress : undefined;
            resourceInputs["cdnAddress"] = args ? args.cdnAddress : undefined;
            resourceInputs["webUiAddress"] = args ? args.webUiAddress : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ManagedPublicEndpoints.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ManagedPublicEndpoints resources.
 */
export interface ManagedPublicEndpointsState {
    /**
     * Additional web UI addresses
     */
    additionalWebUiAddresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Beacon forwarder address
     */
    beaconForwarderAddress?: pulumi.Input<string>;
    /**
     * CDN address
     */
    cdnAddress?: pulumi.Input<string>;
    /**
     * Web UI address
     */
    webUiAddress?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ManagedPublicEndpoints resource.
 */
export interface ManagedPublicEndpointsArgs {
    /**
     * Additional web UI addresses
     */
    additionalWebUiAddresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Beacon forwarder address
     */
    beaconForwarderAddress?: pulumi.Input<string>;
    /**
     * CDN address
     */
    cdnAddress?: pulumi.Input<string>;
    /**
     * Web UI address
     */
    webUiAddress?: pulumi.Input<string>;
}