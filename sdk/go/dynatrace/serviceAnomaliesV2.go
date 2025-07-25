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

type ServiceAnomaliesV2 struct {
	pulumi.CustomResourceState

	// Failure rate
	FailureRate ServiceAnomaliesV2FailureRateOutput `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
	LoadDrops ServiceAnomaliesV2LoadDropsOutput `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
	LoadSpikes ServiceAnomaliesV2LoadSpikesOutput `pulumi:"loadSpikes"`
	// Response time
	ResponseTime ServiceAnomaliesV2ResponseTimeOutput `pulumi:"responseTime"`
	// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
}

// NewServiceAnomaliesV2 registers a new resource with the given unique name, arguments, and options.
func NewServiceAnomaliesV2(ctx *pulumi.Context,
	name string, args *ServiceAnomaliesV2Args, opts ...pulumi.ResourceOption) (*ServiceAnomaliesV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FailureRate == nil {
		return nil, errors.New("invalid value for required argument 'FailureRate'")
	}
	if args.LoadDrops == nil {
		return nil, errors.New("invalid value for required argument 'LoadDrops'")
	}
	if args.LoadSpikes == nil {
		return nil, errors.New("invalid value for required argument 'LoadSpikes'")
	}
	if args.ResponseTime == nil {
		return nil, errors.New("invalid value for required argument 'ResponseTime'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ServiceAnomaliesV2
	err := ctx.RegisterResource("dynatrace:index/serviceAnomaliesV2:ServiceAnomaliesV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceAnomaliesV2 gets an existing ServiceAnomaliesV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceAnomaliesV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceAnomaliesV2State, opts ...pulumi.ResourceOption) (*ServiceAnomaliesV2, error) {
	var resource ServiceAnomaliesV2
	err := ctx.ReadResource("dynatrace:index/serviceAnomaliesV2:ServiceAnomaliesV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceAnomaliesV2 resources.
type serviceAnomaliesV2State struct {
	// Failure rate
	FailureRate *ServiceAnomaliesV2FailureRate `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
	LoadDrops *ServiceAnomaliesV2LoadDrops `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
	LoadSpikes *ServiceAnomaliesV2LoadSpikes `pulumi:"loadSpikes"`
	// Response time
	ResponseTime *ServiceAnomaliesV2ResponseTime `pulumi:"responseTime"`
	// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

type ServiceAnomaliesV2State struct {
	// Failure rate
	FailureRate ServiceAnomaliesV2FailureRatePtrInput
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
	LoadDrops ServiceAnomaliesV2LoadDropsPtrInput
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
	LoadSpikes ServiceAnomaliesV2LoadSpikesPtrInput
	// Response time
	ResponseTime ServiceAnomaliesV2ResponseTimePtrInput
	// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (ServiceAnomaliesV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceAnomaliesV2State)(nil)).Elem()
}

type serviceAnomaliesV2Args struct {
	// Failure rate
	FailureRate ServiceAnomaliesV2FailureRate `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
	LoadDrops ServiceAnomaliesV2LoadDrops `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
	LoadSpikes ServiceAnomaliesV2LoadSpikes `pulumi:"loadSpikes"`
	// Response time
	ResponseTime ServiceAnomaliesV2ResponseTime `pulumi:"responseTime"`
	// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

// The set of arguments for constructing a ServiceAnomaliesV2 resource.
type ServiceAnomaliesV2Args struct {
	// Failure rate
	FailureRate ServiceAnomaliesV2FailureRateInput
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
	LoadDrops ServiceAnomaliesV2LoadDropsInput
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
	LoadSpikes ServiceAnomaliesV2LoadSpikesInput
	// Response time
	ResponseTime ServiceAnomaliesV2ResponseTimeInput
	// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (ServiceAnomaliesV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceAnomaliesV2Args)(nil)).Elem()
}

type ServiceAnomaliesV2Input interface {
	pulumi.Input

	ToServiceAnomaliesV2Output() ServiceAnomaliesV2Output
	ToServiceAnomaliesV2OutputWithContext(ctx context.Context) ServiceAnomaliesV2Output
}

func (*ServiceAnomaliesV2) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceAnomaliesV2)(nil)).Elem()
}

func (i *ServiceAnomaliesV2) ToServiceAnomaliesV2Output() ServiceAnomaliesV2Output {
	return i.ToServiceAnomaliesV2OutputWithContext(context.Background())
}

func (i *ServiceAnomaliesV2) ToServiceAnomaliesV2OutputWithContext(ctx context.Context) ServiceAnomaliesV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceAnomaliesV2Output)
}

// ServiceAnomaliesV2ArrayInput is an input type that accepts ServiceAnomaliesV2Array and ServiceAnomaliesV2ArrayOutput values.
// You can construct a concrete instance of `ServiceAnomaliesV2ArrayInput` via:
//
//	ServiceAnomaliesV2Array{ ServiceAnomaliesV2Args{...} }
type ServiceAnomaliesV2ArrayInput interface {
	pulumi.Input

	ToServiceAnomaliesV2ArrayOutput() ServiceAnomaliesV2ArrayOutput
	ToServiceAnomaliesV2ArrayOutputWithContext(context.Context) ServiceAnomaliesV2ArrayOutput
}

type ServiceAnomaliesV2Array []ServiceAnomaliesV2Input

func (ServiceAnomaliesV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceAnomaliesV2)(nil)).Elem()
}

func (i ServiceAnomaliesV2Array) ToServiceAnomaliesV2ArrayOutput() ServiceAnomaliesV2ArrayOutput {
	return i.ToServiceAnomaliesV2ArrayOutputWithContext(context.Background())
}

