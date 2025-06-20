// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class ServiceHttpFailure extends pulumi.CustomResource {
    /**
     * Get an existing ServiceHttpFailure resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceHttpFailureState, opts?: pulumi.CustomResourceOptions): ServiceHttpFailure {
        return new ServiceHttpFailure(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/serviceHttpFailure:ServiceHttpFailure';

    /**
     * Returns true if the given object is an instance of ServiceHttpFailure.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceHttpFailure {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceHttpFailure.__pulumiType;
    }

    /**
     * HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
     */
    public readonly brokenLinks!: pulumi.Output<outputs.ServiceHttpFailureBrokenLinks | undefined>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * HTTP response codes
     */
    public readonly httpResponseCodes!: pulumi.Output<outputs.ServiceHttpFailureHttpResponseCodes | undefined>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a ServiceHttpFailure resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceHttpFailureArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceHttpFailureArgs | ServiceHttpFailureState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ServiceHttpFailureState | undefined;
            resourceInputs["brokenLinks"] = state ? state.brokenLinks : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["httpResponseCodes"] = state ? state.httpResponseCodes : undefined;
            resourceInputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as ServiceHttpFailureArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.serviceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceId'");
            }
            resourceInputs["brokenLinks"] = args ? args.brokenLinks : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["httpResponseCodes"] = args ? args.httpResponseCodes : undefined;
            resourceInputs["serviceId"] = args ? args.serviceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ServiceHttpFailure.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceHttpFailure resources.
 */
export interface ServiceHttpFailureState {
    /**
     * HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
     */
    brokenLinks?: pulumi.Input<inputs.ServiceHttpFailureBrokenLinks>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * HTTP response codes
     */
    httpResponseCodes?: pulumi.Input<inputs.ServiceHttpFailureHttpResponseCodes>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceHttpFailure resource.
 */
export interface ServiceHttpFailureArgs {
    /**
     * HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
     */
    brokenLinks?: pulumi.Input<inputs.ServiceHttpFailureBrokenLinks>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * HTTP response codes
     */
    httpResponseCodes?: pulumi.Input<inputs.ServiceHttpFailureHttpResponseCodes>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    serviceId: pulumi.Input<string>;
}
