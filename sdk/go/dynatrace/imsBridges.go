// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type ImsBridges struct {
	pulumi.CustomResourceState

	// The name of the IMS bridge
	Name pulumi.StringOutput `pulumi:"name"`
	// Queue manager(s) that belong to the IMS bridge
	QueueManagers ImsBridgesQueueManagerArrayOutput `pulumi:"queueManagers"`
}

// NewImsBridges registers a new resource with the given unique name, arguments, and options.
func NewImsBridges(ctx *pulumi.Context,
	name string, args *ImsBridgesArgs, opts ...pulumi.ResourceOption) (*ImsBridges, error) {
	if args == nil {
		args = &ImsBridgesArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ImsBridges
	err := ctx.RegisterResource("dynatrace:index/imsBridges:ImsBridges", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetImsBridges gets an existing ImsBridges resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetImsBridges(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ImsBridgesState, opts ...pulumi.ResourceOption) (*ImsBridges, error) {
	var resource ImsBridges
	err := ctx.ReadResource("dynatrace:index/imsBridges:ImsBridges", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ImsBridges resources.
type imsBridgesState struct {
	// The name of the IMS bridge
	Name *string `pulumi:"name"`
	// Queue manager(s) that belong to the IMS bridge
	QueueManagers []ImsBridgesQueueManager `pulumi:"queueManagers"`
}

type ImsBridgesState struct {
	// The name of the IMS bridge
	Name pulumi.StringPtrInput
	// Queue manager(s) that belong to the IMS bridge
	QueueManagers ImsBridgesQueueManagerArrayInput
}

func (ImsBridgesState) ElementType() reflect.Type {
	return reflect.TypeOf((*imsBridgesState)(nil)).Elem()
}

type imsBridgesArgs struct {
	// The name of the IMS bridge
	Name *string `pulumi:"name"`
	// Queue manager(s) that belong to the IMS bridge
	QueueManagers []ImsBridgesQueueManager `pulumi:"queueManagers"`
}

// The set of arguments for constructing a ImsBridges resource.
type ImsBridgesArgs struct {
	// The name of the IMS bridge
	Name pulumi.StringPtrInput
	// Queue manager(s) that belong to the IMS bridge
	QueueManagers ImsBridgesQueueManagerArrayInput
}

func (ImsBridgesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*imsBridgesArgs)(nil)).Elem()
}

type ImsBridgesInput interface {
	pulumi.Input

	ToImsBridgesOutput() ImsBridgesOutput
	ToImsBridgesOutputWithContext(ctx context.Context) ImsBridgesOutput
}

func (*ImsBridges) ElementType() reflect.Type {
	return reflect.TypeOf((**ImsBridges)(nil)).Elem()
}

func (i *ImsBridges) ToImsBridgesOutput() ImsBridgesOutput {
	return i.ToImsBridgesOutputWithContext(context.Background())
}

func (i *ImsBridges) ToImsBridgesOutputWithContext(ctx context.Context) ImsBridgesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ImsBridgesOutput)
}

// ImsBridgesArrayInput is an input type that accepts ImsBridgesArray and ImsBridgesArrayOutput values.
// You can construct a concrete instance of `ImsBridgesArrayInput` via:
//
//	ImsBridgesArray{ ImsBridgesArgs{...} }
type ImsBridgesArrayInput interface {
	pulumi.Input

	ToImsBridgesArrayOutput() ImsBridgesArrayOutput
	ToImsBridgesArrayOutputWithContext(context.Context) ImsBridgesArrayOutput
}

type ImsBridgesArray []ImsBridgesInput

func (ImsBridgesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ImsBridges)(nil)).Elem()
}

func (i ImsBridgesArray) ToImsBridgesArrayOutput() ImsBridgesArrayOutput {
	return i.ToImsBridgesArrayOutputWithContext(context.Background())
}

func (i ImsBridgesArray) ToImsBridgesArrayOutputWithContext(ctx context.Context) ImsBridgesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ImsBridgesArrayOutput)
}

// ImsBridgesMapInput is an input type that accepts ImsBridgesMap and ImsBridgesMapOutput values.
// You can construct a concrete instance of `ImsBridgesMapInput` via:
//
//	ImsBridgesMap{ "key": ImsBridgesArgs{...} }
type ImsBridgesMapInput interface {
	pulumi.Input

	ToImsBridgesMapOutput() ImsBridgesMapOutput
	ToImsBridgesMapOutputWithContext(context.Context) ImsBridgesMapOutput
}

type ImsBridgesMap map[string]ImsBridgesInput

func (ImsBridgesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ImsBridges)(nil)).Elem()
}

func (i ImsBridgesMap) ToImsBridgesMapOutput() ImsBridgesMapOutput {
	return i.ToImsBridgesMapOutputWithContext(context.Background())
}

func (i ImsBridgesMap) ToImsBridgesMapOutputWithContext(ctx context.Context) ImsBridgesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ImsBridgesMapOutput)
}

type ImsBridgesOutput struct{ *pulumi.OutputState }

func (ImsBridgesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ImsBridges)(nil)).Elem()
}

func (o ImsBridgesOutput) ToImsBridgesOutput() ImsBridgesOutput {
	return o
}

func (o ImsBridgesOutput) ToImsBridgesOutputWithContext(ctx context.Context) ImsBridgesOutput {
	return o
}

// The name of the IMS bridge
func (o ImsBridgesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ImsBridges) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Queue manager(s) that belong to the IMS bridge
func (o ImsBridgesOutput) QueueManagers() ImsBridgesQueueManagerArrayOutput {
	return o.ApplyT(func(v *ImsBridges) ImsBridgesQueueManagerArrayOutput { return v.QueueManagers }).(ImsBridgesQueueManagerArrayOutput)
}

type ImsBridgesArrayOutput struct{ *pulumi.OutputState }

func (ImsBridgesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ImsBridges)(nil)).Elem()
}

func (o ImsBridgesArrayOutput) ToImsBridgesArrayOutput() ImsBridgesArrayOutput {
	return o
}

func (o ImsBridgesArrayOutput) ToImsBridgesArrayOutputWithContext(ctx context.Context) ImsBridgesArrayOutput {
	return o
}

func (o ImsBridgesArrayOutput) Index(i pulumi.IntInput) ImsBridgesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ImsBridges {
		return vs[0].([]*ImsBridges)[vs[1].(int)]
	}).(ImsBridgesOutput)
}

type ImsBridgesMapOutput struct{ *pulumi.OutputState }

func (ImsBridgesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ImsBridges)(nil)).Elem()
}

func (o ImsBridgesMapOutput) ToImsBridgesMapOutput() ImsBridgesMapOutput {
	return o
}

func (o ImsBridgesMapOutput) ToImsBridgesMapOutputWithContext(ctx context.Context) ImsBridgesMapOutput {
	return o
}

func (o ImsBridgesMapOutput) MapIndex(k pulumi.StringInput) ImsBridgesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ImsBridges {
		return vs[0].(map[string]*ImsBridges)[vs[1].(string)]
	}).(ImsBridgesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ImsBridgesInput)(nil)).Elem(), &ImsBridges{})
	pulumi.RegisterInputType(reflect.TypeOf((*ImsBridgesArrayInput)(nil)).Elem(), ImsBridgesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ImsBridgesMapInput)(nil)).Elem(), ImsBridgesMap{})
	pulumi.RegisterOutputType(ImsBridgesOutput{})
	pulumi.RegisterOutputType(ImsBridgesArrayOutput{})
	pulumi.RegisterOutputType(ImsBridgesMapOutput{})
}
