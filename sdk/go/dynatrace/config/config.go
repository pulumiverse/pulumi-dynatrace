// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

var _ = internal.GetEnvOrDefault

func GetAccountId(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:accountId")
}
func GetAutomationClientId(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:automationClientId")
}
func GetAutomationClientSecret(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:automationClientSecret")
}

// The URL of the Dynatrace Environment with Platform capabilities turned on (`https://#####.apps.dynatrace.com)`. This is
// optional configuration when `dtEnvUrl` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
// `https://#####.apps.dynatrace.com`
func GetAutomationEnvUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:automationEnvUrl")
}

// The URL that provides the Bearer tokens when accessing the Automation REST API. This is optional configuration when
// `dtEnvUrl` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
// `https://#####.apps.dynatrace.com`
func GetAutomationTokenUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:automationTokenUrl")
}
func GetClientId(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:clientId")
}
func GetClientSecret(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:clientSecret")
}
func GetDtApiToken(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "dynatrace:dtApiToken")
	if err == nil {
		return v
	}
	var value string
	if d := internal.GetEnvOrDefault(nil, nil, "DYNATRACE_API_TOKEN", "DT_API_TOKEN"); d != nil {
		value = d.(string)
	}
	return value
}
func GetDtClusterApiToken(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "dynatrace:dtClusterApiToken")
	if err == nil {
		return v
	}
	var value string
	if d := internal.GetEnvOrDefault(nil, nil, "DYNATRACE_CLUSTER_API_TOKEN", "DT_CLUSTER_API_TOKEN"); d != nil {
		value = d.(string)
	}
	return value
}
func GetDtClusterUrl(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "dynatrace:dtClusterUrl")
	if err == nil {
		return v
	}
	var value string
	if d := internal.GetEnvOrDefault(nil, nil, "DYNATRACE_CLUSTER_URL", "DT_CLUSTER_URL"); d != nil {
		value = d.(string)
	}
	return value
}
func GetDtEnvUrl(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "dynatrace:dtEnvUrl")
	if err == nil {
		return v
	}
	var value string
	if d := internal.GetEnvOrDefault(nil, nil, "DYNATRACE_ENV_URL", "DT_ENV_URL"); d != nil {
		value = d.(string)
	}
	return value
}
func GetIamAccountId(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:iamAccountId")
}
func GetIamClientId(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:iamClientId")
}
func GetIamClientSecret(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:iamClientSecret")
}
func GetIamEndpointUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:iamEndpointUrl")
}
func GetIamTokenUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:iamTokenUrl")
}

// A Dynatrace Platform Token. Specifying such a token allows for easy authentication against Platform resources. In such a
// case it supersedes `automationClientId`, `automationClientSecret`, `automationTokenUrl` and `automationEnvUrl`
func GetPlatformToken(ctx *pulumi.Context) string {
	return config.Get(ctx, "dynatrace:platformToken")
}
