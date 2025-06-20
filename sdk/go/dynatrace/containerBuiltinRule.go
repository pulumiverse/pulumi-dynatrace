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

type ContainerBuiltinRule struct {
	pulumi.CustomResourceState

	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreDockerPauseContainer pulumi.BoolOutput `pulumi:"ignoreDockerPauseContainer"`
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreKubernetesPauseContainer pulumi.BoolOutput `pulumi:"ignoreKubernetesPauseContainer"`
	// Disable monitoring of intermediate containers created during image build.
	IgnoreOpenShiftBuildPodName pulumi.BoolOutput `pulumi:"ignoreOpenShiftBuildPodName"`
	// Disable monitoring of platform internal containers in the openshift-sdn namespace.
	IgnoreOpenShiftSdnNamespace pulumi.BoolOutput `pulumi:"ignoreOpenShiftSdnNamespace"`
}

// NewContainerBuiltinRule registers a new resource with the given unique name, arguments, and options.
func NewContainerBuiltinRule(ctx *pulumi.Context,
	name string, args *ContainerBuiltinRuleArgs, opts ...pulumi.ResourceOption) (*ContainerBuiltinRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.IgnoreDockerPauseContainer == nil {
		return nil, errors.New("invalid value for required argument 'IgnoreDockerPauseContainer'")
	}
	if args.IgnoreKubernetesPauseContainer == nil {
		return nil, errors.New("invalid value for required argument 'IgnoreKubernetesPauseContainer'")
	}
	if args.IgnoreOpenShiftBuildPodName == nil {
		return nil, errors.New("invalid value for required argument 'IgnoreOpenShiftBuildPodName'")
	}
	if args.IgnoreOpenShiftSdnNamespace == nil {
		return nil, errors.New("invalid value for required argument 'IgnoreOpenShiftSdnNamespace'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ContainerBuiltinRule
	err := ctx.RegisterResource("dynatrace:index/containerBuiltinRule:ContainerBuiltinRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerBuiltinRule gets an existing ContainerBuiltinRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerBuiltinRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerBuiltinRuleState, opts ...pulumi.ResourceOption) (*ContainerBuiltinRule, error) {
	var resource ContainerBuiltinRule
	err := ctx.ReadResource("dynatrace:index/containerBuiltinRule:ContainerBuiltinRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerBuiltinRule resources.
type containerBuiltinRuleState struct {
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreDockerPauseContainer *bool `pulumi:"ignoreDockerPauseContainer"`
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreKubernetesPauseContainer *bool `pulumi:"ignoreKubernetesPauseContainer"`
	// Disable monitoring of intermediate containers created during image build.
	IgnoreOpenShiftBuildPodName *bool `pulumi:"ignoreOpenShiftBuildPodName"`
	// Disable monitoring of platform internal containers in the openshift-sdn namespace.
	IgnoreOpenShiftSdnNamespace *bool `pulumi:"ignoreOpenShiftSdnNamespace"`
}

type ContainerBuiltinRuleState struct {
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreDockerPauseContainer pulumi.BoolPtrInput
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreKubernetesPauseContainer pulumi.BoolPtrInput
	// Disable monitoring of intermediate containers created during image build.
	IgnoreOpenShiftBuildPodName pulumi.BoolPtrInput
	// Disable monitoring of platform internal containers in the openshift-sdn namespace.
	IgnoreOpenShiftSdnNamespace pulumi.BoolPtrInput
}

func (ContainerBuiltinRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerBuiltinRuleState)(nil)).Elem()
}

type containerBuiltinRuleArgs struct {
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreDockerPauseContainer bool `pulumi:"ignoreDockerPauseContainer"`
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreKubernetesPauseContainer bool `pulumi:"ignoreKubernetesPauseContainer"`
	// Disable monitoring of intermediate containers created during image build.
	IgnoreOpenShiftBuildPodName bool `pulumi:"ignoreOpenShiftBuildPodName"`
	// Disable monitoring of platform internal containers in the openshift-sdn namespace.
	IgnoreOpenShiftSdnNamespace bool `pulumi:"ignoreOpenShiftSdnNamespace"`
}

// The set of arguments for constructing a ContainerBuiltinRule resource.
type ContainerBuiltinRuleArgs struct {
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreDockerPauseContainer pulumi.BoolInput
	// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
	IgnoreKubernetesPauseContainer pulumi.BoolInput
	// Disable monitoring of intermediate containers created during image build.
	IgnoreOpenShiftBuildPodName pulumi.BoolInput
	// Disable monitoring of platform internal containers in the openshift-sdn namespace.
	IgnoreOpenShiftSdnNamespace pulumi.BoolInput
}

func (ContainerBuiltinRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerBuiltinRuleArgs)(nil)).Elem()
}

type ContainerBuiltinRuleInput interface {
	pulumi.Input

	ToContainerBuiltinRuleOutput() ContainerBuiltinRuleOutput
	ToContainerBuiltinRuleOutputWithContext(ctx context.Context) ContainerBuiltinRuleOutput
}

func (*ContainerBuiltinRule) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerBuiltinRule)(nil)).Elem()
}

