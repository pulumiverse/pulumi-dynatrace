// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// !> The data source API endpoint has been deprecated, please use getEntity with entity type `SERVICE` instead.
//
// The service data source allows the service ID to be retrieved by its name and optionally tags / tag-value pairs.
//
// - `name` queries for all services with the specified name
// - `tags` (optional) refers to the tags that need to be present for the service (inclusive)
//
// If multiple services match the given criteria, the first result will be retrieved.
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
//			test, err := dynatrace.GetService(ctx, &dynatrace.GetServiceArgs{
//				Name: "Example",
//				Tags: []string{
//					"TerraformKeyTest",
//					"TerraformKeyValueTest=TestValue",
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = dynatrace.NewKeyRequests(ctx, "#name#", &dynatrace.KeyRequestsArgs{
//				Service: pulumi.String(test.Id),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetService(ctx *pulumi.Context, args *GetServiceArgs, opts ...pulumi.InvokeOption) (*GetServiceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetServiceResult
	err := ctx.Invoke("dynatrace:index/getService:getService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getService.
type GetServiceArgs struct {
	Name     string  `pulumi:"name"`
	Operator *string `pulumi:"operator"`
	// Required tags of the service to find
	Tags []string `pulumi:"tags"`
}

// A collection of values returned by getService.
type GetServiceResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id       string  `pulumi:"id"`
	Name     string  `pulumi:"name"`
	Operator *string `pulumi:"operator"`
	// Required tags of the service to find
	Tags []string `pulumi:"tags"`
}

func GetServiceOutput(ctx *pulumi.Context, args GetServiceOutputArgs, opts ...pulumi.InvokeOption) GetServiceResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetServiceResultOutput, error) {
			args := v.(GetServiceArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("dynatrace:index/getService:getService", args, GetServiceResultOutput{}, options).(GetServiceResultOutput), nil
		}).(GetServiceResultOutput)
}

// A collection of arguments for invoking getService.
type GetServiceOutputArgs struct {
	Name     pulumi.StringInput    `pulumi:"name"`
	Operator pulumi.StringPtrInput `pulumi:"operator"`
	// Required tags of the service to find
	Tags pulumi.StringArrayInput `pulumi:"tags"`
}

func (GetServiceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetServiceArgs)(nil)).Elem()
}

// A collection of values returned by getService.
type GetServiceResultOutput struct{ *pulumi.OutputState }

func (GetServiceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetServiceResult)(nil)).Elem()
}

func (o GetServiceResultOutput) ToGetServiceResultOutput() GetServiceResultOutput {
	return o
}

func (o GetServiceResultOutput) ToGetServiceResultOutputWithContext(ctx context.Context) GetServiceResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetServiceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetServiceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetServiceResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetServiceResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetServiceResultOutput) Operator() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetServiceResult) *string { return v.Operator }).(pulumi.StringPtrOutput)
}

// Required tags of the service to find
func (o GetServiceResultOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetServiceResult) []string { return v.Tags }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetServiceResultOutput{})
}
