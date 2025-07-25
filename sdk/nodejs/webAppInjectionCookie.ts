// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class WebAppInjectionCookie extends pulumi.CustomResource {
    /**
     * Get an existing WebAppInjectionCookie resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebAppInjectionCookieState, opts?: pulumi.CustomResourceOptions): WebAppInjectionCookie {
        return new WebAppInjectionCookie(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/webAppInjectionCookie:WebAppInjectionCookie';

    /**
     * Returns true if the given object is an instance of WebAppInjectionCookie.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppInjectionCookie {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppInjectionCookie.__pulumiType;
    }

    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly applicationId!: pulumi.Output<string>;
    /**
     * Specify an alternative domain for cookies set by Dynatrace. Keep in mind that your browser may not allow placement of cookies on certain domains (for example, top-level domains). Before typing a domain name here, confirm that the domain will accept cookies from your browser. For details, see the list of [forbidden top-level domains](https://dt-url.net/9n6b0pfz).
     */
    public readonly cookiePlacementDomain!: pulumi.Output<string | undefined>;
    /**
     * Possible Values: `LAX`, `NONE`, `NOTSET`, `STRICT`
     */
    public readonly sameSiteCookieAttribute!: pulumi.Output<string>;
    /**
     * If your application is only accessible via SSL, you can add the Secure attribute to all cookies set by Dynatrace. This setting prevents the display of warnings from PCI-compliance security scanners. Be aware that with this setting enabled Dynatrace correlation of user actions with server-side web requests is only possible over SSL connections.
     */
    public readonly useSecureCookieAttribute!: pulumi.Output<boolean>;

    /**
     * Create a WebAppInjectionCookie resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppInjectionCookieArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebAppInjectionCookieArgs | WebAppInjectionCookieState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WebAppInjectionCookieState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["cookiePlacementDomain"] = state ? state.cookiePlacementDomain : undefined;
            resourceInputs["sameSiteCookieAttribute"] = state ? state.sameSiteCookieAttribute : undefined;
            resourceInputs["useSecureCookieAttribute"] = state ? state.useSecureCookieAttribute : undefined;
        } else {
            const args = argsOrState as WebAppInjectionCookieArgs | undefined;
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.sameSiteCookieAttribute === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sameSiteCookieAttribute'");
            }
            if ((!args || args.useSecureCookieAttribute === undefined) && !opts.urn) {
                throw new Error("Missing required property 'useSecureCookieAttribute'");
            }
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["cookiePlacementDomain"] = args ? args.cookiePlacementDomain : undefined;
            resourceInputs["sameSiteCookieAttribute"] = args ? args.sameSiteCookieAttribute : undefined;
            resourceInputs["useSecureCookieAttribute"] = args ? args.useSecureCookieAttribute : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WebAppInjectionCookie.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebAppInjectionCookie resources.
 */
export interface WebAppInjectionCookieState {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Specify an alternative domain for cookies set by Dynatrace. Keep in mind that your browser may not allow placement of cookies on certain domains (for example, top-level domains). Before typing a domain name here, confirm that the domain will accept cookies from your browser. For details, see the list of [forbidden top-level domains](https://dt-url.net/9n6b0pfz).
     */
    cookiePlacementDomain?: pulumi.Input<string>;
    /**
     * Possible Values: `LAX`, `NONE`, `NOTSET`, `STRICT`
     */
    sameSiteCookieAttribute?: pulumi.Input<string>;
    /**
     * If your application is only accessible via SSL, you can add the Secure attribute to all cookies set by Dynatrace. This setting prevents the display of warnings from PCI-compliance security scanners. Be aware that with this setting enabled Dynatrace correlation of user actions with server-side web requests is only possible over SSL connections.
     */
    useSecureCookieAttribute?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a WebAppInjectionCookie resource.
 */
export interface WebAppInjectionCookieArgs {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId: pulumi.Input<string>;
    /**
     * Specify an alternative domain for cookies set by Dynatrace. Keep in mind that your browser may not allow placement of cookies on certain domains (for example, top-level domains). Before typing a domain name here, confirm that the domain will accept cookies from your browser. For details, see the list of [forbidden top-level domains](https://dt-url.net/9n6b0pfz).
     */
    cookiePlacementDomain?: pulumi.Input<string>;
    /**
     * Possible Values: `LAX`, `NONE`, `NOTSET`, `STRICT`
     */
    sameSiteCookieAttribute: pulumi.Input<string>;
    /**
     * If your application is only accessible via SSL, you can add the Secure attribute to all cookies set by Dynatrace. This setting prevents the display of warnings from PCI-compliance security scanners. Be aware that with this setting enabled Dynatrace correlation of user actions with server-side web requests is only possible over SSL connections.
     */
    useSecureCookieAttribute: pulumi.Input<boolean>;
}
