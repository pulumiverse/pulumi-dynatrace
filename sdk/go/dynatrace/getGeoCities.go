// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// The `getGeoCities` data source retrieves the list of cities and their codes based on country and region code.
//
// - `countryCode` (String) - The ISO code of the required country
// - `regionCode` (String) - The code of the required region
//
// Geographic regions API: GET regions of a country - https://docs.dynatrace.com/docs/shortlink/api-v2-rum-geographic-regions-get-regions-country
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			example, err := dynatrace.GetGeoCities(ctx, &dynatrace.GetGeoCitiesArgs{
//				CountryCode: "FR",
//				RegionCode:  "BRE",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("test", example)
//			return nil
//		})
//	}
//
// ```
func GetGeoCities(ctx *pulumi.Context, args *GetGeoCitiesArgs, opts ...pulumi.InvokeOption) (*GetGeoCitiesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetGeoCitiesResult
	err := ctx.Invoke("dynatrace:index/getGeoCities:getGeoCities", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGeoCities.
type GetGeoCitiesArgs struct {
	// The ISO code of the required country
	CountryCode string `pulumi:"countryCode"`
	// The code of the required region
	RegionCode string `pulumi:"regionCode"`
}

// A collection of values returned by getGeoCities.
type GetGeoCitiesResult struct {
	Cities []GetGeoCitiesCity `pulumi:"cities"`
	// The ISO code of the required country
	CountryCode string `pulumi:"countryCode"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The code of the required region
	RegionCode string `pulumi:"regionCode"`
}

func GetGeoCitiesOutput(ctx *pulumi.Context, args GetGeoCitiesOutputArgs, opts ...pulumi.InvokeOption) GetGeoCitiesResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetGeoCitiesResultOutput, error) {
			args := v.(GetGeoCitiesArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("dynatrace:index/getGeoCities:getGeoCities", args, GetGeoCitiesResultOutput{}, options).(GetGeoCitiesResultOutput), nil
		}).(GetGeoCitiesResultOutput)
}

// A collection of arguments for invoking getGeoCities.
type GetGeoCitiesOutputArgs struct {
	// The ISO code of the required country
	CountryCode pulumi.StringInput `pulumi:"countryCode"`
	// The code of the required region
	RegionCode pulumi.StringInput `pulumi:"regionCode"`
}

func (GetGeoCitiesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGeoCitiesArgs)(nil)).Elem()
}

// A collection of values returned by getGeoCities.
type GetGeoCitiesResultOutput struct{ *pulumi.OutputState }

func (GetGeoCitiesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGeoCitiesResult)(nil)).Elem()
}

func (o GetGeoCitiesResultOutput) ToGetGeoCitiesResultOutput() GetGeoCitiesResultOutput {
	return o
}

func (o GetGeoCitiesResultOutput) ToGetGeoCitiesResultOutputWithContext(ctx context.Context) GetGeoCitiesResultOutput {
	return o
}

func (o GetGeoCitiesResultOutput) Cities() GetGeoCitiesCityArrayOutput {
	return o.ApplyT(func(v GetGeoCitiesResult) []GetGeoCitiesCity { return v.Cities }).(GetGeoCitiesCityArrayOutput)
}

// The ISO code of the required country
func (o GetGeoCitiesResultOutput) CountryCode() pulumi.StringOutput {
	return o.ApplyT(func(v GetGeoCitiesResult) string { return v.CountryCode }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetGeoCitiesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetGeoCitiesResult) string { return v.Id }).(pulumi.StringOutput)
}

// The code of the required region
func (o GetGeoCitiesResultOutput) RegionCode() pulumi.StringOutput {
	return o.ApplyT(func(v GetGeoCitiesResult) string { return v.RegionCode }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetGeoCitiesResultOutput{})
}