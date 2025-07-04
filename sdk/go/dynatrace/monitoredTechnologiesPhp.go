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

type MonitoredTechnologiesPhp struct {
	pulumi.CustomResourceState

	// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
	EnablePhpCliServer pulumi.BoolPtrOutput `pulumi:"enablePhpCliServer"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
	EnabledFastCgi pulumi.BoolPtrOutput `pulumi:"enabledFastCgi"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrOutput `pulumi:"hostId"`
}

// NewMonitoredTechnologiesPhp registers a new resource with the given unique name, arguments, and options.
func NewMonitoredTechnologiesPhp(ctx *pulumi.Context,
	name string, args *MonitoredTechnologiesPhpArgs, opts ...pulumi.ResourceOption) (*MonitoredTechnologiesPhp, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MonitoredTechnologiesPhp
	err := ctx.RegisterResource("dynatrace:index/monitoredTechnologiesPhp:MonitoredTechnologiesPhp", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMonitoredTechnologiesPhp gets an existing MonitoredTechnologiesPhp resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMonitoredTechnologiesPhp(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MonitoredTechnologiesPhpState, opts ...pulumi.ResourceOption) (*MonitoredTechnologiesPhp, error) {
	var resource MonitoredTechnologiesPhp
	err := ctx.ReadResource("dynatrace:index/monitoredTechnologiesPhp:MonitoredTechnologiesPhp", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MonitoredTechnologiesPhp resources.
type monitoredTechnologiesPhpState struct {
	// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
	EnablePhpCliServer *bool `pulumi:"enablePhpCliServer"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
	EnabledFastCgi *bool `pulumi:"enabledFastCgi"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId *string `pulumi:"hostId"`
}

type MonitoredTechnologiesPhpState struct {
	// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
	EnablePhpCliServer pulumi.BoolPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
	EnabledFastCgi pulumi.BoolPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrInput
}

func (MonitoredTechnologiesPhpState) ElementType() reflect.Type {
	return reflect.TypeOf((*monitoredTechnologiesPhpState)(nil)).Elem()
}

type monitoredTechnologiesPhpArgs struct {
	// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
	EnablePhpCliServer *bool `pulumi:"enablePhpCliServer"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
	EnabledFastCgi *bool `pulumi:"enabledFastCgi"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId *string `pulumi:"hostId"`
}

// The set of arguments for constructing a MonitoredTechnologiesPhp resource.
type MonitoredTechnologiesPhpArgs struct {
	// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
	EnablePhpCliServer pulumi.BoolPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
	EnabledFastCgi pulumi.BoolPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrInput
}

func (MonitoredTechnologiesPhpArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*monitoredTechnologiesPhpArgs)(nil)).Elem()
}

type MonitoredTechnologiesPhpInput interface {
	pulumi.Input

	ToMonitoredTechnologiesPhpOutput() MonitoredTechnologiesPhpOutput
	ToMonitoredTechnologiesPhpOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpOutput
}

func (*MonitoredTechnologiesPhp) ElementType() reflect.Type {
	return reflect.TypeOf((**MonitoredTechnologiesPhp)(nil)).Elem()
}

func (i *MonitoredTechnologiesPhp) ToMonitoredTechnologiesPhpOutput() MonitoredTechnologiesPhpOutput {
	return i.ToMonitoredTechnologiesPhpOutputWithContext(context.Background())
}

func (i *MonitoredTechnologiesPhp) ToMonitoredTechnologiesPhpOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesPhpOutput)
}

// MonitoredTechnologiesPhpArrayInput is an input type that accepts MonitoredTechnologiesPhpArray and MonitoredTechnologiesPhpArrayOutput values.
// You can construct a concrete instance of `MonitoredTechnologiesPhpArrayInput` via:
//
//	MonitoredTechnologiesPhpArray{ MonitoredTechnologiesPhpArgs{...} }
type MonitoredTechnologiesPhpArrayInput interface {
	pulumi.Input

	ToMonitoredTechnologiesPhpArrayOutput() MonitoredTechnologiesPhpArrayOutput
	ToMonitoredTechnologiesPhpArrayOutputWithContext(context.Context) MonitoredTechnologiesPhpArrayOutput
}

type MonitoredTechnologiesPhpArray []MonitoredTechnologiesPhpInput

func (MonitoredTechnologiesPhpArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MonitoredTechnologiesPhp)(nil)).Elem()
}

func (i MonitoredTechnologiesPhpArray) ToMonitoredTechnologiesPhpArrayOutput() MonitoredTechnologiesPhpArrayOutput {
	return i.ToMonitoredTechnologiesPhpArrayOutputWithContext(context.Background())
}

