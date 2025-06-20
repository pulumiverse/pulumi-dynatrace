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

type MobileAppEnablement struct {
	pulumi.CustomResourceState

	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrOutput `pulumi:"applicationId"`
	// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
	Rum MobileAppEnablementRumOutput `pulumi:"rum"`
	// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
	SessionReplay MobileAppEnablementSessionReplayOutput `pulumi:"sessionReplay"`
}

// NewMobileAppEnablement registers a new resource with the given unique name, arguments, and options.
func NewMobileAppEnablement(ctx *pulumi.Context,
	name string, args *MobileAppEnablementArgs, opts ...pulumi.ResourceOption) (*MobileAppEnablement, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Rum == nil {
		return nil, errors.New("invalid value for required argument 'Rum'")
	}
	if args.SessionReplay == nil {
		return nil, errors.New("invalid value for required argument 'SessionReplay'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MobileAppEnablement
	err := ctx.RegisterResource("dynatrace:index/mobileAppEnablement:MobileAppEnablement", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMobileAppEnablement gets an existing MobileAppEnablement resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMobileAppEnablement(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MobileAppEnablementState, opts ...pulumi.ResourceOption) (*MobileAppEnablement, error) {
	var resource MobileAppEnablement
	err := ctx.ReadResource("dynatrace:index/mobileAppEnablement:MobileAppEnablement", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MobileAppEnablement resources.
type mobileAppEnablementState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId *string `pulumi:"applicationId"`
	// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
	Rum *MobileAppEnablementRum `pulumi:"rum"`
	// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
	SessionReplay *MobileAppEnablementSessionReplay `pulumi:"sessionReplay"`
}

type MobileAppEnablementState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrInput
	// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
	Rum MobileAppEnablementRumPtrInput
	// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
	SessionReplay MobileAppEnablementSessionReplayPtrInput
}

func (MobileAppEnablementState) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileAppEnablementState)(nil)).Elem()
}

type mobileAppEnablementArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId *string `pulumi:"applicationId"`
	// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
	Rum MobileAppEnablementRum `pulumi:"rum"`
	// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
	SessionReplay MobileAppEnablementSessionReplay `pulumi:"sessionReplay"`
}

// The set of arguments for constructing a MobileAppEnablement resource.
type MobileAppEnablementArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrInput
	// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
	Rum MobileAppEnablementRumInput
	// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
	SessionReplay MobileAppEnablementSessionReplayInput
}

func (MobileAppEnablementArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileAppEnablementArgs)(nil)).Elem()
}

type MobileAppEnablementInput interface {
	pulumi.Input

	ToMobileAppEnablementOutput() MobileAppEnablementOutput
	ToMobileAppEnablementOutputWithContext(ctx context.Context) MobileAppEnablementOutput
}

func (*MobileAppEnablement) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileAppEnablement)(nil)).Elem()
}

func (i *MobileAppEnablement) ToMobileAppEnablementOutput() MobileAppEnablementOutput {
	return i.ToMobileAppEnablementOutputWithContext(context.Background())
}

func (i *MobileAppEnablement) ToMobileAppEnablementOutputWithContext(ctx context.Context) MobileAppEnablementOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppEnablementOutput)
}

// MobileAppEnablementArrayInput is an input type that accepts MobileAppEnablementArray and MobileAppEnablementArrayOutput values.
// You can construct a concrete instance of `MobileAppEnablementArrayInput` via:
//
//	MobileAppEnablementArray{ MobileAppEnablementArgs{...} }
type MobileAppEnablementArrayInput interface {
	pulumi.Input

	ToMobileAppEnablementArrayOutput() MobileAppEnablementArrayOutput
	ToMobileAppEnablementArrayOutputWithContext(context.Context) MobileAppEnablementArrayOutput
}

type MobileAppEnablementArray []MobileAppEnablementInput

func (MobileAppEnablementArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileAppEnablement)(nil)).Elem()
}

func (i MobileAppEnablementArray) ToMobileAppEnablementArrayOutput() MobileAppEnablementArrayOutput {
	return i.ToMobileAppEnablementArrayOutputWithContext(context.Background())
}

func (i MobileAppEnablementArray) ToMobileAppEnablementArrayOutputWithContext(ctx context.Context) MobileAppEnablementArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppEnablementArrayOutput)
}

