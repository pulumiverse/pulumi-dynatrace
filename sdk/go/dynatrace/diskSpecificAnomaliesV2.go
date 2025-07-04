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

type DiskSpecificAnomaliesV2 struct {
	pulumi.CustomResourceState

	// The id for the disk anomaly detection
	DiskId pulumi.StringOutput `pulumi:"diskId"`
	// no documentation available
	DiskLowInodesDetection DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrOutput `pulumi:"diskLowInodesDetection"`
	// no documentation available
	DiskLowSpaceDetection DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrOutput `pulumi:"diskLowSpaceDetection"`
	// no documentation available
	DiskSlowWritesAndReadsDetection DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrOutput `pulumi:"diskSlowWritesAndReadsDetection"`
	// Override low disk space detection settings
	OverrideDiskLowSpaceDetection pulumi.BoolOutput `pulumi:"overrideDiskLowSpaceDetection"`
	// Override low inodes detection settings
	OverrideLowInodesDetection pulumi.BoolOutput `pulumi:"overrideLowInodesDetection"`
	// Override slow writes and reads detection settings
	OverrideSlowWritesAndReadsDetection pulumi.BoolOutput `pulumi:"overrideSlowWritesAndReadsDetection"`
}

// NewDiskSpecificAnomaliesV2 registers a new resource with the given unique name, arguments, and options.
func NewDiskSpecificAnomaliesV2(ctx *pulumi.Context,
	name string, args *DiskSpecificAnomaliesV2Args, opts ...pulumi.ResourceOption) (*DiskSpecificAnomaliesV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DiskId == nil {
		return nil, errors.New("invalid value for required argument 'DiskId'")
	}
	if args.OverrideDiskLowSpaceDetection == nil {
		return nil, errors.New("invalid value for required argument 'OverrideDiskLowSpaceDetection'")
	}
	if args.OverrideLowInodesDetection == nil {
		return nil, errors.New("invalid value for required argument 'OverrideLowInodesDetection'")
	}
	if args.OverrideSlowWritesAndReadsDetection == nil {
		return nil, errors.New("invalid value for required argument 'OverrideSlowWritesAndReadsDetection'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DiskSpecificAnomaliesV2
	err := ctx.RegisterResource("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDiskSpecificAnomaliesV2 gets an existing DiskSpecificAnomaliesV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDiskSpecificAnomaliesV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DiskSpecificAnomaliesV2State, opts ...pulumi.ResourceOption) (*DiskSpecificAnomaliesV2, error) {
	var resource DiskSpecificAnomaliesV2
	err := ctx.ReadResource("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DiskSpecificAnomaliesV2 resources.
type diskSpecificAnomaliesV2State struct {
	// The id for the disk anomaly detection
	DiskId *string `pulumi:"diskId"`
	// no documentation available
	DiskLowInodesDetection *DiskSpecificAnomaliesV2DiskLowInodesDetection `pulumi:"diskLowInodesDetection"`
	// no documentation available
	DiskLowSpaceDetection *DiskSpecificAnomaliesV2DiskLowSpaceDetection `pulumi:"diskLowSpaceDetection"`
	// no documentation available
	DiskSlowWritesAndReadsDetection *DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection `pulumi:"diskSlowWritesAndReadsDetection"`
	// Override low disk space detection settings
	OverrideDiskLowSpaceDetection *bool `pulumi:"overrideDiskLowSpaceDetection"`
	// Override low inodes detection settings
	OverrideLowInodesDetection *bool `pulumi:"overrideLowInodesDetection"`
	// Override slow writes and reads detection settings
	OverrideSlowWritesAndReadsDetection *bool `pulumi:"overrideSlowWritesAndReadsDetection"`
}

type DiskSpecificAnomaliesV2State struct {
	// The id for the disk anomaly detection
	DiskId pulumi.StringPtrInput
	// no documentation available
	DiskLowInodesDetection DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrInput
	// no documentation available
	DiskLowSpaceDetection DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrInput
	// no documentation available
	DiskSlowWritesAndReadsDetection DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrInput
	// Override low disk space detection settings
	OverrideDiskLowSpaceDetection pulumi.BoolPtrInput
	// Override low inodes detection settings
	OverrideLowInodesDetection pulumi.BoolPtrInput
	// Override slow writes and reads detection settings
	OverrideSlowWritesAndReadsDetection pulumi.BoolPtrInput
}

func (DiskSpecificAnomaliesV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*diskSpecificAnomaliesV2State)(nil)).Elem()
}

type diskSpecificAnomaliesV2Args struct {
	// The id for the disk anomaly detection
	DiskId string `pulumi:"diskId"`
	// no documentation available
	DiskLowInodesDetection *DiskSpecificAnomaliesV2DiskLowInodesDetection `pulumi:"diskLowInodesDetection"`
	// no documentation available
	DiskLowSpaceDetection *DiskSpecificAnomaliesV2DiskLowSpaceDetection `pulumi:"diskLowSpaceDetection"`
	// no documentation available
	DiskSlowWritesAndReadsDetection *DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection `pulumi:"diskSlowWritesAndReadsDetection"`
	// Override low disk space detection settings
	OverrideDiskLowSpaceDetection bool `pulumi:"overrideDiskLowSpaceDetection"`
	// Override low inodes detection settings
	OverrideLowInodesDetection bool `pulumi:"overrideLowInodesDetection"`
	// Override slow writes and reads detection settings
	OverrideSlowWritesAndReadsDetection bool `pulumi:"overrideSlowWritesAndReadsDetection"`
}

// The set of arguments for constructing a DiskSpecificAnomaliesV2 resource.
type DiskSpecificAnomaliesV2Args struct {
	// The id for the disk anomaly detection
	DiskId pulumi.StringInput
	// no documentation available
	DiskLowInodesDetection DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrInput
	// no documentation available
	DiskLowSpaceDetection DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrInput
	// no documentation available
	DiskSlowWritesAndReadsDetection DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrInput
	// Override low disk space detection settings
	OverrideDiskLowSpaceDetection pulumi.BoolInput
	// Override low inodes detection settings
	OverrideLowInodesDetection pulumi.BoolInput
	// Override slow writes and reads detection settings
	OverrideSlowWritesAndReadsDetection pulumi.BoolInput
}

func (DiskSpecificAnomaliesV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*diskSpecificAnomaliesV2Args)(nil)).Elem()
}

type DiskSpecificAnomaliesV2Input interface {
	pulumi.Input

	ToDiskSpecificAnomaliesV2Output() DiskSpecificAnomaliesV2Output
	ToDiskSpecificAnomaliesV2OutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2Output
}

func (*DiskSpecificAnomaliesV2) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (i *DiskSpecificAnomaliesV2) ToDiskSpecificAnomaliesV2Output() DiskSpecificAnomaliesV2Output {
	return i.ToDiskSpecificAnomaliesV2OutputWithContext(context.Background())
}

func (i *DiskSpecificAnomaliesV2) ToDiskSpecificAnomaliesV2OutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(DiskSpecificAnomaliesV2Output)
}

