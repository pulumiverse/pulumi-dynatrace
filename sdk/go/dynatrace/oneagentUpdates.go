// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type OneagentUpdates struct {
	pulumi.CustomResourceState

	// Maintenance windows
	MaintenanceWindows OneagentUpdatesMaintenanceWindowsPtrOutput `pulumi:"maintenanceWindows"`
	// Revision
	Revision pulumi.StringPtrOutput `pulumi:"revision"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// Target version
	TargetVersion pulumi.StringPtrOutput `pulumi:"targetVersion"`
	// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
	UpdateMode pulumi.StringOutput `pulumi:"updateMode"`
}

// NewOneagentUpdates registers a new resource with the given unique name, arguments, and options.
func NewOneagentUpdates(ctx *pulumi.Context,
	name string, args *OneagentUpdatesArgs, opts ...pulumi.ResourceOption) (*OneagentUpdates, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.UpdateMode == nil {
		return nil, errors.New("invalid value for required argument 'UpdateMode'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource OneagentUpdates
	err := ctx.RegisterResource("dynatrace:index/oneagentUpdates:OneagentUpdates", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOneagentUpdates gets an existing OneagentUpdates resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOneagentUpdates(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OneagentUpdatesState, opts ...pulumi.ResourceOption) (*OneagentUpdates, error) {
	var resource OneagentUpdates
	err := ctx.ReadResource("dynatrace:index/oneagentUpdates:OneagentUpdates", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OneagentUpdates resources.
type oneagentUpdatesState struct {
	// Maintenance windows
	MaintenanceWindows *OneagentUpdatesMaintenanceWindows `pulumi:"maintenanceWindows"`
	// Revision
	Revision *string `pulumi:"revision"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Target version
	TargetVersion *string `pulumi:"targetVersion"`
	// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
	UpdateMode *string `pulumi:"updateMode"`
}

type OneagentUpdatesState struct {
	// Maintenance windows
	MaintenanceWindows OneagentUpdatesMaintenanceWindowsPtrInput
	// Revision
	Revision pulumi.StringPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Target version
	TargetVersion pulumi.StringPtrInput
	// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
	UpdateMode pulumi.StringPtrInput
}

func (OneagentUpdatesState) ElementType() reflect.Type {
	return reflect.TypeOf((*oneagentUpdatesState)(nil)).Elem()
}

