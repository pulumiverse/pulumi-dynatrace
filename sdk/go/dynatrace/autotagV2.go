// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type AutotagV2 struct {
	pulumi.CustomResourceState

	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Tag name
	Name pulumi.StringOutput `pulumi:"name"`
	// Rules
	Rules AutotagV2RulesPtrOutput `pulumi:"rules"`
	// If `true` this resource will not
	RulesMaintainedExternally pulumi.BoolPtrOutput `pulumi:"rulesMaintainedExternally"`
}

// NewAutotagV2 registers a new resource with the given unique name, arguments, and options.
func NewAutotagV2(ctx *pulumi.Context,
	name string, args *AutotagV2Args, opts ...pulumi.ResourceOption) (*AutotagV2, error) {
	if args == nil {
		args = &AutotagV2Args{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AutotagV2
	err := ctx.RegisterResource("dynatrace:index/autotagV2:AutotagV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutotagV2 gets an existing AutotagV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutotagV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutotagV2State, opts ...pulumi.ResourceOption) (*AutotagV2, error) {
	var resource AutotagV2
	err := ctx.ReadResource("dynatrace:index/autotagV2:AutotagV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutotagV2 resources.
type autotagV2State struct {
	// Description
	Description *string `pulumi:"description"`
	// Tag name
	Name *string `pulumi:"name"`
	// Rules
	Rules *AutotagV2Rules `pulumi:"rules"`
	// If `true` this resource will not
	RulesMaintainedExternally *bool `pulumi:"rulesMaintainedExternally"`
}

type AutotagV2State struct {
	// Description
	Description pulumi.StringPtrInput
	// Tag name
	Name pulumi.StringPtrInput
	// Rules
	Rules AutotagV2RulesPtrInput
	// If `true` this resource will not
	RulesMaintainedExternally pulumi.BoolPtrInput
}

func (AutotagV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*autotagV2State)(nil)).Elem()
}

type autotagV2Args struct {
	// Description
	Description *string `pulumi:"description"`
	// Tag name
	Name *string `pulumi:"name"`
	// Rules
	Rules *AutotagV2Rules `pulumi:"rules"`
	// If `true` this resource will not
	RulesMaintainedExternally *bool `pulumi:"rulesMaintainedExternally"`
}

// The set of arguments for constructing a AutotagV2 resource.
type AutotagV2Args struct {
	// Description
	Description pulumi.StringPtrInput
	// Tag name
	Name pulumi.StringPtrInput
	// Rules
	Rules AutotagV2RulesPtrInput
	// If `true` this resource will not
	RulesMaintainedExternally pulumi.BoolPtrInput
}

func (AutotagV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*autotagV2Args)(nil)).Elem()
}

type AutotagV2Input interface {
	pulumi.Input

	ToAutotagV2Output() AutotagV2Output
	ToAutotagV2OutputWithContext(ctx context.Context) AutotagV2Output
}

func (*AutotagV2) ElementType() reflect.Type {
	return reflect.TypeOf((**AutotagV2)(nil)).Elem()
}

func (i *AutotagV2) ToAutotagV2Output() AutotagV2Output {
	return i.ToAutotagV2OutputWithContext(context.Background())
}

func (i *AutotagV2) ToAutotagV2OutputWithContext(ctx context.Context) AutotagV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(AutotagV2Output)
}

// AutotagV2ArrayInput is an input type that accepts AutotagV2Array and AutotagV2ArrayOutput values.
// You can construct a concrete instance of `AutotagV2ArrayInput` via:
//
//	AutotagV2Array{ AutotagV2Args{...} }
type AutotagV2ArrayInput interface {
	pulumi.Input

	ToAutotagV2ArrayOutput() AutotagV2ArrayOutput
	ToAutotagV2ArrayOutputWithContext(context.Context) AutotagV2ArrayOutput
}

type AutotagV2Array []AutotagV2Input

func (AutotagV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutotagV2)(nil)).Elem()
}

