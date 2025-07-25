// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class AzureCredentials extends pulumi.CustomResource {
    /**
     * Get an existing AzureCredentials resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AzureCredentialsState, opts?: pulumi.CustomResourceOptions): AzureCredentials {
        return new AzureCredentials(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/azureCredentials:AzureCredentials';

    /**
     * Returns true if the given object is an instance of AzureCredentials.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureCredentials {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureCredentials.__pulumiType;
    }

    /**
     * The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
     */
    public readonly active!: pulumi.Output<boolean>;
    /**
     * The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
     */
    public readonly appId!: pulumi.Output<string | undefined>;
    /**
     * The automatic capture of Azure tags is on (`true`) or off (`false`)
     */
    public readonly autoTagging!: pulumi.Output<boolean | undefined>;
    /**
     * The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
     */
    public readonly directoryId!: pulumi.Output<string | undefined>;
    /**
     * The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
     */
    public readonly key!: pulumi.Output<string | undefined>;
    /**
     * The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
     */
    public readonly label!: pulumi.Output<string>;
    /**
     * A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
     */
    public readonly monitorOnlyExcludingTagPairs!: pulumi.Output<outputs.AzureCredentialsMonitorOnlyExcludingTagPair[] | undefined>;
    /**
     * A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
     */
    public readonly monitorOnlyTagPairs!: pulumi.Output<outputs.AzureCredentialsMonitorOnlyTagPair[] | undefined>;
    /**
     * Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
     */
    public readonly monitorOnlyTaggedEntities!: pulumi.Output<boolean>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
     */
    public readonly removeDefaults!: pulumi.Output<boolean | undefined>;
    /**
     * A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
     *
     * @deprecated Assigning supported services directly when creating Azure Credentials is deprecated. Use the resource `dynatrace.AzureService` instead.
     */
    public readonly supportingServices!: pulumi.Output<outputs.AzureCredentialsSupportingService[] | undefined>;
    /**
     * @deprecated This attribute is deprecated and has no effect any more. It always defaults to `true`.
     */
    public readonly supportingServicesManagedInDynatrace!: pulumi.Output<boolean | undefined>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    public readonly unknowns!: pulumi.Output<string | undefined>;

    /**
     * Create a AzureCredentials resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AzureCredentialsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AzureCredentialsArgs | AzureCredentialsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AzureCredentialsState | undefined;
            resourceInputs["active"] = state ? state.active : undefined;
            resourceInputs["appId"] = state ? state.appId : undefined;
            resourceInputs["autoTagging"] = state ? state.autoTagging : undefined;
            resourceInputs["directoryId"] = state ? state.directoryId : undefined;
            resourceInputs["key"] = state ? state.key : undefined;
            resourceInputs["label"] = state ? state.label : undefined;
            resourceInputs["monitorOnlyExcludingTagPairs"] = state ? state.monitorOnlyExcludingTagPairs : undefined;
            resourceInputs["monitorOnlyTagPairs"] = state ? state.monitorOnlyTagPairs : undefined;
            resourceInputs["monitorOnlyTaggedEntities"] = state ? state.monitorOnlyTaggedEntities : undefined;
            resourceInputs["removeDefaults"] = state ? state.removeDefaults : undefined;
            resourceInputs["supportingServices"] = state ? state.supportingServices : undefined;
            resourceInputs["supportingServicesManagedInDynatrace"] = state ? state.supportingServicesManagedInDynatrace : undefined;
            resourceInputs["unknowns"] = state ? state.unknowns : undefined;
        } else {
            const args = argsOrState as AzureCredentialsArgs | undefined;
            if ((!args || args.active === undefined) && !opts.urn) {
                throw new Error("Missing required property 'active'");
            }
            if ((!args || args.label === undefined) && !opts.urn) {
                throw new Error("Missing required property 'label'");
            }
            if ((!args || args.monitorOnlyTaggedEntities === undefined) && !opts.urn) {
                throw new Error("Missing required property 'monitorOnlyTaggedEntities'");
            }
            resourceInputs["active"] = args ? args.active : undefined;
            resourceInputs["appId"] = args ? args.appId : undefined;
            resourceInputs["autoTagging"] = args ? args.autoTagging : undefined;
            resourceInputs["directoryId"] = args ? args.directoryId : undefined;
            resourceInputs["key"] = args?.key ? pulumi.secret(args.key) : undefined;
            resourceInputs["label"] = args ? args.label : undefined;
            resourceInputs["monitorOnlyExcludingTagPairs"] = args ? args.monitorOnlyExcludingTagPairs : undefined;
            resourceInputs["monitorOnlyTagPairs"] = args ? args.monitorOnlyTagPairs : undefined;
            resourceInputs["monitorOnlyTaggedEntities"] = args ? args.monitorOnlyTaggedEntities : undefined;
            resourceInputs["removeDefaults"] = args ? args.removeDefaults : undefined;
            resourceInputs["supportingServices"] = args ? args.supportingServices : undefined;
            resourceInputs["supportingServicesManagedInDynatrace"] = args ? args.supportingServicesManagedInDynatrace : undefined;
            resourceInputs["unknowns"] = args ? args.unknowns : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["key"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(AzureCredentials.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AzureCredentials resources.
 */
