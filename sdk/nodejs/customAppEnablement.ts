// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class CustomAppEnablement extends pulumi.CustomResource {
    /**
     * Get an existing CustomAppEnablement resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CustomAppEnablementState, opts?: pulumi.CustomResourceOptions): CustomAppEnablement {
        return new CustomAppEnablement(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/customAppEnablement:CustomAppEnablement';

    /**
     * Returns true if the given object is an instance of CustomAppEnablement.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CustomAppEnablement {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomAppEnablement.__pulumiType;
    }

    /**
     * Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
     */
    public readonly rum!: pulumi.Output<outputs.CustomAppEnablementRum>;
    /**
     * The scope of this setting (CUSTOM_APPLICATION). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;

    /**
     * Create a CustomAppEnablement resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CustomAppEnablementArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CustomAppEnablementArgs | CustomAppEnablementState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CustomAppEnablementState | undefined;
            resourceInputs["rum"] = state ? state.rum : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
        } else {
            const args = argsOrState as CustomAppEnablementArgs | undefined;
            if ((!args || args.rum === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rum'");
            }
            resourceInputs["rum"] = args ? args.rum : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CustomAppEnablement.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CustomAppEnablement resources.
 */
export interface CustomAppEnablementState {
    /**
     * Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
     */
    rum?: pulumi.Input<inputs.CustomAppEnablementRum>;
    /**
     * The scope of this setting (CUSTOM_APPLICATION). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CustomAppEnablement resource.
 */
export interface CustomAppEnablementArgs {
    /**
     * Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
     */
    rum: pulumi.Input<inputs.CustomAppEnablementRum>;
    /**
     * The scope of this setting (CUSTOM_APPLICATION). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
}