func (i *ContainerBuiltinRule) ToContainerBuiltinRuleOutput() ContainerBuiltinRuleOutput {
	return i.ToContainerBuiltinRuleOutputWithContext(context.Background())
}

func (i *ContainerBuiltinRule) ToContainerBuiltinRuleOutputWithContext(ctx context.Context) ContainerBuiltinRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerBuiltinRuleOutput)
}

// ContainerBuiltinRuleArrayInput is an input type that accepts ContainerBuiltinRuleArray and ContainerBuiltinRuleArrayOutput values.
// You can construct a concrete instance of `ContainerBuiltinRuleArrayInput` via:
//
//	ContainerBuiltinRuleArray{ ContainerBuiltinRuleArgs{...} }
type ContainerBuiltinRuleArrayInput interface {
	pulumi.Input

	ToContainerBuiltinRuleArrayOutput() ContainerBuiltinRuleArrayOutput
	ToContainerBuiltinRuleArrayOutputWithContext(context.Context) ContainerBuiltinRuleArrayOutput
}

type ContainerBuiltinRuleArray []ContainerBuiltinRuleInput

func (ContainerBuiltinRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerBuiltinRule)(nil)).Elem()
}

func (i ContainerBuiltinRuleArray) ToContainerBuiltinRuleArrayOutput() ContainerBuiltinRuleArrayOutput {
	return i.ToContainerBuiltinRuleArrayOutputWithContext(context.Background())
}

func (i ContainerBuiltinRuleArray) ToContainerBuiltinRuleArrayOutputWithContext(ctx context.Context) ContainerBuiltinRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerBuiltinRuleArrayOutput)
}

// ContainerBuiltinRuleMapInput is an input type that accepts ContainerBuiltinRuleMap and ContainerBuiltinRuleMapOutput values.
// You can construct a concrete instance of `ContainerBuiltinRuleMapInput` via:
//
//	ContainerBuiltinRuleMap{ "key": ContainerBuiltinRuleArgs{...} }
type ContainerBuiltinRuleMapInput interface {
	pulumi.Input

	ToContainerBuiltinRuleMapOutput() ContainerBuiltinRuleMapOutput
	ToContainerBuiltinRuleMapOutputWithContext(context.Context) ContainerBuiltinRuleMapOutput
}

type ContainerBuiltinRuleMap map[string]ContainerBuiltinRuleInput

func (ContainerBuiltinRuleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerBuiltinRule)(nil)).Elem()
}

func (i ContainerBuiltinRuleMap) ToContainerBuiltinRuleMapOutput() ContainerBuiltinRuleMapOutput {
	return i.ToContainerBuiltinRuleMapOutputWithContext(context.Background())
}

func (i ContainerBuiltinRuleMap) ToContainerBuiltinRuleMapOutputWithContext(ctx context.Context) ContainerBuiltinRuleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerBuiltinRuleMapOutput)
}

type ContainerBuiltinRuleOutput struct{ *pulumi.OutputState }

