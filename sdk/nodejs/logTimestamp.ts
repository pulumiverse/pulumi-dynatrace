// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class LogTimestamp extends pulumi.CustomResource {
    /**
     * Get an existing LogTimestamp resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogTimestampState, opts?: pulumi.CustomResourceOptions): LogTimestamp {
        return new LogTimestamp(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/logTimestamp:LogTimestamp';

    /**
     * Returns true if the given object is an instance of LogTimestamp.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogTimestamp {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogTimestamp.__pulumiType;
    }

    /**
     * Name
     */
    public readonly configItemTitle!: pulumi.Output<string>;
    /**
     * Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
     */
    public readonly dateSearchLimit!: pulumi.Output<number | undefined>;
    /**
     * Date-time pattern
     */
    public readonly dateTimePattern!: pulumi.Output<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Optional field. Enter a fragment of the line text that starts the entry. No support for wildcards - the text is treated literally.
     */
    public readonly entryBoundary!: pulumi.Output<outputs.LogTimestampEntryBoundary | undefined>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * no documentation available
     */
    public readonly matchers!: pulumi.Output<outputs.LogTimestampMatchers | undefined>;
    /**
     * The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;
    /**
     * Timezone
     */
    public readonly timezone!: pulumi.Output<string>;

    /**
     * Create a LogTimestamp resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogTimestampArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogTimestampArgs | LogTimestampState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LogTimestampState | undefined;
            resourceInputs["configItemTitle"] = state ? state.configItemTitle : undefined;
            resourceInputs["dateSearchLimit"] = state ? state.dateSearchLimit : undefined;
            resourceInputs["dateTimePattern"] = state ? state.dateTimePattern : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["entryBoundary"] = state ? state.entryBoundary : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["matchers"] = state ? state.matchers : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["timezone"] = state ? state.timezone : undefined;
        } else {
            const args = argsOrState as LogTimestampArgs | undefined;
            if ((!args || args.configItemTitle === undefined) && !opts.urn) {
                throw new Error("Missing required property 'configItemTitle'");
            }
            if ((!args || args.dateTimePattern === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dateTimePattern'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.timezone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timezone'");
            }
            resourceInputs["configItemTitle"] = args ? args.configItemTitle : undefined;
            resourceInputs["dateSearchLimit"] = args ? args.dateSearchLimit : undefined;
            resourceInputs["dateTimePattern"] = args ? args.dateTimePattern : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["entryBoundary"] = args ? args.entryBoundary : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["matchers"] = args ? args.matchers : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["timezone"] = args ? args.timezone : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LogTimestamp.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogTimestamp resources.
 */
export interface LogTimestampState {
    /**
     * Name
     */
    configItemTitle?: pulumi.Input<string>;
    /**
     * Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
     */
    dateSearchLimit?: pulumi.Input<number>;
    /**
     * Date-time pattern
     */
    dateTimePattern?: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Optional field. Enter a fragment of the line text that starts the entry. No support for wildcards - the text is treated literally.
     */
    entryBoundary?: pulumi.Input<inputs.LogTimestampEntryBoundary>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * no documentation available
     */
    matchers?: pulumi.Input<inputs.LogTimestampMatchers>;
    /**
     * The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * Timezone
     */
    timezone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LogTimestamp resource.
 */
export interface LogTimestampArgs {
    /**
     * Name
     */
    configItemTitle: pulumi.Input<string>;
    /**
     * Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
     */
    dateSearchLimit?: pulumi.Input<number>;
    /**
     * Date-time pattern
     */
    dateTimePattern: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Optional field. Enter a fragment of the line text that starts the entry. No support for wildcards - the text is treated literally.
     */
    entryBoundary?: pulumi.Input<inputs.LogTimestampEntryBoundary>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * no documentation available
     */
    matchers?: pulumi.Input<inputs.LogTimestampMatchers>;
    /**
     * The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
     */
    scope?: pulumi.Input<string>;
    /**
     * Timezone
     */
    timezone: pulumi.Input<string>;
}
