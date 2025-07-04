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

type SiteReliabilityGuardian struct {
	pulumi.CustomResourceState

	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Name
	Name pulumi.StringOutput `pulumi:"name"`
	// Objectives
	Objectives SiteReliabilityGuardianObjectivesOutput `pulumi:"objectives"`
	// Define key/value pairs that further describe this guardian.
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// Define variables for dynamically defining DQL queries
	Variables SiteReliabilityGuardianVariablesPtrOutput `pulumi:"variables"`
}

// NewSiteReliabilityGuardian registers a new resource with the given unique name, arguments, and options.
func NewSiteReliabilityGuardian(ctx *pulumi.Context,
	name string, args *SiteReliabilityGuardianArgs, opts ...pulumi.ResourceOption) (*SiteReliabilityGuardian, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Objectives == nil {
		return nil, errors.New("invalid value for required argument 'Objectives'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SiteReliabilityGuardian
	err := ctx.RegisterResource("dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteReliabilityGuardian gets an existing SiteReliabilityGuardian resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteReliabilityGuardian(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteReliabilityGuardianState, opts ...pulumi.ResourceOption) (*SiteReliabilityGuardian, error) {
	var resource SiteReliabilityGuardian
	err := ctx.ReadResource("dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteReliabilityGuardian resources.
type siteReliabilityGuardianState struct {
	// Description
	Description *string `pulumi:"description"`
	// Name
	Name *string `pulumi:"name"`
	// Objectives
	Objectives *SiteReliabilityGuardianObjectives `pulumi:"objectives"`
	// Define key/value pairs that further describe this guardian.
	Tags []string `pulumi:"tags"`
	// Define variables for dynamically defining DQL queries
	Variables *SiteReliabilityGuardianVariables `pulumi:"variables"`
}

type SiteReliabilityGuardianState struct {
	// Description
	Description pulumi.StringPtrInput
	// Name
	Name pulumi.StringPtrInput
	// Objectives
	Objectives SiteReliabilityGuardianObjectivesPtrInput
	// Define key/value pairs that further describe this guardian.
	Tags pulumi.StringArrayInput
	// Define variables for dynamically defining DQL queries
	Variables SiteReliabilityGuardianVariablesPtrInput
}

func (SiteReliabilityGuardianState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteReliabilityGuardianState)(nil)).Elem()
}

type siteReliabilityGuardianArgs struct {
	// Description
	Description *string `pulumi:"description"`
	// Name
	Name *string `pulumi:"name"`
	// Objectives
	Objectives SiteReliabilityGuardianObjectives `pulumi:"objectives"`
	// Define key/value pairs that further describe this guardian.
	Tags []string `pulumi:"tags"`
	// Define variables for dynamically defining DQL queries
	Variables *SiteReliabilityGuardianVariables `pulumi:"variables"`
}

// The set of arguments for constructing a SiteReliabilityGuardian resource.
type SiteReliabilityGuardianArgs struct {
	// Description
	Description pulumi.StringPtrInput
	// Name
	Name pulumi.StringPtrInput
	// Objectives
	Objectives SiteReliabilityGuardianObjectivesInput
	// Define key/value pairs that further describe this guardian.
	Tags pulumi.StringArrayInput
	// Define variables for dynamically defining DQL queries
	Variables SiteReliabilityGuardianVariablesPtrInput
}

func (SiteReliabilityGuardianArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteReliabilityGuardianArgs)(nil)).Elem()
}

type SiteReliabilityGuardianInput interface {
	pulumi.Input

	ToSiteReliabilityGuardianOutput() SiteReliabilityGuardianOutput
	ToSiteReliabilityGuardianOutputWithContext(ctx context.Context) SiteReliabilityGuardianOutput
}

func (*SiteReliabilityGuardian) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteReliabilityGuardian)(nil)).Elem()
}

func (i *SiteReliabilityGuardian) ToSiteReliabilityGuardianOutput() SiteReliabilityGuardianOutput {
	return i.ToSiteReliabilityGuardianOutputWithContext(context.Background())
}

func (i *SiteReliabilityGuardian) ToSiteReliabilityGuardianOutputWithContext(ctx context.Context) SiteReliabilityGuardianOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteReliabilityGuardianOutput)
}

// SiteReliabilityGuardianArrayInput is an input type that accepts SiteReliabilityGuardianArray and SiteReliabilityGuardianArrayOutput values.
// You can construct a concrete instance of `SiteReliabilityGuardianArrayInput` via:
//
//	SiteReliabilityGuardianArray{ SiteReliabilityGuardianArgs{...} }
type SiteReliabilityGuardianArrayInput interface {
	pulumi.Input

	ToSiteReliabilityGuardianArrayOutput() SiteReliabilityGuardianArrayOutput
	ToSiteReliabilityGuardianArrayOutputWithContext(context.Context) SiteReliabilityGuardianArrayOutput
}

type SiteReliabilityGuardianArray []SiteReliabilityGuardianInput

func (SiteReliabilityGuardianArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SiteReliabilityGuardian)(nil)).Elem()
}

func (i SiteReliabilityGuardianArray) ToSiteReliabilityGuardianArrayOutput() SiteReliabilityGuardianArrayOutput {
	return i.ToSiteReliabilityGuardianArrayOutputWithContext(context.Background())
}

