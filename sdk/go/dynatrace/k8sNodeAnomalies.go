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

type K8sNodeAnomalies struct {
	pulumi.CustomResourceState

	// no documentation available
	CpuRequestsSaturation K8sNodeAnomaliesCpuRequestsSaturationOutput `pulumi:"cpuRequestsSaturation"`
	// no documentation available
	MemoryRequestsSaturation K8sNodeAnomaliesMemoryRequestsSaturationOutput `pulumi:"memoryRequestsSaturation"`
	// no documentation available
	NodeProblematicCondition K8sNodeAnomaliesNodeProblematicConditionOutput `pulumi:"nodeProblematicCondition"`
	// no documentation available
	PodsSaturation K8sNodeAnomaliesPodsSaturationOutput `pulumi:"podsSaturation"`
	// Alerts if node has not been available for a given amount of time
	ReadinessIssues K8sNodeAnomaliesReadinessIssuesOutput `pulumi:"readinessIssues"`
	// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
}

// NewK8sNodeAnomalies registers a new resource with the given unique name, arguments, and options.
func NewK8sNodeAnomalies(ctx *pulumi.Context,
	name string, args *K8sNodeAnomaliesArgs, opts ...pulumi.ResourceOption) (*K8sNodeAnomalies, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CpuRequestsSaturation == nil {
		return nil, errors.New("invalid value for required argument 'CpuRequestsSaturation'")
	}
	if args.MemoryRequestsSaturation == nil {
		return nil, errors.New("invalid value for required argument 'MemoryRequestsSaturation'")
	}
	if args.NodeProblematicCondition == nil {
		return nil, errors.New("invalid value for required argument 'NodeProblematicCondition'")
	}
	if args.PodsSaturation == nil {
		return nil, errors.New("invalid value for required argument 'PodsSaturation'")
	}
	if args.ReadinessIssues == nil {
		return nil, errors.New("invalid value for required argument 'ReadinessIssues'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource K8sNodeAnomalies
	err := ctx.RegisterResource("dynatrace:index/k8sNodeAnomalies:K8sNodeAnomalies", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetK8sNodeAnomalies gets an existing K8sNodeAnomalies resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetK8sNodeAnomalies(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *K8sNodeAnomaliesState, opts ...pulumi.ResourceOption) (*K8sNodeAnomalies, error) {
	var resource K8sNodeAnomalies
	err := ctx.ReadResource("dynatrace:index/k8sNodeAnomalies:K8sNodeAnomalies", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering K8sNodeAnomalies resources.
type k8sNodeAnomaliesState struct {
	// no documentation available
	CpuRequestsSaturation *K8sNodeAnomaliesCpuRequestsSaturation `pulumi:"cpuRequestsSaturation"`
	// no documentation available
	MemoryRequestsSaturation *K8sNodeAnomaliesMemoryRequestsSaturation `pulumi:"memoryRequestsSaturation"`
	// no documentation available
	NodeProblematicCondition *K8sNodeAnomaliesNodeProblematicCondition `pulumi:"nodeProblematicCondition"`
	// no documentation available
	PodsSaturation *K8sNodeAnomaliesPodsSaturation `pulumi:"podsSaturation"`
	// Alerts if node has not been available for a given amount of time
	ReadinessIssues *K8sNodeAnomaliesReadinessIssues `pulumi:"readinessIssues"`
	// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

type K8sNodeAnomaliesState struct {
	// no documentation available
	CpuRequestsSaturation K8sNodeAnomaliesCpuRequestsSaturationPtrInput
	// no documentation available
	MemoryRequestsSaturation K8sNodeAnomaliesMemoryRequestsSaturationPtrInput
	// no documentation available
	NodeProblematicCondition K8sNodeAnomaliesNodeProblematicConditionPtrInput
	// no documentation available
	PodsSaturation K8sNodeAnomaliesPodsSaturationPtrInput
	// Alerts if node has not been available for a given amount of time
	ReadinessIssues K8sNodeAnomaliesReadinessIssuesPtrInput
	// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (K8sNodeAnomaliesState) ElementType() reflect.Type {
	return reflect.TypeOf((*k8sNodeAnomaliesState)(nil)).Elem()
}

type k8sNodeAnomaliesArgs struct {
	// no documentation available
	CpuRequestsSaturation K8sNodeAnomaliesCpuRequestsSaturation `pulumi:"cpuRequestsSaturation"`
	// no documentation available
	MemoryRequestsSaturation K8sNodeAnomaliesMemoryRequestsSaturation `pulumi:"memoryRequestsSaturation"`
	// no documentation available
	NodeProblematicCondition K8sNodeAnomaliesNodeProblematicCondition `pulumi:"nodeProblematicCondition"`
	// no documentation available
	PodsSaturation K8sNodeAnomaliesPodsSaturation `pulumi:"podsSaturation"`
	// Alerts if node has not been available for a given amount of time
	ReadinessIssues K8sNodeAnomaliesReadinessIssues `pulumi:"readinessIssues"`
	// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

// The set of arguments for constructing a K8sNodeAnomalies resource.
type K8sNodeAnomaliesArgs struct {
	// no documentation available
	CpuRequestsSaturation K8sNodeAnomaliesCpuRequestsSaturationInput
	// no documentation available
	MemoryRequestsSaturation K8sNodeAnomaliesMemoryRequestsSaturationInput
	// no documentation available
	NodeProblematicCondition K8sNodeAnomaliesNodeProblematicConditionInput
	// no documentation available
	PodsSaturation K8sNodeAnomaliesPodsSaturationInput
	// Alerts if node has not been available for a given amount of time
	ReadinessIssues K8sNodeAnomaliesReadinessIssuesInput
	// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (K8sNodeAnomaliesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*k8sNodeAnomaliesArgs)(nil)).Elem()
}

type K8sNodeAnomaliesInput interface {
	pulumi.Input

	ToK8sNodeAnomaliesOutput() K8sNodeAnomaliesOutput
	ToK8sNodeAnomaliesOutputWithContext(ctx context.Context) K8sNodeAnomaliesOutput
}

func (*K8sNodeAnomalies) ElementType() reflect.Type {
	return reflect.TypeOf((**K8sNodeAnomalies)(nil)).Elem()
}

func (i *K8sNodeAnomalies) ToK8sNodeAnomaliesOutput() K8sNodeAnomaliesOutput {
	return i.ToK8sNodeAnomaliesOutputWithContext(context.Background())
}

func (i *K8sNodeAnomalies) ToK8sNodeAnomaliesOutputWithContext(ctx context.Context) K8sNodeAnomaliesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(K8sNodeAnomaliesOutput)
}

// K8sNodeAnomaliesArrayInput is an input type that accepts K8sNodeAnomaliesArray and K8sNodeAnomaliesArrayOutput values.
// You can construct a concrete instance of `K8sNodeAnomaliesArrayInput` via:
//
//	K8sNodeAnomaliesArray{ K8sNodeAnomaliesArgs{...} }
type K8sNodeAnomaliesArrayInput interface {
	pulumi.Input

	ToK8sNodeAnomaliesArrayOutput() K8sNodeAnomaliesArrayOutput
	ToK8sNodeAnomaliesArrayOutputWithContext(context.Context) K8sNodeAnomaliesArrayOutput
}

type K8sNodeAnomaliesArray []K8sNodeAnomaliesInput

func (K8sNodeAnomaliesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*K8sNodeAnomalies)(nil)).Elem()
}

func (i K8sNodeAnomaliesArray) ToK8sNodeAnomaliesArrayOutput() K8sNodeAnomaliesArrayOutput {
	return i.ToK8sNodeAnomaliesArrayOutputWithContext(context.Background())
}

func (i K8sNodeAnomaliesArray) ToK8sNodeAnomaliesArrayOutputWithContext(ctx context.Context) K8sNodeAnomaliesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(K8sNodeAnomaliesArrayOutput)
}

// K8sNodeAnomaliesMapInput is an input type that accepts K8sNodeAnomaliesMap and K8sNodeAnomaliesMapOutput values.
// You can construct a concrete instance of `K8sNodeAnomaliesMapInput` via:
//
//	K8sNodeAnomaliesMap{ "key": K8sNodeAnomaliesArgs{...} }
type K8sNodeAnomaliesMapInput interface {
	pulumi.Input

	ToK8sNodeAnomaliesMapOutput() K8sNodeAnomaliesMapOutput
	ToK8sNodeAnomaliesMapOutputWithContext(context.Context) K8sNodeAnomaliesMapOutput
}

type K8sNodeAnomaliesMap map[string]K8sNodeAnomaliesInput

func (K8sNodeAnomaliesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*K8sNodeAnomalies)(nil)).Elem()
}

func (i K8sNodeAnomaliesMap) ToK8sNodeAnomaliesMapOutput() K8sNodeAnomaliesMapOutput {
	return i.ToK8sNodeAnomaliesMapOutputWithContext(context.Background())
}

func (i K8sNodeAnomaliesMap) ToK8sNodeAnomaliesMapOutputWithContext(ctx context.Context) K8sNodeAnomaliesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(K8sNodeAnomaliesMapOutput)
}

type K8sNodeAnomaliesOutput struct{ *pulumi.OutputState }

func (K8sNodeAnomaliesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**K8sNodeAnomalies)(nil)).Elem()
}

