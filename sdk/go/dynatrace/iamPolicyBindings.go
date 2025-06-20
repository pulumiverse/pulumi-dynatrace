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

// > **Dynatrace SaaS only**
//
// > To utilize this resource, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **Allow IAM policy configuration for environments** (`iam-policies-management`) and **View environments** (`account-env-read`).
//
// > This resource is excluded by default in the export utility, please explicitly specify the resource to retrieve existing configuration.
//
// ## Dynatrace Documentation
//
// - Dynatrace IAM Group Permissions - https://docs.dynatrace.com/docs/manage/identity-access-management/permission-management/manage-user-permissions-policies
//
// - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started
type IamPolicyBindings struct {
	pulumi.CustomResourceState

	// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
	Account pulumi.StringPtrOutput `pulumi:"account"`
	// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
	Environment pulumi.StringPtrOutput `pulumi:"environment"`
	// The name of the policy
	Group pulumi.StringOutput `pulumi:"group"`
	// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
	Policies pulumi.StringArrayOutput `pulumi:"policies"`
}

// NewIamPolicyBindings registers a new resource with the given unique name, arguments, and options.
func NewIamPolicyBindings(ctx *pulumi.Context,
	name string, args *IamPolicyBindingsArgs, opts ...pulumi.ResourceOption) (*IamPolicyBindings, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Group == nil {
		return nil, errors.New("invalid value for required argument 'Group'")
	}
	if args.Policies == nil {
		return nil, errors.New("invalid value for required argument 'Policies'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IamPolicyBindings
	err := ctx.RegisterResource("dynatrace:index/iamPolicyBindings:IamPolicyBindings", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIamPolicyBindings gets an existing IamPolicyBindings resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIamPolicyBindings(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IamPolicyBindingsState, opts ...pulumi.ResourceOption) (*IamPolicyBindings, error) {
	var resource IamPolicyBindings
	err := ctx.ReadResource("dynatrace:index/iamPolicyBindings:IamPolicyBindings", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IamPolicyBindings resources.
type iamPolicyBindingsState struct {
	// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
	Account *string `pulumi:"account"`
	// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
	Environment *string `pulumi:"environment"`
	// The name of the policy
	Group *string `pulumi:"group"`
	// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
	Policies []string `pulumi:"policies"`
}

type IamPolicyBindingsState struct {
	// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
	Account pulumi.StringPtrInput
	// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
	Environment pulumi.StringPtrInput
	// The name of the policy
	Group pulumi.StringPtrInput
	// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
	Policies pulumi.StringArrayInput
}

func (IamPolicyBindingsState) ElementType() reflect.Type {
	return reflect.TypeOf((*iamPolicyBindingsState)(nil)).Elem()
}

type iamPolicyBindingsArgs struct {
	// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
	Account *string `pulumi:"account"`
	// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
	Environment *string `pulumi:"environment"`
	// The name of the policy
	Group string `pulumi:"group"`
	// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
	Policies []string `pulumi:"policies"`
}

// The set of arguments for constructing a IamPolicyBindings resource.
type IamPolicyBindingsArgs struct {
	// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
	Account pulumi.StringPtrInput
	// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
	Environment pulumi.StringPtrInput
	// The name of the policy
	Group pulumi.StringInput
	// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
	Policies pulumi.StringArrayInput
}

func (IamPolicyBindingsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iamPolicyBindingsArgs)(nil)).Elem()
}

type IamPolicyBindingsInput interface {
	pulumi.Input

	ToIamPolicyBindingsOutput() IamPolicyBindingsOutput
	ToIamPolicyBindingsOutputWithContext(ctx context.Context) IamPolicyBindingsOutput
}

func (*IamPolicyBindings) ElementType() reflect.Type {
	return reflect.TypeOf((**IamPolicyBindings)(nil)).Elem()
}

func (i *IamPolicyBindings) ToIamPolicyBindingsOutput() IamPolicyBindingsOutput {
	return i.ToIamPolicyBindingsOutputWithContext(context.Background())
}

func (i *IamPolicyBindings) ToIamPolicyBindingsOutputWithContext(ctx context.Context) IamPolicyBindingsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPolicyBindingsOutput)
}

// IamPolicyBindingsArrayInput is an input type that accepts IamPolicyBindingsArray and IamPolicyBindingsArrayOutput values.
// You can construct a concrete instance of `IamPolicyBindingsArrayInput` via:
//
//	IamPolicyBindingsArray{ IamPolicyBindingsArgs{...} }
type IamPolicyBindingsArrayInput interface {
	pulumi.Input

	ToIamPolicyBindingsArrayOutput() IamPolicyBindingsArrayOutput
	ToIamPolicyBindingsArrayOutputWithContext(context.Context) IamPolicyBindingsArrayOutput
}

type IamPolicyBindingsArray []IamPolicyBindingsInput

func (IamPolicyBindingsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamPolicyBindings)(nil)).Elem()
}

