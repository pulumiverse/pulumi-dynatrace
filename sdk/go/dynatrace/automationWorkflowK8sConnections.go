// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type AutomationWorkflowK8sConnections struct {
	pulumi.CustomResourceState

	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// The name of the EdgeConnect deployment
	Name pulumi.StringOutput `pulumi:"name"`
	// The namespace where EdgeConnect is deployed
	Namespace pulumi.StringOutput `pulumi:"namespace"`
	// Token
	Token pulumi.StringOutput `pulumi:"token"`
	// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
	Uid pulumi.StringOutput `pulumi:"uid"`
}

// NewAutomationWorkflowK8sConnections registers a new resource with the given unique name, arguments, and options.
func NewAutomationWorkflowK8sConnections(ctx *pulumi.Context,
	name string, args *AutomationWorkflowK8sConnectionsArgs, opts ...pulumi.ResourceOption) (*AutomationWorkflowK8sConnections, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Namespace == nil {
		return nil, errors.New("invalid value for required argument 'Namespace'")
	}
	if args.Token == nil {
		return nil, errors.New("invalid value for required argument 'Token'")
	}
	if args.Uid == nil {
		return nil, errors.New("invalid value for required argument 'Uid'")
	}
	if args.Token != nil {
		args.Token = pulumi.ToSecret(args.Token).(pulumi.StringInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"token",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AutomationWorkflowK8sConnections
	err := ctx.RegisterResource("dynatrace:index/automationWorkflowK8sConnections:AutomationWorkflowK8sConnections", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutomationWorkflowK8sConnections gets an existing AutomationWorkflowK8sConnections resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutomationWorkflowK8sConnections(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutomationWorkflowK8sConnectionsState, opts ...pulumi.ResourceOption) (*AutomationWorkflowK8sConnections, error) {
	var resource AutomationWorkflowK8sConnections
	err := ctx.ReadResource("dynatrace:index/automationWorkflowK8sConnections:AutomationWorkflowK8sConnections", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutomationWorkflowK8sConnections resources.
type automationWorkflowK8sConnectionsState struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// The name of the EdgeConnect deployment
	Name *string `pulumi:"name"`
	// The namespace where EdgeConnect is deployed
	Namespace *string `pulumi:"namespace"`
	// Token
	Token *string `pulumi:"token"`
	// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
	Uid *string `pulumi:"uid"`
}

type AutomationWorkflowK8sConnectionsState struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// The name of the EdgeConnect deployment
	Name pulumi.StringPtrInput
	// The namespace where EdgeConnect is deployed
	Namespace pulumi.StringPtrInput
	// Token
	Token pulumi.StringPtrInput
	// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
	Uid pulumi.StringPtrInput
}

func (AutomationWorkflowK8sConnectionsState) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowK8sConnectionsState)(nil)).Elem()
}

type automationWorkflowK8sConnectionsArgs struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// The name of the EdgeConnect deployment
	Name *string `pulumi:"name"`
	// The namespace where EdgeConnect is deployed
	Namespace string `pulumi:"namespace"`
	// Token
	Token string `pulumi:"token"`
	// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
	Uid string `pulumi:"uid"`
}

// The set of arguments for constructing a AutomationWorkflowK8sConnections resource.
type AutomationWorkflowK8sConnectionsArgs struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// The name of the EdgeConnect deployment
	Name pulumi.StringPtrInput
	// The namespace where EdgeConnect is deployed
	Namespace pulumi.StringInput
	// Token
	Token pulumi.StringInput
	// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
	Uid pulumi.StringInput
}

func (AutomationWorkflowK8sConnectionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowK8sConnectionsArgs)(nil)).Elem()
}

type AutomationWorkflowK8sConnectionsInput interface {
	pulumi.Input

	ToAutomationWorkflowK8sConnectionsOutput() AutomationWorkflowK8sConnectionsOutput
	ToAutomationWorkflowK8sConnectionsOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsOutput
}

func (*AutomationWorkflowK8sConnections) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (i *AutomationWorkflowK8sConnections) ToAutomationWorkflowK8sConnectionsOutput() AutomationWorkflowK8sConnectionsOutput {
	return i.ToAutomationWorkflowK8sConnectionsOutputWithContext(context.Background())
}

func (i *AutomationWorkflowK8sConnections) ToAutomationWorkflowK8sConnectionsOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowK8sConnectionsOutput)
}

// AutomationWorkflowK8sConnectionsArrayInput is an input type that accepts AutomationWorkflowK8sConnectionsArray and AutomationWorkflowK8sConnectionsArrayOutput values.
// You can construct a concrete instance of `AutomationWorkflowK8sConnectionsArrayInput` via:
//
//	AutomationWorkflowK8sConnectionsArray{ AutomationWorkflowK8sConnectionsArgs{...} }
type AutomationWorkflowK8sConnectionsArrayInput interface {
	pulumi.Input

	ToAutomationWorkflowK8sConnectionsArrayOutput() AutomationWorkflowK8sConnectionsArrayOutput
	ToAutomationWorkflowK8sConnectionsArrayOutputWithContext(context.Context) AutomationWorkflowK8sConnectionsArrayOutput
}

type AutomationWorkflowK8sConnectionsArray []AutomationWorkflowK8sConnectionsInput

