// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// !> This resource API endpoint has been deprecated.
//
// > This resource requires the API token scopes **Read settings** (`settings.read`) and **Write settings** (`settings.write`)
//
// ## Dynatrace Documentation
//
// - DDU Pools - https://www.dynatrace.com/support/help/monitoring-consumption/davis-data-units#ddu-pools
//
// - Settings API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/settings (schemaId: `builtin:accounting.ddu.limit`)
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
//			_, err := dynatrace.NewDduPool(ctx, "#name#", &dynatrace.DduPoolArgs{
//				Events: &dynatrace.DduPoolEventsArgs{
//					Enabled: pulumi.Bool(true),
//					Type:    pulumi.String("MONTHLY"),
//					Value:   pulumi.Int(125),
//				},
//				LogMonitoring: &dynatrace.DduPoolLogMonitoringArgs{
//					Enabled: pulumi.Bool(true),
//					Type:    pulumi.String("MONTHLY"),
//					Value:   pulumi.Int(124),
//				},
//				Metrics: &dynatrace.DduPoolMetricsArgs{
//					Enabled: pulumi.Bool(true),
//					Type:    pulumi.String("MONTHLY"),
//					Value:   pulumi.Int(123),
//				},
//				Serverless: &dynatrace.DduPoolServerlessArgs{
//					Enabled: pulumi.Bool(true),
//					Type:    pulumi.String("MONTHLY"),
//					Value:   pulumi.Int(126),
//				},
//				Traces: &dynatrace.DduPoolTracesArgs{
//					Enabled: pulumi.Bool(true),
//					Type:    pulumi.String("MONTHLY"),
//					Value:   pulumi.Int(127),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type DduPool struct {
	pulumi.CustomResourceState

	// DDU pool settings for Events
	Events DduPoolEventsPtrOutput `pulumi:"events"`
	// DDU pool settings for Log Monitoring
	LogMonitoring DduPoolLogMonitoringPtrOutput `pulumi:"logMonitoring"`
	// DDU pool settings for Metrics
	Metrics DduPoolMetricsPtrOutput `pulumi:"metrics"`
	// DDU pool settings for Serverless
	Serverless DduPoolServerlessPtrOutput `pulumi:"serverless"`
	// DDU pool settings for Traces
	Traces DduPoolTracesPtrOutput `pulumi:"traces"`
}

// NewDduPool registers a new resource with the given unique name, arguments, and options.
func NewDduPool(ctx *pulumi.Context,
	name string, args *DduPoolArgs, opts ...pulumi.ResourceOption) (*DduPool, error) {
	if args == nil {
		args = &DduPoolArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DduPool
	err := ctx.RegisterResource("dynatrace:index/dduPool:DduPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDduPool gets an existing DduPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDduPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DduPoolState, opts ...pulumi.ResourceOption) (*DduPool, error) {
	var resource DduPool
	err := ctx.ReadResource("dynatrace:index/dduPool:DduPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DduPool resources.
type dduPoolState struct {
	// DDU pool settings for Events
	Events *DduPoolEvents `pulumi:"events"`
	// DDU pool settings for Log Monitoring
	LogMonitoring *DduPoolLogMonitoring `pulumi:"logMonitoring"`
	// DDU pool settings for Metrics
	Metrics *DduPoolMetrics `pulumi:"metrics"`
	// DDU pool settings for Serverless
	Serverless *DduPoolServerless `pulumi:"serverless"`
	// DDU pool settings for Traces
	Traces *DduPoolTraces `pulumi:"traces"`
}

type DduPoolState struct {
	// DDU pool settings for Events
	Events DduPoolEventsPtrInput
	// DDU pool settings for Log Monitoring
	LogMonitoring DduPoolLogMonitoringPtrInput
	// DDU pool settings for Metrics
	Metrics DduPoolMetricsPtrInput
	// DDU pool settings for Serverless
	Serverless DduPoolServerlessPtrInput
	// DDU pool settings for Traces
	Traces DduPoolTracesPtrInput
}

func (DduPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*dduPoolState)(nil)).Elem()
}

type dduPoolArgs struct {
	// DDU pool settings for Events
	Events *DduPoolEvents `pulumi:"events"`
	// DDU pool settings for Log Monitoring
	LogMonitoring *DduPoolLogMonitoring `pulumi:"logMonitoring"`
	// DDU pool settings for Metrics
	Metrics *DduPoolMetrics `pulumi:"metrics"`
	// DDU pool settings for Serverless
	Serverless *DduPoolServerless `pulumi:"serverless"`
	// DDU pool settings for Traces
	Traces *DduPoolTraces `pulumi:"traces"`
}

// The set of arguments for constructing a DduPool resource.
type DduPoolArgs struct {
	// DDU pool settings for Events
	Events DduPoolEventsPtrInput
	// DDU pool settings for Log Monitoring
	LogMonitoring DduPoolLogMonitoringPtrInput
	// DDU pool settings for Metrics
	Metrics DduPoolMetricsPtrInput
	// DDU pool settings for Serverless
	Serverless DduPoolServerlessPtrInput
	// DDU pool settings for Traces
	Traces DduPoolTracesPtrInput
}

func (DduPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dduPoolArgs)(nil)).Elem()
}

type DduPoolInput interface {
	pulumi.Input

	ToDduPoolOutput() DduPoolOutput
	ToDduPoolOutputWithContext(ctx context.Context) DduPoolOutput
}

func (*DduPool) ElementType() reflect.Type {
	return reflect.TypeOf((**DduPool)(nil)).Elem()
}

