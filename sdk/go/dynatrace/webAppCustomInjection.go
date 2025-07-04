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

type WebAppCustomInjection struct {
	pulumi.CustomResourceState

	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringOutput `pulumi:"applicationId"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// no documentation available
	HtmlPattern pulumi.StringPtrOutput `pulumi:"htmlPattern"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
	Operator pulumi.StringOutput `pulumi:"operator"`
	// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
	Rule pulumi.StringOutput `pulumi:"rule"`
	// URL pattern
	UrlPattern pulumi.StringPtrOutput `pulumi:"urlPattern"`
}

// NewWebAppCustomInjection registers a new resource with the given unique name, arguments, and options.
func NewWebAppCustomInjection(ctx *pulumi.Context,
	name string, args *WebAppCustomInjectionArgs, opts ...pulumi.ResourceOption) (*WebAppCustomInjection, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApplicationId == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationId'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.Operator == nil {
		return nil, errors.New("invalid value for required argument 'Operator'")
	}
	if args.Rule == nil {
		return nil, errors.New("invalid value for required argument 'Rule'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource WebAppCustomInjection
	err := ctx.RegisterResource("dynatrace:index/webAppCustomInjection:WebAppCustomInjection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppCustomInjection gets an existing WebAppCustomInjection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppCustomInjection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppCustomInjectionState, opts ...pulumi.ResourceOption) (*WebAppCustomInjection, error) {
	var resource WebAppCustomInjection
	err := ctx.ReadResource("dynatrace:index/webAppCustomInjection:WebAppCustomInjection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppCustomInjection resources.
type webAppCustomInjectionState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId *string `pulumi:"applicationId"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// no documentation available
	HtmlPattern *string `pulumi:"htmlPattern"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
	Operator *string `pulumi:"operator"`
	// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
	Rule *string `pulumi:"rule"`
	// URL pattern
	UrlPattern *string `pulumi:"urlPattern"`
}

type WebAppCustomInjectionState struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// no documentation available
	HtmlPattern pulumi.StringPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
	Operator pulumi.StringPtrInput
	// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
	Rule pulumi.StringPtrInput
	// URL pattern
	UrlPattern pulumi.StringPtrInput
}

func (WebAppCustomInjectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppCustomInjectionState)(nil)).Elem()
}

type webAppCustomInjectionArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId string `pulumi:"applicationId"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// no documentation available
	HtmlPattern *string `pulumi:"htmlPattern"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
	Operator string `pulumi:"operator"`
	// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
	Rule string `pulumi:"rule"`
	// URL pattern
	UrlPattern *string `pulumi:"urlPattern"`
}

// The set of arguments for constructing a WebAppCustomInjection resource.
type WebAppCustomInjectionArgs struct {
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ApplicationId pulumi.StringInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// no documentation available
	HtmlPattern pulumi.StringPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
	Operator pulumi.StringInput
	// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
	Rule pulumi.StringInput
	// URL pattern
	UrlPattern pulumi.StringPtrInput
}

func (WebAppCustomInjectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppCustomInjectionArgs)(nil)).Elem()
}

type WebAppCustomInjectionInput interface {
	pulumi.Input

	ToWebAppCustomInjectionOutput() WebAppCustomInjectionOutput
	ToWebAppCustomInjectionOutputWithContext(ctx context.Context) WebAppCustomInjectionOutput
}

func (*WebAppCustomInjection) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppCustomInjection)(nil)).Elem()
}

func (i *WebAppCustomInjection) ToWebAppCustomInjectionOutput() WebAppCustomInjectionOutput {
	return i.ToWebAppCustomInjectionOutputWithContext(context.Background())
}

func (i *WebAppCustomInjection) ToWebAppCustomInjectionOutputWithContext(ctx context.Context) WebAppCustomInjectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomInjectionOutput)
}

// WebAppCustomInjectionArrayInput is an input type that accepts WebAppCustomInjectionArray and WebAppCustomInjectionArrayOutput values.
// You can construct a concrete instance of `WebAppCustomInjectionArrayInput` via:
//
//	WebAppCustomInjectionArray{ WebAppCustomInjectionArgs{...} }
type WebAppCustomInjectionArrayInput interface {
	pulumi.Input

	ToWebAppCustomInjectionArrayOutput() WebAppCustomInjectionArrayOutput
	ToWebAppCustomInjectionArrayOutputWithContext(context.Context) WebAppCustomInjectionArrayOutput
}

type WebAppCustomInjectionArray []WebAppCustomInjectionInput

func (WebAppCustomInjectionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppCustomInjection)(nil)).Elem()
}

func (i WebAppCustomInjectionArray) ToWebAppCustomInjectionArrayOutput() WebAppCustomInjectionArrayOutput {
	return i.ToWebAppCustomInjectionArrayOutputWithContext(context.Background())
}

