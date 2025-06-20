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
// > To utilize this resource, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **Allow read access for identity resources (users and groups)** (`account-idm-read`) and **Allow write access for identity resources (users and groups)** (`account-idm-write`).
//
// > This resource is excluded by default in the export utility, please explicitly specify the resource to retrieve existing configuration.
//
// ## Dynatrace Documentation
//
// - Dynatrace IAM - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions
//
// - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started
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
//			_, err := dynatrace.NewIamPermission(ctx, "permA", &dynatrace.IamPermissionArgs{
//				Account: pulumi.String("023733f0-86d8-47d1-88bd-7f5cc2e22eb8"),
//				Group:   pulumi.String("74ec0a82-8010-4f11-8579-b29a5ba865f0"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type IamPermission struct {
	pulumi.CustomResourceState

	// The UUID of the account this permission is valid for
	Account pulumi.StringPtrOutput `pulumi:"account"`
	// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
	Environment pulumi.StringPtrOutput `pulumi:"environment"`
	// The ID of the group this permission is valid for
	Group pulumi.StringOutput `pulumi:"group"`
	// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
	ManagementZone pulumi.StringPtrOutput `pulumi:"managementZone"`
	// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewIamPermission registers a new resource with the given unique name, arguments, and options.
func NewIamPermission(ctx *pulumi.Context,
	name string, args *IamPermissionArgs, opts ...pulumi.ResourceOption) (*IamPermission, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Group == nil {
		return nil, errors.New("invalid value for required argument 'Group'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IamPermission
	err := ctx.RegisterResource("dynatrace:index/iamPermission:IamPermission", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIamPermission gets an existing IamPermission resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIamPermission(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IamPermissionState, opts ...pulumi.ResourceOption) (*IamPermission, error) {
	var resource IamPermission
	err := ctx.ReadResource("dynatrace:index/iamPermission:IamPermission", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IamPermission resources.
type iamPermissionState struct {
	// The UUID of the account this permission is valid for
	Account *string `pulumi:"account"`
	// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
	Environment *string `pulumi:"environment"`
	// The ID of the group this permission is valid for
	Group *string `pulumi:"group"`
	// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
	ManagementZone *string `pulumi:"managementZone"`
	// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
	Name *string `pulumi:"name"`
}

type IamPermissionState struct {
	// The UUID of the account this permission is valid for
	Account pulumi.StringPtrInput
	// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
	Environment pulumi.StringPtrInput
	// The ID of the group this permission is valid for
	Group pulumi.StringPtrInput
	// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
	ManagementZone pulumi.StringPtrInput
	// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
	Name pulumi.StringPtrInput
}

func (IamPermissionState) ElementType() reflect.Type {
	return reflect.TypeOf((*iamPermissionState)(nil)).Elem()
}

type iamPermissionArgs struct {
	// The UUID of the account this permission is valid for
	Account *string `pulumi:"account"`
	// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
	Environment *string `pulumi:"environment"`
	// The ID of the group this permission is valid for
	Group string `pulumi:"group"`
	// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
	ManagementZone *string `pulumi:"managementZone"`
	// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a IamPermission resource.
type IamPermissionArgs struct {
	// The UUID of the account this permission is valid for
	Account pulumi.StringPtrInput
	// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
	Environment pulumi.StringPtrInput
	// The ID of the group this permission is valid for
	Group pulumi.StringInput
	// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
	ManagementZone pulumi.StringPtrInput
	// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
	Name pulumi.StringPtrInput
}

func (IamPermissionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iamPermissionArgs)(nil)).Elem()
}

type IamPermissionInput interface {
	pulumi.Input

	ToIamPermissionOutput() IamPermissionOutput
	ToIamPermissionOutputWithContext(ctx context.Context) IamPermissionOutput
}

func (*IamPermission) ElementType() reflect.Type {
	return reflect.TypeOf((**IamPermission)(nil)).Elem()
}

func (i *IamPermission) ToIamPermissionOutput() IamPermissionOutput {
	return i.ToIamPermissionOutputWithContext(context.Background())
}

func (i *IamPermission) ToIamPermissionOutputWithContext(ctx context.Context) IamPermissionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPermissionOutput)
}

// IamPermissionArrayInput is an input type that accepts IamPermissionArray and IamPermissionArrayOutput values.
// You can construct a concrete instance of `IamPermissionArrayInput` via:
//
//	IamPermissionArray{ IamPermissionArgs{...} }
type IamPermissionArrayInput interface {
	pulumi.Input

	ToIamPermissionArrayOutput() IamPermissionArrayOutput
	ToIamPermissionArrayOutputWithContext(context.Context) IamPermissionArrayOutput
}

type IamPermissionArray []IamPermissionInput

func (IamPermissionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamPermission)(nil)).Elem()
}

func (i IamPermissionArray) ToIamPermissionArrayOutput() IamPermissionArrayOutput {
	return i.ToIamPermissionArrayOutputWithContext(context.Background())
}

func (i IamPermissionArray) ToIamPermissionArrayOutputWithContext(ctx context.Context) IamPermissionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPermissionArrayOutput)
}

