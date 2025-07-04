// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// !> The data source API endpoint has been deprecated, please use getEntity with entity type `PROCESS_GROUP` instead.
//
// The process group data source allows the process group ID to be retrieved by its name and optionally tags / tag-value pairs.
//
// - `name` queries for all process groups with the specified name
// - `tags` (optional) refers to the tags that need to be present for the process group (inclusive)
//
// If multiple process groups match the given criteria, the first result will be retrieved.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"fmt"
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			test, err := dynatrace.GetProcessGroup(ctx, &dynatrace.GetProcessGroupArgs{
//				Name: "Example",
//				Tags: []string{
//					"TerraformKeyTest",
//					"TerraformKeyValueTest=TestValue",
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = dynatrace.NewManagementZone(ctx, "#name#", &dynatrace.ManagementZoneArgs{
//				EntitySelectorBasedRules: dynatrace.ManagementZoneEntitySelectorBasedRuleArray{
//					&dynatrace.ManagementZoneEntitySelectorBasedRuleArgs{
//						Enabled:  pulumi.Bool(true),
//						Selector: pulumi.Sprintf("type(\"process_group\"),entityId(\"%v\")", test.Id),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetProcessGroup(ctx *pulumi.Context, args *GetProcessGroupArgs, opts ...pulumi.InvokeOption) (*GetProcessGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetProcessGroupResult
	err := ctx.Invoke("dynatrace:index/getProcessGroup:getProcessGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProcessGroup.
type GetProcessGroupArgs struct {
	Name string `pulumi:"name"`
	// Required tags of the process group to find
	Tags []string `pulumi:"tags"`
}

// A collection of values returned by getProcessGroup.
type GetProcessGroupResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// Required tags of the process group to find
	Tags []string `pulumi:"tags"`
}

func GetProcessGroupOutput(ctx *pulumi.Context, args GetProcessGroupOutputArgs, opts ...pulumi.InvokeOption) GetProcessGroupResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetProcessGroupResultOutput, error) {
			args := v.(GetProcessGroupArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("dynatrace:index/getProcessGroup:getProcessGroup", args, GetProcessGroupResultOutput{}, options).(GetProcessGroupResultOutput), nil
		}).(GetProcessGroupResultOutput)
}

// A collection of arguments for invoking getProcessGroup.
type GetProcessGroupOutputArgs struct {
	Name pulumi.StringInput `pulumi:"name"`
	// Required tags of the process group to find
	Tags pulumi.StringArrayInput `pulumi:"tags"`
}

func (GetProcessGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetProcessGroupArgs)(nil)).Elem()
}

// A collection of values returned by getProcessGroup.
type GetProcessGroupResultOutput struct{ *pulumi.OutputState }

func (GetProcessGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetProcessGroupResult)(nil)).Elem()
}

func (o GetProcessGroupResultOutput) ToGetProcessGroupResultOutput() GetProcessGroupResultOutput {
	return o
}

func (o GetProcessGroupResultOutput) ToGetProcessGroupResultOutputWithContext(ctx context.Context) GetProcessGroupResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetProcessGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetProcessGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetProcessGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetProcessGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

// Required tags of the process group to find
func (o GetProcessGroupResultOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProcessGroupResult) []string { return v.Tags }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetProcessGroupResultOutput{})
}