func (i SiteReliabilityGuardianArray) ToSiteReliabilityGuardianArrayOutputWithContext(ctx context.Context) SiteReliabilityGuardianArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteReliabilityGuardianArrayOutput)
}

// SiteReliabilityGuardianMapInput is an input type that accepts SiteReliabilityGuardianMap and SiteReliabilityGuardianMapOutput values.
// You can construct a concrete instance of `SiteReliabilityGuardianMapInput` via:
//
//	SiteReliabilityGuardianMap{ "key": SiteReliabilityGuardianArgs{...} }
type SiteReliabilityGuardianMapInput interface {
	pulumi.Input

	ToSiteReliabilityGuardianMapOutput() SiteReliabilityGuardianMapOutput
	ToSiteReliabilityGuardianMapOutputWithContext(context.Context) SiteReliabilityGuardianMapOutput
}

type SiteReliabilityGuardianMap map[string]SiteReliabilityGuardianInput

func (SiteReliabilityGuardianMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SiteReliabilityGuardian)(nil)).Elem()
}

func (i SiteReliabilityGuardianMap) ToSiteReliabilityGuardianMapOutput() SiteReliabilityGuardianMapOutput {
	return i.ToSiteReliabilityGuardianMapOutputWithContext(context.Background())
}

func (i SiteReliabilityGuardianMap) ToSiteReliabilityGuardianMapOutputWithContext(ctx context.Context) SiteReliabilityGuardianMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteReliabilityGuardianMapOutput)
}

type SiteReliabilityGuardianOutput struct{ *pulumi.OutputState }

func (SiteReliabilityGuardianOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteReliabilityGuardian)(nil)).Elem()
}

func (o SiteReliabilityGuardianOutput) ToSiteReliabilityGuardianOutput() SiteReliabilityGuardianOutput {
	return o
}

func (o SiteReliabilityGuardianOutput) ToSiteReliabilityGuardianOutputWithContext(ctx context.Context) SiteReliabilityGuardianOutput {
	return o
}

// Description
func (o SiteReliabilityGuardianOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteReliabilityGuardian) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Name
func (o SiteReliabilityGuardianOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteReliabilityGuardian) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Objectives
func (o SiteReliabilityGuardianOutput) Objectives() SiteReliabilityGuardianObjectivesOutput {
	return o.ApplyT(func(v *SiteReliabilityGuardian) SiteReliabilityGuardianObjectivesOutput { return v.Objectives }).(SiteReliabilityGuardianObjectivesOutput)
}

// Define key/value pairs that further describe this guardian.
func (o SiteReliabilityGuardianOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *SiteReliabilityGuardian) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

// Define variables for dynamically defining DQL queries
func (o SiteReliabilityGuardianOutput) Variables() SiteReliabilityGuardianVariablesPtrOutput {
	return o.ApplyT(func(v *SiteReliabilityGuardian) SiteReliabilityGuardianVariablesPtrOutput { return v.Variables }).(SiteReliabilityGuardianVariablesPtrOutput)
}

type SiteReliabilityGuardianArrayOutput struct{ *pulumi.OutputState }

func (SiteReliabilityGuardianArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SiteReliabilityGuardian)(nil)).Elem()
}

func (o SiteReliabilityGuardianArrayOutput) ToSiteReliabilityGuardianArrayOutput() SiteReliabilityGuardianArrayOutput {
	return o
}

func (o SiteReliabilityGuardianArrayOutput) ToSiteReliabilityGuardianArrayOutputWithContext(ctx context.Context) SiteReliabilityGuardianArrayOutput {
	return o
}

func (o SiteReliabilityGuardianArrayOutput) Index(i pulumi.IntInput) SiteReliabilityGuardianOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SiteReliabilityGuardian {
		return vs[0].([]*SiteReliabilityGuardian)[vs[1].(int)]
	}).(SiteReliabilityGuardianOutput)
}

type SiteReliabilityGuardianMapOutput struct{ *pulumi.OutputState }

func (SiteReliabilityGuardianMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SiteReliabilityGuardian)(nil)).Elem()
}

func (o SiteReliabilityGuardianMapOutput) ToSiteReliabilityGuardianMapOutput() SiteReliabilityGuardianMapOutput {
	return o
}

func (o SiteReliabilityGuardianMapOutput) ToSiteReliabilityGuardianMapOutputWithContext(ctx context.Context) SiteReliabilityGuardianMapOutput {
	return o
}

func (o SiteReliabilityGuardianMapOutput) MapIndex(k pulumi.StringInput) SiteReliabilityGuardianOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SiteReliabilityGuardian {
		return vs[0].(map[string]*SiteReliabilityGuardian)[vs[1].(string)]
	}).(SiteReliabilityGuardianOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SiteReliabilityGuardianInput)(nil)).Elem(), &SiteReliabilityGuardian{})
	pulumi.RegisterInputType(reflect.TypeOf((*SiteReliabilityGuardianArrayInput)(nil)).Elem(), SiteReliabilityGuardianArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SiteReliabilityGuardianMapInput)(nil)).Elem(), SiteReliabilityGuardianMap{})
	pulumi.RegisterOutputType(SiteReliabilityGuardianOutput{})
	pulumi.RegisterOutputType(SiteReliabilityGuardianArrayOutput{})
	pulumi.RegisterOutputType(SiteReliabilityGuardianMapOutput{})
}
