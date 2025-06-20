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

type UsabilityAnalytics struct {
	pulumi.CustomResourceState

	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrOutput `pulumi:"applicationId"`
	// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
	// With this setting enabled, a rage click count is compiled for each monitored user session.
	DetectRageClicks pulumi.BoolOutput `pulumi:"detectRageClicks"`
}

// NewUsabilityAnalytics registers a new resource with the given unique name, arguments, and options.
func NewUsabilityAnalytics(ctx *pulumi.Context,
	name string, args *UsabilityAnalyticsArgs, opts ...pulumi.ResourceOption) (*UsabilityAnalytics, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DetectRageClicks == nil {
		return nil, errors.New("invalid value for required argument 'DetectRageClicks'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource UsabilityAnalytics
	err := ctx.RegisterResource("dynatrace:index/usabilityAnalytics:UsabilityAnalytics", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUsabilityAnalytics gets an existing UsabilityAnalytics resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUsabilityAnalytics(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UsabilityAnalyticsState, opts ...pulumi.ResourceOption) (*UsabilityAnalytics, error) {
	var resource UsabilityAnalytics
	err := ctx.ReadResource("dynatrace:index/usabilityAnalytics:UsabilityAnalytics", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering UsabilityAnalytics resources.
type usabilityAnalyticsState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId *string `pulumi:"applicationId"`
	// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
	// With this setting enabled, a rage click count is compiled for each monitored user session.
	DetectRageClicks *bool `pulumi:"detectRageClicks"`
}

type UsabilityAnalyticsState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrInput
	// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
	// With this setting enabled, a rage click count is compiled for each monitored user session.
	DetectRageClicks pulumi.BoolPtrInput
}

func (UsabilityAnalyticsState) ElementType() reflect.Type {
	return reflect.TypeOf((*usabilityAnalyticsState)(nil)).Elem()
}

type usabilityAnalyticsArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId *string `pulumi:"applicationId"`
	// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
	// With this setting enabled, a rage click count is compiled for each monitored user session.
	DetectRageClicks bool `pulumi:"detectRageClicks"`
}

// The set of arguments for constructing a UsabilityAnalytics resource.
type UsabilityAnalyticsArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrInput
	// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
	// With this setting enabled, a rage click count is compiled for each monitored user session.
	DetectRageClicks pulumi.BoolInput
}

func (UsabilityAnalyticsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*usabilityAnalyticsArgs)(nil)).Elem()
}

type UsabilityAnalyticsInput interface {
	pulumi.Input

	ToUsabilityAnalyticsOutput() UsabilityAnalyticsOutput
	ToUsabilityAnalyticsOutputWithContext(ctx context.Context) UsabilityAnalyticsOutput
}

func (*UsabilityAnalytics) ElementType() reflect.Type {
	return reflect.TypeOf((**UsabilityAnalytics)(nil)).Elem()
}

func (i *UsabilityAnalytics) ToUsabilityAnalyticsOutput() UsabilityAnalyticsOutput {
	return i.ToUsabilityAnalyticsOutputWithContext(context.Background())
}

func (i *UsabilityAnalytics) ToUsabilityAnalyticsOutputWithContext(ctx context.Context) UsabilityAnalyticsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UsabilityAnalyticsOutput)
}

// UsabilityAnalyticsArrayInput is an input type that accepts UsabilityAnalyticsArray and UsabilityAnalyticsArrayOutput values.
// You can construct a concrete instance of `UsabilityAnalyticsArrayInput` via:
//
//	UsabilityAnalyticsArray{ UsabilityAnalyticsArgs{...} }
type UsabilityAnalyticsArrayInput interface {
	pulumi.Input

	ToUsabilityAnalyticsArrayOutput() UsabilityAnalyticsArrayOutput
	ToUsabilityAnalyticsArrayOutputWithContext(context.Context) UsabilityAnalyticsArrayOutput
}

type UsabilityAnalyticsArray []UsabilityAnalyticsInput

func (UsabilityAnalyticsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*UsabilityAnalytics)(nil)).Elem()
}

func (i UsabilityAnalyticsArray) ToUsabilityAnalyticsArrayOutput() UsabilityAnalyticsArrayOutput {
	return i.ToUsabilityAnalyticsArrayOutputWithContext(context.Background())
}

func (i UsabilityAnalyticsArray) ToUsabilityAnalyticsArrayOutputWithContext(ctx context.Context) UsabilityAnalyticsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UsabilityAnalyticsArrayOutput)
}

