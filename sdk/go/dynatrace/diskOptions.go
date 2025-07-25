// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

type DiskOptions struct {
	pulumi.CustomResourceState

	// Deactivate NFS monitoring on all supported systems
	DisableNfsDiskMonitoring pulumi.BoolPtrOutput `pulumi:"disableNfsDiskMonitoring"`
	// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
	// disks from the monitoring list.
	Exclusions DiskOptionsExclusionsPtrOutput `pulumi:"exclusions"`
	// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
	// Requires OneAgent 1.209 or later
	NfsShowAll pulumi.BoolPtrOutput `pulumi:"nfsShowAll"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
}

// NewDiskOptions registers a new resource with the given unique name, arguments, and options.
func NewDiskOptions(ctx *pulumi.Context,
	name string, args *DiskOptionsArgs, opts ...pulumi.ResourceOption) (*DiskOptions, error) {
	if args == nil {
		args = &DiskOptionsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DiskOptions
	err := ctx.RegisterResource("dynatrace:index/diskOptions:DiskOptions", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDiskOptions gets an existing DiskOptions resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDiskOptions(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DiskOptionsState, opts ...pulumi.ResourceOption) (*DiskOptions, error) {
	var resource DiskOptions
	err := ctx.ReadResource("dynatrace:index/diskOptions:DiskOptions", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DiskOptions resources.
type diskOptionsState struct {
	// Deactivate NFS monitoring on all supported systems
	DisableNfsDiskMonitoring *bool `pulumi:"disableNfsDiskMonitoring"`
	// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
	// disks from the monitoring list.
	Exclusions *DiskOptionsExclusions `pulumi:"exclusions"`
	// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
	// Requires OneAgent 1.209 or later
	NfsShowAll *bool `pulumi:"nfsShowAll"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

type DiskOptionsState struct {
	// Deactivate NFS monitoring on all supported systems
	DisableNfsDiskMonitoring pulumi.BoolPtrInput
	// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
	// disks from the monitoring list.
	Exclusions DiskOptionsExclusionsPtrInput
	// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
	// Requires OneAgent 1.209 or later
	NfsShowAll pulumi.BoolPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (DiskOptionsState) ElementType() reflect.Type {
	return reflect.TypeOf((*diskOptionsState)(nil)).Elem()
}

type diskOptionsArgs struct {
	// Deactivate NFS monitoring on all supported systems
	DisableNfsDiskMonitoring *bool `pulumi:"disableNfsDiskMonitoring"`
	// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
	// disks from the monitoring list.
	Exclusions *DiskOptionsExclusions `pulumi:"exclusions"`
	// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
	// Requires OneAgent 1.209 or later
	NfsShowAll *bool `pulumi:"nfsShowAll"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

// The set of arguments for constructing a DiskOptions resource.
type DiskOptionsArgs struct {
	// Deactivate NFS monitoring on all supported systems
	DisableNfsDiskMonitoring pulumi.BoolPtrInput
	// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
	// disks from the monitoring list.
	Exclusions DiskOptionsExclusionsPtrInput
	// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
	// Requires OneAgent 1.209 or later
	NfsShowAll pulumi.BoolPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (DiskOptionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*diskOptionsArgs)(nil)).Elem()
}

type DiskOptionsInput interface {
	pulumi.Input

	ToDiskOptionsOutput() DiskOptionsOutput
	ToDiskOptionsOutputWithContext(ctx context.Context) DiskOptionsOutput
}

func (*DiskOptions) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskOptions)(nil)).Elem()
}

func (i *DiskOptions) ToDiskOptionsOutput() DiskOptionsOutput {
	return i.ToDiskOptionsOutputWithContext(context.Background())
}

func (i *DiskOptions) ToDiskOptionsOutputWithContext(ctx context.Context) DiskOptionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskOptionsOutput)
}

// DiskOptionsArrayInput is an input type that accepts DiskOptionsArray and DiskOptionsArrayOutput values.
// You can construct a concrete instance of `DiskOptionsArrayInput` via:
//
//	DiskOptionsArray{ DiskOptionsArgs{...} }
type DiskOptionsArrayInput interface {
	pulumi.Input

	ToDiskOptionsArrayOutput() DiskOptionsArrayOutput
	ToDiskOptionsArrayOutputWithContext(context.Context) DiskOptionsArrayOutput
}

type DiskOptionsArray []DiskOptionsInput

func (DiskOptionsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskOptions)(nil)).Elem()
}

func (i DiskOptionsArray) ToDiskOptionsArrayOutput() DiskOptionsArrayOutput {
	return i.ToDiskOptionsArrayOutputWithContext(context.Background())
}

func (i DiskOptionsArray) ToDiskOptionsArrayOutputWithContext(ctx context.Context) DiskOptionsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskOptionsArrayOutput)
}

// DiskOptionsMapInput is an input type that accepts DiskOptionsMap and DiskOptionsMapOutput values.
// You can construct a concrete instance of `DiskOptionsMapInput` via:
//
//	DiskOptionsMap{ "key": DiskOptionsArgs{...} }
type DiskOptionsMapInput interface {
	pulumi.Input

	ToDiskOptionsMapOutput() DiskOptionsMapOutput
	ToDiskOptionsMapOutputWithContext(context.Context) DiskOptionsMapOutput
}

type DiskOptionsMap map[string]DiskOptionsInput

func (DiskOptionsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskOptions)(nil)).Elem()
}

func (i DiskOptionsMap) ToDiskOptionsMapOutput() DiskOptionsMapOutput {
	return i.ToDiskOptionsMapOutputWithContext(context.Background())
}

func (i DiskOptionsMap) ToDiskOptionsMapOutputWithContext(ctx context.Context) DiskOptionsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskOptionsMapOutput)
}

type DiskOptionsOutput struct{ *pulumi.OutputState }

func (DiskOptionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskOptions)(nil)).Elem()
}

func (o DiskOptionsOutput) ToDiskOptionsOutput() DiskOptionsOutput {
	return o
}

func (o DiskOptionsOutput) ToDiskOptionsOutputWithContext(ctx context.Context) DiskOptionsOutput {
	return o
}

// Deactivate NFS monitoring on all supported systems
func (o DiskOptionsOutput) DisableNfsDiskMonitoring() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DiskOptions) pulumi.BoolPtrOutput { return v.DisableNfsDiskMonitoring }).(pulumi.BoolPtrOutput)
}

// OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
// disks from the monitoring list.
func (o DiskOptionsOutput) Exclusions() DiskOptionsExclusionsPtrOutput {
	return o.ApplyT(func(v *DiskOptions) DiskOptionsExclusionsPtrOutput { return v.Exclusions }).(DiskOptionsExclusionsPtrOutput)
}

// When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
// Requires OneAgent 1.209 or later
func (o DiskOptionsOutput) NfsShowAll() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DiskOptions) pulumi.BoolPtrOutput { return v.NfsShowAll }).(pulumi.BoolPtrOutput)
}

// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
func (o DiskOptionsOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DiskOptions) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

type DiskOptionsArrayOutput struct{ *pulumi.OutputState }

func (DiskOptionsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskOptions)(nil)).Elem()
}

func (o DiskOptionsArrayOutput) ToDiskOptionsArrayOutput() DiskOptionsArrayOutput {
	return o
}

func (o DiskOptionsArrayOutput) ToDiskOptionsArrayOutputWithContext(ctx context.Context) DiskOptionsArrayOutput {
	return o
}

func (o DiskOptionsArrayOutput) Index(i pulumi.IntInput) DiskOptionsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DiskOptions {
		return vs[0].([]*DiskOptions)[vs[1].(int)]
	}).(DiskOptionsOutput)
}

type DiskOptionsMapOutput struct{ *pulumi.OutputState }

func (DiskOptionsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskOptions)(nil)).Elem()
}

func (o DiskOptionsMapOutput) ToDiskOptionsMapOutput() DiskOptionsMapOutput {
	return o
}

func (o DiskOptionsMapOutput) ToDiskOptionsMapOutputWithContext(ctx context.Context) DiskOptionsMapOutput {
	return o
}

func (o DiskOptionsMapOutput) MapIndex(k pulumi.StringInput) DiskOptionsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DiskOptions {
		return vs[0].(map[string]*DiskOptions)[vs[1].(string)]
	}).(DiskOptionsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DiskOptionsInput)(nil)).Elem(), &DiskOptions{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskOptionsArrayInput)(nil)).Elem(), DiskOptionsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskOptionsMapInput)(nil)).Elem(), DiskOptionsMap{})
	pulumi.RegisterOutputType(DiskOptionsOutput{})
	pulumi.RegisterOutputType(DiskOptionsArrayOutput{})
	pulumi.RegisterOutputType(DiskOptionsMapOutput{})
}