func (AutomationWorkflowK8sConnectionsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (i AutomationWorkflowK8sConnectionsArray) ToAutomationWorkflowK8sConnectionsArrayOutput() AutomationWorkflowK8sConnectionsArrayOutput {
	return i.ToAutomationWorkflowK8sConnectionsArrayOutputWithContext(context.Background())
}

func (i AutomationWorkflowK8sConnectionsArray) ToAutomationWorkflowK8sConnectionsArrayOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowK8sConnectionsArrayOutput)
}

// AutomationWorkflowK8sConnectionsMapInput is an input type that accepts AutomationWorkflowK8sConnectionsMap and AutomationWorkflowK8sConnectionsMapOutput values.
// You can construct a concrete instance of `AutomationWorkflowK8sConnectionsMapInput` via:
//
//	AutomationWorkflowK8sConnectionsMap{ "key": AutomationWorkflowK8sConnectionsArgs{...} }
type AutomationWorkflowK8sConnectionsMapInput interface {
	pulumi.Input

	ToAutomationWorkflowK8sConnectionsMapOutput() AutomationWorkflowK8sConnectionsMapOutput
	ToAutomationWorkflowK8sConnectionsMapOutputWithContext(context.Context) AutomationWorkflowK8sConnectionsMapOutput
}

type AutomationWorkflowK8sConnectionsMap map[string]AutomationWorkflowK8sConnectionsInput

func (AutomationWorkflowK8sConnectionsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (i AutomationWorkflowK8sConnectionsMap) ToAutomationWorkflowK8sConnectionsMapOutput() AutomationWorkflowK8sConnectionsMapOutput {
	return i.ToAutomationWorkflowK8sConnectionsMapOutputWithContext(context.Background())
}

func (i AutomationWorkflowK8sConnectionsMap) ToAutomationWorkflowK8sConnectionsMapOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowK8sConnectionsMapOutput)
}

type AutomationWorkflowK8sConnectionsOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowK8sConnectionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (o AutomationWorkflowK8sConnectionsOutput) ToAutomationWorkflowK8sConnectionsOutput() AutomationWorkflowK8sConnectionsOutput {
	return o
}

func (o AutomationWorkflowK8sConnectionsOutput) ToAutomationWorkflowK8sConnectionsOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsOutput {
	return o
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o AutomationWorkflowK8sConnectionsOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowK8sConnections) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// The name of the EdgeConnect deployment
func (o AutomationWorkflowK8sConnectionsOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowK8sConnections) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The namespace where EdgeConnect is deployed
func (o AutomationWorkflowK8sConnectionsOutput) Namespace() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowK8sConnections) pulumi.StringOutput { return v.Namespace }).(pulumi.StringOutput)
}

// Token
func (o AutomationWorkflowK8sConnectionsOutput) Token() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowK8sConnections) pulumi.StringOutput { return v.Token }).(pulumi.StringOutput)
}

// A pseudo-ID for the cluster, set to the UID of the kube-system namespace
func (o AutomationWorkflowK8sConnectionsOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowK8sConnections) pulumi.StringOutput { return v.Uid }).(pulumi.StringOutput)
}

type AutomationWorkflowK8sConnectionsArrayOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowK8sConnectionsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (o AutomationWorkflowK8sConnectionsArrayOutput) ToAutomationWorkflowK8sConnectionsArrayOutput() AutomationWorkflowK8sConnectionsArrayOutput {
	return o
}

func (o AutomationWorkflowK8sConnectionsArrayOutput) ToAutomationWorkflowK8sConnectionsArrayOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsArrayOutput {
	return o
}

func (o AutomationWorkflowK8sConnectionsArrayOutput) Index(i pulumi.IntInput) AutomationWorkflowK8sConnectionsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AutomationWorkflowK8sConnections {
		return vs[0].([]*AutomationWorkflowK8sConnections)[vs[1].(int)]
	}).(AutomationWorkflowK8sConnectionsOutput)
}

type AutomationWorkflowK8sConnectionsMapOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowK8sConnectionsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflowK8sConnections)(nil)).Elem()
}

func (o AutomationWorkflowK8sConnectionsMapOutput) ToAutomationWorkflowK8sConnectionsMapOutput() AutomationWorkflowK8sConnectionsMapOutput {
	return o
}

func (o AutomationWorkflowK8sConnectionsMapOutput) ToAutomationWorkflowK8sConnectionsMapOutputWithContext(ctx context.Context) AutomationWorkflowK8sConnectionsMapOutput {
	return o
}

func (o AutomationWorkflowK8sConnectionsMapOutput) MapIndex(k pulumi.StringInput) AutomationWorkflowK8sConnectionsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AutomationWorkflowK8sConnections {
		return vs[0].(map[string]*AutomationWorkflowK8sConnections)[vs[1].(string)]
	}).(AutomationWorkflowK8sConnectionsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowK8sConnectionsInput)(nil)).Elem(), &AutomationWorkflowK8sConnections{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowK8sConnectionsArrayInput)(nil)).Elem(), AutomationWorkflowK8sConnectionsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowK8sConnectionsMapInput)(nil)).Elem(), AutomationWorkflowK8sConnectionsMap{})
	pulumi.RegisterOutputType(AutomationWorkflowK8sConnectionsOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowK8sConnectionsArrayOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowK8sConnectionsMapOutput{})
}