// DiskSpecificAnomaliesV2ArrayInput is an input type that accepts DiskSpecificAnomaliesV2Array and DiskSpecificAnomaliesV2ArrayOutput values.
// You can construct a concrete instance of `DiskSpecificAnomaliesV2ArrayInput` via:
//
//	DiskSpecificAnomaliesV2Array{ DiskSpecificAnomaliesV2Args{...} }
type DiskSpecificAnomaliesV2ArrayInput interface {
	pulumi.Input

	ToDiskSpecificAnomaliesV2ArrayOutput() DiskSpecificAnomaliesV2ArrayOutput
	ToDiskSpecificAnomaliesV2ArrayOutputWithContext(context.Context) DiskSpecificAnomaliesV2ArrayOutput
}

type DiskSpecificAnomaliesV2Array []DiskSpecificAnomaliesV2Input

func (DiskSpecificAnomaliesV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (i DiskSpecificAnomaliesV2Array) ToDiskSpecificAnomaliesV2ArrayOutput() DiskSpecificAnomaliesV2ArrayOutput {
	return i.ToDiskSpecificAnomaliesV2ArrayOutputWithContext(context.Background())
}

func (i DiskSpecificAnomaliesV2Array) ToDiskSpecificAnomaliesV2ArrayOutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskSpecificAnomaliesV2ArrayOutput)
}

// DiskSpecificAnomaliesV2MapInput is an input type that accepts DiskSpecificAnomaliesV2Map and DiskSpecificAnomaliesV2MapOutput values.
// You can construct a concrete instance of `DiskSpecificAnomaliesV2MapInput` via:
//
//	DiskSpecificAnomaliesV2Map{ "key": DiskSpecificAnomaliesV2Args{...} }
type DiskSpecificAnomaliesV2MapInput interface {
	pulumi.Input

	ToDiskSpecificAnomaliesV2MapOutput() DiskSpecificAnomaliesV2MapOutput
	ToDiskSpecificAnomaliesV2MapOutputWithContext(context.Context) DiskSpecificAnomaliesV2MapOutput
}

type DiskSpecificAnomaliesV2Map map[string]DiskSpecificAnomaliesV2Input

func (DiskSpecificAnomaliesV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (i DiskSpecificAnomaliesV2Map) ToDiskSpecificAnomaliesV2MapOutput() DiskSpecificAnomaliesV2MapOutput {
	return i.ToDiskSpecificAnomaliesV2MapOutputWithContext(context.Background())
}

func (i DiskSpecificAnomaliesV2Map) ToDiskSpecificAnomaliesV2MapOutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskSpecificAnomaliesV2MapOutput)
}

