// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class UsabilityAnalytics extends pulumi.CustomResource {
    /**
     * Get an existing UsabilityAnalytics resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UsabilityAnalyticsState, opts?: pulumi.CustomResourceOptions): UsabilityAnalytics {
        return new UsabilityAnalytics(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/usabilityAnalytics:UsabilityAnalytics';

    /**
     * Returns true if the given object is an instance of UsabilityAnalytics.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UsabilityAnalytics {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UsabilityAnalytics.__pulumiType;
    }

    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly applicationId!: pulumi.Output<string | undefined>;
    /**
     * Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
     * With this setting enabled, a rage click count is compiled for each monitored user session.
     */
    public readonly detectRageClicks!: pulumi.Output<boolean>;

    /**
     * Create a UsabilityAnalytics resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UsabilityAnalyticsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UsabilityAnalyticsArgs | UsabilityAnalyticsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UsabilityAnalyticsState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["detectRageClicks"] = state ? state.detectRageClicks : undefined;
        } else {
            const args = argsOrState as UsabilityAnalyticsArgs | undefined;
            if ((!args || args.detectRageClicks === undefined) && !opts.urn) {
                throw new Error("Missing required property 'detectRageClicks'");
            }
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["detectRageClicks"] = args ? args.detectRageClicks : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UsabilityAnalytics.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UsabilityAnalytics resources.
 */
export interface UsabilityAnalyticsState {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
     * With this setting enabled, a rage click count is compiled for each monitored user session.
     */
    detectRageClicks?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a UsabilityAnalytics resource.
 */
export interface UsabilityAnalyticsArgs {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
     * With this setting enabled, a rage click count is compiled for each monitored user session.
     */
    detectRageClicks: pulumi.Input<boolean>;
}
