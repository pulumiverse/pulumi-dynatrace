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

type DatabaseAnomaliesV2 struct {
	pulumi.CustomResourceState

	// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
	DatabaseConnections DatabaseAnomaliesV2DatabaseConnectionsOutput `pulumi:"databaseConnections"`
	// Failure rate
	FailureRate DatabaseAnomaliesV2FailureRateOutput `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
	LoadDrops DatabaseAnomaliesV2LoadDropsOutput `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
	LoadSpikes DatabaseAnomaliesV2LoadSpikesOutput `pulumi:"loadSpikes"`
	// Response time
	ResponseTime DatabaseAnomaliesV2ResponseTimeOutput `pulumi:"responseTime"`
	// The scope for the database anomaly detection
	Scope pulumi.StringOutput `pulumi:"scope"`
}

// NewDatabaseAnomaliesV2 registers a new resource with the given unique name, arguments, and options.
func NewDatabaseAnomaliesV2(ctx *pulumi.Context,
	name string, args *DatabaseAnomaliesV2Args, opts ...pulumi.ResourceOption) (*DatabaseAnomaliesV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatabaseConnections == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseConnections'")
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
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DatabaseAnomaliesV2
	err := ctx.RegisterResource("dynatrace:index/databaseAnomaliesV2:DatabaseAnomaliesV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabaseAnomaliesV2 gets an existing DatabaseAnomaliesV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabaseAnomaliesV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseAnomaliesV2State, opts ...pulumi.ResourceOption) (*DatabaseAnomaliesV2, error) {
	var resource DatabaseAnomaliesV2
	err := ctx.ReadResource("dynatrace:index/databaseAnomaliesV2:DatabaseAnomaliesV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatabaseAnomaliesV2 resources.
type databaseAnomaliesV2State struct {
	// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
	DatabaseConnections *DatabaseAnomaliesV2DatabaseConnections `pulumi:"databaseConnections"`
	// Failure rate
	FailureRate *DatabaseAnomaliesV2FailureRate `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
	LoadDrops *DatabaseAnomaliesV2LoadDrops `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
	LoadSpikes *DatabaseAnomaliesV2LoadSpikes `pulumi:"loadSpikes"`
	// Response time
	ResponseTime *DatabaseAnomaliesV2ResponseTime `pulumi:"responseTime"`
	// The scope for the database anomaly detection
	Scope *string `pulumi:"scope"`
}

type DatabaseAnomaliesV2State struct {
	// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
	DatabaseConnections DatabaseAnomaliesV2DatabaseConnectionsPtrInput
	// Failure rate
	FailureRate DatabaseAnomaliesV2FailureRatePtrInput
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
	LoadDrops DatabaseAnomaliesV2LoadDropsPtrInput
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
	LoadSpikes DatabaseAnomaliesV2LoadSpikesPtrInput
	// Response time
	ResponseTime DatabaseAnomaliesV2ResponseTimePtrInput
	// The scope for the database anomaly detection
	Scope pulumi.StringPtrInput
}

func (DatabaseAnomaliesV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseAnomaliesV2State)(nil)).Elem()
}

type databaseAnomaliesV2Args struct {
	// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
	DatabaseConnections DatabaseAnomaliesV2DatabaseConnections `pulumi:"databaseConnections"`
	// Failure rate
	FailureRate DatabaseAnomaliesV2FailureRate `pulumi:"failureRate"`
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
	LoadDrops DatabaseAnomaliesV2LoadDrops `pulumi:"loadDrops"`
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
	LoadSpikes DatabaseAnomaliesV2LoadSpikes `pulumi:"loadSpikes"`
	// Response time
	ResponseTime DatabaseAnomaliesV2ResponseTime `pulumi:"responseTime"`
	// The scope for the database anomaly detection
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a DatabaseAnomaliesV2 resource.
type DatabaseAnomaliesV2Args struct {
	// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
	DatabaseConnections DatabaseAnomaliesV2DatabaseConnectionsInput
	// Failure rate
	FailureRate DatabaseAnomaliesV2FailureRateInput
	// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
	LoadDrops DatabaseAnomaliesV2LoadDropsInput
	// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
	LoadSpikes DatabaseAnomaliesV2LoadSpikesInput
	// Response time
	ResponseTime DatabaseAnomaliesV2ResponseTimeInput
	// The scope for the database anomaly detection
	Scope pulumi.StringInput
}

func (DatabaseAnomaliesV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseAnomaliesV2Args)(nil)).Elem()
}

