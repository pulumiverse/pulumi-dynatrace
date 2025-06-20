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

type AttributesPreferences struct {
	pulumi.CustomResourceState

	// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
	PersistenceMode pulumi.StringOutput `pulumi:"persistenceMode"`
}

// NewAttributesPreferences registers a new resource with the given unique name, arguments, and options.
func NewAttributesPreferences(ctx *pulumi.Context,
	name string, args *AttributesPreferencesArgs, opts ...pulumi.ResourceOption) (*AttributesPreferences, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PersistenceMode == nil {
		return nil, errors.New("invalid value for required argument 'PersistenceMode'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AttributesPreferences
	err := ctx.RegisterResource("dynatrace:index/attributesPreferences:AttributesPreferences", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAttributesPreferences gets an existing AttributesPreferences resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAttributesPreferences(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AttributesPreferencesState, opts ...pulumi.ResourceOption) (*AttributesPreferences, error) {
	var resource AttributesPreferences
	err := ctx.ReadResource("dynatrace:index/attributesPreferences:AttributesPreferences", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AttributesPreferences resources.
type attributesPreferencesState struct {
	// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
	PersistenceMode *string `pulumi:"persistenceMode"`
}

type AttributesPreferencesState struct {
	// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
	PersistenceMode pulumi.StringPtrInput
}

func (AttributesPreferencesState) ElementType() reflect.Type {
	return reflect.TypeOf((*attributesPreferencesState)(nil)).Elem()
}

type attributesPreferencesArgs struct {
	// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
	PersistenceMode string `pulumi:"persistenceMode"`
}

// The set of arguments for constructing a AttributesPreferences resource.
type AttributesPreferencesArgs struct {
	// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
	PersistenceMode pulumi.StringInput
}

func (AttributesPreferencesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*attributesPreferencesArgs)(nil)).Elem()
}

type AttributesPreferencesInput interface {
	pulumi.Input

	ToAttributesPreferencesOutput() AttributesPreferencesOutput
	ToAttributesPreferencesOutputWithContext(ctx context.Context) AttributesPreferencesOutput
}

func (*AttributesPreferences) ElementType() reflect.Type {
	return reflect.TypeOf((**AttributesPreferences)(nil)).Elem()
}

func (i *AttributesPreferences) ToAttributesPreferencesOutput() AttributesPreferencesOutput {
	return i.ToAttributesPreferencesOutputWithContext(context.Background())
}

func (i *AttributesPreferences) ToAttributesPreferencesOutputWithContext(ctx context.Context) AttributesPreferencesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttributesPreferencesOutput)
}

// AttributesPreferencesArrayInput is an input type that accepts AttributesPreferencesArray and AttributesPreferencesArrayOutput values.
// You can construct a concrete instance of `AttributesPreferencesArrayInput` via:
//
//	AttributesPreferencesArray{ AttributesPreferencesArgs{...} }
type AttributesPreferencesArrayInput interface {
	pulumi.Input

	ToAttributesPreferencesArrayOutput() AttributesPreferencesArrayOutput
	ToAttributesPreferencesArrayOutputWithContext(context.Context) AttributesPreferencesArrayOutput
}

type AttributesPreferencesArray []AttributesPreferencesInput

func (AttributesPreferencesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AttributesPreferences)(nil)).Elem()
}

func (i AttributesPreferencesArray) ToAttributesPreferencesArrayOutput() AttributesPreferencesArrayOutput {
	return i.ToAttributesPreferencesArrayOutputWithContext(context.Background())
}

func (i AttributesPreferencesArray) ToAttributesPreferencesArrayOutputWithContext(ctx context.Context) AttributesPreferencesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttributesPreferencesArrayOutput)
}

// AttributesPreferencesMapInput is an input type that accepts AttributesPreferencesMap and AttributesPreferencesMapOutput values.
// You can construct a concrete instance of `AttributesPreferencesMapInput` via:
//
//	AttributesPreferencesMap{ "key": AttributesPreferencesArgs{...} }
type AttributesPreferencesMapInput interface {
	pulumi.Input

	ToAttributesPreferencesMapOutput() AttributesPreferencesMapOutput
	ToAttributesPreferencesMapOutputWithContext(context.Context) AttributesPreferencesMapOutput
}

type AttributesPreferencesMap map[string]AttributesPreferencesInput

func (AttributesPreferencesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AttributesPreferences)(nil)).Elem()
}

func (i AttributesPreferencesMap) ToAttributesPreferencesMapOutput() AttributesPreferencesMapOutput {
	return i.ToAttributesPreferencesMapOutputWithContext(context.Background())
}

func (i AttributesPreferencesMap) ToAttributesPreferencesMapOutputWithContext(ctx context.Context) AttributesPreferencesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttributesPreferencesMapOutput)
}

type AttributesPreferencesOutput struct{ *pulumi.OutputState }

func (AttributesPreferencesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AttributesPreferences)(nil)).Elem()
}

func (o AttributesPreferencesOutput) ToAttributesPreferencesOutput() AttributesPreferencesOutput {
	return o
}

func (o AttributesPreferencesOutput) ToAttributesPreferencesOutputWithContext(ctx context.Context) AttributesPreferencesOutput {
	return o
}

// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
func (o AttributesPreferencesOutput) PersistenceMode() pulumi.StringOutput {
	return o.ApplyT(func(v *AttributesPreferences) pulumi.StringOutput { return v.PersistenceMode }).(pulumi.StringOutput)
}

type AttributesPreferencesArrayOutput struct{ *pulumi.OutputState }

func (AttributesPreferencesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AttributesPreferences)(nil)).Elem()
}

func (o AttributesPreferencesArrayOutput) ToAttributesPreferencesArrayOutput() AttributesPreferencesArrayOutput {
	return o
}

func (o AttributesPreferencesArrayOutput) ToAttributesPreferencesArrayOutputWithContext(ctx context.Context) AttributesPreferencesArrayOutput {
	return o
}

func (o AttributesPreferencesArrayOutput) Index(i pulumi.IntInput) AttributesPreferencesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AttributesPreferences {
		return vs[0].([]*AttributesPreferences)[vs[1].(int)]
	}).(AttributesPreferencesOutput)
}

type AttributesPreferencesMapOutput struct{ *pulumi.OutputState }

func (AttributesPreferencesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AttributesPreferences)(nil)).Elem()
}

func (o AttributesPreferencesMapOutput) ToAttributesPreferencesMapOutput() AttributesPreferencesMapOutput {
	return o
}

func (o AttributesPreferencesMapOutput) ToAttributesPreferencesMapOutputWithContext(ctx context.Context) AttributesPreferencesMapOutput {
	return o
}

func (o AttributesPreferencesMapOutput) MapIndex(k pulumi.StringInput) AttributesPreferencesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AttributesPreferences {
		return vs[0].(map[string]*AttributesPreferences)[vs[1].(string)]
	}).(AttributesPreferencesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AttributesPreferencesInput)(nil)).Elem(), &AttributesPreferences{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttributesPreferencesArrayInput)(nil)).Elem(), AttributesPreferencesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttributesPreferencesMapInput)(nil)).Elem(), AttributesPreferencesMap{})
	pulumi.RegisterOutputType(AttributesPreferencesOutput{})
	pulumi.RegisterOutputType(AttributesPreferencesArrayOutput{})
	pulumi.RegisterOutputType(AttributesPreferencesMapOutput{})
}
