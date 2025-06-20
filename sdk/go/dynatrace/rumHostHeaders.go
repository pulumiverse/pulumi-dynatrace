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

type RumHostHeaders struct {
	pulumi.CustomResourceState

	// HTTP header format
	HeaderName pulumi.StringOutput `pulumi:"headerName"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
}

// NewRumHostHeaders registers a new resource with the given unique name, arguments, and options.
func NewRumHostHeaders(ctx *pulumi.Context,
	name string, args *RumHostHeadersArgs, opts ...pulumi.ResourceOption) (*RumHostHeaders, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.HeaderName == nil {
		return nil, errors.New("invalid value for required argument 'HeaderName'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RumHostHeaders
	err := ctx.RegisterResource("dynatrace:index/rumHostHeaders:RumHostHeaders", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRumHostHeaders gets an existing RumHostHeaders resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRumHostHeaders(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RumHostHeadersState, opts ...pulumi.ResourceOption) (*RumHostHeaders, error) {
	var resource RumHostHeaders
	err := ctx.ReadResource("dynatrace:index/rumHostHeaders:RumHostHeaders", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RumHostHeaders resources.
type rumHostHeadersState struct {
	// HTTP header format
	HeaderName *string `pulumi:"headerName"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
}

type RumHostHeadersState struct {
	// HTTP header format
	HeaderName pulumi.StringPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
}

func (RumHostHeadersState) ElementType() reflect.Type {
	return reflect.TypeOf((*rumHostHeadersState)(nil)).Elem()
}

type rumHostHeadersArgs struct {
	// HTTP header format
	HeaderName string `pulumi:"headerName"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
}

// The set of arguments for constructing a RumHostHeaders resource.
type RumHostHeadersArgs struct {
	// HTTP header format
	HeaderName pulumi.StringInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
}

func (RumHostHeadersArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rumHostHeadersArgs)(nil)).Elem()
}

type RumHostHeadersInput interface {
	pulumi.Input

	ToRumHostHeadersOutput() RumHostHeadersOutput
	ToRumHostHeadersOutputWithContext(ctx context.Context) RumHostHeadersOutput
}

func (*RumHostHeaders) ElementType() reflect.Type {
	return reflect.TypeOf((**RumHostHeaders)(nil)).Elem()
}

func (i *RumHostHeaders) ToRumHostHeadersOutput() RumHostHeadersOutput {
	return i.ToRumHostHeadersOutputWithContext(context.Background())
}

func (i *RumHostHeaders) ToRumHostHeadersOutputWithContext(ctx context.Context) RumHostHeadersOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumHostHeadersOutput)
}

// RumHostHeadersArrayInput is an input type that accepts RumHostHeadersArray and RumHostHeadersArrayOutput values.
// You can construct a concrete instance of `RumHostHeadersArrayInput` via:
//
//	RumHostHeadersArray{ RumHostHeadersArgs{...} }
type RumHostHeadersArrayInput interface {
	pulumi.Input

	ToRumHostHeadersArrayOutput() RumHostHeadersArrayOutput
	ToRumHostHeadersArrayOutputWithContext(context.Context) RumHostHeadersArrayOutput
}

type RumHostHeadersArray []RumHostHeadersInput

func (RumHostHeadersArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumHostHeaders)(nil)).Elem()
}

func (i RumHostHeadersArray) ToRumHostHeadersArrayOutput() RumHostHeadersArrayOutput {
	return i.ToRumHostHeadersArrayOutputWithContext(context.Background())
}

func (i RumHostHeadersArray) ToRumHostHeadersArrayOutputWithContext(ctx context.Context) RumHostHeadersArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumHostHeadersArrayOutput)
}

// RumHostHeadersMapInput is an input type that accepts RumHostHeadersMap and RumHostHeadersMapOutput values.
// You can construct a concrete instance of `RumHostHeadersMapInput` via:
//
//	RumHostHeadersMap{ "key": RumHostHeadersArgs{...} }
type RumHostHeadersMapInput interface {
	pulumi.Input

	ToRumHostHeadersMapOutput() RumHostHeadersMapOutput
	ToRumHostHeadersMapOutputWithContext(context.Context) RumHostHeadersMapOutput
}

type RumHostHeadersMap map[string]RumHostHeadersInput

func (RumHostHeadersMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumHostHeaders)(nil)).Elem()
}

func (i RumHostHeadersMap) ToRumHostHeadersMapOutput() RumHostHeadersMapOutput {
	return i.ToRumHostHeadersMapOutputWithContext(context.Background())
}

func (i RumHostHeadersMap) ToRumHostHeadersMapOutputWithContext(ctx context.Context) RumHostHeadersMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumHostHeadersMapOutput)
}

type RumHostHeadersOutput struct{ *pulumi.OutputState }

func (RumHostHeadersOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RumHostHeaders)(nil)).Elem()
}

func (o RumHostHeadersOutput) ToRumHostHeadersOutput() RumHostHeadersOutput {
	return o
}

func (o RumHostHeadersOutput) ToRumHostHeadersOutputWithContext(ctx context.Context) RumHostHeadersOutput {
	return o
}

// HTTP header format
func (o RumHostHeadersOutput) HeaderName() pulumi.StringOutput {
	return o.ApplyT(func(v *RumHostHeaders) pulumi.StringOutput { return v.HeaderName }).(pulumi.StringOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o RumHostHeadersOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *RumHostHeaders) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

type RumHostHeadersArrayOutput struct{ *pulumi.OutputState }

func (RumHostHeadersArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumHostHeaders)(nil)).Elem()
}

func (o RumHostHeadersArrayOutput) ToRumHostHeadersArrayOutput() RumHostHeadersArrayOutput {
	return o
}

func (o RumHostHeadersArrayOutput) ToRumHostHeadersArrayOutputWithContext(ctx context.Context) RumHostHeadersArrayOutput {
	return o
}

func (o RumHostHeadersArrayOutput) Index(i pulumi.IntInput) RumHostHeadersOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RumHostHeaders {
		return vs[0].([]*RumHostHeaders)[vs[1].(int)]
	}).(RumHostHeadersOutput)
}

type RumHostHeadersMapOutput struct{ *pulumi.OutputState }

func (RumHostHeadersMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumHostHeaders)(nil)).Elem()
}

func (o RumHostHeadersMapOutput) ToRumHostHeadersMapOutput() RumHostHeadersMapOutput {
	return o
}

func (o RumHostHeadersMapOutput) ToRumHostHeadersMapOutputWithContext(ctx context.Context) RumHostHeadersMapOutput {
	return o
}

func (o RumHostHeadersMapOutput) MapIndex(k pulumi.StringInput) RumHostHeadersOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RumHostHeaders {
		return vs[0].(map[string]*RumHostHeaders)[vs[1].(string)]
	}).(RumHostHeadersOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RumHostHeadersInput)(nil)).Elem(), &RumHostHeaders{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumHostHeadersArrayInput)(nil)).Elem(), RumHostHeadersArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumHostHeadersMapInput)(nil)).Elem(), RumHostHeadersMap{})
	pulumi.RegisterOutputType(RumHostHeadersOutput{})
	pulumi.RegisterOutputType(RumHostHeadersArrayOutput{})
	pulumi.RegisterOutputType(RumHostHeadersMapOutput{})
}
