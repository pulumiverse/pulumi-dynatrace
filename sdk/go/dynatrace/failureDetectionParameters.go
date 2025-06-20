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

type FailureDetectionParameters struct {
	pulumi.CustomResourceState

	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks FailureDetectionParametersBrokenLinksOutput `pulumi:"brokenLinks"`
	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Customize failure detection for specific exceptions and errors
	ExceptionRules FailureDetectionParametersExceptionRulesOutput `pulumi:"exceptionRules"`
	// HTTP response codes
	HttpResponseCodes FailureDetectionParametersHttpResponseCodesOutput `pulumi:"httpResponseCodes"`
	// Name
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewFailureDetectionParameters registers a new resource with the given unique name, arguments, and options.
func NewFailureDetectionParameters(ctx *pulumi.Context,
	name string, args *FailureDetectionParametersArgs, opts ...pulumi.ResourceOption) (*FailureDetectionParameters, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BrokenLinks == nil {
		return nil, errors.New("invalid value for required argument 'BrokenLinks'")
	}
	if args.ExceptionRules == nil {
		return nil, errors.New("invalid value for required argument 'ExceptionRules'")
	}
	if args.HttpResponseCodes == nil {
		return nil, errors.New("invalid value for required argument 'HttpResponseCodes'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FailureDetectionParameters
	err := ctx.RegisterResource("dynatrace:index/failureDetectionParameters:FailureDetectionParameters", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFailureDetectionParameters gets an existing FailureDetectionParameters resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFailureDetectionParameters(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FailureDetectionParametersState, opts ...pulumi.ResourceOption) (*FailureDetectionParameters, error) {
	var resource FailureDetectionParameters
	err := ctx.ReadResource("dynatrace:index/failureDetectionParameters:FailureDetectionParameters", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FailureDetectionParameters resources.
type failureDetectionParametersState struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks *FailureDetectionParametersBrokenLinks `pulumi:"brokenLinks"`
	// Description
	Description *string `pulumi:"description"`
	// Customize failure detection for specific exceptions and errors
	ExceptionRules *FailureDetectionParametersExceptionRules `pulumi:"exceptionRules"`
	// HTTP response codes
	HttpResponseCodes *FailureDetectionParametersHttpResponseCodes `pulumi:"httpResponseCodes"`
	// Name
	Name *string `pulumi:"name"`
}

type FailureDetectionParametersState struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks FailureDetectionParametersBrokenLinksPtrInput
	// Description
	Description pulumi.StringPtrInput
	// Customize failure detection for specific exceptions and errors
	ExceptionRules FailureDetectionParametersExceptionRulesPtrInput
	// HTTP response codes
	HttpResponseCodes FailureDetectionParametersHttpResponseCodesPtrInput
	// Name
	Name pulumi.StringPtrInput
}

func (FailureDetectionParametersState) ElementType() reflect.Type {
	return reflect.TypeOf((*failureDetectionParametersState)(nil)).Elem()
}

type failureDetectionParametersArgs struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks FailureDetectionParametersBrokenLinks `pulumi:"brokenLinks"`
	// Description
	Description *string `pulumi:"description"`
	// Customize failure detection for specific exceptions and errors
	ExceptionRules FailureDetectionParametersExceptionRules `pulumi:"exceptionRules"`
	// HTTP response codes
	HttpResponseCodes FailureDetectionParametersHttpResponseCodes `pulumi:"httpResponseCodes"`
	// Name
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a FailureDetectionParameters resource.
type FailureDetectionParametersArgs struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks FailureDetectionParametersBrokenLinksInput
	// Description
	Description pulumi.StringPtrInput
	// Customize failure detection for specific exceptions and errors
	ExceptionRules FailureDetectionParametersExceptionRulesInput
	// HTTP response codes
	HttpResponseCodes FailureDetectionParametersHttpResponseCodesInput
	// Name
	Name pulumi.StringPtrInput
}

func (FailureDetectionParametersArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*failureDetectionParametersArgs)(nil)).Elem()
}

type FailureDetectionParametersInput interface {
	pulumi.Input

	ToFailureDetectionParametersOutput() FailureDetectionParametersOutput
	ToFailureDetectionParametersOutputWithContext(ctx context.Context) FailureDetectionParametersOutput
}

func (*FailureDetectionParameters) ElementType() reflect.Type {
	return reflect.TypeOf((**FailureDetectionParameters)(nil)).Elem()
}

func (i *FailureDetectionParameters) ToFailureDetectionParametersOutput() FailureDetectionParametersOutput {
	return i.ToFailureDetectionParametersOutputWithContext(context.Background())
}

func (i *FailureDetectionParameters) ToFailureDetectionParametersOutputWithContext(ctx context.Context) FailureDetectionParametersOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionParametersOutput)
}

// FailureDetectionParametersArrayInput is an input type that accepts FailureDetectionParametersArray and FailureDetectionParametersArrayOutput values.
// You can construct a concrete instance of `FailureDetectionParametersArrayInput` via:
//
//	FailureDetectionParametersArray{ FailureDetectionParametersArgs{...} }
type FailureDetectionParametersArrayInput interface {
	pulumi.Input

	ToFailureDetectionParametersArrayOutput() FailureDetectionParametersArrayOutput
	ToFailureDetectionParametersArrayOutputWithContext(context.Context) FailureDetectionParametersArrayOutput
}

type FailureDetectionParametersArray []FailureDetectionParametersInput

