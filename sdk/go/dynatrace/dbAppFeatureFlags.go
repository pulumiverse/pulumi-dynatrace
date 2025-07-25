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

type DbAppFeatureFlags struct {
	pulumi.CustomResourceState

	// State of boolean feature flag
	BooleanValue pulumi.BoolPtrOutput `pulumi:"booleanValue"`
	// Name of the feature
	Name pulumi.StringOutput `pulumi:"name"`
	// State of numeric feature flag
	NumberValue pulumi.IntPtrOutput `pulumi:"numberValue"`
	// State of textual feature flag
	StringValue pulumi.StringPtrOutput `pulumi:"stringValue"`
	// Possible Values: `Boolean`, `Number`, `String`
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDbAppFeatureFlags registers a new resource with the given unique name, arguments, and options.
func NewDbAppFeatureFlags(ctx *pulumi.Context,
	name string, args *DbAppFeatureFlagsArgs, opts ...pulumi.ResourceOption) (*DbAppFeatureFlags, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DbAppFeatureFlags
	err := ctx.RegisterResource("dynatrace:index/dbAppFeatureFlags:DbAppFeatureFlags", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDbAppFeatureFlags gets an existing DbAppFeatureFlags resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDbAppFeatureFlags(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DbAppFeatureFlagsState, opts ...pulumi.ResourceOption) (*DbAppFeatureFlags, error) {
	var resource DbAppFeatureFlags
	err := ctx.ReadResource("dynatrace:index/dbAppFeatureFlags:DbAppFeatureFlags", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DbAppFeatureFlags resources.
type dbAppFeatureFlagsState struct {
	// State of boolean feature flag
	BooleanValue *bool `pulumi:"booleanValue"`
	// Name of the feature
	Name *string `pulumi:"name"`
	// State of numeric feature flag
	NumberValue *int `pulumi:"numberValue"`
	// State of textual feature flag
	StringValue *string `pulumi:"stringValue"`
	// Possible Values: `Boolean`, `Number`, `String`
	Type *string `pulumi:"type"`
}

type DbAppFeatureFlagsState struct {
	// State of boolean feature flag
	BooleanValue pulumi.BoolPtrInput
	// Name of the feature
	Name pulumi.StringPtrInput
	// State of numeric feature flag
	NumberValue pulumi.IntPtrInput
	// State of textual feature flag
	StringValue pulumi.StringPtrInput
	// Possible Values: `Boolean`, `Number`, `String`
	Type pulumi.StringPtrInput
}

func (DbAppFeatureFlagsState) ElementType() reflect.Type {
	return reflect.TypeOf((*dbAppFeatureFlagsState)(nil)).Elem()
}

type dbAppFeatureFlagsArgs struct {
	// State of boolean feature flag
	BooleanValue *bool `pulumi:"booleanValue"`
	// Name of the feature
	Name *string `pulumi:"name"`
	// State of numeric feature flag
	NumberValue *int `pulumi:"numberValue"`
	// State of textual feature flag
	StringValue *string `pulumi:"stringValue"`
	// Possible Values: `Boolean`, `Number`, `String`
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a DbAppFeatureFlags resource.
type DbAppFeatureFlagsArgs struct {
	// State of boolean feature flag
	BooleanValue pulumi.BoolPtrInput
	// Name of the feature
	Name pulumi.StringPtrInput
	// State of numeric feature flag
	NumberValue pulumi.IntPtrInput
	// State of textual feature flag
	StringValue pulumi.StringPtrInput
	// Possible Values: `Boolean`, `Number`, `String`
	Type pulumi.StringInput
}

func (DbAppFeatureFlagsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dbAppFeatureFlagsArgs)(nil)).Elem()
}

type DbAppFeatureFlagsInput interface {
	pulumi.Input

	ToDbAppFeatureFlagsOutput() DbAppFeatureFlagsOutput
	ToDbAppFeatureFlagsOutputWithContext(ctx context.Context) DbAppFeatureFlagsOutput
}

func (*DbAppFeatureFlags) ElementType() reflect.Type {
	return reflect.TypeOf((**DbAppFeatureFlags)(nil)).Elem()
}

func (i *DbAppFeatureFlags) ToDbAppFeatureFlagsOutput() DbAppFeatureFlagsOutput {
	return i.ToDbAppFeatureFlagsOutputWithContext(context.Background())
}

func (i *DbAppFeatureFlags) ToDbAppFeatureFlagsOutputWithContext(ctx context.Context) DbAppFeatureFlagsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DbAppFeatureFlagsOutput)
}

// DbAppFeatureFlagsArrayInput is an input type that accepts DbAppFeatureFlagsArray and DbAppFeatureFlagsArrayOutput values.
// You can construct a concrete instance of `DbAppFeatureFlagsArrayInput` via:
//
//	DbAppFeatureFlagsArray{ DbAppFeatureFlagsArgs{...} }
type DbAppFeatureFlagsArrayInput interface {
	pulumi.Input

	ToDbAppFeatureFlagsArrayOutput() DbAppFeatureFlagsArrayOutput
	ToDbAppFeatureFlagsArrayOutputWithContext(context.Context) DbAppFeatureFlagsArrayOutput
}

type DbAppFeatureFlagsArray []DbAppFeatureFlagsInput

func (DbAppFeatureFlagsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DbAppFeatureFlags)(nil)).Elem()
}