// UsabilityAnalyticsMapInput is an input type that accepts UsabilityAnalyticsMap and UsabilityAnalyticsMapOutput values.
// You can construct a concrete instance of `UsabilityAnalyticsMapInput` via:
//
//	UsabilityAnalyticsMap{ "key": UsabilityAnalyticsArgs{...} }
type UsabilityAnalyticsMapInput interface {
	pulumi.Input

	ToUsabilityAnalyticsMapOutput() UsabilityAnalyticsMapOutput
	ToUsabilityAnalyticsMapOutputWithContext(context.Context) UsabilityAnalyticsMapOutput
}

type UsabilityAnalyticsMap map[string]UsabilityAnalyticsInput

func (UsabilityAnalyticsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*UsabilityAnalytics)(nil)).Elem()
}

func (i UsabilityAnalyticsMap) ToUsabilityAnalyticsMapOutput() UsabilityAnalyticsMapOutput {
	return i.ToUsabilityAnalyticsMapOutputWithContext(context.Background())
}

func (i UsabilityAnalyticsMap) ToUsabilityAnalyticsMapOutputWithContext(ctx context.Context) UsabilityAnalyticsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UsabilityAnalyticsMapOutput)
}

type UsabilityAnalyticsOutput struct{ *pulumi.OutputState }

func (UsabilityAnalyticsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**UsabilityAnalytics)(nil)).Elem()
}

func (o UsabilityAnalyticsOutput) ToUsabilityAnalyticsOutput() UsabilityAnalyticsOutput {
	return o
}

func (o UsabilityAnalyticsOutput) ToUsabilityAnalyticsOutputWithContext(ctx context.Context) UsabilityAnalyticsOutput {
	return o
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o UsabilityAnalyticsOutput) ApplicationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *UsabilityAnalytics) pulumi.StringPtrOutput { return v.ApplicationId }).(pulumi.StringPtrOutput)
}

// Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
// With this setting enabled, a rage click count is compiled for each monitored user session.
func (o UsabilityAnalyticsOutput) DetectRageClicks() pulumi.BoolOutput {
	return o.ApplyT(func(v *UsabilityAnalytics) pulumi.BoolOutput { return v.DetectRageClicks }).(pulumi.BoolOutput)
}

type UsabilityAnalyticsArrayOutput struct{ *pulumi.OutputState }

func (UsabilityAnalyticsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*UsabilityAnalytics)(nil)).Elem()
}

func (o UsabilityAnalyticsArrayOutput) ToUsabilityAnalyticsArrayOutput() UsabilityAnalyticsArrayOutput {
	return o
}

func (o UsabilityAnalyticsArrayOutput) ToUsabilityAnalyticsArrayOutputWithContext(ctx context.Context) UsabilityAnalyticsArrayOutput {
	return o
}

func (o UsabilityAnalyticsArrayOutput) Index(i pulumi.IntInput) UsabilityAnalyticsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *UsabilityAnalytics {
		return vs[0].([]*UsabilityAnalytics)[vs[1].(int)]
	}).(UsabilityAnalyticsOutput)
}

type UsabilityAnalyticsMapOutput struct{ *pulumi.OutputState }

func (UsabilityAnalyticsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*UsabilityAnalytics)(nil)).Elem()
}

func (o UsabilityAnalyticsMapOutput) ToUsabilityAnalyticsMapOutput() UsabilityAnalyticsMapOutput {
	return o
}

func (o UsabilityAnalyticsMapOutput) ToUsabilityAnalyticsMapOutputWithContext(ctx context.Context) UsabilityAnalyticsMapOutput {
	return o
}

func (o UsabilityAnalyticsMapOutput) MapIndex(k pulumi.StringInput) UsabilityAnalyticsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *UsabilityAnalytics {
		return vs[0].(map[string]*UsabilityAnalytics)[vs[1].(string)]
	}).(UsabilityAnalyticsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*UsabilityAnalyticsInput)(nil)).Elem(), &UsabilityAnalytics{})
	pulumi.RegisterInputType(reflect.TypeOf((*UsabilityAnalyticsArrayInput)(nil)).Elem(), UsabilityAnalyticsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*UsabilityAnalyticsMapInput)(nil)).Elem(), UsabilityAnalyticsMap{})
	pulumi.RegisterOutputType(UsabilityAnalyticsOutput{})
	pulumi.RegisterOutputType(UsabilityAnalyticsArrayOutput{})
	pulumi.RegisterOutputType(UsabilityAnalyticsMapOutput{})
}
