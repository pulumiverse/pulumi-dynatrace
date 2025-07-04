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

// > This resource requires the API token scopes **Read settings** (`settings.read`) and **Write settings** (`settings.write`)
//
// ## Dynatrace Documentation
//
// - Web applications - https://docs.dynatrace.com/docs/platform-modules/digital-experience/web-applications
//
// - Settings API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/settings (schemaId: `builtin:rum.web.rum-javascript-file-name`)
//
// ## Resource Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := dynatrace.NewWebAppJavascriptFilename(ctx, "#name#", &dynatrace.WebAppJavascriptFilenameArgs{
//				Filename: pulumi.String("tf"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type WebAppJavascriptFilename struct {
	pulumi.CustomResourceState

	// Custom filename prefix
	Filename pulumi.StringOutput `pulumi:"filename"`
}

// NewWebAppJavascriptFilename registers a new resource with the given unique name, arguments, and options.
func NewWebAppJavascriptFilename(ctx *pulumi.Context,
	name string, args *WebAppJavascriptFilenameArgs, opts ...pulumi.ResourceOption) (*WebAppJavascriptFilename, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Filename == nil {
		return nil, errors.New("invalid value for required argument 'Filename'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource WebAppJavascriptFilename
	err := ctx.RegisterResource("dynatrace:index/webAppJavascriptFilename:WebAppJavascriptFilename", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppJavascriptFilename gets an existing WebAppJavascriptFilename resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppJavascriptFilename(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppJavascriptFilenameState, opts ...pulumi.ResourceOption) (*WebAppJavascriptFilename, error) {
	var resource WebAppJavascriptFilename
	err := ctx.ReadResource("dynatrace:index/webAppJavascriptFilename:WebAppJavascriptFilename", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppJavascriptFilename resources.
type webAppJavascriptFilenameState struct {
	// Custom filename prefix
	Filename *string `pulumi:"filename"`
}

type WebAppJavascriptFilenameState struct {
	// Custom filename prefix
	Filename pulumi.StringPtrInput
}

func (WebAppJavascriptFilenameState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppJavascriptFilenameState)(nil)).Elem()
}

type webAppJavascriptFilenameArgs struct {
	// Custom filename prefix
	Filename string `pulumi:"filename"`
}

// The set of arguments for constructing a WebAppJavascriptFilename resource.
type WebAppJavascriptFilenameArgs struct {
	// Custom filename prefix
	Filename pulumi.StringInput
}

func (WebAppJavascriptFilenameArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppJavascriptFilenameArgs)(nil)).Elem()
}

type WebAppJavascriptFilenameInput interface {
	pulumi.Input

	ToWebAppJavascriptFilenameOutput() WebAppJavascriptFilenameOutput
	ToWebAppJavascriptFilenameOutputWithContext(ctx context.Context) WebAppJavascriptFilenameOutput
}

func (*WebAppJavascriptFilename) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppJavascriptFilename)(nil)).Elem()
}

func (i *WebAppJavascriptFilename) ToWebAppJavascriptFilenameOutput() WebAppJavascriptFilenameOutput {
	return i.ToWebAppJavascriptFilenameOutputWithContext(context.Background())
}

func (i *WebAppJavascriptFilename) ToWebAppJavascriptFilenameOutputWithContext(ctx context.Context) WebAppJavascriptFilenameOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppJavascriptFilenameOutput)
}

// WebAppJavascriptFilenameArrayInput is an input type that accepts WebAppJavascriptFilenameArray and WebAppJavascriptFilenameArrayOutput values.
// You can construct a concrete instance of `WebAppJavascriptFilenameArrayInput` via:
//
//	WebAppJavascriptFilenameArray{ WebAppJavascriptFilenameArgs{...} }
type WebAppJavascriptFilenameArrayInput interface {
	pulumi.Input

	ToWebAppJavascriptFilenameArrayOutput() WebAppJavascriptFilenameArrayOutput
	ToWebAppJavascriptFilenameArrayOutputWithContext(context.Context) WebAppJavascriptFilenameArrayOutput
}

type WebAppJavascriptFilenameArray []WebAppJavascriptFilenameInput

func (WebAppJavascriptFilenameArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppJavascriptFilename)(nil)).Elem()
}

func (i WebAppJavascriptFilenameArray) ToWebAppJavascriptFilenameArrayOutput() WebAppJavascriptFilenameArrayOutput {
	return i.ToWebAppJavascriptFilenameArrayOutputWithContext(context.Background())
}

