// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type FailureDetectionRules struct {
	pulumi.CustomResourceState

	// Conditions
	Conditions FailureDetectionRulesConditionsOutput `pulumi:"conditions"`
	// Rule description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// Rule name
	Name pulumi.StringOutput `pulumi:"name"`
	// Failure detection parameters
	ParameterId pulumi.StringOutput `pulumi:"parameterId"`
}

// NewFailureDetectionRules registers a new resource with the given unique name, arguments, and options.
func NewFailureDetectionRules(ctx *pulumi.Context,
	name string, args *FailureDetectionRulesArgs, opts ...pulumi.ResourceOption) (*FailureDetectionRules, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Conditions == nil {
		return nil, errors.New("invalid value for required argument 'Conditions'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.ParameterId == nil {
		return nil, errors.New("invalid value for required argument 'ParameterId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FailureDetectionRules
	err := ctx.RegisterResource("dynatrace:index/failureDetectionRules:FailureDetectionRules", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFailureDetectionRules gets an existing FailureDetectionRules resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFailureDetectionRules(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FailureDetectionRulesState, opts ...pulumi.ResourceOption) (*FailureDetectionRules, error) {
	var resource FailureDetectionRules
	err := ctx.ReadResource("dynatrace:index/failureDetectionRules:FailureDetectionRules", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FailureDetectionRules resources.
type failureDetectionRulesState struct {
	// Conditions
	Conditions *FailureDetectionRulesConditions `pulumi:"conditions"`
	// Rule description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Rule name
	Name *string `pulumi:"name"`
	// Failure detection parameters
	ParameterId *string `pulumi:"parameterId"`
}

type FailureDetectionRulesState struct {
	// Conditions
	Conditions FailureDetectionRulesConditionsPtrInput
	// Rule description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Rule name
	Name pulumi.StringPtrInput
	// Failure detection parameters
	ParameterId pulumi.StringPtrInput
}

func (FailureDetectionRulesState) ElementType() reflect.Type {
	return reflect.TypeOf((*failureDetectionRulesState)(nil)).Elem()
}

type failureDetectionRulesArgs struct {
	// Conditions
	Conditions FailureDetectionRulesConditions `pulumi:"conditions"`
	// Rule description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Rule name
	Name *string `pulumi:"name"`
	// Failure detection parameters
	ParameterId string `pulumi:"parameterId"`
}

// The set of arguments for constructing a FailureDetectionRules resource.
type FailureDetectionRulesArgs struct {
	// Conditions
	Conditions FailureDetectionRulesConditionsInput
	// Rule description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Rule name
	Name pulumi.StringPtrInput
	// Failure detection parameters
	ParameterId pulumi.StringInput
}

func (FailureDetectionRulesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*failureDetectionRulesArgs)(nil)).Elem()
}

type FailureDetectionRulesInput interface {
	pulumi.Input

	ToFailureDetectionRulesOutput() FailureDetectionRulesOutput
	ToFailureDetectionRulesOutputWithContext(ctx context.Context) FailureDetectionRulesOutput
}

func (*FailureDetectionRules) ElementType() reflect.Type {
	return reflect.TypeOf((**FailureDetectionRules)(nil)).Elem()
}

func (i *FailureDetectionRules) ToFailureDetectionRulesOutput() FailureDetectionRulesOutput {
	return i.ToFailureDetectionRulesOutputWithContext(context.Background())
}

func (i *FailureDetectionRules) ToFailureDetectionRulesOutputWithContext(ctx context.Context) FailureDetectionRulesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionRulesOutput)
}

// FailureDetectionRulesArrayInput is an input type that accepts FailureDetectionRulesArray and FailureDetectionRulesArrayOutput values.
// You can construct a concrete instance of `FailureDetectionRulesArrayInput` via:
//
//	FailureDetectionRulesArray{ FailureDetectionRulesArgs{...} }
type FailureDetectionRulesArrayInput interface {
	pulumi.Input

	ToFailureDetectionRulesArrayOutput() FailureDetectionRulesArrayOutput
	ToFailureDetectionRulesArrayOutputWithContext(context.Context) FailureDetectionRulesArrayOutput
}

type FailureDetectionRulesArray []FailureDetectionRulesInput

func (FailureDetectionRulesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FailureDetectionRules)(nil)).Elem()
}

func (i FailureDetectionRulesArray) ToFailureDetectionRulesArrayOutput() FailureDetectionRulesArrayOutput {
	return i.ToFailureDetectionRulesArrayOutputWithContext(context.Background())
}

func (i FailureDetectionRulesArray) ToFailureDetectionRulesArrayOutputWithContext(ctx context.Context) FailureDetectionRulesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionRulesArrayOutput)
}

