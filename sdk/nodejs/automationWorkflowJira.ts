// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class AutomationWorkflowJira extends pulumi.CustomResource {
    /**
     * Get an existing AutomationWorkflowJira resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AutomationWorkflowJiraState, opts?: pulumi.CustomResourceOptions): AutomationWorkflowJira {
        return new AutomationWorkflowJira(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/automationWorkflowJira:AutomationWorkflowJira';

    /**
     * Returns true if the given object is an instance of AutomationWorkflowJira.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AutomationWorkflowJira {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AutomationWorkflowJira.__pulumiType;
    }

    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     *
     * @deprecated This resource is no longer ordered, please remove this attribute from the configuration
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * The name of the Jira connection
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Password of the Jira user
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * Token for the selected authentication type
     */
    public readonly token!: pulumi.Output<string | undefined>;
    /**
     * Possible Values: `Basic`, `Cloud_token`, `Pat`
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * URL of the Jira server
     */
    public readonly url!: pulumi.Output<string>;
    /**
     * Username or E-Mail address
     */
    public readonly user!: pulumi.Output<string | undefined>;

    /**
     * Create a AutomationWorkflowJira resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AutomationWorkflowJiraArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AutomationWorkflowJiraArgs | AutomationWorkflowJiraState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AutomationWorkflowJiraState | undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
            resourceInputs["user"] = state ? state.user : undefined;
        } else {
            const args = argsOrState as AutomationWorkflowJiraArgs | undefined;
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.url === undefined) && !opts.urn) {
                throw new Error("Missing required property 'url'");
            }
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["token"] = args?.token ? pulumi.secret(args.token) : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
            resourceInputs["user"] = args ? args.user : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["password", "token"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(AutomationWorkflowJira.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AutomationWorkflowJira resources.
 */
export interface AutomationWorkflowJiraState {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     *
     * @deprecated This resource is no longer ordered, please remove this attribute from the configuration
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The name of the Jira connection
     */
    name?: pulumi.Input<string>;
    /**
     * Password of the Jira user
     */
    password?: pulumi.Input<string>;
    /**
     * Token for the selected authentication type
     */
    token?: pulumi.Input<string>;
    /**
     * Possible Values: `Basic`, `Cloud_token`, `Pat`
     */
    type?: pulumi.Input<string>;
    /**
     * URL of the Jira server
     */
    url?: pulumi.Input<string>;
    /**
     * Username or E-Mail address
     */
    user?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AutomationWorkflowJira resource.
 */
export interface AutomationWorkflowJiraArgs {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     *
     * @deprecated This resource is no longer ordered, please remove this attribute from the configuration
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The name of the Jira connection
     */
    name?: pulumi.Input<string>;
    /**
     * Password of the Jira user
     */
    password?: pulumi.Input<string>;
    /**
     * Token for the selected authentication type
     */
    token?: pulumi.Input<string>;
    /**
     * Possible Values: `Basic`, `Cloud_token`, `Pat`
     */
    type: pulumi.Input<string>;
    /**
     * URL of the Jira server
     */
    url: pulumi.Input<string>;
    /**
     * Username or E-Mail address
     */
    user?: pulumi.Input<string>;
}
