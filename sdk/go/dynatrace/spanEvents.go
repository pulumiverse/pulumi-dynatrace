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

type SpanEvents struct {
	pulumi.CustomResourceState

	// Key of the span event attribute to store
	Key pulumi.StringOutput `pulumi:"key"`
	// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
	Masking pulumi.StringOutput `pulumi:"masking"`
}

// NewSpanEvents registers a new resource with the given unique name, arguments, and options.
func NewSpanEvents(ctx *pulumi.Context,
	name string, args *SpanEventsArgs, opts ...pulumi.ResourceOption) (*SpanEvents, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Key == nil {
		return nil, errors.New("invalid value for required argument 'Key'")
	}
	if args.Masking == nil {
		return nil, errors.New("invalid value for required argument 'Masking'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SpanEvents
	err := ctx.RegisterResource("dynatrace:index/spanEvents:SpanEvents", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSpanEvents gets an existing SpanEvents resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSpanEvents(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SpanEventsState, opts ...pulumi.ResourceOption) (*SpanEvents, error) {
	var resource SpanEvents
	err := ctx.ReadResource("dynatrace:index/spanEvents:SpanEvents", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SpanEvents resources.
type spanEventsState struct {
	// Key of the span event attribute to store
	Key *string `pulumi:"key"`
	// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
	Masking *string `pulumi:"masking"`
}

type SpanEventsState struct {
	// Key of the span event attribute to store
	Key pulumi.StringPtrInput
	// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
	Masking pulumi.StringPtrInput
}

func (SpanEventsState) ElementType() reflect.Type {
	return reflect.TypeOf((*spanEventsState)(nil)).Elem()
}

type spanEventsArgs struct {
	// Key of the span event attribute to store
	Key string `pulumi:"key"`
	// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
	Masking string `pulumi:"masking"`
}

// The set of arguments for constructing a SpanEvents resource.
type SpanEventsArgs struct {
	// Key of the span event attribute to store
	Key pulumi.StringInput
	// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
	Masking pulumi.StringInput
}

func (SpanEventsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*spanEventsArgs)(nil)).Elem()
}

type SpanEventsInput interface {
	pulumi.Input

	ToSpanEventsOutput() SpanEventsOutput
	ToSpanEventsOutputWithContext(ctx context.Context) SpanEventsOutput
}

func (*SpanEvents) ElementType() reflect.Type {
	return reflect.TypeOf((**SpanEvents)(nil)).Elem()
}

func (i *SpanEvents) ToSpanEventsOutput() SpanEventsOutput {
	return i.ToSpanEventsOutputWithContext(context.Background())
}

func (i *SpanEvents) ToSpanEventsOutputWithContext(ctx context.Context) SpanEventsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SpanEventsOutput)
}

// SpanEventsArrayInput is an input type that accepts SpanEventsArray and SpanEventsArrayOutput values.
// You can construct a concrete instance of `SpanEventsArrayInput` via:
//
//	SpanEventsArray{ SpanEventsArgs{...} }
type SpanEventsArrayInput interface {
	pulumi.Input

	ToSpanEventsArrayOutput() SpanEventsArrayOutput
	ToSpanEventsArrayOutputWithContext(context.Context) SpanEventsArrayOutput
}

type SpanEventsArray []SpanEventsInput

func (SpanEventsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SpanEvents)(nil)).Elem()
}

func (i SpanEventsArray) ToSpanEventsArrayOutput() SpanEventsArrayOutput {
	return i.ToSpanEventsArrayOutputWithContext(context.Background())
}

func (i SpanEventsArray) ToSpanEventsArrayOutputWithContext(ctx context.Context) SpanEventsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SpanEventsArrayOutput)
}

// SpanEventsMapInput is an input type that accepts SpanEventsMap and SpanEventsMapOutput values.
// You can construct a concrete instance of `SpanEventsMapInput` via:
//
//	SpanEventsMap{ "key": SpanEventsArgs{...} }
type SpanEventsMapInput interface {
	pulumi.Input

	ToSpanEventsMapOutput() SpanEventsMapOutput
	ToSpanEventsMapOutputWithContext(context.Context) SpanEventsMapOutput
}

type SpanEventsMap map[string]SpanEventsInput

func (SpanEventsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SpanEvents)(nil)).Elem()
}

func (i SpanEventsMap) ToSpanEventsMapOutput() SpanEventsMapOutput {
	return i.ToSpanEventsMapOutputWithContext(context.Background())
}

func (i SpanEventsMap) ToSpanEventsMapOutputWithContext(ctx context.Context) SpanEventsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SpanEventsMapOutput)
}

type SpanEventsOutput struct{ *pulumi.OutputState }

func (SpanEventsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SpanEvents)(nil)).Elem()
}

func (o SpanEventsOutput) ToSpanEventsOutput() SpanEventsOutput {
	return o
}

func (o SpanEventsOutput) ToSpanEventsOutputWithContext(ctx context.Context) SpanEventsOutput {
	return o
}

// Key of the span event attribute to store
func (o SpanEventsOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v *SpanEvents) pulumi.StringOutput { return v.Key }).(pulumi.StringOutput)
}

// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
func (o SpanEventsOutput) Masking() pulumi.StringOutput {
	return o.ApplyT(func(v *SpanEvents) pulumi.StringOutput { return v.Masking }).(pulumi.StringOutput)
}

type SpanEventsArrayOutput struct{ *pulumi.OutputState }

func (SpanEventsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SpanEvents)(nil)).Elem()
}

func (o SpanEventsArrayOutput) ToSpanEventsArrayOutput() SpanEventsArrayOutput {
	return o
}

func (o SpanEventsArrayOutput) ToSpanEventsArrayOutputWithContext(ctx context.Context) SpanEventsArrayOutput {
	return o
}

func (o SpanEventsArrayOutput) Index(i pulumi.IntInput) SpanEventsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SpanEvents {
		return vs[0].([]*SpanEvents)[vs[1].(int)]
	}).(SpanEventsOutput)
}

type SpanEventsMapOutput struct{ *pulumi.OutputState }

func (SpanEventsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SpanEvents)(nil)).Elem()
}

func (o SpanEventsMapOutput) ToSpanEventsMapOutput() SpanEventsMapOutput {
	return o
}

func (o SpanEventsMapOutput) ToSpanEventsMapOutputWithContext(ctx context.Context) SpanEventsMapOutput {
	return o
}

func (o SpanEventsMapOutput) MapIndex(k pulumi.StringInput) SpanEventsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SpanEvents {
		return vs[0].(map[string]*SpanEvents)[vs[1].(string)]
	}).(SpanEventsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SpanEventsInput)(nil)).Elem(), &SpanEvents{})
	pulumi.RegisterInputType(reflect.TypeOf((*SpanEventsArrayInput)(nil)).Elem(), SpanEventsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SpanEventsMapInput)(nil)).Elem(), SpanEventsMap{})
	pulumi.RegisterOutputType(SpanEventsOutput{})
	pulumi.RegisterOutputType(SpanEventsArrayOutput{})
	pulumi.RegisterOutputType(SpanEventsMapOutput{})
}
