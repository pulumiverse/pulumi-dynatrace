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

type ProblemFields struct {
	pulumi.CustomResourceState

	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Field from the event that will be extracted.
	EventField pulumi.StringOutput `pulumi:"eventField"`
	// Field under which the extracted event data will be stored on the problem.
	ProblemField pulumi.StringOutput `pulumi:"problemField"`
}

// NewProblemFields registers a new resource with the given unique name, arguments, and options.
func NewProblemFields(ctx *pulumi.Context,
	name string, args *ProblemFieldsArgs, opts ...pulumi.ResourceOption) (*ProblemFields, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.EventField == nil {
		return nil, errors.New("invalid value for required argument 'EventField'")
	}
	if args.ProblemField == nil {
		return nil, errors.New("invalid value for required argument 'ProblemField'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ProblemFields
	err := ctx.RegisterResource("dynatrace:index/problemFields:ProblemFields", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProblemFields gets an existing ProblemFields resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProblemFields(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProblemFieldsState, opts ...pulumi.ResourceOption) (*ProblemFields, error) {
	var resource ProblemFields
	err := ctx.ReadResource("dynatrace:index/problemFields:ProblemFields", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProblemFields resources.
type problemFieldsState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Field from the event that will be extracted.
	EventField *string `pulumi:"eventField"`
	// Field under which the extracted event data will be stored on the problem.
	ProblemField *string `pulumi:"problemField"`
}

type ProblemFieldsState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Field from the event that will be extracted.
	EventField pulumi.StringPtrInput
	// Field under which the extracted event data will be stored on the problem.
	ProblemField pulumi.StringPtrInput
}

func (ProblemFieldsState) ElementType() reflect.Type {
	return reflect.TypeOf((*problemFieldsState)(nil)).Elem()
}

type problemFieldsArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Field from the event that will be extracted.
	EventField string `pulumi:"eventField"`
	// Field under which the extracted event data will be stored on the problem.
	ProblemField string `pulumi:"problemField"`
}

// The set of arguments for constructing a ProblemFields resource.
type ProblemFieldsArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Field from the event that will be extracted.
	EventField pulumi.StringInput
	// Field under which the extracted event data will be stored on the problem.
	ProblemField pulumi.StringInput
}

func (ProblemFieldsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*problemFieldsArgs)(nil)).Elem()
}

type ProblemFieldsInput interface {
	pulumi.Input

	ToProblemFieldsOutput() ProblemFieldsOutput
	ToProblemFieldsOutputWithContext(ctx context.Context) ProblemFieldsOutput
}

func (*ProblemFields) ElementType() reflect.Type {
	return reflect.TypeOf((**ProblemFields)(nil)).Elem()
}

func (i *ProblemFields) ToProblemFieldsOutput() ProblemFieldsOutput {
	return i.ToProblemFieldsOutputWithContext(context.Background())
}

func (i *ProblemFields) ToProblemFieldsOutputWithContext(ctx context.Context) ProblemFieldsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProblemFieldsOutput)
}

// ProblemFieldsArrayInput is an input type that accepts ProblemFieldsArray and ProblemFieldsArrayOutput values.
// You can construct a concrete instance of `ProblemFieldsArrayInput` via:
//
//	ProblemFieldsArray{ ProblemFieldsArgs{...} }
type ProblemFieldsArrayInput interface {
	pulumi.Input

	ToProblemFieldsArrayOutput() ProblemFieldsArrayOutput
	ToProblemFieldsArrayOutputWithContext(context.Context) ProblemFieldsArrayOutput
}

type ProblemFieldsArray []ProblemFieldsInput

func (ProblemFieldsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProblemFields)(nil)).Elem()
}

func (i ProblemFieldsArray) ToProblemFieldsArrayOutput() ProblemFieldsArrayOutput {
	return i.ToProblemFieldsArrayOutputWithContext(context.Background())
}

