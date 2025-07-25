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

type RumOverloadPrevention struct {
	pulumi.CustomResourceState

	// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
	OverloadPreventionLimit pulumi.IntOutput `pulumi:"overloadPreventionLimit"`
}

// NewRumOverloadPrevention registers a new resource with the given unique name, arguments, and options.
func NewRumOverloadPrevention(ctx *pulumi.Context,
	name string, args *RumOverloadPreventionArgs, opts ...pulumi.ResourceOption) (*RumOverloadPrevention, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.OverloadPreventionLimit == nil {
		return nil, errors.New("invalid value for required argument 'OverloadPreventionLimit'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RumOverloadPrevention
	err := ctx.RegisterResource("dynatrace:index/rumOverloadPrevention:RumOverloadPrevention", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRumOverloadPrevention gets an existing RumOverloadPrevention resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRumOverloadPrevention(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RumOverloadPreventionState, opts ...pulumi.ResourceOption) (*RumOverloadPrevention, error) {
	var resource RumOverloadPrevention
	err := ctx.ReadResource("dynatrace:index/rumOverloadPrevention:RumOverloadPrevention", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RumOverloadPrevention resources.
type rumOverloadPreventionState struct {
	// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
	OverloadPreventionLimit *int `pulumi:"overloadPreventionLimit"`
}

type RumOverloadPreventionState struct {
	// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
	OverloadPreventionLimit pulumi.IntPtrInput
}

func (RumOverloadPreventionState) ElementType() reflect.Type {
	return reflect.TypeOf((*rumOverloadPreventionState)(nil)).Elem()
}

type rumOverloadPreventionArgs struct {
	// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
	OverloadPreventionLimit int `pulumi:"overloadPreventionLimit"`
}

// The set of arguments for constructing a RumOverloadPrevention resource.
type RumOverloadPreventionArgs struct {
	// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
	OverloadPreventionLimit pulumi.IntInput
}

func (RumOverloadPreventionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rumOverloadPreventionArgs)(nil)).Elem()
}

type RumOverloadPreventionInput interface {
	pulumi.Input

	ToRumOverloadPreventionOutput() RumOverloadPreventionOutput
	ToRumOverloadPreventionOutputWithContext(ctx context.Context) RumOverloadPreventionOutput
}

func (*RumOverloadPrevention) ElementType() reflect.Type {
	return reflect.TypeOf((**RumOverloadPrevention)(nil)).Elem()
}

func (i *RumOverloadPrevention) ToRumOverloadPreventionOutput() RumOverloadPreventionOutput {
	return i.ToRumOverloadPreventionOutputWithContext(context.Background())
}

func (i *RumOverloadPrevention) ToRumOverloadPreventionOutputWithContext(ctx context.Context) RumOverloadPreventionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumOverloadPreventionOutput)
}

// RumOverloadPreventionArrayInput is an input type that accepts RumOverloadPreventionArray and RumOverloadPreventionArrayOutput values.
// You can construct a concrete instance of `RumOverloadPreventionArrayInput` via:
//
//	RumOverloadPreventionArray{ RumOverloadPreventionArgs{...} }
type RumOverloadPreventionArrayInput interface {
	pulumi.Input

	ToRumOverloadPreventionArrayOutput() RumOverloadPreventionArrayOutput
	ToRumOverloadPreventionArrayOutputWithContext(context.Context) RumOverloadPreventionArrayOutput
}

type RumOverloadPreventionArray []RumOverloadPreventionInput

func (RumOverloadPreventionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumOverloadPrevention)(nil)).Elem()
}

func (i RumOverloadPreventionArray) ToRumOverloadPreventionArrayOutput() RumOverloadPreventionArrayOutput {
	return i.ToRumOverloadPreventionArrayOutputWithContext(context.Background())
}

func (i RumOverloadPreventionArray) ToRumOverloadPreventionArrayOutputWithContext(ctx context.Context) RumOverloadPreventionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumOverloadPreventionArrayOutput)
}

