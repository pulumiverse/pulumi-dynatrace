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

type RumAdvancedCorrelation struct {
	pulumi.CustomResourceState

	// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
	Matcher pulumi.StringOutput `pulumi:"matcher"`
	// Pattern
	Pattern pulumi.StringOutput `pulumi:"pattern"`
}

// NewRumAdvancedCorrelation registers a new resource with the given unique name, arguments, and options.
func NewRumAdvancedCorrelation(ctx *pulumi.Context,
	name string, args *RumAdvancedCorrelationArgs, opts ...pulumi.ResourceOption) (*RumAdvancedCorrelation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Matcher == nil {
		return nil, errors.New("invalid value for required argument 'Matcher'")
	}
	if args.Pattern == nil {
		return nil, errors.New("invalid value for required argument 'Pattern'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RumAdvancedCorrelation
	err := ctx.RegisterResource("dynatrace:index/rumAdvancedCorrelation:RumAdvancedCorrelation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRumAdvancedCorrelation gets an existing RumAdvancedCorrelation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRumAdvancedCorrelation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RumAdvancedCorrelationState, opts ...pulumi.ResourceOption) (*RumAdvancedCorrelation, error) {
	var resource RumAdvancedCorrelation
	err := ctx.ReadResource("dynatrace:index/rumAdvancedCorrelation:RumAdvancedCorrelation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RumAdvancedCorrelation resources.
type rumAdvancedCorrelationState struct {
	// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
	Matcher *string `pulumi:"matcher"`
	// Pattern
	Pattern *string `pulumi:"pattern"`
}

type RumAdvancedCorrelationState struct {
	// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
	Matcher pulumi.StringPtrInput
	// Pattern
	Pattern pulumi.StringPtrInput
}

func (RumAdvancedCorrelationState) ElementType() reflect.Type {
	return reflect.TypeOf((*rumAdvancedCorrelationState)(nil)).Elem()
}

type rumAdvancedCorrelationArgs struct {
	// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
	Matcher string `pulumi:"matcher"`
	// Pattern
	Pattern string `pulumi:"pattern"`
}

// The set of arguments for constructing a RumAdvancedCorrelation resource.
type RumAdvancedCorrelationArgs struct {
	// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
	Matcher pulumi.StringInput
	// Pattern
	Pattern pulumi.StringInput
}

func (RumAdvancedCorrelationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rumAdvancedCorrelationArgs)(nil)).Elem()
}

type RumAdvancedCorrelationInput interface {
	pulumi.Input

	ToRumAdvancedCorrelationOutput() RumAdvancedCorrelationOutput
	ToRumAdvancedCorrelationOutputWithContext(ctx context.Context) RumAdvancedCorrelationOutput
}

func (*RumAdvancedCorrelation) ElementType() reflect.Type {
	return reflect.TypeOf((**RumAdvancedCorrelation)(nil)).Elem()
}

func (i *RumAdvancedCorrelation) ToRumAdvancedCorrelationOutput() RumAdvancedCorrelationOutput {
	return i.ToRumAdvancedCorrelationOutputWithContext(context.Background())
}

func (i *RumAdvancedCorrelation) ToRumAdvancedCorrelationOutputWithContext(ctx context.Context) RumAdvancedCorrelationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumAdvancedCorrelationOutput)
}

// RumAdvancedCorrelationArrayInput is an input type that accepts RumAdvancedCorrelationArray and RumAdvancedCorrelationArrayOutput values.
// You can construct a concrete instance of `RumAdvancedCorrelationArrayInput` via:
//
//	RumAdvancedCorrelationArray{ RumAdvancedCorrelationArgs{...} }
type RumAdvancedCorrelationArrayInput interface {
	pulumi.Input

	ToRumAdvancedCorrelationArrayOutput() RumAdvancedCorrelationArrayOutput
	ToRumAdvancedCorrelationArrayOutputWithContext(context.Context) RumAdvancedCorrelationArrayOutput
}

type RumAdvancedCorrelationArray []RumAdvancedCorrelationInput

func (RumAdvancedCorrelationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumAdvancedCorrelation)(nil)).Elem()
}

func (i RumAdvancedCorrelationArray) ToRumAdvancedCorrelationArrayOutput() RumAdvancedCorrelationArrayOutput {
	return i.ToRumAdvancedCorrelationArrayOutputWithContext(context.Background())
}

func (i RumAdvancedCorrelationArray) ToRumAdvancedCorrelationArrayOutputWithContext(ctx context.Context) RumAdvancedCorrelationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumAdvancedCorrelationArrayOutput)
}

