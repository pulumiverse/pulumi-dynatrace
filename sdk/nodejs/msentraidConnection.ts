// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class MsentraidConnection extends pulumi.CustomResource {
    /**
     * Get an existing MsentraidConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MsentraidConnectionState, opts?: pulumi.CustomResourceOptions): MsentraidConnection {
        return new MsentraidConnection(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/msentraidConnection:MsentraidConnection';

    /**
     * Returns true if the given object is an instance of MsentraidConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MsentraidConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MsentraidConnection.__pulumiType;
    }

    /**
     * Application (client) ID of your app registered in Microsoft Azure App registrations
     */
    public readonly applicationId!: pulumi.Output<string>;
    /**
     * Client secret of your app registered in Microsoft Azure App registrations
     */
    public readonly clientSecret!: pulumi.Output<string>;
    /**
     * Description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Directory (tenant) ID of Microsoft Entra Identity Developer
     */
    public readonly directoryId!: pulumi.Output<string>;
    /**
     * The name of the Microsoft Entra Identity Developer connection
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a MsentraidConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MsentraidConnectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MsentraidConnectionArgs | MsentraidConnectionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MsentraidConnectionState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["clientSecret"] = state ? state.clientSecret : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["directoryId"] = state ? state.directoryId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as MsentraidConnectionArgs | undefined;
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.clientSecret === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientSecret'");
            }
            if ((!args || args.directoryId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'directoryId'");
            }
            resourceInputs["applicationId"] = args?.applicationId ? pulumi.secret(args.applicationId) : undefined;
            resourceInputs["clientSecret"] = args?.clientSecret ? pulumi.secret(args.clientSecret) : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["directoryId"] = args?.directoryId ? pulumi.secret(args.directoryId) : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["applicationId", "clientSecret", "directoryId"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(MsentraidConnection.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MsentraidConnection resources.
 */
export interface MsentraidConnectionState {
    /**
     * Application (client) ID of your app registered in Microsoft Azure App registrations
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Client secret of your app registered in Microsoft Azure App registrations
     */
    clientSecret?: pulumi.Input<string>;
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * Directory (tenant) ID of Microsoft Entra Identity Developer
     */
    directoryId?: pulumi.Input<string>;
    /**
     * The name of the Microsoft Entra Identity Developer connection
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MsentraidConnection resource.
 */
export interface MsentraidConnectionArgs {
    /**
     * Application (client) ID of your app registered in Microsoft Azure App registrations
     */
    applicationId: pulumi.Input<string>;
    /**
     * Client secret of your app registered in Microsoft Azure App registrations
     */
    clientSecret: pulumi.Input<string>;
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * Directory (tenant) ID of Microsoft Entra Identity Developer
     */
    directoryId: pulumi.Input<string>;
    /**
     * The name of the Microsoft Entra Identity Developer connection
     */
    name?: pulumi.Input<string>;
}
