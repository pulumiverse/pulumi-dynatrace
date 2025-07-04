// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class ExtensionExecutionController extends pulumi.CustomResource {
    /**
     * Get an existing ExtensionExecutionController resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ExtensionExecutionControllerState, opts?: pulumi.CustomResourceOptions): ExtensionExecutionController {
        return new ExtensionExecutionController(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/extensionExecutionController:ExtensionExecutionController';

    /**
     * Returns true if the given object is an instance of ExtensionExecutionController.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExtensionExecutionController {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExtensionExecutionController.__pulumiType;
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Enable local HTTP Metric, Log and Event Ingest API
     */
    public readonly ingestActive!: pulumi.Output<boolean | undefined>;
    /**
     * Possible Values: `DEFAULT`, `HIGH`
     */
    public readonly performanceProfile!: pulumi.Output<string | undefined>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;
    /**
     * Enable Dynatrace StatsD
     */
    public readonly statsdActive!: pulumi.Output<boolean | undefined>;

    /**
     * Create a ExtensionExecutionController resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExtensionExecutionControllerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ExtensionExecutionControllerArgs | ExtensionExecutionControllerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ExtensionExecutionControllerState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["ingestActive"] = state ? state.ingestActive : undefined;
            resourceInputs["performanceProfile"] = state ? state.performanceProfile : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["statsdActive"] = state ? state.statsdActive : undefined;
        } else {
            const args = argsOrState as ExtensionExecutionControllerArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["ingestActive"] = args ? args.ingestActive : undefined;
            resourceInputs["performanceProfile"] = args ? args.performanceProfile : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["statsdActive"] = args ? args.statsdActive : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ExtensionExecutionController.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ExtensionExecutionController resources.
 */
export interface ExtensionExecutionControllerState {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Enable local HTTP Metric, Log and Event Ingest API
     */
    ingestActive?: pulumi.Input<boolean>;
    /**
     * Possible Values: `DEFAULT`, `HIGH`
     */
    performanceProfile?: pulumi.Input<string>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * Enable Dynatrace StatsD
     */
    statsdActive?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a ExtensionExecutionController resource.
 */
export interface ExtensionExecutionControllerArgs {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Enable local HTTP Metric, Log and Event Ingest API
     */
    ingestActive?: pulumi.Input<boolean>;
    /**
     * Possible Values: `DEFAULT`, `HIGH`
     */
    performanceProfile?: pulumi.Input<string>;
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * Enable Dynatrace StatsD
     */
    statsdActive?: pulumi.Input<boolean>;
}