func (i WebAppJavascriptFilenameArray) ToWebAppJavascriptFilenameArrayOutputWithContext(ctx context.Context) WebAppJavascriptFilenameArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppJavascriptFilenameArrayOutput)
}

// WebAppJavascriptFilenameMapInput is an input type that accepts WebAppJavascriptFilenameMap and WebAppJavascriptFilenameMapOutput values.
// You can construct a concrete instance of `WebAppJavascriptFilenameMapInput` via:
//
//	WebAppJavascriptFilenameMap{ "key": WebAppJavascriptFilenameArgs{...} }
type WebAppJavascriptFilenameMapInput interface {
	pulumi.Input

	ToWebAppJavascriptFilenameMapOutput() WebAppJavascriptFilenameMapOutput
	ToWebAppJavascriptFilenameMapOutputWithContext(context.Context) WebAppJavascriptFilenameMapOutput
}

type WebAppJavascriptFilenameMap map[string]WebAppJavascriptFilenameInput

func (WebAppJavascriptFilenameMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppJavascriptFilename)(nil)).Elem()
}

func (i WebAppJavascriptFilenameMap) ToWebAppJavascriptFilenameMapOutput() WebAppJavascriptFilenameMapOutput {
	return i.ToWebAppJavascriptFilenameMapOutputWithContext(context.Background())
}

func (i WebAppJavascriptFilenameMap) ToWebAppJavascriptFilenameMapOutputWithContext(ctx context.Context) WebAppJavascriptFilenameMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppJavascriptFilenameMapOutput)
}

type WebAppJavascriptFilenameOutput struct{ *pulumi.OutputState }

func (WebAppJavascriptFilenameOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppJavascriptFilename)(nil)).Elem()
}

func (o WebAppJavascriptFilenameOutput) ToWebAppJavascriptFilenameOutput() WebAppJavascriptFilenameOutput {
	return o
}

func (o WebAppJavascriptFilenameOutput) ToWebAppJavascriptFilenameOutputWithContext(ctx context.Context) WebAppJavascriptFilenameOutput {
	return o
}

// Custom filename prefix
func (o WebAppJavascriptFilenameOutput) Filename() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppJavascriptFilename) pulumi.StringOutput { return v.Filename }).(pulumi.StringOutput)
}

type WebAppJavascriptFilenameArrayOutput struct{ *pulumi.OutputState }

func (WebAppJavascriptFilenameArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppJavascriptFilename)(nil)).Elem()
}

func (o WebAppJavascriptFilenameArrayOutput) ToWebAppJavascriptFilenameArrayOutput() WebAppJavascriptFilenameArrayOutput {
	return o
}

func (o WebAppJavascriptFilenameArrayOutput) ToWebAppJavascriptFilenameArrayOutputWithContext(ctx context.Context) WebAppJavascriptFilenameArrayOutput {
	return o
}

func (o WebAppJavascriptFilenameArrayOutput) Index(i pulumi.IntInput) WebAppJavascriptFilenameOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WebAppJavascriptFilename {
		return vs[0].([]*WebAppJavascriptFilename)[vs[1].(int)]
	}).(WebAppJavascriptFilenameOutput)
}

type WebAppJavascriptFilenameMapOutput struct{ *pulumi.OutputState }

func (WebAppJavascriptFilenameMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppJavascriptFilename)(nil)).Elem()
}

func (o WebAppJavascriptFilenameMapOutput) ToWebAppJavascriptFilenameMapOutput() WebAppJavascriptFilenameMapOutput {
	return o
}

func (o WebAppJavascriptFilenameMapOutput) ToWebAppJavascriptFilenameMapOutputWithContext(ctx context.Context) WebAppJavascriptFilenameMapOutput {
	return o
}

func (o WebAppJavascriptFilenameMapOutput) MapIndex(k pulumi.StringInput) WebAppJavascriptFilenameOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WebAppJavascriptFilename {
		return vs[0].(map[string]*WebAppJavascriptFilename)[vs[1].(string)]
	}).(WebAppJavascriptFilenameOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppJavascriptFilenameInput)(nil)).Elem(), &WebAppJavascriptFilename{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppJavascriptFilenameArrayInput)(nil)).Elem(), WebAppJavascriptFilenameArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppJavascriptFilenameMapInput)(nil)).Elem(), WebAppJavascriptFilenameMap{})
	pulumi.RegisterOutputType(WebAppJavascriptFilenameOutput{})
	pulumi.RegisterOutputType(WebAppJavascriptFilenameArrayOutput{})
	pulumi.RegisterOutputType(WebAppJavascriptFilenameMapOutput{})
}
