// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type OpenpipelineSecurityEvents struct {
	pulumi.CustomResourceState

	// List of all ingest sources of the configuration
	Endpoints OpenpipelineSecurityEventsEndpointsPtrOutput `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines OpenpipelineSecurityEventsPipelinesPtrOutput `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing OpenpipelineSecurityEventsRoutingPtrOutput `pulumi:"routing"`
}

// NewOpenpipelineSecurityEvents registers a new resource with the given unique name, arguments, and options.
func NewOpenpipelineSecurityEvents(ctx *pulumi.Context,
	name string, args *OpenpipelineSecurityEventsArgs, opts ...pulumi.ResourceOption) (*OpenpipelineSecurityEvents, error) {
	if args == nil {
		args = &OpenpipelineSecurityEventsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OpenpipelineSecurityEvents
	err := ctx.RegisterResource("dynatrace:index/openpipelineSecurityEvents:OpenpipelineSecurityEvents", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOpenpipelineSecurityEvents gets an existing OpenpipelineSecurityEvents resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOpenpipelineSecurityEvents(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OpenpipelineSecurityEventsState, opts ...pulumi.ResourceOption) (*OpenpipelineSecurityEvents, error) {
	var resource OpenpipelineSecurityEvents
	err := ctx.ReadResource("dynatrace:index/openpipelineSecurityEvents:OpenpipelineSecurityEvents", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OpenpipelineSecurityEvents resources.
type openpipelineSecurityEventsState struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineSecurityEventsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineSecurityEventsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineSecurityEventsRouting `pulumi:"routing"`
}

type OpenpipelineSecurityEventsState struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineSecurityEventsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineSecurityEventsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineSecurityEventsRoutingPtrInput
}

func (OpenpipelineSecurityEventsState) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineSecurityEventsState)(nil)).Elem()
}

type openpipelineSecurityEventsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints *OpenpipelineSecurityEventsEndpoints `pulumi:"endpoints"`
	// List of all pipelines of the configuration
	Pipelines *OpenpipelineSecurityEventsPipelines `pulumi:"pipelines"`
	// Dynamic routing definition
	Routing *OpenpipelineSecurityEventsRouting `pulumi:"routing"`
}

// The set of arguments for constructing a OpenpipelineSecurityEvents resource.
type OpenpipelineSecurityEventsArgs struct {
	// List of all ingest sources of the configuration
	Endpoints OpenpipelineSecurityEventsEndpointsPtrInput
	// List of all pipelines of the configuration
	Pipelines OpenpipelineSecurityEventsPipelinesPtrInput
	// Dynamic routing definition
	Routing OpenpipelineSecurityEventsRoutingPtrInput
}

func (OpenpipelineSecurityEventsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*openpipelineSecurityEventsArgs)(nil)).Elem()
}

type OpenpipelineSecurityEventsInput interface {
	pulumi.Input

	ToOpenpipelineSecurityEventsOutput() OpenpipelineSecurityEventsOutput
	ToOpenpipelineSecurityEventsOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsOutput
}

func (*OpenpipelineSecurityEvents) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineSecurityEvents)(nil)).Elem()
}

func (i *OpenpipelineSecurityEvents) ToOpenpipelineSecurityEventsOutput() OpenpipelineSecurityEventsOutput {
	return i.ToOpenpipelineSecurityEventsOutputWithContext(context.Background())
}

func (i *OpenpipelineSecurityEvents) ToOpenpipelineSecurityEventsOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineSecurityEventsOutput)
}

// OpenpipelineSecurityEventsArrayInput is an input type that accepts OpenpipelineSecurityEventsArray and OpenpipelineSecurityEventsArrayOutput values.
// You can construct a concrete instance of `OpenpipelineSecurityEventsArrayInput` via:
//
//	OpenpipelineSecurityEventsArray{ OpenpipelineSecurityEventsArgs{...} }
type OpenpipelineSecurityEventsArrayInput interface {
	pulumi.Input

	ToOpenpipelineSecurityEventsArrayOutput() OpenpipelineSecurityEventsArrayOutput
	ToOpenpipelineSecurityEventsArrayOutputWithContext(context.Context) OpenpipelineSecurityEventsArrayOutput
}

type OpenpipelineSecurityEventsArray []OpenpipelineSecurityEventsInput

func (OpenpipelineSecurityEventsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineSecurityEvents)(nil)).Elem()
}

func (i OpenpipelineSecurityEventsArray) ToOpenpipelineSecurityEventsArrayOutput() OpenpipelineSecurityEventsArrayOutput {
	return i.ToOpenpipelineSecurityEventsArrayOutputWithContext(context.Background())
}

func (i OpenpipelineSecurityEventsArray) ToOpenpipelineSecurityEventsArrayOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineSecurityEventsArrayOutput)
}