export interface AzureCredentialsState {
    /**
     * The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
     */
    active?: pulumi.Input<boolean>;
    /**
     * The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
     */
    appId?: pulumi.Input<string>;
    /**
     * The automatic capture of Azure tags is on (`true`) or off (`false`)
     */
    autoTagging?: pulumi.Input<boolean>;
    /**
     * The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
     */
    directoryId?: pulumi.Input<string>;
    /**
     * The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
     */
    key?: pulumi.Input<string>;
    /**
     * The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
     */
    label?: pulumi.Input<string>;
    /**
     * A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
     */
    monitorOnlyExcludingTagPairs?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsMonitorOnlyExcludingTagPair>[]>;
    /**
     * A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
     */
    monitorOnlyTagPairs?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsMonitorOnlyTagPair>[]>;
    /**
     * Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
     */
    monitorOnlyTaggedEntities?: pulumi.Input<boolean>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
     */
    removeDefaults?: pulumi.Input<boolean>;
    /**
     * A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
     *
     * @deprecated Assigning supported services directly when creating Azure Credentials is deprecated. Use the resource `dynatrace.AzureService` instead.
     */
    supportingServices?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsSupportingService>[]>;
    /**
     * @deprecated This attribute is deprecated and has no effect any more. It always defaults to `true`.
     */
    supportingServicesManagedInDynatrace?: pulumi.Input<boolean>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    unknowns?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AzureCredentials resource.
 */
export interface AzureCredentialsArgs {
    /**
     * The monitoring is enabled (`true`) or disabled (`false`).  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected
     */
    active: pulumi.Input<boolean>;
    /**
     * The Application ID (also referred to as Client ID)  The combination of Application ID and Directory ID must be unique
     */
    appId?: pulumi.Input<string>;
    /**
     * The automatic capture of Azure tags is on (`true`) or off (`false`)
     */
    autoTagging?: pulumi.Input<boolean>;
    /**
     * The Directory ID (also referred to as Tenant ID)  The combination of Application ID and Directory ID must be unique
     */
    directoryId?: pulumi.Input<string>;
    /**
     * The secret key associated with the Application ID.  For security reasons, GET requests return this field as `null`. Submit your key on creation or update of the configuration. If the field is omitted during an update, the old value remains unaffected.
     */
    key?: pulumi.Input<string>;
    /**
     * The unique name of the Azure credentials configuration.  Allowed characters are letters, numbers, and spaces. Also the special characters `.+-_` are allowed
     */
    label: pulumi.Input<string>;
    /**
     * A list of Azure tags to be excluded from monitoring.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`.
     */
    monitorOnlyExcludingTagPairs?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsMonitorOnlyExcludingTagPair>[]>;
    /**
     * A list of Azure tags to be monitored.  You can specify up to 20 tags. A resource tagged with *any* of the specified tags is monitored.  Only applicable when the **monitorOnlyTaggedEntities** parameter is set to `true`
     */
    monitorOnlyTagPairs?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsMonitorOnlyTagPair>[]>;
    /**
     * Monitor only resources that have specified Azure tags (`true`) or all resources (`false`).
     */
    monitorOnlyTaggedEntities: pulumi.Input<boolean>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created Azure Credentials. Supporting Services applied by via `dynatrace.AzureService` subsequently won't get touched.
     */
    removeDefaults?: pulumi.Input<boolean>;
    /**
     * A list of Azure supporting services to be monitored. For each service there's a sublist of its metrics and the metrics' dimensions that should be monitored. All of these elements (services, metrics, dimensions) must have corresponding static definitions on the server.
     *
     * @deprecated Assigning supported services directly when creating Azure Credentials is deprecated. Use the resource `dynatrace.AzureService` instead.
     */
    supportingServices?: pulumi.Input<pulumi.Input<inputs.AzureCredentialsSupportingService>[]>;
    /**
     * @deprecated This attribute is deprecated and has no effect any more. It always defaults to `true`.
     */
    supportingServicesManagedInDynatrace?: pulumi.Input<boolean>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    unknowns?: pulumi.Input<string>;
}
