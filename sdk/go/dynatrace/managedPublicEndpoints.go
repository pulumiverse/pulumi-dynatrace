// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type ManagedPublicEndpoints struct {
	pulumi.CustomResourceState

	// Additional web UI addresses
	AdditionalWebUiAddresses pulumi.StringArrayOutput `pulumi:"additionalWebUiAddresses"`
	// Beacon forwarder address
	BeaconForwarderAddress pulumi.StringPtrOutput `pulumi:"beaconForwarderAddress"`
	// CDN address
	CdnAddress pulumi.StringPtrOutput `pulumi:"cdnAddress"`
	// Web UI address
	WebUiAddress pulumi.StringPtrOutput `pulumi:"webUiAddress"`
}

// NewManagedPublicEndpoints registers a new resource with the given unique name, arguments, and options.
func NewManagedPublicEndpoints(ctx *pulumi.Context,
	name string, args *ManagedPublicEndpointsArgs, opts ...pulumi.ResourceOption) (*ManagedPublicEndpoints, error) {
	if args == nil {
		args = &ManagedPublicEndpointsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ManagedPublicEndpoints
	err := ctx.RegisterResource("dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedPublicEndpoints gets an existing ManagedPublicEndpoints resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedPublicEndpoints(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedPublicEndpointsState, opts ...pulumi.ResourceOption) (*ManagedPublicEndpoints, error) {
	var resource ManagedPublicEndpoints
	err := ctx.ReadResource("dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedPublicEndpoints resources.
type managedPublicEndpointsState struct {
	// Additional web UI addresses
	AdditionalWebUiAddresses []string `pulumi:"additionalWebUiAddresses"`
	// Beacon forwarder address
	BeaconForwarderAddress *string `pulumi:"beaconForwarderAddress"`
	// CDN address
	CdnAddress *string `pulumi:"cdnAddress"`
	// Web UI address
	WebUiAddress *string `pulumi:"webUiAddress"`
}

type ManagedPublicEndpointsState struct {
	// Additional web UI addresses
	AdditionalWebUiAddresses pulumi.StringArrayInput
	// Beacon forwarder address
	BeaconForwarderAddress pulumi.StringPtrInput
	// CDN address
	CdnAddress pulumi.StringPtrInput
	// Web UI address
	WebUiAddress pulumi.StringPtrInput
}

func (ManagedPublicEndpointsState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedPublicEndpointsState)(nil)).Elem()
}

type managedPublicEndpointsArgs struct {
	// Additional web UI addresses
	AdditionalWebUiAddresses []string `pulumi:"additionalWebUiAddresses"`
	// Beacon forwarder address
	BeaconForwarderAddress *string `pulumi:"beaconForwarderAddress"`
	// CDN address
	CdnAddress *string `pulumi:"cdnAddress"`
	// Web UI address
	WebUiAddress *string `pulumi:"webUiAddress"`
}

// The set of arguments for constructing a ManagedPublicEndpoints resource.
type ManagedPublicEndpointsArgs struct {
	// Additional web UI addresses
	AdditionalWebUiAddresses pulumi.StringArrayInput
	// Beacon forwarder address
	BeaconForwarderAddress pulumi.StringPtrInput
	// CDN address
	CdnAddress pulumi.StringPtrInput
	// Web UI address
	WebUiAddress pulumi.StringPtrInput
}

func (ManagedPublicEndpointsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedPublicEndpointsArgs)(nil)).Elem()
}

type ManagedPublicEndpointsInput interface {
	pulumi.Input

	ToManagedPublicEndpointsOutput() ManagedPublicEndpointsOutput
	ToManagedPublicEndpointsOutputWithContext(ctx context.Context) ManagedPublicEndpointsOutput
}

func (*ManagedPublicEndpoints) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedPublicEndpoints)(nil)).Elem()
}

func (i *ManagedPublicEndpoints) ToManagedPublicEndpointsOutput() ManagedPublicEndpointsOutput {
	return i.ToManagedPublicEndpointsOutputWithContext(context.Background())
}

func (i *ManagedPublicEndpoints) ToManagedPublicEndpointsOutputWithContext(ctx context.Context) ManagedPublicEndpointsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedPublicEndpointsOutput)
}

// ManagedPublicEndpointsArrayInput is an input type that accepts ManagedPublicEndpointsArray and ManagedPublicEndpointsArrayOutput values.
// You can construct a concrete instance of `ManagedPublicEndpointsArrayInput` via:
//
//	ManagedPublicEndpointsArray{ ManagedPublicEndpointsArgs{...} }
type ManagedPublicEndpointsArrayInput interface {
	pulumi.Input

	ToManagedPublicEndpointsArrayOutput() ManagedPublicEndpointsArrayOutput
	ToManagedPublicEndpointsArrayOutputWithContext(context.Context) ManagedPublicEndpointsArrayOutput
}

type ManagedPublicEndpointsArray []ManagedPublicEndpointsInput

func (ManagedPublicEndpointsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedPublicEndpoints)(nil)).Elem()
}

func (i ManagedPublicEndpointsArray) ToManagedPublicEndpointsArrayOutput() ManagedPublicEndpointsArrayOutput {
	return i.ToManagedPublicEndpointsArrayOutputWithContext(context.Background())
}

