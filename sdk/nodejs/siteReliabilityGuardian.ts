// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class SiteReliabilityGuardian extends pulumi.CustomResource {
    /**
     * Get an existing SiteReliabilityGuardian resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SiteReliabilityGuardianState, opts?: pulumi.CustomResourceOptions): SiteReliabilityGuardian {
        return new SiteReliabilityGuardian(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian';

    /**
     * Returns true if the given object is an instance of SiteReliabilityGuardian.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteReliabilityGuardian {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteReliabilityGuardian.__pulumiType;
    }

    /**
     * Description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Objectives
     */
    public readonly objectives!: pulumi.Output<outputs.SiteReliabilityGuardianObjectives>;
    /**
     * Define key/value pairs that further describe this guardian.
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;
    /**
     * Define variables for dynamically defining DQL queries
     */
    public readonly variables!: pulumi.Output<outputs.SiteReliabilityGuardianVariables | undefined>;

    /**
     * Create a SiteReliabilityGuardian resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SiteReliabilityGuardianArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SiteReliabilityGuardianArgs | SiteReliabilityGuardianState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SiteReliabilityGuardianState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["objectives"] = state ? state.objectives : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["variables"] = state ? state.variables : undefined;
        } else {
            const args = argsOrState as SiteReliabilityGuardianArgs | undefined;
            if ((!args || args.objectives === undefined) && !opts.urn) {
                throw new Error("Missing required property 'objectives'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["objectives"] = args ? args.objectives : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["variables"] = args ? args.variables : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SiteReliabilityGuardian.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SiteReliabilityGuardian resources.
 */
export interface SiteReliabilityGuardianState {
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * Name
     */
    name?: pulumi.Input<string>;
    /**
     * Objectives
     */
    objectives?: pulumi.Input<inputs.SiteReliabilityGuardianObjectives>;
    /**
     * Define key/value pairs that further describe this guardian.
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Define variables for dynamically defining DQL queries
     */
    variables?: pulumi.Input<inputs.SiteReliabilityGuardianVariables>;
}

/**
 * The set of arguments for constructing a SiteReliabilityGuardian resource.
 */
export interface SiteReliabilityGuardianArgs {
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * Name
     */
    name?: pulumi.Input<string>;
    /**
     * Objectives
     */
    objectives: pulumi.Input<inputs.SiteReliabilityGuardianObjectives>;
    /**
     * Define key/value pairs that further describe this guardian.
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Define variables for dynamically defining DQL queries
     */
    variables?: pulumi.Input<inputs.SiteReliabilityGuardianVariables>;
}