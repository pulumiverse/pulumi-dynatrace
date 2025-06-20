// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type OpenpipelineBusinessEvents struct {
	pulumi.CustomResourceState

	// List of all ingest sources of the configuration
	Endpoints OpenpipelineBusinessEventsEndpointsPtrOutput `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines OpenpipelineBusinessEventsPipelinesPtrOutput `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing OpenpipelineBusinessEventsRoutingPtrOutput `pulumi:"routing"`
}

// NewOpenpipelineBusinessEvents registers a new resource with the given unique name, arguments, and options.
func NewOpenpipelineBusinessEvents(ctx *pulumi.Context,
	name string, args *OpenpipelineBusinessEventsArgs, opts ...pulumi.ResourceOption) (*OpenpipelineBusinessEvents, error) {
	if args == nil {
		args = &OpenpipelineBusinessEventsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OpenpipelineBusinessEvents
	err := ctx.RegisterResource("dynatrace:index/openpipelineBusinessEvents:OpenpipelineBusinessEvents", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOpenpipelineBusinessEvents gets an existing OpenpipelineBusinessEvents resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOpenpipelineBusinessEvents(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OpenpipelineBusinessEventsState, opts ...pulumi.ResourceOption) (*OpenpipelineBusinessEvents, error) {
	var resource OpenpipelineBusinessEvents
	err := ctx.ReadResource("dynatrace:index/openpipelineBusinessEvents:OpenpipelineBusinessEvents", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OpenpipelineBusinessEvents resources.
type openpipelineBusinessEventsState struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineBusinessEventsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineBusinessEventsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineBusinessEventsRouting `pulumi:"routing"`
}

type OpenpipelineBusinessEventsState struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineBusinessEventsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineBusinessEventsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineBusinessEventsRoutingPtrInput
}

func (OpenpipelineBusinessEventsState) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineBusinessEventsState)(nil)).Elem()
}

type openpipelineBusinessEventsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineBusinessEventsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineBusinessEventsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineBusinessEventsRouting `pulumi:"routing"`
}

// The set of arguments for constructing a OpenpipelineBusinessEvents resource.
type OpenpipelineBusinessEventsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineBusinessEventsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineBusinessEventsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineBusinessEventsRoutingPtrInput
}

func (OpenpipelineBusinessEventsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineBusinessEventsArgs)(nil)).Elem()
}

type OpenpipelineBusinessEventsInput interface {
	pulumi.Input

	ToOpenpipelineBusinessEventsOutput() OpenpipelineBusinessEventsOutput
	ToOpenpipelineBusinessEventsOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsOutput
}

func (*OpenpipelineBusinessEvents) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineBusinessEvents)(nil)).Elem()
}

func (i *OpenpipelineBusinessEvents) ToOpenpipelineBusinessEventsOutput() OpenpipelineBusinessEventsOutput {
	return i.ToOpenpipelineBusinessEventsOutputWithContext(context.Background())
}

func (i *OpenpipelineBusinessEvents) ToOpenpipelineBusinessEventsOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineBusinessEventsOutput)
}

// OpenpipelineBusinessEventsArrayInput is an input type that accepts OpenpipelineBusinessEventsArray and OpenpipelineBusinessEventsArrayOutput values.
// You can construct a concrete instance of `OpenpipelineBusinessEventsArrayInput` via:
//
//	OpenpipelineBusinessEventsArray{ OpenpipelineBusinessEventsArgs{...} }
type OpenpipelineBusinessEventsArrayInput interface {
	pulumi.Input

	ToOpenpipelineBusinessEventsArrayOutput() OpenpipelineBusinessEventsArrayOutput
	ToOpenpipelineBusinessEventsArrayOutputWithContext(context.Context) OpenpipelineBusinessEventsArrayOutput
}

type OpenpipelineBusinessEventsArray []OpenpipelineBusinessEventsInput

func (OpenpipelineBusinessEventsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineBusinessEvents)(nil)).Elem()
}

func (i OpenpipelineBusinessEventsArray) ToOpenpipelineBusinessEventsArrayOutput() OpenpipelineBusinessEventsArrayOutput {
	return i.ToOpenpipelineBusinessEventsArrayOutputWithContext(context.Background())
}

func (i OpenpipelineBusinessEventsArray) ToOpenpipelineBusinessEventsArrayOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineBusinessEventsArrayOutput)
}

// OpenpipelineBusinessEventsMapInput is an input type that accepts OpenpipelineBusinessEventsMap and OpenpipelineBusinessEventsMapOutput values.
// You can construct a concrete instance of `OpenpipelineBusinessEventsMapInput` via:
//
//	OpenpipelineBusinessEventsMap{ "key": OpenpipelineBusinessEventsArgs{...} }
type OpenpipelineBusinessEventsMapInput interface {
	pulumi.Input

	ToOpenpipelineBusinessEventsMapOutput() OpenpipelineBusinessEventsMapOutput
	ToOpenpipelineBusinessEventsMapOutputWithContext(context.Context) OpenpipelineBusinessEventsMapOutput
}