// RumOverloadPreventionMapInput is an input type that accepts RumOverloadPreventionMap and RumOverloadPreventionMapOutput values.
// You can construct a concrete instance of `RumOverloadPreventionMapInput` via:
//
//	RumOverloadPreventionMap{ "key": RumOverloadPreventionArgs{...} }
type RumOverloadPreventionMapInput interface {
	pulumi.Input

	ToRumOverloadPreventionMapOutput() RumOverloadPreventionMapOutput
	ToRumOverloadPreventionMapOutputWithContext(context.Context) RumOverloadPreventionMapOutput
}

type RumOverloadPreventionMap map[string]RumOverloadPreventionInput

func (RumOverloadPreventionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumOverloadPrevention)(nil)).Elem()
}

func (i RumOverloadPreventionMap) ToRumOverloadPreventionMapOutput() RumOverloadPreventionMapOutput {
	return i.ToRumOverloadPreventionMapOutputWithContext(context.Background())
}

func (i RumOverloadPreventionMap) ToRumOverloadPreventionMapOutputWithContext(ctx context.Context) RumOverloadPreventionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumOverloadPreventionMapOutput)
}

type RumOverloadPreventionOutput struct{ *pulumi.OutputState }

func (RumOverloadPreventionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RumOverloadPrevention)(nil)).Elem()
}

func (o RumOverloadPreventionOutput) ToRumOverloadPreventionOutput() RumOverloadPreventionOutput {
	return o
}

func (o RumOverloadPreventionOutput) ToRumOverloadPreventionOutputWithContext(ctx context.Context) RumOverloadPreventionOutput {
	return o
}

// Once this limit is reached, Dynatrace [throttles the number of captured user sessions](https://dt-url.net/fm3v0p7g).
func (o RumOverloadPreventionOutput) OverloadPreventionLimit() pulumi.IntOutput {
	return o.ApplyT(func(v *RumOverloadPrevention) pulumi.IntOutput { return v.OverloadPreventionLimit }).(pulumi.IntOutput)
}

type RumOverloadPreventionArrayOutput struct{ *pulumi.OutputState }

func (RumOverloadPreventionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumOverloadPrevention)(nil)).Elem()
}

func (o RumOverloadPreventionArrayOutput) ToRumOverloadPreventionArrayOutput() RumOverloadPreventionArrayOutput {
	return o
}

func (o RumOverloadPreventionArrayOutput) ToRumOverloadPreventionArrayOutputWithContext(ctx context.Context) RumOverloadPreventionArrayOutput {
	return o
}

func (o RumOverloadPreventionArrayOutput) Index(i pulumi.IntInput) RumOverloadPreventionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RumOverloadPrevention {
		return vs[0].([]*RumOverloadPrevention)[vs[1].(int)]
	}).(RumOverloadPreventionOutput)
}

type RumOverloadPreventionMapOutput struct{ *pulumi.OutputState }

func (RumOverloadPreventionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumOverloadPrevention)(nil)).Elem()
}

func (o RumOverloadPreventionMapOutput) ToRumOverloadPreventionMapOutput() RumOverloadPreventionMapOutput {
	return o
}

func (o RumOverloadPreventionMapOutput) ToRumOverloadPreventionMapOutputWithContext(ctx context.Context) RumOverloadPreventionMapOutput {
	return o
}

func (o RumOverloadPreventionMapOutput) MapIndex(k pulumi.StringInput) RumOverloadPreventionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RumOverloadPrevention {
		return vs[0].(map[string]*RumOverloadPrevention)[vs[1].(string)]
	}).(RumOverloadPreventionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RumOverloadPreventionInput)(nil)).Elem(), &RumOverloadPrevention{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumOverloadPreventionArrayInput)(nil)).Elem(), RumOverloadPreventionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumOverloadPreventionMapInput)(nil)).Elem(), RumOverloadPreventionMap{})
	pulumi.RegisterOutputType(RumOverloadPreventionOutput{})
	pulumi.RegisterOutputType(RumOverloadPreventionArrayOutput{})
	pulumi.RegisterOutputType(RumOverloadPreventionMapOutput{})
}
