// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class OwnershipTeams extends pulumi.CustomResource {
    /**
     * Get an existing OwnershipTeams resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OwnershipTeamsState, opts?: pulumi.CustomResourceOptions): OwnershipTeams {
        return new OwnershipTeams(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/ownershipTeams:OwnershipTeams';

    /**
     * Returns true if the given object is an instance of OwnershipTeams.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OwnershipTeams {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OwnershipTeams.__pulumiType;
    }

    /**
     * Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
     */
    public readonly additionalInformation!: pulumi.Output<outputs.OwnershipTeamsAdditionalInformation | undefined>;
    /**
     * Define options for messaging integration or other means of contacting this team.
     */
    public readonly contactDetails!: pulumi.Output<outputs.OwnershipTeamsContactDetails | undefined>;
    /**
     * Description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * This field should only be used for the automation purpose when importing team information.
     */
    public readonly externalId!: pulumi.Output<string | undefined>;
    /**
     * The team identifier is used to reference the team from any entity in Dynatrace. If you are using Kubernetes labels, keep in mind the 63 character limit that they enforce.
     */
    public readonly identifier!: pulumi.Output<string>;
    /**
     * Include links to online resources where information relevant to this team’s responsibilities can be found.
     */
    public readonly links!: pulumi.Output<outputs.OwnershipTeamsLinks | undefined>;
    /**
     * Team name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Turn on all responsibility assignments that apply to this team.
     */
    public readonly responsibilities!: pulumi.Output<outputs.OwnershipTeamsResponsibilities>;
    /**
     * The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
     */
    public readonly supplementaryIdentifiers!: pulumi.Output<outputs.OwnershipTeamsSupplementaryIdentifiers | undefined>;

    /**
     * Create a OwnershipTeams resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OwnershipTeamsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OwnershipTeamsArgs | OwnershipTeamsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OwnershipTeamsState | undefined;
            resourceInputs["additionalInformation"] = state ? state.additionalInformation : undefined;
            resourceInputs["contactDetails"] = state ? state.contactDetails : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["externalId"] = state ? state.externalId : undefined;
            resourceInputs["identifier"] = state ? state.identifier : undefined;
            resourceInputs["links"] = state ? state.links : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["responsibilities"] = state ? state.responsibilities : undefined;
            resourceInputs["supplementaryIdentifiers"] = state ? state.supplementaryIdentifiers : undefined;
        } else {
            const args = argsOrState as OwnershipTeamsArgs | undefined;
            if ((!args || args.identifier === undefined) && !opts.urn) {
                throw new Error("Missing required property 'identifier'");
            }
            if ((!args || args.responsibilities === undefined) && !opts.urn) {
                throw new Error("Missing required property 'responsibilities'");
            }
            resourceInputs["additionalInformation"] = args ? args.additionalInformation : undefined;
            resourceInputs["contactDetails"] = args ? args.contactDetails : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["externalId"] = args ? args.externalId : undefined;
            resourceInputs["identifier"] = args ? args.identifier : undefined;
            resourceInputs["links"] = args ? args.links : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["responsibilities"] = args ? args.responsibilities : undefined;
            resourceInputs["supplementaryIdentifiers"] = args ? args.supplementaryIdentifiers : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OwnershipTeams.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OwnershipTeams resources.
 */
export interface OwnershipTeamsState {
    /**
     * Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
     */
    additionalInformation?: pulumi.Input<inputs.OwnershipTeamsAdditionalInformation>;
    /**
     * Define options for messaging integration or other means of contacting this team.
     */
    contactDetails?: pulumi.Input<inputs.OwnershipTeamsContactDetails>;
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * This field should only be used for the automation purpose when importing team information.
     */
    externalId?: pulumi.Input<string>;
    /**
     * The team identifier is used to reference the team from any entity in Dynatrace. If you are using Kubernetes labels, keep in mind the 63 character limit that they enforce.
     */
    identifier?: pulumi.Input<string>;
    /**
     * Include links to online resources where information relevant to this team’s responsibilities can be found.
     */
    links?: pulumi.Input<inputs.OwnershipTeamsLinks>;
    /**
     * Team name
     */
    name?: pulumi.Input<string>;
    /**
     * Turn on all responsibility assignments that apply to this team.
     */
    responsibilities?: pulumi.Input<inputs.OwnershipTeamsResponsibilities>;
    /**
     * The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
     */
    supplementaryIdentifiers?: pulumi.Input<inputs.OwnershipTeamsSupplementaryIdentifiers>;
}

/**
 * The set of arguments for constructing a OwnershipTeams resource.
 */
export interface OwnershipTeamsArgs {
    /**
     * Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
     */
    additionalInformation?: pulumi.Input<inputs.OwnershipTeamsAdditionalInformation>;
    /**
     * Define options for messaging integration or other means of contacting this team.
     */
    contactDetails?: pulumi.Input<inputs.OwnershipTeamsContactDetails>;
    /**
     * Description
     */
    description?: pulumi.Input<string>;
    /**
     * This field should only be used for the automation purpose when importing team information.
     */
    externalId?: pulumi.Input<string>;
    /**
     * The team identifier is used to reference the team from any entity in Dynatrace. If you are using Kubernetes labels, keep in mind the 63 character limit that they enforce.
     */
    identifier: pulumi.Input<string>;
    /**
     * Include links to online resources where information relevant to this team’s responsibilities can be found.
     */
    links?: pulumi.Input<inputs.OwnershipTeamsLinks>;
    /**
     * Team name
     */
    name?: pulumi.Input<string>;
    /**
     * Turn on all responsibility assignments that apply to this team.
     */
    responsibilities: pulumi.Input<inputs.OwnershipTeamsResponsibilities>;
    /**
     * The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
     */
    supplementaryIdentifiers?: pulumi.Input<inputs.OwnershipTeamsSupplementaryIdentifiers>;
}