func (i ManagedPublicEndpointsArray) ToManagedPublicEndpointsArrayOutputWithContext(ctx context.Context) ManagedPublicEndpointsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedPublicEndpointsArrayOutput)
}

// ManagedPublicEndpointsMapInput is an input type that accepts ManagedPublicEndpointsMap and ManagedPublicEndpointsMapOutput values.
// You can construct a concrete instance of `ManagedPublicEndpointsMapInput` via:
//
//	ManagedPublicEndpointsMap{ "key": ManagedPublicEndpointsArgs{...} }
type ManagedPublicEndpointsMapInput interface {
	pulumi.Input

	ToManagedPublicEndpointsMapOutput() ManagedPublicEndpointsMapOutput
	ToManagedPublicEndpointsMapOutputWithContext(context.Context) ManagedPublicEndpointsMapOutput
}

type ManagedPublicEndpointsMap map[string]ManagedPublicEndpointsInput

func (ManagedPublicEndpointsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedPublicEndpoints)(nil)).Elem()
}

func (i ManagedPublicEndpointsMap) ToManagedPublicEndpointsMapOutput() ManagedPublicEndpointsMapOutput {
	return i.ToManagedPublicEndpointsMapOutputWithContext(context.Background())
}

func (i ManagedPublicEndpointsMap) ToManagedPublicEndpointsMapOutputWithContext(ctx context.Context) ManagedPublicEndpointsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedPublicEndpointsMapOutput)
}

type ManagedPublicEndpointsOutput struct{ *pulumi.OutputState }

func (ManagedPublicEndpointsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedPublicEndpoints)(nil)).Elem()
}

func (o ManagedPublicEndpointsOutput) ToManagedPublicEndpointsOutput() ManagedPublicEndpointsOutput {
	return o
}

func (o ManagedPublicEndpointsOutput) ToManagedPublicEndpointsOutputWithContext(ctx context.Context) ManagedPublicEndpointsOutput {
	return o
}

// Additional web UI addresses
func (o ManagedPublicEndpointsOutput) AdditionalWebUiAddresses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ManagedPublicEndpoints) pulumi.StringArrayOutput { return v.AdditionalWebUiAddresses }).(pulumi.StringArrayOutput)
}

// Beacon forwarder address
func (o ManagedPublicEndpointsOutput) BeaconForwarderAddress() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedPublicEndpoints) pulumi.StringPtrOutput { return v.BeaconForwarderAddress }).(pulumi.StringPtrOutput)
}

// CDN address
func (o ManagedPublicEndpointsOutput) CdnAddress() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedPublicEndpoints) pulumi.StringPtrOutput { return v.CdnAddress }).(pulumi.StringPtrOutput)
}

// Web UI address
func (o ManagedPublicEndpointsOutput) WebUiAddress() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedPublicEndpoints) pulumi.StringPtrOutput { return v.WebUiAddress }).(pulumi.StringPtrOutput)
}

type ManagedPublicEndpointsArrayOutput struct{ *pulumi.OutputState }

func (ManagedPublicEndpointsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedPublicEndpoints)(nil)).Elem()
}

func (o ManagedPublicEndpointsArrayOutput) ToManagedPublicEndpointsArrayOutput() ManagedPublicEndpointsArrayOutput {
	return o
}

func (o ManagedPublicEndpointsArrayOutput) ToManagedPublicEndpointsArrayOutputWithContext(ctx context.Context) ManagedPublicEndpointsArrayOutput {
	return o
}

func (o ManagedPublicEndpointsArrayOutput) Index(i pulumi.IntInput) ManagedPublicEndpointsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ManagedPublicEndpoints {
		return vs[0].([]*ManagedPublicEndpoints)[vs[1].(int)]
	}).(ManagedPublicEndpointsOutput)
}

type ManagedPublicEndpointsMapOutput struct{ *pulumi.OutputState }

func (ManagedPublicEndpointsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedPublicEndpoints)(nil)).Elem()
}

func (o ManagedPublicEndpointsMapOutput) ToManagedPublicEndpointsMapOutput() ManagedPublicEndpointsMapOutput {
	return o
}

func (o ManagedPublicEndpointsMapOutput) ToManagedPublicEndpointsMapOutputWithContext(ctx context.Context) ManagedPublicEndpointsMapOutput {
	return o
}

func (o ManagedPublicEndpointsMapOutput) MapIndex(k pulumi.StringInput) ManagedPublicEndpointsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ManagedPublicEndpoints {
		return vs[0].(map[string]*ManagedPublicEndpoints)[vs[1].(string)]
	}).(ManagedPublicEndpointsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedPublicEndpointsInput)(nil)).Elem(), &ManagedPublicEndpoints{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedPublicEndpointsArrayInput)(nil)).Elem(), ManagedPublicEndpointsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedPublicEndpointsMapInput)(nil)).Elem(), ManagedPublicEndpointsMap{})
	pulumi.RegisterOutputType(ManagedPublicEndpointsOutput{})
	pulumi.RegisterOutputType(ManagedPublicEndpointsArrayOutput{})
	pulumi.RegisterOutputType(ManagedPublicEndpointsMapOutput{})
}