type DatabaseAnomaliesV2Input interface {
	pulumi.Input

	ToDatabaseAnomaliesV2Output() DatabaseAnomaliesV2Output
	ToDatabaseAnomaliesV2OutputWithContext(ctx context.Context) DatabaseAnomaliesV2Output
}

func (*DatabaseAnomaliesV2) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabaseAnomaliesV2)(nil)).Elem()
}

func (i *DatabaseAnomaliesV2) ToDatabaseAnomaliesV2Output() DatabaseAnomaliesV2Output {
	return i.ToDatabaseAnomaliesV2OutputWithContext(context.Background())
}

func (i *DatabaseAnomaliesV2) ToDatabaseAnomaliesV2OutputWithContext(ctx context.Context) DatabaseAnomaliesV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseAnomaliesV2Output)
}

// DatabaseAnomaliesV2ArrayInput is an input type that accepts DatabaseAnomaliesV2Array and DatabaseAnomaliesV2ArrayOutput values.
// You can construct a concrete instance of `DatabaseAnomaliesV2ArrayInput` via:
//
//	DatabaseAnomaliesV2Array{ DatabaseAnomaliesV2Args{...} }
type DatabaseAnomaliesV2ArrayInput interface {
	pulumi.Input

	ToDatabaseAnomaliesV2ArrayOutput() DatabaseAnomaliesV2ArrayOutput
	ToDatabaseAnomaliesV2ArrayOutputWithContext(context.Context) DatabaseAnomaliesV2ArrayOutput
}

type DatabaseAnomaliesV2Array []DatabaseAnomaliesV2Input

func (DatabaseAnomaliesV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DatabaseAnomaliesV2)(nil)).Elem()
}

func (i DatabaseAnomaliesV2Array) ToDatabaseAnomaliesV2ArrayOutput() DatabaseAnomaliesV2ArrayOutput {
	return i.ToDatabaseAnomaliesV2ArrayOutputWithContext(context.Background())
}

func (i DatabaseAnomaliesV2Array) ToDatabaseAnomaliesV2ArrayOutputWithContext(ctx context.Context) DatabaseAnomaliesV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseAnomaliesV2ArrayOutput)
}

// DatabaseAnomaliesV2MapInput is an input type that accepts DatabaseAnomaliesV2Map and DatabaseAnomaliesV2MapOutput values.
// You can construct a concrete instance of `DatabaseAnomaliesV2MapInput` via:
//
//	DatabaseAnomaliesV2Map{ "key": DatabaseAnomaliesV2Args{...} }
type DatabaseAnomaliesV2MapInput interface {
	pulumi.Input

	ToDatabaseAnomaliesV2MapOutput() DatabaseAnomaliesV2MapOutput
	ToDatabaseAnomaliesV2MapOutputWithContext(context.Context) DatabaseAnomaliesV2MapOutput
}

type DatabaseAnomaliesV2Map map[string]DatabaseAnomaliesV2Input

func (DatabaseAnomaliesV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DatabaseAnomaliesV2)(nil)).Elem()
}

func (i DatabaseAnomaliesV2Map) ToDatabaseAnomaliesV2MapOutput() DatabaseAnomaliesV2MapOutput {
	return i.ToDatabaseAnomaliesV2MapOutputWithContext(context.Background())
}

func (i DatabaseAnomaliesV2Map) ToDatabaseAnomaliesV2MapOutputWithContext(ctx context.Context) DatabaseAnomaliesV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseAnomaliesV2MapOutput)
}

type DatabaseAnomaliesV2Output struct{ *pulumi.OutputState }

func (DatabaseAnomaliesV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabaseAnomaliesV2)(nil)).Elem()
}

func (o DatabaseAnomaliesV2Output) ToDatabaseAnomaliesV2Output() DatabaseAnomaliesV2Output {
	return o
}