func (i ServiceAnomaliesV2Array) ToServiceAnomaliesV2ArrayOutputWithContext(ctx context.Context) ServiceAnomaliesV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceAnomaliesV2ArrayOutput)
}

// ServiceAnomaliesV2MapInput is an input type that accepts ServiceAnomaliesV2Map and ServiceAnomaliesV2MapOutput values.
// You can construct a concrete instance of `ServiceAnomaliesV2MapInput` via:
//
//	ServiceAnomaliesV2Map{ "key": ServiceAnomaliesV2Args{...} }
type ServiceAnomaliesV2MapInput interface {
	pulumi.Input

	ToServiceAnomaliesV2MapOutput() ServiceAnomaliesV2MapOutput
	ToServiceAnomaliesV2MapOutputWithContext(context.Context) ServiceAnomaliesV2MapOutput
}

type ServiceAnomaliesV2Map map[string]ServiceAnomaliesV2Input

func (ServiceAnomaliesV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceAnomaliesV2)(nil)).Elem()
}

func (i ServiceAnomaliesV2Map) ToServiceAnomaliesV2MapOutput() ServiceAnomaliesV2MapOutput {
	return i.ToServiceAnomaliesV2MapOutputWithContext(context.Background())
}

func (i ServiceAnomaliesV2Map) ToServiceAnomaliesV2MapOutputWithContext(ctx context.Context) ServiceAnomaliesV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceAnomaliesV2MapOutput)
}

type ServiceAnomaliesV2Output struct{ *pulumi.OutputState }

func (ServiceAnomaliesV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceAnomaliesV2)(nil)).Elem()
}

func (o ServiceAnomaliesV2Output) ToServiceAnomaliesV2Output() ServiceAnomaliesV2Output {
	return o
}

func (o ServiceAnomaliesV2Output) ToServiceAnomaliesV2OutputWithContext(ctx context.Context) ServiceAnomaliesV2Output {
	return o
}

// Failure rate
func (o ServiceAnomaliesV2Output) FailureRate() ServiceAnomaliesV2FailureRateOutput {
	return o.ApplyT(func(v *ServiceAnomaliesV2) ServiceAnomaliesV2FailureRateOutput { return v.FailureRate }).(ServiceAnomaliesV2FailureRateOutput)
}

// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
func (o ServiceAnomaliesV2Output) LoadDrops() ServiceAnomaliesV2LoadDropsOutput {
	return o.ApplyT(func(v *ServiceAnomaliesV2) ServiceAnomaliesV2LoadDropsOutput { return v.LoadDrops }).(ServiceAnomaliesV2LoadDropsOutput)
}

// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
func (o ServiceAnomaliesV2Output) LoadSpikes() ServiceAnomaliesV2LoadSpikesOutput {
	return o.ApplyT(func(v *ServiceAnomaliesV2) ServiceAnomaliesV2LoadSpikesOutput { return v.LoadSpikes }).(ServiceAnomaliesV2LoadSpikesOutput)
}

// Response time
func (o ServiceAnomaliesV2Output) ResponseTime() ServiceAnomaliesV2ResponseTimeOutput {
	return o.ApplyT(func(v *ServiceAnomaliesV2) ServiceAnomaliesV2ResponseTimeOutput { return v.ResponseTime }).(ServiceAnomaliesV2ResponseTimeOutput)
}

// The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
func (o ServiceAnomaliesV2Output) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServiceAnomaliesV2) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

type ServiceAnomaliesV2ArrayOutput struct{ *pulumi.OutputState }

func (ServiceAnomaliesV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceAnomaliesV2)(nil)).Elem()
}

func (o ServiceAnomaliesV2ArrayOutput) ToServiceAnomaliesV2ArrayOutput() ServiceAnomaliesV2ArrayOutput {
	return o
}

func (o ServiceAnomaliesV2ArrayOutput) ToServiceAnomaliesV2ArrayOutputWithContext(ctx context.Context) ServiceAnomaliesV2ArrayOutput {
	return o
}

func (o ServiceAnomaliesV2ArrayOutput) Index(i pulumi.IntInput) ServiceAnomaliesV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ServiceAnomaliesV2 {
		return vs[0].([]*ServiceAnomaliesV2)[vs[1].(int)]
	}).(ServiceAnomaliesV2Output)
}

type ServiceAnomaliesV2MapOutput struct{ *pulumi.OutputState }

func (ServiceAnomaliesV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceAnomaliesV2)(nil)).Elem()
}

func (o ServiceAnomaliesV2MapOutput) ToServiceAnomaliesV2MapOutput() ServiceAnomaliesV2MapOutput {
	return o
}

func (o ServiceAnomaliesV2MapOutput) ToServiceAnomaliesV2MapOutputWithContext(ctx context.Context) ServiceAnomaliesV2MapOutput {
	return o
}

func (o ServiceAnomaliesV2MapOutput) MapIndex(k pulumi.StringInput) ServiceAnomaliesV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ServiceAnomaliesV2 {
		return vs[0].(map[string]*ServiceAnomaliesV2)[vs[1].(string)]
	}).(ServiceAnomaliesV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceAnomaliesV2Input)(nil)).Elem(), &ServiceAnomaliesV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceAnomaliesV2ArrayInput)(nil)).Elem(), ServiceAnomaliesV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceAnomaliesV2MapInput)(nil)).Elem(), ServiceAnomaliesV2Map{})
	pulumi.RegisterOutputType(ServiceAnomaliesV2Output{})
	pulumi.RegisterOutputType(ServiceAnomaliesV2ArrayOutput{})
	pulumi.RegisterOutputType(ServiceAnomaliesV2MapOutput{})
}