type DiskSpecificAnomaliesV2Output struct{ *pulumi.OutputState }

func (DiskSpecificAnomaliesV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (o DiskSpecificAnomaliesV2Output) ToDiskSpecificAnomaliesV2Output() DiskSpecificAnomaliesV2Output {
	return o
}

func (o DiskSpecificAnomaliesV2Output) ToDiskSpecificAnomaliesV2OutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2Output {
	return o
}

// The id for the disk anomaly detection
func (o DiskSpecificAnomaliesV2Output) DiskId() pulumi.StringOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) pulumi.StringOutput { return v.DiskId }).(pulumi.StringOutput)
}

// no documentation available
func (o DiskSpecificAnomaliesV2Output) DiskLowInodesDetection() DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrOutput {
		return v.DiskLowInodesDetection
	}).(DiskSpecificAnomaliesV2DiskLowInodesDetectionPtrOutput)
}

// no documentation available
func (o DiskSpecificAnomaliesV2Output) DiskLowSpaceDetection() DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrOutput {
		return v.DiskLowSpaceDetection
	}).(DiskSpecificAnomaliesV2DiskLowSpaceDetectionPtrOutput)
}

// no documentation available
func (o DiskSpecificAnomaliesV2Output) DiskSlowWritesAndReadsDetection() DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrOutput {
		return v.DiskSlowWritesAndReadsDetection
	}).(DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionPtrOutput)
}

// Override low disk space detection settings
func (o DiskSpecificAnomaliesV2Output) OverrideDiskLowSpaceDetection() pulumi.BoolOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) pulumi.BoolOutput { return v.OverrideDiskLowSpaceDetection }).(pulumi.BoolOutput)
}

// Override low inodes detection settings
func (o DiskSpecificAnomaliesV2Output) OverrideLowInodesDetection() pulumi.BoolOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) pulumi.BoolOutput { return v.OverrideLowInodesDetection }).(pulumi.BoolOutput)
}

// Override slow writes and reads detection settings
func (o DiskSpecificAnomaliesV2Output) OverrideSlowWritesAndReadsDetection() pulumi.BoolOutput {
	return o.ApplyT(func(v *DiskSpecificAnomaliesV2) pulumi.BoolOutput { return v.OverrideSlowWritesAndReadsDetection }).(pulumi.BoolOutput)
}

type DiskSpecificAnomaliesV2ArrayOutput struct{ *pulumi.OutputState }

func (DiskSpecificAnomaliesV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (o DiskSpecificAnomaliesV2ArrayOutput) ToDiskSpecificAnomaliesV2ArrayOutput() DiskSpecificAnomaliesV2ArrayOutput {
	return o
}

func (o DiskSpecificAnomaliesV2ArrayOutput) ToDiskSpecificAnomaliesV2ArrayOutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2ArrayOutput {
	return o
}

func (o DiskSpecificAnomaliesV2ArrayOutput) Index(i pulumi.IntInput) DiskSpecificAnomaliesV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DiskSpecificAnomaliesV2 {
		return vs[0].([]*DiskSpecificAnomaliesV2)[vs[1].(int)]
	}).(DiskSpecificAnomaliesV2Output)
}

type DiskSpecificAnomaliesV2MapOutput struct{ *pulumi.OutputState }

func (DiskSpecificAnomaliesV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskSpecificAnomaliesV2)(nil)).Elem()
}

func (o DiskSpecificAnomaliesV2MapOutput) ToDiskSpecificAnomaliesV2MapOutput() DiskSpecificAnomaliesV2MapOutput {
	return o
}

func (o DiskSpecificAnomaliesV2MapOutput) ToDiskSpecificAnomaliesV2MapOutputWithContext(ctx context.Context) DiskSpecificAnomaliesV2MapOutput {
	return o
}

func (o DiskSpecificAnomaliesV2MapOutput) MapIndex(k pulumi.StringInput) DiskSpecificAnomaliesV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DiskSpecificAnomaliesV2 {
		return vs[0].(map[string]*DiskSpecificAnomaliesV2)[vs[1].(string)]
	}).(DiskSpecificAnomaliesV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DiskSpecificAnomaliesV2Input)(nil)).Elem(), &DiskSpecificAnomaliesV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskSpecificAnomaliesV2ArrayInput)(nil)).Elem(), DiskSpecificAnomaliesV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskSpecificAnomaliesV2MapInput)(nil)).Elem(), DiskSpecificAnomaliesV2Map{})
	pulumi.RegisterOutputType(DiskSpecificAnomaliesV2Output{})
	pulumi.RegisterOutputType(DiskSpecificAnomaliesV2ArrayOutput{})
	pulumi.RegisterOutputType(DiskSpecificAnomaliesV2MapOutput{})
}