// IamPermissionMapInput is an input type that accepts IamPermissionMap and IamPermissionMapOutput values.
// You can construct a concrete instance of `IamPermissionMapInput` via:
//
//	IamPermissionMap{ "key": IamPermissionArgs{...} }
type IamPermissionMapInput interface {
	pulumi.Input

	ToIamPermissionMapOutput() IamPermissionMapOutput
	ToIamPermissionMapOutputWithContext(context.Context) IamPermissionMapOutput
}

type IamPermissionMap map[string]IamPermissionInput

func (IamPermissionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamPermission)(nil)).Elem()
}

func (i IamPermissionMap) ToIamPermissionMapOutput() IamPermissionMapOutput {
	return i.ToIamPermissionMapOutputWithContext(context.Background())
}

func (i IamPermissionMap) ToIamPermissionMapOutputWithContext(ctx context.Context) IamPermissionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamPermissionMapOutput)
}

type IamPermissionOutput struct{ *pulumi.OutputState }

func (IamPermissionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IamPermission)(nil)).Elem()
}

func (o IamPermissionOutput) ToIamPermissionOutput() IamPermissionOutput {
	return o
}

func (o IamPermissionOutput) ToIamPermissionOutputWithContext(ctx context.Context) IamPermissionOutput {
	return o
}

// The UUID of the account this permission is valid for
func (o IamPermissionOutput) Account() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IamPermission) pulumi.StringPtrOutput { return v.Account }).(pulumi.StringPtrOutput)
}

// The environment this permission is valid (`https://<environmentid>.live.dynatrace.com`). Also required in when trying to specify a management zone permission.
func (o IamPermissionOutput) Environment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IamPermission) pulumi.StringPtrOutput { return v.Environment }).(pulumi.StringPtrOutput)
}

// The ID of the group this permission is valid for
func (o IamPermissionOutput) Group() pulumi.StringOutput {
	return o.ApplyT(func(v *IamPermission) pulumi.StringOutput { return v.Group }).(pulumi.StringOutput)
}

// The management zone this permission is valid for. You need to use the attribute `legacyId` when referring to a resource `ManagementZoneV2` or a data source `ManagementZone`. The attribute `environment` is required to get specified also in order to identify the management zone uniquely.
func (o IamPermissionOutput) ManagementZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IamPermission) pulumi.StringPtrOutput { return v.ManagementZone }).(pulumi.StringPtrOutput)
}

// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
func (o IamPermissionOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *IamPermission) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type IamPermissionArrayOutput struct{ *pulumi.OutputState }

func (IamPermissionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamPermission)(nil)).Elem()
}

func (o IamPermissionArrayOutput) ToIamPermissionArrayOutput() IamPermissionArrayOutput {
	return o
}

func (o IamPermissionArrayOutput) ToIamPermissionArrayOutputWithContext(ctx context.Context) IamPermissionArrayOutput {
	return o
}

func (o IamPermissionArrayOutput) Index(i pulumi.IntInput) IamPermissionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IamPermission {
		return vs[0].([]*IamPermission)[vs[1].(int)]
	}).(IamPermissionOutput)
}

type IamPermissionMapOutput struct{ *pulumi.OutputState }

func (IamPermissionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamPermission)(nil)).Elem()
}

func (o IamPermissionMapOutput) ToIamPermissionMapOutput() IamPermissionMapOutput {
	return o
}

func (o IamPermissionMapOutput) ToIamPermissionMapOutputWithContext(ctx context.Context) IamPermissionMapOutput {
	return o
}

func (o IamPermissionMapOutput) MapIndex(k pulumi.StringInput) IamPermissionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IamPermission {
		return vs[0].(map[string]*IamPermission)[vs[1].(string)]
	}).(IamPermissionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IamPermissionInput)(nil)).Elem(), &IamPermission{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamPermissionArrayInput)(nil)).Elem(), IamPermissionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamPermissionMapInput)(nil)).Elem(), IamPermissionMap{})
	pulumi.RegisterOutputType(IamPermissionOutput{})
	pulumi.RegisterOutputType(IamPermissionArrayOutput{})
	pulumi.RegisterOutputType(IamPermissionMapOutput{})
}
