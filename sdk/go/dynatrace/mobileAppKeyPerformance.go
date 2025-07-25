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

type MobileAppKeyPerformance struct {
	pulumi.CustomResourceState

	// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
	FrustratingIfReportedOrWebRequestError pulumi.BoolOutput `pulumi:"frustratingIfReportedOrWebRequestError"`
	// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
	Scope pulumi.StringOutput `pulumi:"scope"`
	// no documentation available
	Thresholds MobileAppKeyPerformanceThresholdsOutput `pulumi:"thresholds"`
}

// NewMobileAppKeyPerformance registers a new resource with the given unique name, arguments, and options.
func NewMobileAppKeyPerformance(ctx *pulumi.Context,
	name string, args *MobileAppKeyPerformanceArgs, opts ...pulumi.ResourceOption) (*MobileAppKeyPerformance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FrustratingIfReportedOrWebRequestError == nil {
		return nil, errors.New("invalid value for required argument 'FrustratingIfReportedOrWebRequestError'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	if args.Thresholds == nil {
		return nil, errors.New("invalid value for required argument 'Thresholds'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MobileAppKeyPerformance
	err := ctx.RegisterResource("dynatrace:index/mobileAppKeyPerformance:MobileAppKeyPerformance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMobileAppKeyPerformance gets an existing MobileAppKeyPerformance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMobileAppKeyPerformance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MobileAppKeyPerformanceState, opts ...pulumi.ResourceOption) (*MobileAppKeyPerformance, error) {
	var resource MobileAppKeyPerformance
	err := ctx.ReadResource("dynatrace:index/mobileAppKeyPerformance:MobileAppKeyPerformance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MobileAppKeyPerformance resources.
type mobileAppKeyPerformanceState struct {
	// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
	FrustratingIfReportedOrWebRequestError *bool `pulumi:"frustratingIfReportedOrWebRequestError"`
	// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
	Scope *string `pulumi:"scope"`
	// no documentation available
	Thresholds *MobileAppKeyPerformanceThresholds `pulumi:"thresholds"`
}

type MobileAppKeyPerformanceState struct {
	// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
	FrustratingIfReportedOrWebRequestError pulumi.BoolPtrInput
	// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
	Scope pulumi.StringPtrInput
	// no documentation available
	Thresholds MobileAppKeyPerformanceThresholdsPtrInput
}

func (MobileAppKeyPerformanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileAppKeyPerformanceState)(nil)).Elem()
}

type mobileAppKeyPerformanceArgs struct {
	// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
	FrustratingIfReportedOrWebRequestError bool `pulumi:"frustratingIfReportedOrWebRequestError"`
	// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
	Scope string `pulumi:"scope"`
	// no documentation available
	Thresholds MobileAppKeyPerformanceThresholds `pulumi:"thresholds"`
}

// The set of arguments for constructing a MobileAppKeyPerformance resource.
type MobileAppKeyPerformanceArgs struct {
	// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
	FrustratingIfReportedOrWebRequestError pulumi.BoolInput
	// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
	Scope pulumi.StringInput
	// no documentation available
	Thresholds MobileAppKeyPerformanceThresholdsInput
}

func (MobileAppKeyPerformanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileAppKeyPerformanceArgs)(nil)).Elem()
}

type MobileAppKeyPerformanceInput interface {
	pulumi.Input

	ToMobileAppKeyPerformanceOutput() MobileAppKeyPerformanceOutput
	ToMobileAppKeyPerformanceOutputWithContext(ctx context.Context) MobileAppKeyPerformanceOutput
}

func (*MobileAppKeyPerformance) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileAppKeyPerformance)(nil)).Elem()
}

func (i *MobileAppKeyPerformance) ToMobileAppKeyPerformanceOutput() MobileAppKeyPerformanceOutput {
	return i.ToMobileAppKeyPerformanceOutputWithContext(context.Background())
}

func (i *MobileAppKeyPerformance) ToMobileAppKeyPerformanceOutputWithContext(ctx context.Context) MobileAppKeyPerformanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppKeyPerformanceOutput)
}

// MobileAppKeyPerformanceArrayInput is an input type that accepts MobileAppKeyPerformanceArray and MobileAppKeyPerformanceArrayOutput values.
// You can construct a concrete instance of `MobileAppKeyPerformanceArrayInput` via:
//
//	MobileAppKeyPerformanceArray{ MobileAppKeyPerformanceArgs{...} }
type MobileAppKeyPerformanceArrayInput interface {
	pulumi.Input

	ToMobileAppKeyPerformanceArrayOutput() MobileAppKeyPerformanceArrayOutput
	ToMobileAppKeyPerformanceArrayOutputWithContext(context.Context) MobileAppKeyPerformanceArrayOutput
}

type MobileAppKeyPerformanceArray []MobileAppKeyPerformanceInput

func (MobileAppKeyPerformanceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileAppKeyPerformance)(nil)).Elem()
}

func (i MobileAppKeyPerformanceArray) ToMobileAppKeyPerformanceArrayOutput() MobileAppKeyPerformanceArrayOutput {
	return i.ToMobileAppKeyPerformanceArrayOutputWithContext(context.Background())
}