// FailureDetectionRulesMapInput is an input type that accepts FailureDetectionRulesMap and FailureDetectionRulesMapOutput values.
// You can construct a concrete instance of `FailureDetectionRulesMapInput` via:
//
//	FailureDetectionRulesMap{ "key": FailureDetectionRulesArgs{...} }
type FailureDetectionRulesMapInput interface {
	pulumi.Input

	ToFailureDetectionRulesMapOutput() FailureDetectionRulesMapOutput
	ToFailureDetectionRulesMapOutputWithContext(context.Context) FailureDetectionRulesMapOutput
}

type FailureDetectionRulesMap map[string]FailureDetectionRulesInput

func (FailureDetectionRulesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FailureDetectionRules)(nil)).Elem()
}

func (i FailureDetectionRulesMap) ToFailureDetectionRulesMapOutput() FailureDetectionRulesMapOutput {
	return i.ToFailureDetectionRulesMapOutputWithContext(context.Background())
}

func (i FailureDetectionRulesMap) ToFailureDetectionRulesMapOutputWithContext(ctx context.Context) FailureDetectionRulesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionRulesMapOutput)
}

type FailureDetectionRulesOutput struct{ *pulumi.OutputState }

func (FailureDetectionRulesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FailureDetectionRules)(nil)).Elem()
}

func (o FailureDetectionRulesOutput) ToFailureDetectionRulesOutput() FailureDetectionRulesOutput {
	return o
}

func (o FailureDetectionRulesOutput) ToFailureDetectionRulesOutputWithContext(ctx context.Context) FailureDetectionRulesOutput {
	return o
}

// Conditions
func (o FailureDetectionRulesOutput) Conditions() FailureDetectionRulesConditionsOutput {
	return o.ApplyT(func(v *FailureDetectionRules) FailureDetectionRulesConditionsOutput { return v.Conditions }).(FailureDetectionRulesConditionsOutput)
}

// Rule description
func (o FailureDetectionRulesOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *FailureDetectionRules) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o FailureDetectionRulesOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *FailureDetectionRules) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o FailureDetectionRulesOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *FailureDetectionRules) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// Rule name
func (o FailureDetectionRulesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *FailureDetectionRules) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Failure detection parameters
func (o FailureDetectionRulesOutput) ParameterId() pulumi.StringOutput {
	return o.ApplyT(func(v *FailureDetectionRules) pulumi.StringOutput { return v.ParameterId }).(pulumi.StringOutput)
}

type FailureDetectionRulesArrayOutput struct{ *pulumi.OutputState }

func (FailureDetectionRulesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FailureDetectionRules)(nil)).Elem()
}

func (o FailureDetectionRulesArrayOutput) ToFailureDetectionRulesArrayOutput() FailureDetectionRulesArrayOutput {
	return o
}

func (o FailureDetectionRulesArrayOutput) ToFailureDetectionRulesArrayOutputWithContext(ctx context.Context) FailureDetectionRulesArrayOutput {
	return o
}

func (o FailureDetectionRulesArrayOutput) Index(i pulumi.IntInput) FailureDetectionRulesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FailureDetectionRules {
		return vs[0].([]*FailureDetectionRules)[vs[1].(int)]
	}).(FailureDetectionRulesOutput)
}

type FailureDetectionRulesMapOutput struct{ *pulumi.OutputState }

func (FailureDetectionRulesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FailureDetectionRules)(nil)).Elem()
}

func (o FailureDetectionRulesMapOutput) ToFailureDetectionRulesMapOutput() FailureDetectionRulesMapOutput {
	return o
}

func (o FailureDetectionRulesMapOutput) ToFailureDetectionRulesMapOutputWithContext(ctx context.Context) FailureDetectionRulesMapOutput {
	return o
}

func (o FailureDetectionRulesMapOutput) MapIndex(k pulumi.StringInput) FailureDetectionRulesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FailureDetectionRules {
		return vs[0].(map[string]*FailureDetectionRules)[vs[1].(string)]
	}).(FailureDetectionRulesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionRulesInput)(nil)).Elem(), &FailureDetectionRules{})
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionRulesArrayInput)(nil)).Elem(), FailureDetectionRulesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionRulesMapInput)(nil)).Elem(), FailureDetectionRulesMap{})
	pulumi.RegisterOutputType(FailureDetectionRulesOutput{})
	pulumi.RegisterOutputType(FailureDetectionRulesArrayOutput{})
	pulumi.RegisterOutputType(FailureDetectionRulesMapOutput{})
}
