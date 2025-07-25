// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type OpenpipelineDavisProblems struct {
	pulumi.CustomResourceState

	// List of all ingest sources of the configuration
	Endpoints OpenpipelineDavisProblemsEndpointsPtrOutput `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines OpenpipelineDavisProblemsPipelinesPtrOutput `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing OpenpipelineDavisProblemsRoutingPtrOutput `pulumi:"routing"`
}

// NewOpenpipelineDavisProblems registers a new resource with the given unique name, arguments, and options.
func NewOpenpipelineDavisProblems(ctx *pulumi.Context,
	name string, args *OpenpipelineDavisProblemsArgs, opts ...pulumi.ResourceOption) (*OpenpipelineDavisProblems, error) {
	if args == nil {
		args = &OpenpipelineDavisProblemsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OpenpipelineDavisProblems
	err := ctx.RegisterResource("dynatrace:index/openpipelineDavisProblems:OpenpipelineDavisProblems", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOpenpipelineDavisProblems gets an existing OpenpipelineDavisProblems resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOpenpipelineDavisProblems(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OpenpipelineDavisProblemsState, opts ...pulumi.ResourceOption) (*OpenpipelineDavisProblems, error) {
	var resource OpenpipelineDavisProblems
	err := ctx.ReadResource("dynatrace:index/openpipelineDavisProblems:OpenpipelineDavisProblems", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OpenpipelineDavisProblems resources.
type openpipelineDavisProblemsState struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineDavisProblemsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineDavisProblemsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineDavisProblemsRouting `pulumi:"routing"`
}

type OpenpipelineDavisProblemsState struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineDavisProblemsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineDavisProblemsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineDavisProblemsRoutingPtrInput
}

func (OpenpipelineDavisProblemsState) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineDavisProblemsState)(nil)).Elem()
}

type openpipelineDavisProblemsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineDavisProblemsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineDavisProblemsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineDavisProblemsRouting `pulumi:"routing"`
}

// The set of arguments for constructing a OpenpipelineDavisProblems resource.
type OpenpipelineDavisProblemsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineDavisProblemsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineDavisProblemsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineDavisProblemsRoutingPtrInput
}

func (OpenpipelineDavisProblemsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineDavisProblemsArgs)(nil)).Elem()
}

type OpenpipelineDavisProblemsInput interface {
	pulumi.Input

	ToOpenpipelineDavisProblemsOutput() OpenpipelineDavisProblemsOutput
	ToOpenpipelineDavisProblemsOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsOutput
}

func (*OpenpipelineDavisProblems) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineDavisProblems)(nil)).Elem()
}

func (i *OpenpipelineDavisProblems) ToOpenpipelineDavisProblemsOutput() OpenpipelineDavisProblemsOutput {
	return i.ToOpenpipelineDavisProblemsOutputWithContext(context.Background())
}

func (i *OpenpipelineDavisProblems) ToOpenpipelineDavisProblemsOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineDavisProblemsOutput)
}

// OpenpipelineDavisProblemsArrayInput is an input type that accepts OpenpipelineDavisProblemsArray and OpenpipelineDavisProblemsArrayOutput values.
// You can construct a concrete instance of `OpenpipelineDavisProblemsArrayInput` via:
//
//	OpenpipelineDavisProblemsArray{ OpenpipelineDavisProblemsArgs{...} }
type OpenpipelineDavisProblemsArrayInput interface {
	pulumi.Input

	ToOpenpipelineDavisProblemsArrayOutput() OpenpipelineDavisProblemsArrayOutput
	ToOpenpipelineDavisProblemsArrayOutputWithContext(context.Context) OpenpipelineDavisProblemsArrayOutput
}

type OpenpipelineDavisProblemsArray []OpenpipelineDavisProblemsInput

func (OpenpipelineDavisProblemsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineDavisProblems)(nil)).Elem()
}

func (i OpenpipelineDavisProblemsArray) ToOpenpipelineDavisProblemsArrayOutput() OpenpipelineDavisProblemsArrayOutput {
	return i.ToOpenpipelineDavisProblemsArrayOutputWithContext(context.Background())
}

func (i OpenpipelineDavisProblemsArray) ToOpenpipelineDavisProblemsArrayOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineDavisProblemsArrayOutput)
}

// OpenpipelineDavisProblemsMapInput is an input type that accepts OpenpipelineDavisProblemsMap and OpenpipelineDavisProblemsMapOutput values.
// You can construct a concrete instance of `OpenpipelineDavisProblemsMapInput` via:
//
//	OpenpipelineDavisProblemsMap{ "key": OpenpipelineDavisProblemsArgs{...} }
type OpenpipelineDavisProblemsMapInput interface {
	pulumi.Input

	ToOpenpipelineDavisProblemsMapOutput() OpenpipelineDavisProblemsMapOutput
	ToOpenpipelineDavisProblemsMapOutputWithContext(context.Context) OpenpipelineDavisProblemsMapOutput
}

