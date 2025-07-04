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

type ContainerRule struct {
	pulumi.CustomResourceState

	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
	Mode pulumi.StringOutput `pulumi:"mode"`
	// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
	Operator pulumi.StringOutput `pulumi:"operator"`
	// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
	Property pulumi.StringOutput `pulumi:"property"`
	// Condition value
	Value pulumi.StringPtrOutput `pulumi:"value"`
}

// NewContainerRule registers a new resource with the given unique name, arguments, and options.
func NewContainerRule(ctx *pulumi.Context,
	name string, args *ContainerRuleArgs, opts ...pulumi.ResourceOption) (*ContainerRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.Mode == nil {
		return nil, errors.New("invalid value for required argument 'Mode'")
	}
	if args.Operator == nil {
		return nil, errors.New("invalid value for required argument 'Operator'")
	}
	if args.Property == nil {
		return nil, errors.New("invalid value for required argument 'Property'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ContainerRule
	err := ctx.RegisterResource("dynatrace:index/containerRule:ContainerRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerRule gets an existing ContainerRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerRuleState, opts ...pulumi.ResourceOption) (*ContainerRule, error) {
	var resource ContainerRule
	err := ctx.ReadResource("dynatrace:index/containerRule:ContainerRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerRule resources.
type containerRuleState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
	Mode *string `pulumi:"mode"`
	// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
	Operator *string `pulumi:"operator"`
	// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
	Property *string `pulumi:"property"`
	// Condition value
	Value *string `pulumi:"value"`
}

type ContainerRuleState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
	Mode pulumi.StringPtrInput
	// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
	Operator pulumi.StringPtrInput
	// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
	Property pulumi.StringPtrInput
	// Condition value
	Value pulumi.StringPtrInput
}

func (ContainerRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRuleState)(nil)).Elem()
}

type containerRuleArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
	Mode string `pulumi:"mode"`
	// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
	Operator string `pulumi:"operator"`
	// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
	Property string `pulumi:"property"`
	// Condition value
	Value *string `pulumi:"value"`
}

// The set of arguments for constructing a ContainerRule resource.
type ContainerRuleArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
	Mode pulumi.StringInput
	// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
	Operator pulumi.StringInput
	// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
	Property pulumi.StringInput
	// Condition value
	Value pulumi.StringPtrInput
}

func (ContainerRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRuleArgs)(nil)).Elem()
}

type ContainerRuleInput interface {
	pulumi.Input

	ToContainerRuleOutput() ContainerRuleOutput
	ToContainerRuleOutputWithContext(ctx context.Context) ContainerRuleOutput
}

func (*ContainerRule) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRule)(nil)).Elem()
}

func (i *ContainerRule) ToContainerRuleOutput() ContainerRuleOutput {
	return i.ToContainerRuleOutputWithContext(context.Background())
}

func (i *ContainerRule) ToContainerRuleOutputWithContext(ctx context.Context) ContainerRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRuleOutput)
}

// ContainerRuleArrayInput is an input type that accepts ContainerRuleArray and ContainerRuleArrayOutput values.
// You can construct a concrete instance of `ContainerRuleArrayInput` via:
//
//	ContainerRuleArray{ ContainerRuleArgs{...} }
type ContainerRuleArrayInput interface {
	pulumi.Input

	ToContainerRuleArrayOutput() ContainerRuleArrayOutput
	ToContainerRuleArrayOutputWithContext(context.Context) ContainerRuleArrayOutput
}

type ContainerRuleArray []ContainerRuleInput

func (ContainerRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRule)(nil)).Elem()
}

func (i ContainerRuleArray) ToContainerRuleArrayOutput() ContainerRuleArrayOutput {
	return i.ToContainerRuleArrayOutputWithContext(context.Background())
}

func (i ContainerRuleArray) ToContainerRuleArrayOutputWithContext(ctx context.Context) ContainerRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRuleArrayOutput)
}