// OpenpipelineSecurityEventsMapInput is an input type that accepts OpenpipelineSecurityEventsMap and OpenpipelineSecurityEventsMapOutput values.
// You can construct a concrete instance of `OpenpipelineSecurityEventsMapInput` via:
//
//	OpenpipelineSecurityEventsMap{ "key": OpenpipelineSecurityEventsArgs{...} }
type OpenpipelineSecurityEventsMapInput interface {
	pulumi.Input

	ToOpenpipelineSecurityEventsMapOutput() OpenpipelineSecurityEventsMapOutput
	ToOpenpipelineSecurityEventsMapOutputWithContext(context.Context) OpenpipelineSecurityEventsMapOutput
}

type OpenpipelineSecurityEventsMap map[string]OpenpipelineSecurityEventsInput

func (OpenpipelineSecurityEventsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineSecurityEvents)(nil)).Elem()
}

func (i OpenpipelineSecurityEventsMap) ToOpenpipelineSecurityEventsMapOutput() OpenpipelineSecurityEventsMapOutput {
	return i.ToOpenpipelineSecurityEventsMapOutputWithContext(context.Background())
}

func (i OpenpipelineSecurityEventsMap) ToOpenpipelineSecurityEventsMapOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenpipelineSecurityEventsMapOutput)
}

type OpenpipelineSecurityEventsOutput struct{ *pulumi.OutputState }

func (OpenpipelineSecurityEventsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OpenpipelineSecurityEvents)(nil)).Elem()
}

func (o OpenpipelineSecurityEventsOutput) ToOpenpipelineSecurityEventsOutput() OpenpipelineSecurityEventsOutput {
	return o
}

func (o OpenpipelineSecurityEventsOutput) ToOpenpipelineSecurityEventsOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsOutput {
	return o
}

// List of all ingest sources of the configuration
func (o OpenpipelineSecurityEventsOutput) Endpoints() OpenpipelineSecurityEventsEndpointsPtrOutput {
	return o.ApplyT(func(v *OpenpipelineSecurityEvents) OpenpipelineSecurityEventsEndpointsPtrOutput { return v.Endpoints }).(OpenpipelineSecurityEventsEndpointsPtrOutput)
}

// List of all pipelines of the configuration
func (o OpenpipelineSecurityEventsOutput) Pipelines() OpenpipelineSecurityEventsPipelinesPtrOutput {
	return o.ApplyT(func(v *OpenpipelineSecurityEvents) OpenpipelineSecurityEventsPipelinesPtrOutput { return v.Pipelines }).(OpenpipelineSecurityEventsPipelinesPtrOutput)
}

// Dynamic routing definition
func (o OpenpipelineSecurityEventsOutput) Routing() OpenpipelineSecurityEventsRoutingPtrOutput {
	return o.ApplyT(func(v *OpenpipelineSecurityEvents) OpenpipelineSecurityEventsRoutingPtrOutput { return v.Routing }).(OpenpipelineSecurityEventsRoutingPtrOutput)
}

type OpenpipelineSecurityEventsArrayOutput struct{ *pulumi.OutputState }

func (OpenpipelineSecurityEventsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpenpipelineSecurityEvents)(nil)).Elem()
}

func (o OpenpipelineSecurityEventsArrayOutput) ToOpenpipelineSecurityEventsArrayOutput() OpenpipelineSecurityEventsArrayOutput {
	return o
}

func (o OpenpipelineSecurityEventsArrayOutput) ToOpenpipelineSecurityEventsArrayOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsArrayOutput {
	return o
}

func (o OpenpipelineSecurityEventsArrayOutput) Index(i pulumi.IntInput) OpenpipelineSecurityEventsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OpenpipelineSecurityEvents {
		return vs[0].([]*OpenpipelineSecurityEvents)[vs[1].(int)]
	}).(OpenpipelineSecurityEventsOutput)
}

type OpenpipelineSecurityEventsMapOutput struct{ *pulumi.OutputState }

func (OpenpipelineSecurityEventsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpenpipelineSecurityEvents)(nil)).Elem()
}

func (o OpenpipelineSecurityEventsMapOutput) ToOpenpipelineSecurityEventsMapOutput() OpenpipelineSecurityEventsMapOutput {
	return o
}

func (o OpenpipelineSecurityEventsMapOutput) ToOpenpipelineSecurityEventsMapOutputWithContext(ctx context.Context) OpenpipelineSecurityEventsMapOutput {
	return o
}

func (o OpenpipelineSecurityEventsMapOutput) MapIndex(k pulumi.StringInput) OpenpipelineSecurityEventsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OpenpipelineSecurityEvents {
		return vs[0].(map[string]*OpenpipelineSecurityEvents)[vs[1].(string)]
	}).(OpenpipelineSecurityEventsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineSecurityEventsInput)(nil)).Elem(), &OpenpipelineSecurityEvents{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineSecurityEventsArrayInput)(nil)).Elem(), OpenpipelineSecurityEventsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenpipelineSecurityEventsMapInput)(nil)).Elem(), OpenpipelineSecurityEventsMap{})
	pulumi.RegisterOutputType(OpenpipelineSecurityEventsOutput{})
	pulumi.RegisterOutputType(OpenpipelineSecurityEventsArrayOutput{})
	pulumi.RegisterOutputType(OpenpipelineSecurityEventsMapOutput{})
}