func (i DbAppFeatureFlagsArray) ToDbAppFeatureFlagsArrayOutput() DbAppFeatureFlagsArrayOutput {
	return i.ToDbAppFeatureFlagsArrayOutputWithContext(context.Background())
}

func (i DbAppFeatureFlagsArray) ToDbAppFeatureFlagsArrayOutputWithContext(ctx context.Context) DbAppFeatureFlagsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DbAppFeatureFlagsArrayOutput)
}

// DbAppFeatureFlagsMapInput is an input type that accepts DbAppFeatureFlagsMap and DbAppFeatureFlagsMapOutput values.
// You can construct a concrete instance of `DbAppFeatureFlagsMapInput` via:
//
//	DbAppFeatureFlagsMap{ "key": DbAppFeatureFlagsArgs{...} }
type DbAppFeatureFlagsMapInput interface {
	pulumi.Input

	ToDbAppFeatureFlagsMapOutput() DbAppFeatureFlagsMapOutput
	ToDbAppFeatureFlagsMapOutputWithContext(context.Context) DbAppFeatureFlagsMapOutput
}

type DbAppFeatureFlagsMap map[string]DbAppFeatureFlagsInput

func (DbAppFeatureFlagsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DbAppFeatureFlags)(nil)).Elem()
}

func (i DbAppFeatureFlagsMap) ToDbAppFeatureFlagsMapOutput() DbAppFeatureFlagsMapOutput {
	return i.ToDbAppFeatureFlagsMapOutputWithContext(context.Background())
}

func (i DbAppFeatureFlagsMap) ToDbAppFeatureFlagsMapOutputWithContext(ctx context.Context) DbAppFeatureFlagsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DbAppFeatureFlagsMapOutput)
}

type DbAppFeatureFlagsOutput struct{ *pulumi.OutputState }

func (DbAppFeatureFlagsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DbAppFeatureFlags)(nil)).Elem()
}

func (o DbAppFeatureFlagsOutput) ToDbAppFeatureFlagsOutput() DbAppFeatureFlagsOutput {
	return o
}

func (o DbAppFeatureFlagsOutput) ToDbAppFeatureFlagsOutputWithContext(ctx context.Context) DbAppFeatureFlagsOutput {
	return o
}

// State of boolean feature flag
func (o DbAppFeatureFlagsOutput) BooleanValue() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DbAppFeatureFlags) pulumi.BoolPtrOutput { return v.BooleanValue }).(pulumi.BoolPtrOutput)
}

// Name of the feature
func (o DbAppFeatureFlagsOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DbAppFeatureFlags) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// State of numeric feature flag
func (o DbAppFeatureFlagsOutput) NumberValue() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *DbAppFeatureFlags) pulumi.IntPtrOutput { return v.NumberValue }).(pulumi.IntPtrOutput)
}

// State of textual feature flag
func (o DbAppFeatureFlagsOutput) StringValue() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DbAppFeatureFlags) pulumi.StringPtrOutput { return v.StringValue }).(pulumi.StringPtrOutput)
}

// Possible Values: `Boolean`, `Number`, `String`
func (o DbAppFeatureFlagsOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *DbAppFeatureFlags) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

type DbAppFeatureFlagsArrayOutput struct{ *pulumi.OutputState }

func (DbAppFeatureFlagsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DbAppFeatureFlags)(nil)).Elem()
}

func (o DbAppFeatureFlagsArrayOutput) ToDbAppFeatureFlagsArrayOutput() DbAppFeatureFlagsArrayOutput {
	return o
}

func (o DbAppFeatureFlagsArrayOutput) ToDbAppFeatureFlagsArrayOutputWithContext(ctx context.Context) DbAppFeatureFlagsArrayOutput {
	return o
}

func (o DbAppFeatureFlagsArrayOutput) Index(i pulumi.IntInput) DbAppFeatureFlagsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DbAppFeatureFlags {
		return vs[0].([]*DbAppFeatureFlags)[vs[1].(int)]
	}).(DbAppFeatureFlagsOutput)
}

type DbAppFeatureFlagsMapOutput struct{ *pulumi.OutputState }

func (DbAppFeatureFlagsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DbAppFeatureFlags)(nil)).Elem()
}

func (o DbAppFeatureFlagsMapOutput) ToDbAppFeatureFlagsMapOutput() DbAppFeatureFlagsMapOutput {
	return o
}

func (o DbAppFeatureFlagsMapOutput) ToDbAppFeatureFlagsMapOutputWithContext(ctx context.Context) DbAppFeatureFlagsMapOutput {
	return o
}

func (o DbAppFeatureFlagsMapOutput) MapIndex(k pulumi.StringInput) DbAppFeatureFlagsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DbAppFeatureFlags {
		return vs[0].(map[string]*DbAppFeatureFlags)[vs[1].(string)]
	}).(DbAppFeatureFlagsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DbAppFeatureFlagsInput)(nil)).Elem(), &DbAppFeatureFlags{})
	pulumi.RegisterInputType(reflect.TypeOf((*DbAppFeatureFlagsArrayInput)(nil)).Elem(), DbAppFeatureFlagsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DbAppFeatureFlagsMapInput)(nil)).Elem(), DbAppFeatureFlagsMap{})
	pulumi.RegisterOutputType(DbAppFeatureFlagsOutput{})
	pulumi.RegisterOutputType(DbAppFeatureFlagsArrayOutput{})
	pulumi.RegisterOutputType(DbAppFeatureFlagsMapOutput{})
}