// ContainerRuleMapInput is an input type that accepts ContainerRuleMap and ContainerRuleMapOutput values.
// You can construct a concrete instance of `ContainerRuleMapInput` via:
//
//	ContainerRuleMap{ "key": ContainerRuleArgs{...} }
type ContainerRuleMapInput interface {
	pulumi.Input

	ToContainerRuleMapOutput() ContainerRuleMapOutput
	ToContainerRuleMapOutputWithContext(context.Context) ContainerRuleMapOutput
}

type ContainerRuleMap map[string]ContainerRuleInput

func (ContainerRuleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRule)(nil)).Elem()
}

func (i ContainerRuleMap) ToContainerRuleMapOutput() ContainerRuleMapOutput {
	return i.ToContainerRuleMapOutputWithContext(context.Background())
}

func (i ContainerRuleMap) ToContainerRuleMapOutputWithContext(ctx context.Context) ContainerRuleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRuleMapOutput)
}

type ContainerRuleOutput struct{ *pulumi.OutputState }

func (ContainerRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRule)(nil)).Elem()
}

func (o ContainerRuleOutput) ToContainerRuleOutput() ContainerRuleOutput {
	return o
}

func (o ContainerRuleOutput) ToContainerRuleOutputWithContext(ctx context.Context) ContainerRuleOutput {
	return o
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ContainerRuleOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o ContainerRuleOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// Possible Values: `MONITORING_OFF`, `MONITORING_ON`
func (o ContainerRuleOutput) Mode() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.StringOutput { return v.Mode }).(pulumi.StringOutput)
}

// Possible Values: `CONTAINS`, `ENDS`, `EQUALS`, `EXISTS`, `NOT_CONTAINS`, `NOT_ENDS`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_STARTS`, `STARTS`
func (o ContainerRuleOutput) Operator() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.StringOutput { return v.Operator }).(pulumi.StringOutput)
}

// Possible Values: `CONTAINER_NAME`, `IMAGE_NAME`, `KUBERNETES_BASEPODNAME`, `KUBERNETES_CONTAINERNAME`, `KUBERNETES_FULLPODNAME`, `KUBERNETES_NAMESPACE`, `KUBERNETES_PODUID`
func (o ContainerRuleOutput) Property() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.StringOutput { return v.Property }).(pulumi.StringOutput)
}

// Condition value
func (o ContainerRuleOutput) Value() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ContainerRule) pulumi.StringPtrOutput { return v.Value }).(pulumi.StringPtrOutput)
}

type ContainerRuleArrayOutput struct{ *pulumi.OutputState }

func (ContainerRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRule)(nil)).Elem()
}

func (o ContainerRuleArrayOutput) ToContainerRuleArrayOutput() ContainerRuleArrayOutput {
	return o
}

func (o ContainerRuleArrayOutput) ToContainerRuleArrayOutputWithContext(ctx context.Context) ContainerRuleArrayOutput {
	return o
}

func (o ContainerRuleArrayOutput) Index(i pulumi.IntInput) ContainerRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContainerRule {
		return vs[0].([]*ContainerRule)[vs[1].(int)]
	}).(ContainerRuleOutput)
}

type ContainerRuleMapOutput struct{ *pulumi.OutputState }

func (ContainerRuleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRule)(nil)).Elem()
}

func (o ContainerRuleMapOutput) ToContainerRuleMapOutput() ContainerRuleMapOutput {
	return o
}

func (o ContainerRuleMapOutput) ToContainerRuleMapOutputWithContext(ctx context.Context) ContainerRuleMapOutput {
	return o
}

func (o ContainerRuleMapOutput) MapIndex(k pulumi.StringInput) ContainerRuleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContainerRule {
		return vs[0].(map[string]*ContainerRule)[vs[1].(string)]
	}).(ContainerRuleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRuleInput)(nil)).Elem(), &ContainerRule{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRuleArrayInput)(nil)).Elem(), ContainerRuleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRuleMapInput)(nil)).Elem(), ContainerRuleMap{})
	pulumi.RegisterOutputType(ContainerRuleOutput{})
	pulumi.RegisterOutputType(ContainerRuleArrayOutput{})
	pulumi.RegisterOutputType(ContainerRuleMapOutput{})
}