func (i *DduPool) ToDduPoolOutput() DduPoolOutput {
	return i.ToDduPoolOutputWithContext(context.Background())
}

func (i *DduPool) ToDduPoolOutputWithContext(ctx context.Context) DduPoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DduPoolOutput)
}

// DduPoolArrayInput is an input type that accepts DduPoolArray and DduPoolArrayOutput values.
// You can construct a concrete instance of `DduPoolArrayInput` via:
//
//	DduPoolArray{ DduPoolArgs{...} }
type DduPoolArrayInput interface {
	pulumi.Input

	ToDduPoolArrayOutput() DduPoolArrayOutput
	ToDduPoolArrayOutputWithContext(context.Context) DduPoolArrayOutput
}

type DduPoolArray []DduPoolInput

func (DduPoolArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DduPool)(nil)).Elem()
}

func (i DduPoolArray) ToDduPoolArrayOutput() DduPoolArrayOutput {
	return i.ToDduPoolArrayOutputWithContext(context.Background())
}

func (i DduPoolArray) ToDduPoolArrayOutputWithContext(ctx context.Context) DduPoolArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DduPoolArrayOutput)
}

// DduPoolMapInput is an input type that accepts DduPoolMap and DduPoolMapOutput values.
// You can construct a concrete instance of `DduPoolMapInput` via:
//
//	DduPoolMap{ "key": DduPoolArgs{...} }
type DduPoolMapInput interface {
	pulumi.Input

	ToDduPoolMapOutput() DduPoolMapOutput
	ToDduPoolMapOutputWithContext(context.Context) DduPoolMapOutput
}

type DduPoolMap map[string]DduPoolInput

func (DduPoolMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DduPool)(nil)).Elem()
}

func (i DduPoolMap) ToDduPoolMapOutput() DduPoolMapOutput {
	return i.ToDduPoolMapOutputWithContext(context.Background())
}

func (i DduPoolMap) ToDduPoolMapOutputWithContext(ctx context.Context) DduPoolMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DduPoolMapOutput)
}

type DduPoolOutput struct{ *pulumi.OutputState }

func (DduPoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DduPool)(nil)).Elem()
}

func (o DduPoolOutput) ToDduPoolOutput() DduPoolOutput {
	return o
}

func (o DduPoolOutput) ToDduPoolOutputWithContext(ctx context.Context) DduPoolOutput {
	return o
}

// DDU pool settings for Events
func (o DduPoolOutput) Events() DduPoolEventsPtrOutput {
	return o.ApplyT(func(v *DduPool) DduPoolEventsPtrOutput { return v.Events }).(DduPoolEventsPtrOutput)
}

// DDU pool settings for Log Monitoring
func (o DduPoolOutput) LogMonitoring() DduPoolLogMonitoringPtrOutput {
	return o.ApplyT(func(v *DduPool) DduPoolLogMonitoringPtrOutput { return v.LogMonitoring }).(DduPoolLogMonitoringPtrOutput)
}

// DDU pool settings for Metrics
func (o DduPoolOutput) Metrics() DduPoolMetricsPtrOutput {
	return o.ApplyT(func(v *DduPool) DduPoolMetricsPtrOutput { return v.Metrics }).(DduPoolMetricsPtrOutput)
}

// DDU pool settings for Serverless
func (o DduPoolOutput) Serverless() DduPoolServerlessPtrOutput {
	return o.ApplyT(func(v *DduPool) DduPoolServerlessPtrOutput { return v.Serverless }).(DduPoolServerlessPtrOutput)
}

// DDU pool settings for Traces
func (o DduPoolOutput) Traces() DduPoolTracesPtrOutput {
	return o.ApplyT(func(v *DduPool) DduPoolTracesPtrOutput { return v.Traces }).(DduPoolTracesPtrOutput)
}

type DduPoolArrayOutput struct{ *pulumi.OutputState }

func (DduPoolArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DduPool)(nil)).Elem()
}

func (o DduPoolArrayOutput) ToDduPoolArrayOutput() DduPoolArrayOutput {
	return o
}

func (o DduPoolArrayOutput) ToDduPoolArrayOutputWithContext(ctx context.Context) DduPoolArrayOutput {
	return o
}

func (o DduPoolArrayOutput) Index(i pulumi.IntInput) DduPoolOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DduPool {
		return vs[0].([]*DduPool)[vs[1].(int)]
	}).(DduPoolOutput)
}

type DduPoolMapOutput struct{ *pulumi.OutputState }

func (DduPoolMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DduPool)(nil)).Elem()
}

func (o DduPoolMapOutput) ToDduPoolMapOutput() DduPoolMapOutput {
	return o
}

func (o DduPoolMapOutput) ToDduPoolMapOutputWithContext(ctx context.Context) DduPoolMapOutput {
	return o
}

func (o DduPoolMapOutput) MapIndex(k pulumi.StringInput) DduPoolOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DduPool {
		return vs[0].(map[string]*DduPool)[vs[1].(string)]
	}).(DduPoolOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DduPoolInput)(nil)).Elem(), &DduPool{})
	pulumi.RegisterInputType(reflect.TypeOf((*DduPoolArrayInput)(nil)).Elem(), DduPoolArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DduPoolMapInput)(nil)).Elem(), DduPoolMap{})
	pulumi.RegisterOutputType(DduPoolOutput{})
	pulumi.RegisterOutputType(DduPoolArrayOutput{})
	pulumi.RegisterOutputType(DduPoolMapOutput{})
}
