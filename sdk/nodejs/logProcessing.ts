// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class LogProcessing extends pulumi.CustomResource {
    /**
     * Get an existing LogProcessing resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogProcessingState, opts?: pulumi.CustomResourceOptions): LogProcessing {
        return new LogProcessing(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/logProcessing:LogProcessing';

    /**
     * Returns true if the given object is an instance of LogProcessing.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogProcessing {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogProcessing.__pulumiType;
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
     * instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
     * specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * ## Processor definition Add a rule definition using our syntax. [In our documentation](https://dt-url.net/8k03xm2) you
     * will find instructions and application [examples](https://dt-url.net/m24305t).
     */
    public readonly processorDefinition!: pulumi.Output<outputs.LogProcessingProcessorDefinition>;
    /**
     * Matcher
     */
    public readonly query!: pulumi.Output<string>;
    /**
     * Rule name
     */
    public readonly ruleName!: pulumi.Output<string>;
    /**
     * ## Rule testing ### 1. Paste a log / JSON sample
     */
    public readonly ruleTesting!: pulumi.Output<outputs.LogProcessingRuleTesting>;

    /**
     * Create a LogProcessing resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogProcessingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogProcessingArgs | LogProcessingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LogProcessingState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["processorDefinition"] = state ? state.processorDefinition : undefined;
            resourceInputs["query"] = state ? state.query : undefined;
            resourceInputs["ruleName"] = state ? state.ruleName : undefined;
            resourceInputs["ruleTesting"] = state ? state.ruleTesting : undefined;
        } else {
            const args = argsOrState as LogProcessingArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.processorDefinition === undefined) && !opts.urn) {
                throw new Error("Missing required property 'processorDefinition'");
            }
            if ((!args || args.query === undefined) && !opts.urn) {
                throw new Error("Missing required property 'query'");
            }
            if ((!args || args.ruleName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleName'");
            }
            if ((!args || args.ruleTesting === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleTesting'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["processorDefinition"] = args ? args.processorDefinition : undefined;
            resourceInputs["query"] = args ? args.query : undefined;
            resourceInputs["ruleName"] = args ? args.ruleName : undefined;
            resourceInputs["ruleTesting"] = args ? args.ruleTesting : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LogProcessing.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogProcessing resources.
 */
export interface LogProcessingState {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
     * instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
     * specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * ## Processor definition Add a rule definition using our syntax. [In our documentation](https://dt-url.net/8k03xm2) you
     * will find instructions and application [examples](https://dt-url.net/m24305t).
     */
    processorDefinition?: pulumi.Input<inputs.LogProcessingProcessorDefinition>;
    /**
     * Matcher
     */
    query?: pulumi.Input<string>;
    /**
     * Rule name
     */
    ruleName?: pulumi.Input<string>;
    /**
     * ## Rule testing ### 1. Paste a log / JSON sample
     */
    ruleTesting?: pulumi.Input<inputs.LogProcessingRuleTesting>;
}

/**
 * The set of arguments for constructing a LogProcessing resource.
 */
export interface LogProcessingArgs {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
     * instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
     * specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * ## Processor definition Add a rule definition using our syntax. [In our documentation](https://dt-url.net/8k03xm2) you
     * will find instructions and application [examples](https://dt-url.net/m24305t).
     */
    processorDefinition: pulumi.Input<inputs.LogProcessingProcessorDefinition>;
    /**
     * Matcher
     */
    query: pulumi.Input<string>;
    /**
     * Rule name
     */
    ruleName: pulumi.Input<string>;
    /**
     * ## Rule testing ### 1. Paste a log / JSON sample
     */
    ruleTesting: pulumi.Input<inputs.LogProcessingRuleTesting>;
}
