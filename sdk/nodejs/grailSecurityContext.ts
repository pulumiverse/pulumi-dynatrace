// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class GrailSecurityContext extends pulumi.CustomResource {
    /**
     * Get an existing GrailSecurityContext resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GrailSecurityContextState, opts?: pulumi.CustomResourceOptions): GrailSecurityContext {
        return new GrailSecurityContext(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/grailSecurityContext:GrailSecurityContext';

    /**
     * Returns true if the given object is an instance of GrailSecurityContext.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GrailSecurityContext {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GrailSecurityContext.__pulumiType;
    }

    /**
     * The case-sensitive name of a property of the destination type.
     */
    public readonly destinationProperty!: pulumi.Output<string>;
    /**
     * Type of the entity whose security context to override.
     */
    public readonly entityType!: pulumi.Output<string>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;

    /**
     * Create a GrailSecurityContext resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GrailSecurityContextArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GrailSecurityContextArgs | GrailSecurityContextState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as GrailSecurityContextState | undefined;
            resourceInputs["destinationProperty"] = state ? state.destinationProperty : undefined;
            resourceInputs["entityType"] = state ? state.entityType : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
        } else {
            const args = argsOrState as GrailSecurityContextArgs | undefined;
            if ((!args || args.destinationProperty === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destinationProperty'");
            }
            if ((!args || args.entityType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'entityType'");
            }
            resourceInputs["destinationProperty"] = args ? args.destinationProperty : undefined;
            resourceInputs["entityType"] = args ? args.entityType : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(GrailSecurityContext.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GrailSecurityContext resources.
 */
export interface GrailSecurityContextState {
    /**
     * The case-sensitive name of a property of the destination type.
     */
    destinationProperty?: pulumi.Input<string>;
    /**
     * Type of the entity whose security context to override.
     */
    entityType?: pulumi.Input<string>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a GrailSecurityContext resource.
 */
export interface GrailSecurityContextArgs {
    /**
     * The case-sensitive name of a property of the destination type.
     */
    destinationProperty: pulumi.Input<string>;
    /**
     * Type of the entity whose security context to override.
     */
    entityType: pulumi.Input<string>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
}