func (ContainerBuiltinRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerBuiltinRule)(nil)).Elem()
}

func (o ContainerBuiltinRuleOutput) ToContainerBuiltinRuleOutput() ContainerBuiltinRuleOutput {
	return o
}

func (o ContainerBuiltinRuleOutput) ToContainerBuiltinRuleOutputWithContext(ctx context.Context) ContainerBuiltinRuleOutput {
	return o
}

// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
func (o ContainerBuiltinRuleOutput) IgnoreDockerPauseContainer() pulumi.BoolOutput {
	return o.ApplyT(func(v *ContainerBuiltinRule) pulumi.BoolOutput { return v.IgnoreDockerPauseContainer }).(pulumi.BoolOutput)
}

// Disable monitoring of platform internal pause containers in Kubernetes and OpenShift.
func (o ContainerBuiltinRuleOutput) IgnoreKubernetesPauseContainer() pulumi.BoolOutput {
	return o.ApplyT(func(v *ContainerBuiltinRule) pulumi.BoolOutput { return v.IgnoreKubernetesPauseContainer }).(pulumi.BoolOutput)
}

// Disable monitoring of intermediate containers created during image build.
func (o ContainerBuiltinRuleOutput) IgnoreOpenShiftBuildPodName() pulumi.BoolOutput {
	return o.ApplyT(func(v *ContainerBuiltinRule) pulumi.BoolOutput { return v.IgnoreOpenShiftBuildPodName }).(pulumi.BoolOutput)
}

// Disable monitoring of platform internal containers in the openshift-sdn namespace.
func (o ContainerBuiltinRuleOutput) IgnoreOpenShiftSdnNamespace() pulumi.BoolOutput {
	return o.ApplyT(func(v *ContainerBuiltinRule) pulumi.BoolOutput { return v.IgnoreOpenShiftSdnNamespace }).(pulumi.BoolOutput)
}

type ContainerBuiltinRuleArrayOutput struct{ *pulumi.OutputState }

func (ContainerBuiltinRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerBuiltinRule)(nil)).Elem()
}

func (o ContainerBuiltinRuleArrayOutput) ToContainerBuiltinRuleArrayOutput() ContainerBuiltinRuleArrayOutput {
	return o
}

func (o ContainerBuiltinRuleArrayOutput) ToContainerBuiltinRuleArrayOutputWithContext(ctx context.Context) ContainerBuiltinRuleArrayOutput {
	return o
}

func (o ContainerBuiltinRuleArrayOutput) Index(i pulumi.IntInput) ContainerBuiltinRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContainerBuiltinRule {
		return vs[0].([]*ContainerBuiltinRule)[vs[1].(int)]
	}).(ContainerBuiltinRuleOutput)
}

type ContainerBuiltinRuleMapOutput struct{ *pulumi.OutputState }

func (ContainerBuiltinRuleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerBuiltinRule)(nil)).Elem()
}

func (o ContainerBuiltinRuleMapOutput) ToContainerBuiltinRuleMapOutput() ContainerBuiltinRuleMapOutput {
	return o
}

func (o ContainerBuiltinRuleMapOutput) ToContainerBuiltinRuleMapOutputWithContext(ctx context.Context) ContainerBuiltinRuleMapOutput {
	return o
}

func (o ContainerBuiltinRuleMapOutput) MapIndex(k pulumi.StringInput) ContainerBuiltinRuleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContainerBuiltinRule {
		return vs[0].(map[string]*ContainerBuiltinRule)[vs[1].(string)]
	}).(ContainerBuiltinRuleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerBuiltinRuleInput)(nil)).Elem(), &ContainerBuiltinRule{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerBuiltinRuleArrayInput)(nil)).Elem(), ContainerBuiltinRuleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerBuiltinRuleMapInput)(nil)).Elem(), ContainerBuiltinRuleMap{})
	pulumi.RegisterOutputType(ContainerBuiltinRuleOutput{})
	pulumi.RegisterOutputType(ContainerBuiltinRuleArrayOutput{})
	pulumi.RegisterOutputType(ContainerBuiltinRuleMapOutput{})
}
