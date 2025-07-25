// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class FrequentIssues extends pulumi.CustomResource {
    /**
     * Get an existing FrequentIssues resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FrequentIssuesState, opts?: pulumi.CustomResourceOptions): FrequentIssues {
        return new FrequentIssues(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/frequentIssues:FrequentIssues';

    /**
     * Returns true if the given object is an instance of FrequentIssues.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FrequentIssues {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FrequentIssues.__pulumiType;
    }

    /**
     * Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
     */
    public readonly detectApps!: pulumi.Output<boolean>;
    /**
     * Events raised at this level typically occur when no specific topological entity is applicable, often based on data such as logs and metrics. This does not impact the detection of issues within applications, transactions, services, or infrastructure.
     */
    public readonly detectEnv!: pulumi.Output<boolean | undefined>;
    /**
     * Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
     */
    public readonly detectInfra!: pulumi.Output<boolean>;
    /**
     * Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
     */
    public readonly detectTxn!: pulumi.Output<boolean>;

    /**
     * Create a FrequentIssues resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FrequentIssuesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FrequentIssuesArgs | FrequentIssuesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FrequentIssuesState | undefined;
            resourceInputs["detectApps"] = state ? state.detectApps : undefined;
            resourceInputs["detectEnv"] = state ? state.detectEnv : undefined;
            resourceInputs["detectInfra"] = state ? state.detectInfra : undefined;
            resourceInputs["detectTxn"] = state ? state.detectTxn : undefined;
        } else {
            const args = argsOrState as FrequentIssuesArgs | undefined;
            if ((!args || args.detectApps === undefined) && !opts.urn) {
                throw new Error("Missing required property 'detectApps'");
            }
            if ((!args || args.detectInfra === undefined) && !opts.urn) {
                throw new Error("Missing required property 'detectInfra'");
            }
            if ((!args || args.detectTxn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'detectTxn'");
            }
            resourceInputs["detectApps"] = args ? args.detectApps : undefined;
            resourceInputs["detectEnv"] = args ? args.detectEnv : undefined;
            resourceInputs["detectInfra"] = args ? args.detectInfra : undefined;
            resourceInputs["detectTxn"] = args ? args.detectTxn : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FrequentIssues.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FrequentIssues resources.
 */
export interface FrequentIssuesState {
    /**
     * Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
     */
    detectApps?: pulumi.Input<boolean>;
    /**
     * Events raised at this level typically occur when no specific topological entity is applicable, often based on data such as logs and metrics. This does not impact the detection of issues within applications, transactions, services, or infrastructure.
     */
    detectEnv?: pulumi.Input<boolean>;
    /**
     * Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
     */
    detectInfra?: pulumi.Input<boolean>;
    /**
     * Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
     */
    detectTxn?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a FrequentIssues resource.
 */
export interface FrequentIssuesArgs {
    /**
     * Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
     */
    detectApps: pulumi.Input<boolean>;
    /**
     * Events raised at this level typically occur when no specific topological entity is applicable, often based on data such as logs and metrics. This does not impact the detection of issues within applications, transactions, services, or infrastructure.
     */
    detectEnv?: pulumi.Input<boolean>;
    /**
     * Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
     */
    detectInfra: pulumi.Input<boolean>;
    /**
     * Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
     */
    detectTxn: pulumi.Input<boolean>;
}