func (i WebAppCustomInjectionArray) ToWebAppCustomInjectionArrayOutputWithContext(ctx context.Context) WebAppCustomInjectionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomInjectionArrayOutput)
}

// WebAppCustomInjectionMapInput is an input type that accepts WebAppCustomInjectionMap and WebAppCustomInjectionMapOutput values.
// You can construct a concrete instance of `WebAppCustomInjectionMapInput` via:
//
//	WebAppCustomInjectionMap{ "key": WebAppCustomInjectionArgs{...} }
type WebAppCustomInjectionMapInput interface {
	pulumi.Input

	ToWebAppCustomInjectionMapOutput() WebAppCustomInjectionMapOutput
	ToWebAppCustomInjectionMapOutputWithContext(context.Context) WebAppCustomInjectionMapOutput
}

type WebAppCustomInjectionMap map[string]WebAppCustomInjectionInput

func (WebAppCustomInjectionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppCustomInjection)(nil)).Elem()
}

func (i WebAppCustomInjectionMap) ToWebAppCustomInjectionMapOutput() WebAppCustomInjectionMapOutput {
	return i.ToWebAppCustomInjectionMapOutputWithContext(context.Background())
}

func (i WebAppCustomInjectionMap) ToWebAppCustomInjectionMapOutputWithContext(ctx context.Context) WebAppCustomInjectionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomInjectionMapOutput)
}

type WebAppCustomInjectionOutput struct{ *pulumi.OutputState }

func (WebAppCustomInjectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppCustomInjection)(nil)).Elem()
}

func (o WebAppCustomInjectionOutput) ToWebAppCustomInjectionOutput() WebAppCustomInjectionOutput {
	return o
}

func (o WebAppCustomInjectionOutput) ToWebAppCustomInjectionOutputWithContext(ctx context.Context) WebAppCustomInjectionOutput {
	return o
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o WebAppCustomInjectionOutput) ApplicationId() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringOutput { return v.ApplicationId }).(pulumi.StringOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o WebAppCustomInjectionOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// no documentation available
func (o WebAppCustomInjectionOutput) HtmlPattern() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringPtrOutput { return v.HtmlPattern }).(pulumi.StringPtrOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o WebAppCustomInjectionOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// Possible Values: `AllPages`, `Contains`, `Ends`, `Equals`, `Starts`
func (o WebAppCustomInjectionOutput) Operator() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringOutput { return v.Operator }).(pulumi.StringOutput)
}

// Possible Values: `AfterSpecificHtml`, `Automatic`, `BeforeSpecificHtml`, `DoNotInject`
func (o WebAppCustomInjectionOutput) Rule() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringOutput { return v.Rule }).(pulumi.StringOutput)
}

// URL pattern
func (o WebAppCustomInjectionOutput) UrlPattern() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WebAppCustomInjection) pulumi.StringPtrOutput { return v.UrlPattern }).(pulumi.StringPtrOutput)
}

type WebAppCustomInjectionArrayOutput struct{ *pulumi.OutputState }

func (WebAppCustomInjectionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppCustomInjection)(nil)).Elem()
}

func (o WebAppCustomInjectionArrayOutput) ToWebAppCustomInjectionArrayOutput() WebAppCustomInjectionArrayOutput {
	return o
}

func (o WebAppCustomInjectionArrayOutput) ToWebAppCustomInjectionArrayOutputWithContext(ctx context.Context) WebAppCustomInjectionArrayOutput {
	return o
}

func (o WebAppCustomInjectionArrayOutput) Index(i pulumi.IntInput) WebAppCustomInjectionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WebAppCustomInjection {
		return vs[0].([]*WebAppCustomInjection)[vs[1].(int)]
	}).(WebAppCustomInjectionOutput)
}

type WebAppCustomInjectionMapOutput struct{ *pulumi.OutputState }

func (WebAppCustomInjectionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppCustomInjection)(nil)).Elem()
}

func (o WebAppCustomInjectionMapOutput) ToWebAppCustomInjectionMapOutput() WebAppCustomInjectionMapOutput {
	return o
}

func (o WebAppCustomInjectionMapOutput) ToWebAppCustomInjectionMapOutputWithContext(ctx context.Context) WebAppCustomInjectionMapOutput {
	return o
}

func (o WebAppCustomInjectionMapOutput) MapIndex(k pulumi.StringInput) WebAppCustomInjectionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WebAppCustomInjection {
		return vs[0].(map[string]*WebAppCustomInjection)[vs[1].(string)]
	}).(WebAppCustomInjectionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomInjectionInput)(nil)).Elem(), &WebAppCustomInjection{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomInjectionArrayInput)(nil)).Elem(), WebAppCustomInjectionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomInjectionMapInput)(nil)).Elem(), WebAppCustomInjectionMap{})
	pulumi.RegisterOutputType(WebAppCustomInjectionOutput{})
	pulumi.RegisterOutputType(WebAppCustomInjectionArrayOutput{})
	pulumi.RegisterOutputType(WebAppCustomInjectionMapOutput{})
}