type oneagentUpdatesArgs struct {
	// Maintenance windows
	MaintenanceWindows *OneagentUpdatesMaintenanceWindows `pulumi:"maintenanceWindows"`
	// Revision
	Revision *string `pulumi:"revision"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Target version
	TargetVersion *string `pulumi:"targetVersion"`
	// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
	UpdateMode string `pulumi:"updateMode"`
}

// The set of arguments for constructing a OneagentUpdates resource.
type OneagentUpdatesArgs struct {
	// Maintenance windows
	MaintenanceWindows OneagentUpdatesMaintenanceWindowsPtrInput
	// Revision
	Revision pulumi.StringPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Target version
	TargetVersion pulumi.StringPtrInput
	// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
	UpdateMode pulumi.StringInput
}

func (OneagentUpdatesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*oneagentUpdatesArgs)(nil)).Elem()
}

type OneagentUpdatesInput interface {
	pulumi.Input

	ToOneagentUpdatesOutput() OneagentUpdatesOutput
	ToOneagentUpdatesOutputWithContext(ctx context.Context) OneagentUpdatesOutput
}

func (*OneagentUpdates) ElementType() reflect.Type {
	return reflect.TypeOf((**OneagentUpdates)(nil)).Elem()
}

func (i *OneagentUpdates) ToOneagentUpdatesOutput() OneagentUpdatesOutput {
	return i.ToOneagentUpdatesOutputWithContext(context.Background())
}

func (i *OneagentUpdates) ToOneagentUpdatesOutputWithContext(ctx context.Context) OneagentUpdatesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OneagentUpdatesOutput)
}

// OneagentUpdatesArrayInput is an input type that accepts OneagentUpdatesArray and OneagentUpdatesArrayOutput values.
// You can construct a concrete instance of `OneagentUpdatesArrayInput` via:
//
//	OneagentUpdatesArray{ OneagentUpdatesArgs{...} }
type OneagentUpdatesArrayInput interface {
	pulumi.Input

	ToOneagentUpdatesArrayOutput() OneagentUpdatesArrayOutput
	ToOneagentUpdatesArrayOutputWithContext(context.Context) OneagentUpdatesArrayOutput
}

type OneagentUpdatesArray []OneagentUpdatesInput

func (OneagentUpdatesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OneagentUpdates)(nil)).Elem()
}

func (i OneagentUpdatesArray) ToOneagentUpdatesArrayOutput() OneagentUpdatesArrayOutput {
	return i.ToOneagentUpdatesArrayOutputWithContext(context.Background())
}

func (i OneagentUpdatesArray) ToOneagentUpdatesArrayOutputWithContext(ctx context.Context) OneagentUpdatesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OneagentUpdatesArrayOutput)
}

// OneagentUpdatesMapInput is an input type that accepts OneagentUpdatesMap and OneagentUpdatesMapOutput values.
// You can construct a concrete instance of `OneagentUpdatesMapInput` via:
//
//	OneagentUpdatesMap{ "key": OneagentUpdatesArgs{...} }
type OneagentUpdatesMapInput interface {
	pulumi.Input

	ToOneagentUpdatesMapOutput() OneagentUpdatesMapOutput
	ToOneagentUpdatesMapOutputWithContext(context.Context) OneagentUpdatesMapOutput
}

type OneagentUpdatesMap map[string]OneagentUpdatesInput

func (OneagentUpdatesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OneagentUpdates)(nil)).Elem()
}

func (i OneagentUpdatesMap) ToOneagentUpdatesMapOutput() OneagentUpdatesMapOutput {
	return i.ToOneagentUpdatesMapOutputWithContext(context.Background())
}

func (i OneagentUpdatesMap) ToOneagentUpdatesMapOutputWithContext(ctx context.Context) OneagentUpdatesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OneagentUpdatesMapOutput)
}

type OneagentUpdatesOutput struct{ *pulumi.OutputState }

func (OneagentUpdatesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OneagentUpdates)(nil)).Elem()
}

func (o OneagentUpdatesOutput) ToOneagentUpdatesOutput() OneagentUpdatesOutput {
	return o
}

func (o OneagentUpdatesOutput) ToOneagentUpdatesOutputWithContext(ctx context.Context) OneagentUpdatesOutput {
	return o
}

// Maintenance windows
func (o OneagentUpdatesOutput) MaintenanceWindows() OneagentUpdatesMaintenanceWindowsPtrOutput {
	return o.ApplyT(func(v *OneagentUpdates) OneagentUpdatesMaintenanceWindowsPtrOutput { return v.MaintenanceWindows }).(OneagentUpdatesMaintenanceWindowsPtrOutput)
}

// Revision
func (o OneagentUpdatesOutput) Revision() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OneagentUpdates) pulumi.StringPtrOutput { return v.Revision }).(pulumi.StringPtrOutput)
}

// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
func (o OneagentUpdatesOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OneagentUpdates) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

// Target version
func (o OneagentUpdatesOutput) TargetVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OneagentUpdates) pulumi.StringPtrOutput { return v.TargetVersion }).(pulumi.StringPtrOutput)
}

// Possible Values: `AUTOMATIC`, `AUTOMATIC_DURING_MW`, `MANUAL`
func (o OneagentUpdatesOutput) UpdateMode() pulumi.StringOutput {
	return o.ApplyT(func(v *OneagentUpdates) pulumi.StringOutput { return v.UpdateMode }).(pulumi.StringOutput)
}

type OneagentUpdatesArrayOutput struct{ *pulumi.OutputState }

func (OneagentUpdatesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OneagentUpdates)(nil)).Elem()
}

func (o OneagentUpdatesArrayOutput) ToOneagentUpdatesArrayOutput() OneagentUpdatesArrayOutput {
	return o
}

func (o OneagentUpdatesArrayOutput) ToOneagentUpdatesArrayOutputWithContext(ctx context.Context) OneagentUpdatesArrayOutput {
	return o
}

func (o OneagentUpdatesArrayOutput) Index(i pulumi.IntInput) OneagentUpdatesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OneagentUpdates {
		return vs[0].([]*OneagentUpdates)[vs[1].(int)]
	}).(OneagentUpdatesOutput)
}

type OneagentUpdatesMapOutput struct{ *pulumi.OutputState }

func (OneagentUpdatesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OneagentUpdates)(nil)).Elem()
}

func (o OneagentUpdatesMapOutput) ToOneagentUpdatesMapOutput() OneagentUpdatesMapOutput {
	return o
}

func (o OneagentUpdatesMapOutput) ToOneagentUpdatesMapOutputWithContext(ctx context.Context) OneagentUpdatesMapOutput {
	return o
}

func (o OneagentUpdatesMapOutput) MapIndex(k pulumi.StringInput) OneagentUpdatesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OneagentUpdates {
		return vs[0].(map[string]*OneagentUpdates)[vs[1].(string)]
	}).(OneagentUpdatesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OneagentUpdatesInput)(nil)).Elem(), &OneagentUpdates{})
	pulumi.RegisterInputType(reflect.TypeOf((*OneagentUpdatesArrayInput)(nil)).Elem(), OneagentUpdatesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OneagentUpdatesMapInput)(nil)).Elem(), OneagentUpdatesMap{})
	pulumi.RegisterOutputType(OneagentUpdatesOutput{})
	pulumi.RegisterOutputType(OneagentUpdatesArrayOutput{})
	pulumi.RegisterOutputType(OneagentUpdatesMapOutput{})
}