type OpenpipelineDavisProblemsMap map[string]OpenpipelineDavisProblemsInput

func (OpenpipelineDavisProblemsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineDavisProblems)(nil)).Elem()
}

func (i OpenpipelineDavisProblemsMap) ToOpenpipelineDavisProblemsMapOutput() OpenpipelineDavisProblemsMapOutput {
	return i.ToOpenpipelineDavisProblemsMapOutputWithContext(context.Background())
}

func (i OpenpipelineDavisProblemsMap) ToOpenpipelineDavisProblemsMapOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineDavisProblemsMapOutput)
}

type OpenpipelineDavisProblemsOutput struct{ *pulumi.OutputState }

func (OpenpipelineDavisProblemsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineDavisProblems)(nil)).Elem()
}

func (o OpenpipelineDavisProblemsOutput) ToOpenpipelineDavisProblemsOutput() OpenpipelineDavisProblemsOutput {
	return o
}

func (o OpenpipelineDavisProblemsOutput) ToOpenpipelineDavisProblemsOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsOutput {
	return o
}

// List of all ingest sources of the configuration
func (o OpenpipelineDavisProblemsOutput) Endpoints() OpenpipelineDavisProblemsEndpointsPtrOutput {
	return o.ApplyT(func(v *OpenpipelineDavisProblems) OpenpipelineDavisProblemsEndpointsPtrOutput { return v.Endpoints }).(OpenpipelineDavisProblemsEndpointsPtrOutput)
}

// List of all pipelines of the configuration
func (o OpenpipelineDavisProblemsOutput) Pipelines() OpenpipelineDavisProblemsPipelinesPtrOutput {
	return o.ApplyT(func(v *OpenpipelineDavisProblems) OpenpipelineDavisProblemsPipelinesPtrOutput { return v.Pipelines }).(OpenpipelineDavisProblemsPipelinesPtrOutput)
}

// Dynamic routing definition
func (o OpenpipelineDavisProblemsOutput) Routing() OpenpipelineDavisProblemsRoutingPtrOutput {
	return o.ApplyT(func(v *OpenpipelineDavisProblems) OpenpipelineDavisProblemsRoutingPtrOutput { return v.Routing }).(OpenpipelineDavisProblemsRoutingPtrOutput)
}

type OpenpipelineDavisProblemsArrayOutput struct{ *pulumi.OutputState }

func (OpenpipelineDavisProblemsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineDavisProblems)(nil)).Elem()
}

func (o OpenpipelineDavisProblemsArrayOutput) ToOpenpipelineDavisProblemsArrayOutput() OpenpipelineDavisProblemsArrayOutput {
	return o
}

func (o OpenpipelineDavisProblemsArrayOutput) ToOpenpipelineDavisProblemsArrayOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsArrayOutput {
	return o
}

func (o OpenpipelineDavisProblemsArrayOutput) Index(i pulumi.IntInput) OpenpipelineDavisProblemsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OpenpipelineDavisProblems {
		return vs[0].([]*OpenpipelineDavisProblems)[vs[1].(int)]
	}).(OpenpipelineDavisProblemsOutput)
}

type OpenpipelineDavisProblemsMapOutput struct{ *pulumi.OutputState }

func (OpenpipelineDavisProblemsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineDavisProblems)(nil)).Elem()
}

func (o OpenpipelineDavisProblemsMapOutput) ToOpenpipelineDavisProblemsMapOutput() OpenpipelineDavisProblemsMapOutput {
	return o
}

func (o OpenpipelineDavisProblemsMapOutput) ToOpenpipelineDavisProblemsMapOutputWithContext(ctx context.Context) OpenpipelineDavisProblemsMapOutput {
	return o
}

func (o OpenpipelineDavisProblemsMapOutput) MapIndex(k pulumi.StringInput) OpenpipelineDavisProblemsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OpenpipelineDavisProblems {
		return vs[0].(map[string]*OpenpipelineDavisProblems)[vs[1].(string)]
	}).(OpenpipelineDavisProblemsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineDavisProblemsInput)(nil)).Elem(), &OpenpipelineDavisProblems{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineDavisProblemsArrayInput)(nil)).Elem(), OpenpipelineDavisProblemsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineDavisProblemsMapInput)(nil)).Elem(), OpenpipelineDavisProblemsMap{})
	pulumi.RegisterOutputType(OpenpipelineDavisProblemsOutput{})
	pulumi.RegisterOutputType(OpenpipelineDavisProblemsArrayOutput{})
	pulumi.RegisterOutputType(OpenpipelineDavisProblemsMapOutput{})
}
