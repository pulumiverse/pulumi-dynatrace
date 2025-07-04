// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class UserSessionMetrics extends pulumi.CustomResource {
    /**
     * Get an existing UserSessionMetrics resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserSessionMetricsState, opts?: pulumi.CustomResourceOptions): UserSessionMetrics {
        return new UserSessionMetrics(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/userSessionMetrics:UserSessionMetrics';

    /**
     * Returns true if the given object is an instance of UserSessionMetrics.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UserSessionMetrics {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UserSessionMetrics.__pulumiType;
    }

    /**
     * Defines the fields that are used as dimensions. A dimension is a collection of reference information about a metric data point that is of interest to your business. Dimensions are parameters like "browserFamily", "userType", "country". For example, using "userType" as a dimension allows you to split chart data based on user types.
     */
    public readonly dimensions!: pulumi.Output<string[] | undefined>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Defines the filters for the user session. Filters apply at the moment of extracting the data and only sessions that satisfy the filtering criteria will be used to extract the custom metrics. You will not be able to modify these filters in the metric data explorer. For example, using "userType equals REAL_USER" will give you only data from real users, while forcing the synthetic sessions to be ignored.
     */
    public readonly filters!: pulumi.Output<outputs.UserSessionMetricsFilters | undefined>;
    /**
     * Metric key
     */
    public readonly metricKey!: pulumi.Output<string>;
    /**
     * Defines the type of value to be extracted from the user session. When using **User session counter**, the number of user sessions is counted (similar to count(*) when using USQL). When using **User session field value**, the value of a user session field is extracted.
     */
    public readonly value!: pulumi.Output<outputs.UserSessionMetricsValue>;

    /**
     * Create a UserSessionMetrics resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserSessionMetricsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserSessionMetricsArgs | UserSessionMetricsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UserSessionMetricsState | undefined;
            resourceInputs["dimensions"] = state ? state.dimensions : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["filters"] = state ? state.filters : undefined;
            resourceInputs["metricKey"] = state ? state.metricKey : undefined;
            resourceInputs["value"] = state ? state.value : undefined;
        } else {
            const args = argsOrState as UserSessionMetricsArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.metricKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricKey'");
            }
            if ((!args || args.value === undefined) && !opts.urn) {
                throw new Error("Missing required property 'value'");
            }
            resourceInputs["dimensions"] = args ? args.dimensions : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["filters"] = args ? args.filters : undefined;
            resourceInputs["metricKey"] = args ? args.metricKey : undefined;
            resourceInputs["value"] = args ? args.value : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UserSessionMetrics.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserSessionMetrics resources.
 */
export interface UserSessionMetricsState {
    /**
     * Defines the fields that are used as dimensions. A dimension is a collection of reference information about a metric data point that is of interest to your business. Dimensions are parameters like "browserFamily", "userType", "country". For example, using "userType" as a dimension allows you to split chart data based on user types.
     */
    dimensions?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Defines the filters for the user session. Filters apply at the moment of extracting the data and only sessions that satisfy the filtering criteria will be used to extract the custom metrics. You will not be able to modify these filters in the metric data explorer. For example, using "userType equals REAL_USER" will give you only data from real users, while forcing the synthetic sessions to be ignored.
     */
    filters?: pulumi.Input<inputs.UserSessionMetricsFilters>;
    /**
     * Metric key
     */
    metricKey?: pulumi.Input<string>;
    /**
     * Defines the type of value to be extracted from the user session. When using **User session counter**, the number of user sessions is counted (similar to count(*) when using USQL). When using **User session field value**, the value of a user session field is extracted.
     */
    value?: pulumi.Input<inputs.UserSessionMetricsValue>;
}

/**
 * The set of arguments for constructing a UserSessionMetrics resource.
 */
export interface UserSessionMetricsArgs {
    /**
     * Defines the fields that are used as dimensions. A dimension is a collection of reference information about a metric data point that is of interest to your business. Dimensions are parameters like "browserFamily", "userType", "country". For example, using "userType" as a dimension allows you to split chart data based on user types.
     */
    dimensions?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Defines the filters for the user session. Filters apply at the moment of extracting the data and only sessions that satisfy the filtering criteria will be used to extract the custom metrics. You will not be able to modify these filters in the metric data explorer. For example, using "userType equals REAL_USER" will give you only data from real users, while forcing the synthetic sessions to be ignored.
     */
    filters?: pulumi.Input<inputs.UserSessionMetricsFilters>;
    /**
     * Metric key
     */
    metricKey: pulumi.Input<string>;
    /**
     * Defines the type of value to be extracted from the user session. When using **User session counter**, the number of user sessions is counted (similar to count(*) when using USQL). When using **User session field value**, the value of a user session field is extracted.
     */
    value: pulumi.Input<inputs.UserSessionMetricsValue>;
}