// RumAdvancedCorrelationMapInput is an input type that accepts RumAdvancedCorrelationMap and RumAdvancedCorrelationMapOutput values.
// You can construct a concrete instance of `RumAdvancedCorrelationMapInput` via:
//
//	RumAdvancedCorrelationMap{ "key": RumAdvancedCorrelationArgs{...} }
type RumAdvancedCorrelationMapInput interface {
	pulumi.Input

	ToRumAdvancedCorrelationMapOutput() RumAdvancedCorrelationMapOutput
	ToRumAdvancedCorrelationMapOutputWithContext(context.Context) RumAdvancedCorrelationMapOutput
}

type RumAdvancedCorrelationMap map[string]RumAdvancedCorrelationInput

func (RumAdvancedCorrelationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumAdvancedCorrelation)(nil)).Elem()
}

func (i RumAdvancedCorrelationMap) ToRumAdvancedCorrelationMapOutput() RumAdvancedCorrelationMapOutput {
	return i.ToRumAdvancedCorrelationMapOutputWithContext(context.Background())
}

func (i RumAdvancedCorrelationMap) ToRumAdvancedCorrelationMapOutputWithContext(ctx context.Context) RumAdvancedCorrelationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RumAdvancedCorrelationMapOutput)
}

type RumAdvancedCorrelationOutput struct{ *pulumi.OutputState }

func (RumAdvancedCorrelationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RumAdvancedCorrelation)(nil)).Elem()
}

func (o RumAdvancedCorrelationOutput) ToRumAdvancedCorrelationOutput() RumAdvancedCorrelationOutput {
	return o
}

func (o RumAdvancedCorrelationOutput) ToRumAdvancedCorrelationOutputWithContext(ctx context.Context) RumAdvancedCorrelationOutput {
	return o
}

// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
func (o RumAdvancedCorrelationOutput) Matcher() pulumi.StringOutput {
	return o.ApplyT(func(v *RumAdvancedCorrelation) pulumi.StringOutput { return v.Matcher }).(pulumi.StringOutput)
}

// Pattern
func (o RumAdvancedCorrelationOutput) Pattern() pulumi.StringOutput {
	return o.ApplyT(func(v *RumAdvancedCorrelation) pulumi.StringOutput { return v.Pattern }).(pulumi.StringOutput)
}

type RumAdvancedCorrelationArrayOutput struct{ *pulumi.OutputState }

func (RumAdvancedCorrelationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RumAdvancedCorrelation)(nil)).Elem()
}

func (o RumAdvancedCorrelationArrayOutput) ToRumAdvancedCorrelationArrayOutput() RumAdvancedCorrelationArrayOutput {
	return o
}

func (o RumAdvancedCorrelationArrayOutput) ToRumAdvancedCorrelationArrayOutputWithContext(ctx context.Context) RumAdvancedCorrelationArrayOutput {
	return o
}

func (o RumAdvancedCorrelationArrayOutput) Index(i pulumi.IntInput) RumAdvancedCorrelationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RumAdvancedCorrelation {
		return vs[0].([]*RumAdvancedCorrelation)[vs[1].(int)]
	}).(RumAdvancedCorrelationOutput)
}

type RumAdvancedCorrelationMapOutput struct{ *pulumi.OutputState }

func (RumAdvancedCorrelationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RumAdvancedCorrelation)(nil)).Elem()
}

func (o RumAdvancedCorrelationMapOutput) ToRumAdvancedCorrelationMapOutput() RumAdvancedCorrelationMapOutput {
	return o
}

func (o RumAdvancedCorrelationMapOutput) ToRumAdvancedCorrelationMapOutputWithContext(ctx context.Context) RumAdvancedCorrelationMapOutput {
	return o
}

func (o RumAdvancedCorrelationMapOutput) MapIndex(k pulumi.StringInput) RumAdvancedCorrelationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RumAdvancedCorrelation {
		return vs[0].(map[string]*RumAdvancedCorrelation)[vs[1].(string)]
	}).(RumAdvancedCorrelationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RumAdvancedCorrelationInput)(nil)).Elem(), &RumAdvancedCorrelation{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumAdvancedCorrelationArrayInput)(nil)).Elem(), RumAdvancedCorrelationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RumAdvancedCorrelationMapInput)(nil)).Elem(), RumAdvancedCorrelationMap{})
	pulumi.RegisterOutputType(RumAdvancedCorrelationOutput{})
	pulumi.RegisterOutputType(RumAdvancedCorrelationArrayOutput{})
	pulumi.RegisterOutputType(RumAdvancedCorrelationMapOutput{})
}