func (i MonitoredTechnologiesPhpArray) ToMonitoredTechnologiesPhpArrayOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesPhpArrayOutput)
}

// MonitoredTechnologiesPhpMapInput is an input type that accepts MonitoredTechnologiesPhpMap and MonitoredTechnologiesPhpMapOutput values.
// You can construct a concrete instance of `MonitoredTechnologiesPhpMapInput` via:
//
//	MonitoredTechnologiesPhpMap{ "key": MonitoredTechnologiesPhpArgs{...} }
type MonitoredTechnologiesPhpMapInput interface {
	pulumi.Input

	ToMonitoredTechnologiesPhpMapOutput() MonitoredTechnologiesPhpMapOutput
	ToMonitoredTechnologiesPhpMapOutputWithContext(context.Context) MonitoredTechnologiesPhpMapOutput
}

type MonitoredTechnologiesPhpMap map[string]MonitoredTechnologiesPhpInput

func (MonitoredTechnologiesPhpMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MonitoredTechnologiesPhp)(nil)).Elem()
}

func (i MonitoredTechnologiesPhpMap) ToMonitoredTechnologiesPhpMapOutput() MonitoredTechnologiesPhpMapOutput {
	return i.ToMonitoredTechnologiesPhpMapOutputWithContext(context.Background())
}

func (i MonitoredTechnologiesPhpMap) ToMonitoredTechnologiesPhpMapOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesPhpMapOutput)
}

type MonitoredTechnologiesPhpOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesPhpOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MonitoredTechnologiesPhp)(nil)).Elem()
}

func (o MonitoredTechnologiesPhpOutput) ToMonitoredTechnologiesPhpOutput() MonitoredTechnologiesPhpOutput {
	return o
}

func (o MonitoredTechnologiesPhpOutput) ToMonitoredTechnologiesPhpOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpOutput {
	return o
}

// Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
func (o MonitoredTechnologiesPhpOutput) EnablePhpCliServer() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesPhp) pulumi.BoolPtrOutput { return v.EnablePhpCliServer }).(pulumi.BoolPtrOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o MonitoredTechnologiesPhpOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesPhp) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it's ignored and permanently enabled
func (o MonitoredTechnologiesPhpOutput) EnabledFastCgi() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesPhp) pulumi.BoolPtrOutput { return v.EnabledFastCgi }).(pulumi.BoolPtrOutput)
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o MonitoredTechnologiesPhpOutput) HostId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesPhp) pulumi.StringPtrOutput { return v.HostId }).(pulumi.StringPtrOutput)
}

type MonitoredTechnologiesPhpArrayOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesPhpArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MonitoredTechnologiesPhp)(nil)).Elem()
}

func (o MonitoredTechnologiesPhpArrayOutput) ToMonitoredTechnologiesPhpArrayOutput() MonitoredTechnologiesPhpArrayOutput {
	return o
}

func (o MonitoredTechnologiesPhpArrayOutput) ToMonitoredTechnologiesPhpArrayOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpArrayOutput {
	return o
}

func (o MonitoredTechnologiesPhpArrayOutput) Index(i pulumi.IntInput) MonitoredTechnologiesPhpOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MonitoredTechnologiesPhp {
		return vs[0].([]*MonitoredTechnologiesPhp)[vs[1].(int)]
	}).(MonitoredTechnologiesPhpOutput)
}

type MonitoredTechnologiesPhpMapOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesPhpMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MonitoredTechnologiesPhp)(nil)).Elem()
}

func (o MonitoredTechnologiesPhpMapOutput) ToMonitoredTechnologiesPhpMapOutput() MonitoredTechnologiesPhpMapOutput {
	return o
}

func (o MonitoredTechnologiesPhpMapOutput) ToMonitoredTechnologiesPhpMapOutputWithContext(ctx context.Context) MonitoredTechnologiesPhpMapOutput {
	return o
}

func (o MonitoredTechnologiesPhpMapOutput) MapIndex(k pulumi.StringInput) MonitoredTechnologiesPhpOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MonitoredTechnologiesPhp {
		return vs[0].(map[string]*MonitoredTechnologiesPhp)[vs[1].(string)]
	}).(MonitoredTechnologiesPhpOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesPhpInput)(nil)).Elem(), &MonitoredTechnologiesPhp{})
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesPhpArrayInput)(nil)).Elem(), MonitoredTechnologiesPhpArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesPhpMapInput)(nil)).Elem(), MonitoredTechnologiesPhpMap{})
	pulumi.RegisterOutputType(MonitoredTechnologiesPhpOutput{})
	pulumi.RegisterOutputType(MonitoredTechnologiesPhpArrayOutput{})
	pulumi.RegisterOutputType(MonitoredTechnologiesPhpMapOutput{})
}
