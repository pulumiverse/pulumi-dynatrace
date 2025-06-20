// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Slo extends pulumi.CustomResource {
    /**
     * Get an existing Slo resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SloState, opts?: pulumi.CustomResourceOptions): Slo {
        return new Slo(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/slo:Slo';

    /**
     * Returns true if the given object is an instance of Slo.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Slo {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Slo.__pulumiType;
    }

    /**
     * The total count metric (the denominator in rate calculation)
     */
    public readonly denominator!: pulumi.Output<string | undefined>;
    /**
     * The custom description of the SLO (optional)
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The SLO is enabled (`false`) or disabled (`true`)
     */
    public readonly disabled!: pulumi.Output<boolean | undefined>;
    /**
     * Error budget burn rate configuration of a service-level objective (SLO).
     */
    public readonly errorBudgetBurnRate!: pulumi.Output<outputs.SloErrorBudgetBurnRate | undefined>;
    /**
     * The evaluation type of the SLO. Currently only `AGGREGATE` is supported
     */
    public readonly evaluation!: pulumi.Output<string>;
    /**
     * The entity filter for the SLO evaluation. Use the [syntax of entity selector](https://dt-url.net/entityselector)
     */
    public readonly filter!: pulumi.Output<string | undefined>;
    /**
     * The percentage-based metric expression for the calculation of the SLO
     */
    public readonly metricExpression!: pulumi.Output<string | undefined>;
    /**
     * The name that is used to create SLO func metrics keys. Once created, metric name cannot be changed.
     */
    public readonly metricName!: pulumi.Output<string | undefined>;
    /**
     * The name of the rule
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The metric for the count of successes (the numerator in rate calculation)
     *
     * @deprecated `numerator` and `denominator` have been replaced by `metricExpression`
     */
    public readonly numerator!: pulumi.Output<string | undefined>;
    /**
     * The percentage-based metric for the calculation of the SLO
     */
    public readonly rate!: pulumi.Output<string | undefined>;
    /**
     * The target value of the SLO
     */
    public readonly target!: pulumi.Output<number>;
    /**
     * The timeframe for the SLO evaluation. Use the syntax of the global timeframe selector
     */
    public readonly timeframe!: pulumi.Output<string>;
    /**
     * The warning value of the SLO. At warning state the SLO is still fulfilled but is getting close to failure
     */
    public readonly warning!: pulumi.Output<number>;

    /**
     * Create a Slo resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SloArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SloArgs | SloState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SloState | undefined;
            resourceInputs["denominator"] = state ? state.denominator : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["disabled"] = state ? state.disabled : undefined;
            resourceInputs["errorBudgetBurnRate"] = state ? state.errorBudgetBurnRate : undefined;
            resourceInputs["evaluation"] = state ? state.evaluation : undefined;
            resourceInputs["filter"] = state ? state.filter : undefined;
            resourceInputs["metricExpression"] = state ? state.metricExpression : undefined;
            resourceInputs["metricName"] = state ? state.metricName : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["numerator"] = state ? state.numerator : undefined;
            resourceInputs["rate"] = state ? state.rate : undefined;
            resourceInputs["target"] = state ? state.target : undefined;
            resourceInputs["timeframe"] = state ? state.timeframe : undefined;
            resourceInputs["warning"] = state ? state.warning : undefined;
        } else {
            const args = argsOrState as SloArgs | undefined;
            if ((!args || args.evaluation === undefined) && !opts.urn) {
                throw new Error("Missing required property 'evaluation'");
            }
            if ((!args || args.target === undefined) && !opts.urn) {
                throw new Error("Missing required property 'target'");
            }
            if ((!args || args.timeframe === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timeframe'");
            }
            if ((!args || args.warning === undefined) && !opts.urn) {
                throw new Error("Missing required property 'warning'");
            }
            resourceInputs["denominator"] = args ? args.denominator : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["disabled"] = args ? args.disabled : undefined;
            resourceInputs["errorBudgetBurnRate"] = args ? args.errorBudgetBurnRate : undefined;
            resourceInputs["evaluation"] = args ? args.evaluation : undefined;
            resourceInputs["filter"] = args ? args.filter : undefined;
            resourceInputs["metricExpression"] = args ? args.metricExpression : undefined;
            resourceInputs["metricName"] = args ? args.metricName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["numerator"] = args ? args.numerator : undefined;
            resourceInputs["rate"] = args ? args.rate : undefined;
            resourceInputs["target"] = args ? args.target : undefined;
            resourceInputs["timeframe"] = args ? args.timeframe : undefined;
            resourceInputs["warning"] = args ? args.warning : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Slo.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Slo resources.
 */