func (i MobileAppKeyPerformanceArray) ToMobileAppKeyPerformanceArrayOutputWithContext(ctx context.Context) MobileAppKeyPerformanceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppKeyPerformanceArrayOutput)
}

// MobileAppKeyPerformanceMapInput is an input type that accepts MobileAppKeyPerformanceMap and MobileAppKeyPerformanceMapOutput values.
// You can construct a concrete instance of `MobileAppKeyPerformanceMapInput` via:
//
//	MobileAppKeyPerformanceMap{ "key": MobileAppKeyPerformanceArgs{...} }
type MobileAppKeyPerformanceMapInput interface {
	pulumi.Input

	ToMobileAppKeyPerformanceMapOutput() MobileAppKeyPerformanceMapOutput
	ToMobileAppKeyPerformanceMapOutputWithContext(context.Context) MobileAppKeyPerformanceMapOutput
}

type MobileAppKeyPerformanceMap map[string]MobileAppKeyPerformanceInput

func (MobileAppKeyPerformanceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileAppKeyPerformance)(nil)).Elem()
}

func (i MobileAppKeyPerformanceMap) ToMobileAppKeyPerformanceMapOutput() MobileAppKeyPerformanceMapOutput {
	return i.ToMobileAppKeyPerformanceMapOutputWithContext(context.Background())
}

func (i MobileAppKeyPerformanceMap) ToMobileAppKeyPerformanceMapOutputWithContext(ctx context.Context) MobileAppKeyPerformanceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppKeyPerformanceMapOutput)
}

type MobileAppKeyPerformanceOutput struct{ *pulumi.OutputState }

func (MobileAppKeyPerformanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileAppKeyPerformance)(nil)).Elem()
}

func (o MobileAppKeyPerformanceOutput) ToMobileAppKeyPerformanceOutput() MobileAppKeyPerformanceOutput {
	return o
}

func (o MobileAppKeyPerformanceOutput) ToMobileAppKeyPerformanceOutputWithContext(ctx context.Context) MobileAppKeyPerformanceOutput {
	return o
}

// Treat user actions with reported errors or web request errors as erroneous and rate their performance as Frustrating. Turn off this setting if errors should not affect the Apdex rate.
func (o MobileAppKeyPerformanceOutput) FrustratingIfReportedOrWebRequestError() pulumi.BoolOutput {
	return o.ApplyT(func(v *MobileAppKeyPerformance) pulumi.BoolOutput { return v.FrustratingIfReportedOrWebRequestError }).(pulumi.BoolOutput)
}

// The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE*APPLICATION, CUSTOM*APPLICATION)
func (o MobileAppKeyPerformanceOutput) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *MobileAppKeyPerformance) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

// no documentation available
func (o MobileAppKeyPerformanceOutput) Thresholds() MobileAppKeyPerformanceThresholdsOutput {
	return o.ApplyT(func(v *MobileAppKeyPerformance) MobileAppKeyPerformanceThresholdsOutput { return v.Thresholds }).(MobileAppKeyPerformanceThresholdsOutput)
}

type MobileAppKeyPerformanceArrayOutput struct{ *pulumi.OutputState }

func (MobileAppKeyPerformanceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileAppKeyPerformance)(nil)).Elem()
}

func (o MobileAppKeyPerformanceArrayOutput) ToMobileAppKeyPerformanceArrayOutput() MobileAppKeyPerformanceArrayOutput {
	return o
}

func (o MobileAppKeyPerformanceArrayOutput) ToMobileAppKeyPerformanceArrayOutputWithContext(ctx context.Context) MobileAppKeyPerformanceArrayOutput {
	return o
}

func (o MobileAppKeyPerformanceArrayOutput) Index(i pulumi.IntInput) MobileAppKeyPerformanceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MobileAppKeyPerformance {
		return vs[0].([]*MobileAppKeyPerformance)[vs[1].(int)]
	}).(MobileAppKeyPerformanceOutput)
}

type MobileAppKeyPerformanceMapOutput struct{ *pulumi.OutputState }

func (MobileAppKeyPerformanceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileAppKeyPerformance)(nil)).Elem()
}

func (o MobileAppKeyPerformanceMapOutput) ToMobileAppKeyPerformanceMapOutput() MobileAppKeyPerformanceMapOutput {
	return o
}

func (o MobileAppKeyPerformanceMapOutput) ToMobileAppKeyPerformanceMapOutputWithContext(ctx context.Context) MobileAppKeyPerformanceMapOutput {
	return o
}

func (o MobileAppKeyPerformanceMapOutput) MapIndex(k pulumi.StringInput) MobileAppKeyPerformanceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MobileAppKeyPerformance {
		return vs[0].(map[string]*MobileAppKeyPerformance)[vs[1].(string)]
	}).(MobileAppKeyPerformanceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppKeyPerformanceInput)(nil)).Elem(), &MobileAppKeyPerformance{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppKeyPerformanceArrayInput)(nil)).Elem(), MobileAppKeyPerformanceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppKeyPerformanceMapInput)(nil)).Elem(), MobileAppKeyPerformanceMap{})
	pulumi.RegisterOutputType(MobileAppKeyPerformanceOutput{})
	pulumi.RegisterOutputType(MobileAppKeyPerformanceArrayOutput{})
	pulumi.RegisterOutputType(MobileAppKeyPerformanceMapOutput{})
}