// MobileAppEnablementMapInput is an input type that accepts MobileAppEnablementMap and MobileAppEnablementMapOutput values.
// You can construct a concrete instance of `MobileAppEnablementMapInput` via:
//
//	MobileAppEnablementMap{ "key": MobileAppEnablementArgs{...} }
type MobileAppEnablementMapInput interface {
	pulumi.Input

	ToMobileAppEnablementMapOutput() MobileAppEnablementMapOutput
	ToMobileAppEnablementMapOutputWithContext(context.Context) MobileAppEnablementMapOutput
}

type MobileAppEnablementMap map[string]MobileAppEnablementInput

func (MobileAppEnablementMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileAppEnablement)(nil)).Elem()
}

func (i MobileAppEnablementMap) ToMobileAppEnablementMapOutput() MobileAppEnablementMapOutput {
	return i.ToMobileAppEnablementMapOutputWithContext(context.Background())
}

func (i MobileAppEnablementMap) ToMobileAppEnablementMapOutputWithContext(ctx context.Context) MobileAppEnablementMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileAppEnablementMapOutput)
}

type MobileAppEnablementOutput struct{ *pulumi.OutputState }

func (MobileAppEnablementOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileAppEnablement)(nil)).Elem()
}

func (o MobileAppEnablementOutput) ToMobileAppEnablementOutput() MobileAppEnablementOutput {
	return o
}

func (o MobileAppEnablementOutput) ToMobileAppEnablementOutputWithContext(ctx context.Context) MobileAppEnablementOutput {
	return o
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o MobileAppEnablementOutput) ApplicationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MobileAppEnablement) pulumi.StringPtrOutput { return v.ApplicationId }).(pulumi.StringPtrOutput)
}

// (Field has overlap with `MobileApplication`) Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
func (o MobileAppEnablementOutput) Rum() MobileAppEnablementRumOutput {
	return o.ApplyT(func(v *MobileAppEnablement) MobileAppEnablementRumOutput { return v.Rum }).(MobileAppEnablementRumOutput)
}

// (Field has overlap with `MobileApplication`) [Session Replay on crashes](https://dt-url.net/session-replay) gives you additional context for crash analysis in the form of video-like screen recordings that replay user actions immediately preceding a detected crash, while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
func (o MobileAppEnablementOutput) SessionReplay() MobileAppEnablementSessionReplayOutput {
	return o.ApplyT(func(v *MobileAppEnablement) MobileAppEnablementSessionReplayOutput { return v.SessionReplay }).(MobileAppEnablementSessionReplayOutput)
}

type MobileAppEnablementArrayOutput struct{ *pulumi.OutputState }

func (MobileAppEnablementArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileAppEnablement)(nil)).Elem()
}

func (o MobileAppEnablementArrayOutput) ToMobileAppEnablementArrayOutput() MobileAppEnablementArrayOutput {
	return o
}

func (o MobileAppEnablementArrayOutput) ToMobileAppEnablementArrayOutputWithContext(ctx context.Context) MobileAppEnablementArrayOutput {
	return o
}

func (o MobileAppEnablementArrayOutput) Index(i pulumi.IntInput) MobileAppEnablementOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MobileAppEnablement {
		return vs[0].([]*MobileAppEnablement)[vs[1].(int)]
	}).(MobileAppEnablementOutput)
}

type MobileAppEnablementMapOutput struct{ *pulumi.OutputState }

func (MobileAppEnablementMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileAppEnablement)(nil)).Elem()
}

func (o MobileAppEnablementMapOutput) ToMobileAppEnablementMapOutput() MobileAppEnablementMapOutput {
	return o
}

func (o MobileAppEnablementMapOutput) ToMobileAppEnablementMapOutputWithContext(ctx context.Context) MobileAppEnablementMapOutput {
	return o
}

func (o MobileAppEnablementMapOutput) MapIndex(k pulumi.StringInput) MobileAppEnablementOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MobileAppEnablement {
		return vs[0].(map[string]*MobileAppEnablement)[vs[1].(string)]
	}).(MobileAppEnablementOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppEnablementInput)(nil)).Elem(), &MobileAppEnablement{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppEnablementArrayInput)(nil)).Elem(), MobileAppEnablementArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileAppEnablementMapInput)(nil)).Elem(), MobileAppEnablementMap{})
	pulumi.RegisterOutputType(MobileAppEnablementOutput{})
	pulumi.RegisterOutputType(MobileAppEnablementArrayOutput{})
	pulumi.RegisterOutputType(MobileAppEnablementMapOutput{})
}
