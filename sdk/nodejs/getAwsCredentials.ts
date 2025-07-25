// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The `dynatrace.AwsCredentials` data source allows the AWS credential ID to be retrieved by its label.
 *
 * - `label` (String) - The label/name of the AWS credential
 */
export function getAwsCredentials(args: GetAwsCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<GetAwsCredentialsResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getAwsCredentials:getAwsCredentials", {
        "label": args.label,
    }, opts);
}

/**
 * A collection of arguments for invoking getAwsCredentials.
 */
export interface GetAwsCredentialsArgs {
    label: string;
}

/**
 * A collection of values returned by getAwsCredentials.
 */
export interface GetAwsCredentialsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly label: string;
}
/**
 * The `dynatrace.AwsCredentials` data source allows the AWS credential ID to be retrieved by its label.
 *
 * - `label` (String) - The label/name of the AWS credential
 */
export function getAwsCredentialsOutput(args: GetAwsCredentialsOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetAwsCredentialsResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("dynatrace:index/getAwsCredentials:getAwsCredentials", {
        "label": args.label,
    }, opts);
}

/**
 * A collection of arguments for invoking getAwsCredentials.
 */
export interface GetAwsCredentialsOutputArgs {
    label: pulumi.Input<string>;
}
