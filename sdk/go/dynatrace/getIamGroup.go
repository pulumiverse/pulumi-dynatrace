// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// > **Dynatrace SaaS only**
//
// > To utilize this resource, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permission: **Allow read access for identity resources (users and groups)** (`account-idm-read`).
//
// The IAM group data source allows the group ID to be retrieved by its name.
//
// - `name` (String) - The name of the IAM group
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
//			example, err := dynatrace.LookupIamGroup(ctx, &dynatrace.LookupIamGroupArgs{
//				Name: "Terraform Example",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("groups", example.Id)
//			return nil
//		})
//	}
//
// ```
func LookupIamGroup(ctx *pulumi.Context, args *LookupIamGroupArgs, opts ...pulumi.InvokeOption) (*LookupIamGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupIamGroupResult
	err := ctx.Invoke("dynatrace:index/getIamGroup:getIamGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamGroup.
type LookupIamGroupArgs struct {
	Name string `pulumi:"name"`
}

// A collection of values returned by getIamGroup.
type LookupIamGroupResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
}

func LookupIamGroupOutput(ctx *pulumi.Context, args LookupIamGroupOutputArgs, opts ...pulumi.InvokeOption) LookupIamGroupResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupIamGroupResultOutput, error) {
			args := v.(LookupIamGroupArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("dynatrace:index/getIamGroup:getIamGroup", args, LookupIamGroupResultOutput{}, options).(LookupIamGroupResultOutput), nil
		}).(LookupIamGroupResultOutput)
}

// A collection of arguments for invoking getIamGroup.
type LookupIamGroupOutputArgs struct {
	Name pulumi.StringInput `pulumi:"name"`
}

func (LookupIamGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamGroupArgs)(nil)).Elem()
}

// A collection of values returned by getIamGroup.
type LookupIamGroupResultOutput struct{ *pulumi.OutputState }

func (LookupIamGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamGroupResult)(nil)).Elem()
}

func (o LookupIamGroupResultOutput) ToLookupIamGroupResultOutput() LookupIamGroupResultOutput {
	return o
}

func (o LookupIamGroupResultOutput) ToLookupIamGroupResultOutputWithContext(ctx context.Context) LookupIamGroupResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o LookupIamGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupIamGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIamGroupResultOutput{})
}
