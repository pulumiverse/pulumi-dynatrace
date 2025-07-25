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

type MobileNotifications struct {
	pulumi.CustomResourceState

	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
}

// NewMobileNotifications registers a new resource with the given unique name, arguments, and options.
func NewMobileNotifications(ctx *pulumi.Context,
	name string, args *MobileNotificationsArgs, opts ...pulumi.ResourceOption) (*MobileNotifications, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MobileNotifications
	err := ctx.RegisterResource("dynatrace:index/mobileNotifications:MobileNotifications", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMobileNotifications gets an existing MobileNotifications resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMobileNotifications(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MobileNotificationsState, opts ...pulumi.ResourceOption) (*MobileNotifications, error) {
	var resource MobileNotifications
	err := ctx.ReadResource("dynatrace:index/mobileNotifications:MobileNotifications", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MobileNotifications resources.
type mobileNotificationsState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
}

type MobileNotificationsState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
}

func (MobileNotificationsState) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileNotificationsState)(nil)).Elem()
}

type mobileNotificationsArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
}

// The set of arguments for constructing a MobileNotifications resource.
type MobileNotificationsArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
}

func (MobileNotificationsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileNotificationsArgs)(nil)).Elem()
}

type MobileNotificationsInput interface {
	pulumi.Input

	ToMobileNotificationsOutput() MobileNotificationsOutput
	ToMobileNotificationsOutputWithContext(ctx context.Context) MobileNotificationsOutput
}

func (*MobileNotifications) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileNotifications)(nil)).Elem()
}

func (i *MobileNotifications) ToMobileNotificationsOutput() MobileNotificationsOutput {
	return i.ToMobileNotificationsOutputWithContext(context.Background())
}

func (i *MobileNotifications) ToMobileNotificationsOutputWithContext(ctx context.Context) MobileNotificationsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileNotificationsOutput)
}

// MobileNotificationsArrayInput is an input type that accepts MobileNotificationsArray and MobileNotificationsArrayOutput values.
// You can construct a concrete instance of `MobileNotificationsArrayInput` via:
//
//	MobileNotificationsArray{ MobileNotificationsArgs{...} }
type MobileNotificationsArrayInput interface {
	pulumi.Input

	ToMobileNotificationsArrayOutput() MobileNotificationsArrayOutput
	ToMobileNotificationsArrayOutputWithContext(context.Context) MobileNotificationsArrayOutput
}

type MobileNotificationsArray []MobileNotificationsInput

func (MobileNotificationsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileNotifications)(nil)).Elem()
}

func (i MobileNotificationsArray) ToMobileNotificationsArrayOutput() MobileNotificationsArrayOutput {
	return i.ToMobileNotificationsArrayOutputWithContext(context.Background())
}

func (i MobileNotificationsArray) ToMobileNotificationsArrayOutputWithContext(ctx context.Context) MobileNotificationsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileNotificationsArrayOutput)
}

// MobileNotificationsMapInput is an input type that accepts MobileNotificationsMap and MobileNotificationsMapOutput values.
// You can construct a concrete instance of `MobileNotificationsMapInput` via:
//
//	MobileNotificationsMap{ "key": MobileNotificationsArgs{...} }
type MobileNotificationsMapInput interface {
	pulumi.Input

	ToMobileNotificationsMapOutput() MobileNotificationsMapOutput
	ToMobileNotificationsMapOutputWithContext(context.Context) MobileNotificationsMapOutput
}

type MobileNotificationsMap map[string]MobileNotificationsInput

func (MobileNotificationsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileNotifications)(nil)).Elem()
}

func (i MobileNotificationsMap) ToMobileNotificationsMapOutput() MobileNotificationsMapOutput {
	return i.ToMobileNotificationsMapOutputWithContext(context.Background())
}

func (i MobileNotificationsMap) ToMobileNotificationsMapOutputWithContext(ctx context.Context) MobileNotificationsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileNotificationsMapOutput)
}

type MobileNotificationsOutput struct{ *pulumi.OutputState }

func (MobileNotificationsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileNotifications)(nil)).Elem()
}

func (o MobileNotificationsOutput) ToMobileNotificationsOutput() MobileNotificationsOutput {
	return o
}

func (o MobileNotificationsOutput) ToMobileNotificationsOutputWithContext(ctx context.Context) MobileNotificationsOutput {
	return o
}

// This setting is enabled (`true`) or disabled (`false`)
func (o MobileNotificationsOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *MobileNotifications) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

type MobileNotificationsArrayOutput struct{ *pulumi.OutputState }

func (MobileNotificationsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileNotifications)(nil)).Elem()
}

func (o MobileNotificationsArrayOutput) ToMobileNotificationsArrayOutput() MobileNotificationsArrayOutput {
	return o
}

func (o MobileNotificationsArrayOutput) ToMobileNotificationsArrayOutputWithContext(ctx context.Context) MobileNotificationsArrayOutput {
	return o
}

func (o MobileNotificationsArrayOutput) Index(i pulumi.IntInput) MobileNotificationsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MobileNotifications {
		return vs[0].([]*MobileNotifications)[vs[1].(int)]
	}).(MobileNotificationsOutput)
}

type MobileNotificationsMapOutput struct{ *pulumi.OutputState }

func (MobileNotificationsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileNotifications)(nil)).Elem()
}

func (o MobileNotificationsMapOutput) ToMobileNotificationsMapOutput() MobileNotificationsMapOutput {
	return o
}

func (o MobileNotificationsMapOutput) ToMobileNotificationsMapOutputWithContext(ctx context.Context) MobileNotificationsMapOutput {
	return o
}

func (o MobileNotificationsMapOutput) MapIndex(k pulumi.StringInput) MobileNotificationsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MobileNotifications {
		return vs[0].(map[string]*MobileNotifications)[vs[1].(string)]
	}).(MobileNotificationsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MobileNotificationsInput)(nil)).Elem(), &MobileNotifications{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileNotificationsArrayInput)(nil)).Elem(), MobileNotificationsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileNotificationsMapInput)(nil)).Elem(), MobileNotificationsMap{})
	pulumi.RegisterOutputType(MobileNotificationsOutput{})
	pulumi.RegisterOutputType(MobileNotificationsArrayOutput{})
	pulumi.RegisterOutputType(MobileNotificationsMapOutput{})
}
