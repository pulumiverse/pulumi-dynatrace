// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ServiceFullWebService struct {
	pulumi.CustomResourceState

	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
	Conditions ServiceFullWebServiceConditionsPtrOutput `pulumi:"conditions"`
	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
	IdContributors ServiceFullWebServiceIdContributorsOutput `pulumi:"idContributors"`
	// Define a management zone filter for this service detection rule.
	ManagementZones pulumi.StringArrayOutput `pulumi:"managementZones"`
	// Rule name
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewServiceFullWebService registers a new resource with the given unique name, arguments, and options.
func NewServiceFullWebService(ctx *pulumi.Context,
	name string, args *ServiceFullWebServiceArgs, opts ...pulumi.ResourceOption) (*ServiceFullWebService, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.IdContributors == nil {
		return nil, errors.New("invalid value for required argument 'IdContributors'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource ServiceFullWebService
	err := ctx.RegisterResource("dynatrace:index/serviceFullWebService:ServiceFullWebService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceFullWebService gets an existing ServiceFullWebService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceFullWebService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceFullWebServiceState, opts ...pulumi.ResourceOption) (*ServiceFullWebService, error) {
	var resource ServiceFullWebService
	err := ctx.ReadResource("dynatrace:index/serviceFullWebService:ServiceFullWebService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceFullWebService resources.
type serviceFullWebServiceState struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
	Conditions *ServiceFullWebServiceConditions `pulumi:"conditions"`
	// Description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
	IdContributors *ServiceFullWebServiceIdContributors `pulumi:"idContributors"`
	// Define a management zone filter for this service detection rule.
	ManagementZones []string `pulumi:"managementZones"`
	// Rule name
	Name *string `pulumi:"name"`
}

type ServiceFullWebServiceState struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
	Conditions ServiceFullWebServiceConditionsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
	IdContributors ServiceFullWebServiceIdContributorsPtrInput
	// Define a management zone filter for this service detection rule.
	ManagementZones pulumi.StringArrayInput
	// Rule name
	Name pulumi.StringPtrInput
}

func (ServiceFullWebServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceFullWebServiceState)(nil)).Elem()
}

type serviceFullWebServiceArgs struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
	Conditions *ServiceFullWebServiceConditions `pulumi:"conditions"`
	// Description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
	IdContributors ServiceFullWebServiceIdContributors `pulumi:"idContributors"`
	// Define a management zone filter for this service detection rule.
	ManagementZones []string `pulumi:"managementZones"`
	// Rule name
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a ServiceFullWebService resource.
type ServiceFullWebServiceArgs struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
	Conditions ServiceFullWebServiceConditionsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
	IdContributors ServiceFullWebServiceIdContributorsInput
	// Define a management zone filter for this service detection rule.
	ManagementZones pulumi.StringArrayInput
	// Rule name
	Name pulumi.StringPtrInput
}

func (ServiceFullWebServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceFullWebServiceArgs)(nil)).Elem()
}

type ServiceFullWebServiceInput interface {
	pulumi.Input

	ToServiceFullWebServiceOutput() ServiceFullWebServiceOutput
	ToServiceFullWebServiceOutputWithContext(ctx context.Context) ServiceFullWebServiceOutput
}

func (*ServiceFullWebService) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceFullWebService)(nil)).Elem()
}

func (i *ServiceFullWebService) ToServiceFullWebServiceOutput() ServiceFullWebServiceOutput {
	return i.ToServiceFullWebServiceOutputWithContext(context.Background())
}

func (i *ServiceFullWebService) ToServiceFullWebServiceOutputWithContext(ctx context.Context) ServiceFullWebServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebServiceOutput)
}

// ServiceFullWebServiceArrayInput is an input type that accepts ServiceFullWebServiceArray and ServiceFullWebServiceArrayOutput values.
// You can construct a concrete instance of `ServiceFullWebServiceArrayInput` via:
//
//	ServiceFullWebServiceArray{ ServiceFullWebServiceArgs{...} }
type ServiceFullWebServiceArrayInput interface {
	pulumi.Input

	ToServiceFullWebServiceArrayOutput() ServiceFullWebServiceArrayOutput
	ToServiceFullWebServiceArrayOutputWithContext(context.Context) ServiceFullWebServiceArrayOutput
}

type ServiceFullWebServiceArray []ServiceFullWebServiceInput

func (ServiceFullWebServiceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceFullWebService)(nil)).Elem()
}

func (i ServiceFullWebServiceArray) ToServiceFullWebServiceArrayOutput() ServiceFullWebServiceArrayOutput {
	return i.ToServiceFullWebServiceArrayOutputWithContext(context.Background())
}

func (i ServiceFullWebServiceArray) ToServiceFullWebServiceArrayOutputWithContext(ctx context.Context) ServiceFullWebServiceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebServiceArrayOutput)
}