func (FailureDetectionParametersArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FailureDetectionParameters)(nil)).Elem()
}

func (i FailureDetectionParametersArray) ToFailureDetectionParametersArrayOutput() FailureDetectionParametersArrayOutput {
	return i.ToFailureDetectionParametersArrayOutputWithContext(context.Background())
}

func (i FailureDetectionParametersArray) ToFailureDetectionParametersArrayOutputWithContext(ctx context.Context) FailureDetectionParametersArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionParametersArrayOutput)
}

// FailureDetectionParametersMapInput is an input type that accepts FailureDetectionParametersMap and FailureDetectionParametersMapOutput values.
// You can construct a concrete instance of `FailureDetectionParametersMapInput` via:
//
//	FailureDetectionParametersMap{ "key": FailureDetectionParametersArgs{...} }
type FailureDetectionParametersMapInput interface {
	pulumi.Input

	ToFailureDetectionParametersMapOutput() FailureDetectionParametersMapOutput
	ToFailureDetectionParametersMapOutputWithContext(context.Context) FailureDetectionParametersMapOutput
}

type FailureDetectionParametersMap map[string]FailureDetectionParametersInput

func (FailureDetectionParametersMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FailureDetectionParameters)(nil)).Elem()
}

func (i FailureDetectionParametersMap) ToFailureDetectionParametersMapOutput() FailureDetectionParametersMapOutput {
	return i.ToFailureDetectionParametersMapOutputWithContext(context.Background())
}

func (i FailureDetectionParametersMap) ToFailureDetectionParametersMapOutputWithContext(ctx context.Context) FailureDetectionParametersMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FailureDetectionParametersMapOutput)
}

type FailureDetectionParametersOutput struct{ *pulumi.OutputState }

func (FailureDetectionParametersOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FailureDetectionParameters)(nil)).Elem()
}

func (o FailureDetectionParametersOutput) ToFailureDetectionParametersOutput() FailureDetectionParametersOutput {
	return o
}

func (o FailureDetectionParametersOutput) ToFailureDetectionParametersOutputWithContext(ctx context.Context) FailureDetectionParametersOutput {
	return o
}

// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
func (o FailureDetectionParametersOutput) BrokenLinks() FailureDetectionParametersBrokenLinksOutput {
	return o.ApplyT(func(v *FailureDetectionParameters) FailureDetectionParametersBrokenLinksOutput { return v.BrokenLinks }).(FailureDetectionParametersBrokenLinksOutput)
}

// Description
func (o FailureDetectionParametersOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *FailureDetectionParameters) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Customize failure detection for specific exceptions and errors
func (o FailureDetectionParametersOutput) ExceptionRules() FailureDetectionParametersExceptionRulesOutput {
	return o.ApplyT(func(v *FailureDetectionParameters) FailureDetectionParametersExceptionRulesOutput {
		return v.ExceptionRules
	}).(FailureDetectionParametersExceptionRulesOutput)
}

// HTTP response codes
func (o FailureDetectionParametersOutput) HttpResponseCodes() FailureDetectionParametersHttpResponseCodesOutput {
	return o.ApplyT(func(v *FailureDetectionParameters) FailureDetectionParametersHttpResponseCodesOutput {
		return v.HttpResponseCodes
	}).(FailureDetectionParametersHttpResponseCodesOutput)
}

// Name
func (o FailureDetectionParametersOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *FailureDetectionParameters) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type FailureDetectionParametersArrayOutput struct{ *pulumi.OutputState }

func (FailureDetectionParametersArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FailureDetectionParameters)(nil)).Elem()
}

func (o FailureDetectionParametersArrayOutput) ToFailureDetectionParametersArrayOutput() FailureDetectionParametersArrayOutput {
	return o
}

func (o FailureDetectionParametersArrayOutput) ToFailureDetectionParametersArrayOutputWithContext(ctx context.Context) FailureDetectionParametersArrayOutput {
	return o
}

func (o FailureDetectionParametersArrayOutput) Index(i pulumi.IntInput) FailureDetectionParametersOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FailureDetectionParameters {
		return vs[0].([]*FailureDetectionParameters)[vs[1].(int)]
	}).(FailureDetectionParametersOutput)
}

type FailureDetectionParametersMapOutput struct{ *pulumi.OutputState }

func (FailureDetectionParametersMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FailureDetectionParameters)(nil)).Elem()
}

func (o FailureDetectionParametersMapOutput) ToFailureDetectionParametersMapOutput() FailureDetectionParametersMapOutput {
	return o
}

func (o FailureDetectionParametersMapOutput) ToFailureDetectionParametersMapOutputWithContext(ctx context.Context) FailureDetectionParametersMapOutput {
	return o
}

func (o FailureDetectionParametersMapOutput) MapIndex(k pulumi.StringInput) FailureDetectionParametersOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FailureDetectionParameters {
		return vs[0].(map[string]*FailureDetectionParameters)[vs[1].(string)]
	}).(FailureDetectionParametersOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionParametersInput)(nil)).Elem(), &FailureDetectionParameters{})
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionParametersArrayInput)(nil)).Elem(), FailureDetectionParametersArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FailureDetectionParametersMapInput)(nil)).Elem(), FailureDetectionParametersMap{})
	pulumi.RegisterOutputType(FailureDetectionParametersOutput{})
	pulumi.RegisterOutputType(FailureDetectionParametersArrayOutput{})
	pulumi.RegisterOutputType(FailureDetectionParametersMapOutput{})
}