export interface SloState {
    /**
     * The total count metric (the denominator in rate calculation)
     */
    denominator?: pulumi.Input<string>;
    /**
     * The custom description of the SLO (optional)
     */
    description?: pulumi.Input<string>;
    /**
     * The SLO is enabled (`false`) or disabled (`true`)
     */
    disabled?: pulumi.Input<boolean>;
    /**
     * Error budget burn rate configuration of a service-level objective (SLO).
     */
    errorBudgetBurnRate?: pulumi.Input<inputs.SloErrorBudgetBurnRate>;
    /**
     * The evaluation type of the SLO. Currently only `AGGREGATE` is supported
     */
    evaluation?: pulumi.Input<string>;
    /**
     * The entity filter for the SLO evaluation. Use the [syntax of entity selector](https://dt-url.net/entityselector)
     */
    filter?: pulumi.Input<string>;
    /**
     * The percentage-based metric expression for the calculation of the SLO
     */
    metricExpression?: pulumi.Input<string>;
    /**
     * The name that is used to create SLO func metrics keys. Once created, metric name cannot be changed.
     */
    metricName?: pulumi.Input<string>;
    /**
     * The name of the rule
     */
    name?: pulumi.Input<string>;
    /**
     * The metric for the count of successes (the numerator in rate calculation)
     *
     * @deprecated `numerator` and `denominator` have been replaced by `metricExpression`
     */
    numerator?: pulumi.Input<string>;
    /**
     * The percentage-based metric for the calculation of the SLO
     */
    rate?: pulumi.Input<string>;
    /**
     * The target value of the SLO
     */
    target?: pulumi.Input<number>;
    /**
     * The timeframe for the SLO evaluation. Use the syntax of the global timeframe selector
     */
    timeframe?: pulumi.Input<string>;
    /**
     * The warning value of the SLO. At warning state the SLO is still fulfilled but is getting close to failure
     */
    warning?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Slo resource.
 */
export interface SloArgs {
    /**
     * The total count metric (the denominator in rate calculation)
     */
    denominator?: pulumi.Input<string>;
    /**
     * The custom description of the SLO (optional)
     */
    description?: pulumi.Input<string>;
    /**
     * The SLO is enabled (`false`) or disabled (`true`)
     */
    disabled?: pulumi.Input<boolean>;
    /**
     * Error budget burn rate configuration of a service-level objective (SLO).
     */
    errorBudgetBurnRate?: pulumi.Input<inputs.SloErrorBudgetBurnRate>;
    /**
     * The evaluation type of the SLO. Currently only `AGGREGATE` is supported
     */
    evaluation: pulumi.Input<string>;
    /**
     * The entity filter for the SLO evaluation. Use the [syntax of entity selector](https://dt-url.net/entityselector)
     */
    filter?: pulumi.Input<string>;
    /**
     * The percentage-based metric expression for the calculation of the SLO
     */
    metricExpression?: pulumi.Input<string>;
    /**
     * The name that is used to create SLO func metrics keys. Once created, metric name cannot be changed.
     */
    metricName?: pulumi.Input<string>;
    /**
     * The name of the rule
     */
    name?: pulumi.Input<string>;
    /**
     * The metric for the count of successes (the numerator in rate calculation)
     *
     * @deprecated `numerator` and `denominator` have been replaced by `metricExpression`
     */
    numerator?: pulumi.Input<string>;
    /**
     * The percentage-based metric for the calculation of the SLO
     */
    rate?: pulumi.Input<string>;
    /**
     * The target value of the SLO
     */
    target: pulumi.Input<number>;
    /**
     * The timeframe for the SLO evaluation. Use the syntax of the global timeframe selector
     */
    timeframe: pulumi.Input<string>;
    /**
     * The warning value of the SLO. At warning state the SLO is still fulfilled but is getting close to failure
     */
    warning: pulumi.Input<number>;
}