func (i IamPolicyBindingsArray) ToIamPolicyBindingsArrayOutput() IamPolicyBindingsArrayOutput {
	return i.ToIamPolicyBindingsArrayOutputWithContext(context.Background())
}

func (i IamPolicyBindingsArray) ToIamPolicyBindingsArrayOutputWithContext(ctx context.Context) IamPolicyBindingsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPolicyBindingsArrayOutput)
}

// IamPolicyBindingsMapInput is an input type that accepts IamPolicyBindingsMap and IamPolicyBindingsMapOutput values.
// You can construct a concrete instance of `IamPolicyBindingsMapInput` via:
//
//	IamPolicyBindingsMap{ "key": IamPolicyBindingsArgs{...} }
type IamPolicyBindingsMapInput interface {
	pulumi.Input

	ToIamPolicyBindingsMapOutput() IamPolicyBindingsMapOutput
	ToIamPolicyBindingsMapOutputWithContext(context.Context) IamPolicyBindingsMapOutput
}

type IamPolicyBindingsMap map[string]IamPolicyBindingsInput

func (IamPolicyBindingsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamPolicyBindings)(nil)).Elem()
}

func (i IamPolicyBindingsMap) ToIamPolicyBindingsMapOutput() IamPolicyBindingsMapOutput {
	return i.ToIamPolicyBindingsMapOutputWithContext(context.Background())
}

func (i IamPolicyBindingsMap) ToIamPolicyBindingsMapOutputWithContext(ctx context.Context) IamPolicyBindingsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPolicyBindingsMapOutput)
}

type IamPolicyBindingsOutput struct{ *pulumi.OutputState }

func (IamPolicyBindingsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IamPolicyBindings)(nil)).Elem()
}

func (o IamPolicyBindingsOutput) ToIamPolicyBindingsOutput() IamPolicyBindingsOutput {
	return o
}

func (o IamPolicyBindingsOutput) ToIamPolicyBindingsOutputWithContext(ctx context.Context) IamPolicyBindingsOutput {
	return o
}

// The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
func (o IamPolicyBindingsOutput) Account() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IamPolicyBindings) pulumi.StringPtrOutput { return v.Account }).(pulumi.StringPtrOutput)
}

// The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
func (o IamPolicyBindingsOutput) Environment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IamPolicyBindings) pulumi.StringPtrOutput { return v.Environment }).(pulumi.StringPtrOutput)
}

// The name of the policy
func (o IamPolicyBindingsOutput) Group() pulumi.StringOutput {
	return o.ApplyT(func(v *IamPolicyBindings) pulumi.StringOutput { return v.Group }).(pulumi.StringOutput)
}

// A list of IDs referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
func (o IamPolicyBindingsOutput) Policies() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *IamPolicyBindings) pulumi.StringArrayOutput { return v.Policies }).(pulumi.StringArrayOutput)
}

type IamPolicyBindingsArrayOutput struct{ *pulumi.OutputState }

func (IamPolicyBindingsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamPolicyBindings)(nil)).Elem()
}

func (o IamPolicyBindingsArrayOutput) ToIamPolicyBindingsArrayOutput() IamPolicyBindingsArrayOutput {
	return o
}

func (o IamPolicyBindingsArrayOutput) ToIamPolicyBindingsArrayOutputWithContext(ctx context.Context) IamPolicyBindingsArrayOutput {
	return o
}

func (o IamPolicyBindingsArrayOutput) Index(i pulumi.IntInput) IamPolicyBindingsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IamPolicyBindings {
		return vs[0].([]*IamPolicyBindings)[vs[1].(int)]
	}).(IamPolicyBindingsOutput)
}

type IamPolicyBindingsMapOutput struct{ *pulumi.OutputState }

func (IamPolicyBindingsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamPolicyBindings)(nil)).Elem()
}

func (o IamPolicyBindingsMapOutput) ToIamPolicyBindingsMapOutput() IamPolicyBindingsMapOutput {
	return o
}

func (o IamPolicyBindingsMapOutput) ToIamPolicyBindingsMapOutputWithContext(ctx context.Context) IamPolicyBindingsMapOutput {
	return o
}

func (o IamPolicyBindingsMapOutput) MapIndex(k pulumi.StringInput) IamPolicyBindingsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IamPolicyBindings {
		return vs[0].(map[string]*IamPolicyBindings)[vs[1].(string)]
	}).(IamPolicyBindingsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IamPolicyBindingsInput)(nil)).Elem(), &IamPolicyBindings{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamPolicyBindingsArrayInput)(nil)).Elem(), IamPolicyBindingsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamPolicyBindingsMapInput)(nil)).Elem(), IamPolicyBindingsMap{})
	pulumi.RegisterOutputType(IamPolicyBindingsOutput{})
	pulumi.RegisterOutputType(IamPolicyBindingsArrayOutput{})
	pulumi.RegisterOutputType(IamPolicyBindingsMapOutput{})
}