func (o DatabaseAnomaliesV2Output) ToDatabaseAnomaliesV2OutputWithContext(ctx context.Context) DatabaseAnomaliesV2Output {
	return o
}

// Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
func (o DatabaseAnomaliesV2Output) DatabaseConnections() DatabaseAnomaliesV2DatabaseConnectionsOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) DatabaseAnomaliesV2DatabaseConnectionsOutput {
		return v.DatabaseConnections
	}).(DatabaseAnomaliesV2DatabaseConnectionsOutput)
}

// Failure rate
func (o DatabaseAnomaliesV2Output) FailureRate() DatabaseAnomaliesV2FailureRateOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) DatabaseAnomaliesV2FailureRateOutput { return v.FailureRate }).(DatabaseAnomaliesV2FailureRateOutput)
}

// Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
func (o DatabaseAnomaliesV2Output) LoadDrops() DatabaseAnomaliesV2LoadDropsOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) DatabaseAnomaliesV2LoadDropsOutput { return v.LoadDrops }).(DatabaseAnomaliesV2LoadDropsOutput)
}

// Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
func (o DatabaseAnomaliesV2Output) LoadSpikes() DatabaseAnomaliesV2LoadSpikesOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) DatabaseAnomaliesV2LoadSpikesOutput { return v.LoadSpikes }).(DatabaseAnomaliesV2LoadSpikesOutput)
}

// Response time
func (o DatabaseAnomaliesV2Output) ResponseTime() DatabaseAnomaliesV2ResponseTimeOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) DatabaseAnomaliesV2ResponseTimeOutput { return v.ResponseTime }).(DatabaseAnomaliesV2ResponseTimeOutput)
}

// The scope for the database anomaly detection
func (o DatabaseAnomaliesV2Output) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *DatabaseAnomaliesV2) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

type DatabaseAnomaliesV2ArrayOutput struct{ *pulumi.OutputState }

func (DatabaseAnomaliesV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DatabaseAnomaliesV2)(nil)).Elem()
}

func (o DatabaseAnomaliesV2ArrayOutput) ToDatabaseAnomaliesV2ArrayOutput() DatabaseAnomaliesV2ArrayOutput {
	return o
}

func (o DatabaseAnomaliesV2ArrayOutput) ToDatabaseAnomaliesV2ArrayOutputWithContext(ctx context.Context) DatabaseAnomaliesV2ArrayOutput {
	return o
}

func (o DatabaseAnomaliesV2ArrayOutput) Index(i pulumi.IntInput) DatabaseAnomaliesV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DatabaseAnomaliesV2 {
		return vs[0].([]*DatabaseAnomaliesV2)[vs[1].(int)]
	}).(DatabaseAnomaliesV2Output)
}

type DatabaseAnomaliesV2MapOutput struct{ *pulumi.OutputState }

func (DatabaseAnomaliesV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DatabaseAnomaliesV2)(nil)).Elem()
}

func (o DatabaseAnomaliesV2MapOutput) ToDatabaseAnomaliesV2MapOutput() DatabaseAnomaliesV2MapOutput {
	return o
}

func (o DatabaseAnomaliesV2MapOutput) ToDatabaseAnomaliesV2MapOutputWithContext(ctx context.Context) DatabaseAnomaliesV2MapOutput {
	return o
}

func (o DatabaseAnomaliesV2MapOutput) MapIndex(k pulumi.StringInput) DatabaseAnomaliesV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DatabaseAnomaliesV2 {
		return vs[0].(map[string]*DatabaseAnomaliesV2)[vs[1].(string)]
	}).(DatabaseAnomaliesV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseAnomaliesV2Input)(nil)).Elem(), &DatabaseAnomaliesV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseAnomaliesV2ArrayInput)(nil)).Elem(), DatabaseAnomaliesV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseAnomaliesV2MapInput)(nil)).Elem(), DatabaseAnomaliesV2Map{})
	pulumi.RegisterOutputType(DatabaseAnomaliesV2Output{})
	pulumi.RegisterOutputType(DatabaseAnomaliesV2ArrayOutput{})
	pulumi.RegisterOutputType(DatabaseAnomaliesV2MapOutput{})
}