func (o K8sNodeAnomaliesOutput) ToK8sNodeAnomaliesOutput() K8sNodeAnomaliesOutput {
	return o
}

func (o K8sNodeAnomaliesOutput) ToK8sNodeAnomaliesOutputWithContext(ctx context.Context) K8sNodeAnomaliesOutput {
	return o
}

// no documentation available
func (o K8sNodeAnomaliesOutput) CpuRequestsSaturation() K8sNodeAnomaliesCpuRequestsSaturationOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) K8sNodeAnomaliesCpuRequestsSaturationOutput { return v.CpuRequestsSaturation }).(K8sNodeAnomaliesCpuRequestsSaturationOutput)
}

// no documentation available
func (o K8sNodeAnomaliesOutput) MemoryRequestsSaturation() K8sNodeAnomaliesMemoryRequestsSaturationOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) K8sNodeAnomaliesMemoryRequestsSaturationOutput {
		return v.MemoryRequestsSaturation
	}).(K8sNodeAnomaliesMemoryRequestsSaturationOutput)
}

// no documentation available
func (o K8sNodeAnomaliesOutput) NodeProblematicCondition() K8sNodeAnomaliesNodeProblematicConditionOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) K8sNodeAnomaliesNodeProblematicConditionOutput {
		return v.NodeProblematicCondition
	}).(K8sNodeAnomaliesNodeProblematicConditionOutput)
}