func (i ProblemFieldsArray) ToProblemFieldsArrayOutputWithContext(ctx context.Context) ProblemFieldsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProblemFieldsArrayOutput)
}

// ProblemFieldsMapInput is an input type that accepts ProblemFieldsMap and ProblemFieldsMapOutput values.
// You can construct a concrete instance of `ProblemFieldsMapInput` via:
//
//	ProblemFieldsMap{ "key": ProblemFieldsArgs{...} }
type ProblemFieldsMapInput interface {
	pulumi.Input

	ToProblemFieldsMapOutput() ProblemFieldsMapOutput
	ToProblemFieldsMapOutputWithContext(context.Context) ProblemFieldsMapOutput
}

type ProblemFieldsMap map[string]ProblemFieldsInput

func (ProblemFieldsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProblemFields)(nil)).Elem()
}

func (i ProblemFieldsMap) ToProblemFieldsMapOutput() ProblemFieldsMapOutput {
	return i.ToProblemFieldsMapOutputWithContext(context.Background())
}

func (i ProblemFieldsMap) ToProblemFieldsMapOutputWithContext(ctx context.Context) ProblemFieldsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProblemFieldsMapOutput)
}

type ProblemFieldsOutput struct{ *pulumi.OutputState }

func (ProblemFieldsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProblemFields)(nil)).Elem()
}

func (o ProblemFieldsOutput) ToProblemFieldsOutput() ProblemFieldsOutput {
	return o
}

func (o ProblemFieldsOutput) ToProblemFieldsOutputWithContext(ctx context.Context) ProblemFieldsOutput {
	return o
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ProblemFieldsOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ProblemFields) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Field from the event that will be extracted.
func (o ProblemFieldsOutput) EventField() pulumi.StringOutput {
	return o.ApplyT(func(v *ProblemFields) pulumi.StringOutput { return v.EventField }).(pulumi.StringOutput)
}

// Field under which the extracted event data will be stored on the problem.
func (o ProblemFieldsOutput) ProblemField() pulumi.StringOutput {
	return o.ApplyT(func(v *ProblemFields) pulumi.StringOutput { return v.ProblemField }).(pulumi.StringOutput)
}

type ProblemFieldsArrayOutput struct{ *pulumi.OutputState }

func (ProblemFieldsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProblemFields)(nil)).Elem()
}

func (o ProblemFieldsArrayOutput) ToProblemFieldsArrayOutput() ProblemFieldsArrayOutput {
	return o
}

func (o ProblemFieldsArrayOutput) ToProblemFieldsArrayOutputWithContext(ctx context.Context) ProblemFieldsArrayOutput {
	return o
}

func (o ProblemFieldsArrayOutput) Index(i pulumi.IntInput) ProblemFieldsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProblemFields {
		return vs[0].([]*ProblemFields)[vs[1].(int)]
	}).(ProblemFieldsOutput)
}

type ProblemFieldsMapOutput struct{ *pulumi.OutputState }

func (ProblemFieldsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProblemFields)(nil)).Elem()
}

func (o ProblemFieldsMapOutput) ToProblemFieldsMapOutput() ProblemFieldsMapOutput {
	return o
}

func (o ProblemFieldsMapOutput) ToProblemFieldsMapOutputWithContext(ctx context.Context) ProblemFieldsMapOutput {
	return o
}

func (o ProblemFieldsMapOutput) MapIndex(k pulumi.StringInput) ProblemFieldsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProblemFields {
		return vs[0].(map[string]*ProblemFields)[vs[1].(string)]
	}).(ProblemFieldsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProblemFieldsInput)(nil)).Elem(), &ProblemFields{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProblemFieldsArrayInput)(nil)).Elem(), ProblemFieldsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProblemFieldsMapInput)(nil)).Elem(), ProblemFieldsMap{})
	pulumi.RegisterOutputType(ProblemFieldsOutput{})
	pulumi.RegisterOutputType(ProblemFieldsArrayOutput{})
	pulumi.RegisterOutputType(ProblemFieldsMapOutput{})
}