type OpenpipelineBusinessEventsMap map[string]OpenpipelineBusinessEventsInput

func (OpenpipelineBusinessEventsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineBusinessEvents)(nil)).Elem()
}

func (i OpenpipelineBusinessEventsMap) ToOpenpipelineBusinessEventsMapOutput() OpenpipelineBusinessEventsMapOutput {
	return i.ToOpenpipelineBusinessEventsMapOutputWithContext(context.Background())
}

func (i OpenpipelineBusinessEventsMap) ToOpenpipelineBusinessEventsMapOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineBusinessEventsMapOutput)
}

type OpenpipelineBusinessEventsOutput struct{ *pulumi.OutputState }

func (OpenpipelineBusinessEventsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineBusinessEvents)(nil)).Elem()
}

func (o OpenpipelineBusinessEventsOutput) ToOpenpipelineBusinessEventsOutput() OpenpipelineBusinessEventsOutput {
	return o
}

func (o OpenpipelineBusinessEventsOutput) ToOpenpipelineBusinessEventsOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsOutput {
	return o
}

// List of all ingest sources of the configuration
func (o OpenpipelineBusinessEventsOutput) Endpoints() OpenpipelineBusinessEventsEndpointsPtrOutput {
	return o.ApplyT(func(v *OpenpipelineBusinessEvents) OpenpipelineBusinessEventsEndpointsPtrOutput { return v.Endpoints }).(OpenpipelineBusinessEventsEndpointsPtrOutput)
}

// List of all pipelines of the configuration
func (o OpenpipelineBusinessEventsOutput) Pipelines() OpenpipelineBusinessEventsPipelinesPtrOutput {
	return o.ApplyT(func(v *OpenpipelineBusinessEvents) OpenpipelineBusinessEventsPipelinesPtrOutput { return v.Pipelines }).(OpenpipelineBusinessEventsPipelinesPtrOutput)
}

// Dynamic routing definition
func (o OpenpipelineBusinessEventsOutput) Routing() OpenpipelineBusinessEventsRoutingPtrOutput {
	return o.ApplyT(func(v *OpenpipelineBusinessEvents) OpenpipelineBusinessEventsRoutingPtrOutput { return v.Routing }).(OpenpipelineBusinessEventsRoutingPtrOutput)
}

type OpenpipelineBusinessEventsArrayOutput struct{ *pulumi.OutputState }

func (OpenpipelineBusinessEventsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineBusinessEvents)(nil)).Elem()
}

func (o OpenpipelineBusinessEventsArrayOutput) ToOpenpipelineBusinessEventsArrayOutput() OpenpipelineBusinessEventsArrayOutput {
	return o
}

func (o OpenpipelineBusinessEventsArrayOutput) ToOpenpipelineBusinessEventsArrayOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsArrayOutput {
	return o
}

func (o OpenpipelineBusinessEventsArrayOutput) Index(i pulumi.IntInput) OpenpipelineBusinessEventsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OpenpipelineBusinessEvents {
		return vs[0].([]*OpenpipelineBusinessEvents)[vs[1].(int)]
	}).(OpenpipelineBusinessEventsOutput)
}

type OpenpipelineBusinessEventsMapOutput struct{ *pulumi.OutputState }

func (OpenpipelineBusinessEventsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineBusinessEvents)(nil)).Elem()
}

func (o OpenpipelineBusinessEventsMapOutput) ToOpenpipelineBusinessEventsMapOutput() OpenpipelineBusinessEventsMapOutput {
	return o
}

func (o OpenpipelineBusinessEventsMapOutput) ToOpenpipelineBusinessEventsMapOutputWithContext(ctx context.Context) OpenpipelineBusinessEventsMapOutput {
	return o
}

func (o OpenpipelineBusinessEventsMapOutput) MapIndex(k pulumi.StringInput) OpenpipelineBusinessEventsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OpenpipelineBusinessEvents {
		return vs[0].(map[string]*OpenpipelineBusinessEvents)[vs[1].(string)]
	}).(OpenpipelineBusinessEventsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineBusinessEventsInput)(nil)).Elem(), &OpenpipelineBusinessEvents{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineBusinessEventsArrayInput)(nil)).Elem(), OpenpipelineBusinessEventsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineBusinessEventsMapInput)(nil)).Elem(), OpenpipelineBusinessEventsMap{})
	pulumi.RegisterOutputType(OpenpipelineBusinessEventsOutput{})
	pulumi.RegisterOutputType(OpenpipelineBusinessEventsArrayOutput{})
	pulumi.RegisterOutputType(OpenpipelineBusinessEventsMapOutput{})
}
