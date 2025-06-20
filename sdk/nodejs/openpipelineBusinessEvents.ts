// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class OpenpipelineBusinessEvents extends pulumi.CustomResource {
    /**
     * Get an existing OpenpipelineBusinessEvents resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OpenpipelineBusinessEventsState, opts?: pulumi.CustomResourceOptions): OpenpipelineBusinessEvents {
        return new OpenpipelineBusinessEvents(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/openpipelineBusinessEvents:OpenpipelineBusinessEvents';

    /**
     * Returns true if the given object is an instance of OpenpipelineBusinessEvents.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OpenpipelineBusinessEvents {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OpenpipelineBusinessEvents.__pulumiType;
    }

    /**
     * List of all ingest sources of the configuration
     */
    public readonly endpoints!: pulumi.Output<outputs.OpenpipelineBusinessEventsEndpoints | undefined>;
    /**
     * List of all pipelines of the configuration
     */
    public readonly pipelines!: pulumi.Output<outputs.OpenpipelineBusinessEventsPipelines | undefined>;
    /**
     * Dynamic routing definition
     */
    public readonly routing!: pulumi.Output<outputs.OpenpipelineBusinessEventsRouting | undefined>;

    /**
     * Create a OpenpipelineBusinessEvents resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: OpenpipelineBusinessEventsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OpenpipelineBusinessEventsArgs | OpenpipelineBusinessEventsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OpenpipelineBusinessEventsState | undefined;
            resourceInputs["endpoints"] = state ? state.endpoints : undefined;
            resourceInputs["pipelines"] = state ? state.pipelines : undefined;
            resourceInputs["routing"] = state ? state.routing : undefined;
        } else {
            const args = argsOrState as OpenpipelineBusinessEventsArgs | undefined;
            resourceInputs["endpoints"] = args ? args.endpoints : undefined;
            resourceInputs["pipelines"] = args ? args.pipelines : undefined;
            resourceInputs["routing"] = args ? args.routing : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OpenpipelineBusinessEvents.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OpenpipelineBusinessEvents resources.
 */
export interface OpenpipelineBusinessEventsState {
    /**
     * List of all ingest sources of the configuration
     */
    endpoints?: pulumi.Input<inputs.OpenpipelineBusinessEventsEndpoints>;
    /**
     * List of all pipelines of the configuration
     */
    pipelines?: pulumi.Input<inputs.OpenpipelineBusinessEventsPipelines>;
    /**
     * Dynamic routing definition
     */
    routing?: pulumi.Input<inputs.OpenpipelineBusinessEventsRouting>;
}

/**
 * The set of arguments for constructing a OpenpipelineBusinessEvents resource.
 */
export interface OpenpipelineBusinessEventsArgs {
    /**
     * List of all ingest sources of the configuration
     */
    endpoints?: pulumi.Input<inputs.OpenpipelineBusinessEventsEndpoints>;
    /**
     * List of all pipelines of the configuration
     */
    pipelines?: pulumi.Input<inputs.OpenpipelineBusinessEventsPipelines>;
    /**
     * Dynamic routing definition
     */
    routing?: pulumi.Input<inputs.OpenpipelineBusinessEventsRouting>;
}