// no documentation available
func (o K8sNodeAnomaliesOutput) PodsSaturation() K8sNodeAnomaliesPodsSaturationOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) K8sNodeAnomaliesPodsSaturationOutput { return v.PodsSaturation }).(K8sNodeAnomaliesPodsSaturationOutput)
}

// Alerts if node has not been available for a given amount of time
func (o K8sNodeAnomaliesOutput) ReadinessIssues() K8sNodeAnomaliesReadinessIssuesOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) K8sNodeAnomaliesReadinessIssuesOutput { return v.ReadinessIssues }).(K8sNodeAnomaliesReadinessIssuesOutput)
}

// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
func (o K8sNodeAnomaliesOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *K8sNodeAnomalies) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

type K8sNodeAnomaliesArrayOutput struct{ *pulumi.OutputState }

func (K8sNodeAnomaliesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*K8sNodeAnomalies)(nil)).Elem()
}

func (o K8sNodeAnomaliesArrayOutput) ToK8sNodeAnomaliesArrayOutput() K8sNodeAnomaliesArrayOutput {
	return o
}

func (o K8sNodeAnomaliesArrayOutput) ToK8sNodeAnomaliesArrayOutputWithContext(ctx context.Context) K8sNodeAnomaliesArrayOutput {
	return o
}

func (o K8sNodeAnomaliesArrayOutput) Index(i pulumi.IntInput) K8sNodeAnomaliesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *K8sNodeAnomalies {
		return vs[0].([]*K8sNodeAnomalies)[vs[1].(int)]
	}).(K8sNodeAnomaliesOutput)
}

type K8sNodeAnomaliesMapOutput struct{ *pulumi.OutputState }

func (K8sNodeAnomaliesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*K8sNodeAnomalies)(nil)).Elem()
}

func (o K8sNodeAnomaliesMapOutput) ToK8sNodeAnomaliesMapOutput() K8sNodeAnomaliesMapOutput {
	return o
}

func (o K8sNodeAnomaliesMapOutput) ToK8sNodeAnomaliesMapOutputWithContext(ctx context.Context) K8sNodeAnomaliesMapOutput {
	return o
}

func (o K8sNodeAnomaliesMapOutput) MapIndex(k pulumi.StringInput) K8sNodeAnomaliesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *K8sNodeAnomalies {
		return vs[0].(map[string]*K8sNodeAnomalies)[vs[1].(string)]
	}).(K8sNodeAnomaliesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*K8sNodeAnomaliesInput)(nil)).Elem(), &K8sNodeAnomalies{})
	pulumi.RegisterInputType(reflect.TypeOf((*K8sNodeAnomaliesArrayInput)(nil)).Elem(), K8sNodeAnomaliesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*K8sNodeAnomaliesMapInput)(nil)).Elem(), K8sNodeAnomaliesMap{})
	pulumi.RegisterOutputType(K8sNodeAnomaliesOutput{})
	pulumi.RegisterOutputType(K8sNodeAnomaliesArrayOutput{})
	pulumi.RegisterOutputType(K8sNodeAnomaliesMapOutput{})
}