// ServiceFullWebServiceMapInput is an input type that accepts ServiceFullWebServiceMap and ServiceFullWebServiceMapOutput values.
// You can construct a concrete instance of `ServiceFullWebServiceMapInput` via:
//
//	ServiceFullWebServiceMap{ "key": ServiceFullWebServiceArgs{...} }
type ServiceFullWebServiceMapInput interface {
	pulumi.Input

	ToServiceFullWebServiceMapOutput() ServiceFullWebServiceMapOutput
	ToServiceFullWebServiceMapOutputWithContext(context.Context) ServiceFullWebServiceMapOutput
}

type ServiceFullWebServiceMap map[string]ServiceFullWebServiceInput

func (ServiceFullWebServiceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceFullWebService)(nil)).Elem()
}

func (i ServiceFullWebServiceMap) ToServiceFullWebServiceMapOutput() ServiceFullWebServiceMapOutput {
	return i.ToServiceFullWebServiceMapOutputWithContext(context.Background())
}

func (i ServiceFullWebServiceMap) ToServiceFullWebServiceMapOutputWithContext(ctx context.Context) ServiceFullWebServiceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebServiceMapOutput)
}

type ServiceFullWebServiceOutput struct{ *pulumi.OutputState }

func (ServiceFullWebServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceFullWebService)(nil)).Elem()
}

func (o ServiceFullWebServiceOutput) ToServiceFullWebServiceOutput() ServiceFullWebServiceOutput {
	return o
}

func (o ServiceFullWebServiceOutput) ToServiceFullWebServiceOutputWithContext(ctx context.Context) ServiceFullWebServiceOutput {
	return o
}

// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they **all** must match a Request for the rule to apply. Conditions evaluate against attributes, but do not modify them.
func (o ServiceFullWebServiceOutput) Conditions() ServiceFullWebServiceConditionsPtrOutput {
	return o.ApplyT(func(v *ServiceFullWebService) ServiceFullWebServiceConditionsPtrOutput { return v.Conditions }).(ServiceFullWebServiceConditionsPtrOutput)
}

// Description
func (o ServiceFullWebServiceOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServiceFullWebService) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ServiceFullWebServiceOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ServiceFullWebService) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Contributors to the Service Identifier calculation. All of the Contributors always get applied.
func (o ServiceFullWebServiceOutput) IdContributors() ServiceFullWebServiceIdContributorsOutput {
	return o.ApplyT(func(v *ServiceFullWebService) ServiceFullWebServiceIdContributorsOutput { return v.IdContributors }).(ServiceFullWebServiceIdContributorsOutput)
}

// Define a management zone filter for this service detection rule.
func (o ServiceFullWebServiceOutput) ManagementZones() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ServiceFullWebService) pulumi.StringArrayOutput { return v.ManagementZones }).(pulumi.StringArrayOutput)
}

// Rule name
func (o ServiceFullWebServiceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ServiceFullWebService) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type ServiceFullWebServiceArrayOutput struct{ *pulumi.OutputState }

func (ServiceFullWebServiceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceFullWebService)(nil)).Elem()
}

func (o ServiceFullWebServiceArrayOutput) ToServiceFullWebServiceArrayOutput() ServiceFullWebServiceArrayOutput {
	return o
}

func (o ServiceFullWebServiceArrayOutput) ToServiceFullWebServiceArrayOutputWithContext(ctx context.Context) ServiceFullWebServiceArrayOutput {
	return o
}

func (o ServiceFullWebServiceArrayOutput) Index(i pulumi.IntInput) ServiceFullWebServiceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ServiceFullWebService {
		return vs[0].([]*ServiceFullWebService)[vs[1].(int)]
	}).(ServiceFullWebServiceOutput)
}

type ServiceFullWebServiceMapOutput struct{ *pulumi.OutputState }

func (ServiceFullWebServiceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceFullWebService)(nil)).Elem()
}

func (o ServiceFullWebServiceMapOutput) ToServiceFullWebServiceMapOutput() ServiceFullWebServiceMapOutput {
	return o
}

func (o ServiceFullWebServiceMapOutput) ToServiceFullWebServiceMapOutputWithContext(ctx context.Context) ServiceFullWebServiceMapOutput {
	return o
}

func (o ServiceFullWebServiceMapOutput) MapIndex(k pulumi.StringInput) ServiceFullWebServiceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ServiceFullWebService {
		return vs[0].(map[string]*ServiceFullWebService)[vs[1].(string)]
	}).(ServiceFullWebServiceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebServiceInput)(nil)).Elem(), &ServiceFullWebService{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebServiceArrayInput)(nil)).Elem(), ServiceFullWebServiceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebServiceMapInput)(nil)).Elem(), ServiceFullWebServiceMap{})
	pulumi.RegisterOutputType(ServiceFullWebServiceOutput{})
	pulumi.RegisterOutputType(ServiceFullWebServiceArrayOutput{})
	pulumi.RegisterOutputType(ServiceFullWebServiceMapOutput{})
}