func (i AutotagV2Array) ToAutotagV2ArrayOutput() AutotagV2ArrayOutput {
	return i.ToAutotagV2ArrayOutputWithContext(context.Background())
}

func (i AutotagV2Array) ToAutotagV2ArrayOutputWithContext(ctx context.Context) AutotagV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutotagV2ArrayOutput)
}

// AutotagV2MapInput is an input type that accepts AutotagV2Map and AutotagV2MapOutput values.
// You can construct a concrete instance of `AutotagV2MapInput` via:
//
//	AutotagV2Map{ "key": AutotagV2Args{...} }
type AutotagV2MapInput interface {
	pulumi.Input

	ToAutotagV2MapOutput() AutotagV2MapOutput
	ToAutotagV2MapOutputWithContext(context.Context) AutotagV2MapOutput
}

type AutotagV2Map map[string]AutotagV2Input

func (AutotagV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutotagV2)(nil)).Elem()
}

func (i AutotagV2Map) ToAutotagV2MapOutput() AutotagV2MapOutput {
	return i.ToAutotagV2MapOutputWithContext(context.Background())
}

func (i AutotagV2Map) ToAutotagV2MapOutputWithContext(ctx context.Context) AutotagV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutotagV2MapOutput)
}

type AutotagV2Output struct{ *pulumi.OutputState }

func (AutotagV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**AutotagV2)(nil)).Elem()
}

func (o AutotagV2Output) ToAutotagV2Output() AutotagV2Output {
	return o
}

func (o AutotagV2Output) ToAutotagV2OutputWithContext(ctx context.Context) AutotagV2Output {
	return o
}

// Description
func (o AutotagV2Output) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutotagV2) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Tag name
func (o AutotagV2Output) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AutotagV2) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Rules
func (o AutotagV2Output) Rules() AutotagV2RulesPtrOutput {
	return o.ApplyT(func(v *AutotagV2) AutotagV2RulesPtrOutput { return v.Rules }).(AutotagV2RulesPtrOutput)
}

// If `true` this resource will not
func (o AutotagV2Output) RulesMaintainedExternally() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AutotagV2) pulumi.BoolPtrOutput { return v.RulesMaintainedExternally }).(pulumi.BoolPtrOutput)
}

type AutotagV2ArrayOutput struct{ *pulumi.OutputState }

func (AutotagV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutotagV2)(nil)).Elem()
}

func (o AutotagV2ArrayOutput) ToAutotagV2ArrayOutput() AutotagV2ArrayOutput {
	return o
}

func (o AutotagV2ArrayOutput) ToAutotagV2ArrayOutputWithContext(ctx context.Context) AutotagV2ArrayOutput {
	return o
}

func (o AutotagV2ArrayOutput) Index(i pulumi.IntInput) AutotagV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AutotagV2 {
		return vs[0].([]*AutotagV2)[vs[1].(int)]
	}).(AutotagV2Output)
}

type AutotagV2MapOutput struct{ *pulumi.OutputState }

func (AutotagV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutotagV2)(nil)).Elem()
}

func (o AutotagV2MapOutput) ToAutotagV2MapOutput() AutotagV2MapOutput {
	return o
}

func (o AutotagV2MapOutput) ToAutotagV2MapOutputWithContext(ctx context.Context) AutotagV2MapOutput {
	return o
}

func (o AutotagV2MapOutput) MapIndex(k pulumi.StringInput) AutotagV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AutotagV2 {
		return vs[0].(map[string]*AutotagV2)[vs[1].(string)]
	}).(AutotagV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AutotagV2Input)(nil)).Elem(), &AutotagV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutotagV2ArrayInput)(nil)).Elem(), AutotagV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutotagV2MapInput)(nil)).Elem(), AutotagV2Map{})
	pulumi.RegisterOutputType(AutotagV2Output{})
	pulumi.RegisterOutputType(AutotagV2ArrayOutput{})
	pulumi.RegisterOutputType(AutotagV2MapOutput{})
}
