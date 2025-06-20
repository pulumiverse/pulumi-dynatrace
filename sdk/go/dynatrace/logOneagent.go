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

type LogOneagent struct {
	pulumi.CustomResourceState

	// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
	ContainerTimezoneHeuristicEnabled pulumi.BoolOutput `pulumi:"containerTimezoneHeuristicEnabled"`
	// Allows detection of log messages written to the containerized application's stdout/stderr streams.
	ContainersLogsDetectionEnabled pulumi.BoolOutput `pulumi:"containersLogsDetectionEnabled"`
	// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimitBytes pulumi.IntOutput `pulumi:"dateSearchLimitBytes"`
	// Default timezone for agent if more specific configurations is not defined.
	DefaultTimezone pulumi.StringOutput `pulumi:"defaultTimezone"`
	// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
	EventLogQueryTimeoutSec pulumi.IntOutput `pulumi:"eventLogQueryTimeoutSec"`
	// Allows detection of logs and event logs written by IIS server.
	IisdetectionEnabled pulumi.BoolOutput `pulumi:"iisdetectionEnabled"`
	// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
	LogScannerLinuxNfsEnabled pulumi.BoolOutput `pulumi:"logScannerLinuxNfsEnabled"`
	// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
	MaxLgisPerEntityCount pulumi.IntOutput `pulumi:"maxLgisPerEntityCount"`
	// Defines the minimum number of bytes in log file required for binary detection.
	MinBinaryDetectionLimitBytes pulumi.IntOutput `pulumi:"minBinaryDetectionLimitBytes"`
	// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
	MonitorOwnLogsEnabled pulumi.BoolOutput `pulumi:"monitorOwnLogsEnabled"`
	// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
	OpenLogFilesDetectionEnabled pulumi.BoolOutput `pulumi:"openLogFilesDetectionEnabled"`
	// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
	SeverityDetectionLimitBytes pulumi.IntOutput `pulumi:"severityDetectionLimitBytes"`
	// Defines the number of the first lines of every log entry where severity is searched.
	SeverityDetectionLinesLimit pulumi.IntOutput `pulumi:"severityDetectionLinesLimit"`
	// Linux: syslog, message log Windows: system, application, security event logs
	SystemLogsDetectionEnabled pulumi.BoolOutput `pulumi:"systemLogsDetectionEnabled"`
}

// NewLogOneagent registers a new resource with the given unique name, arguments, and options.
func NewLogOneagent(ctx *pulumi.Context,
	name string, args *LogOneagentArgs, opts ...pulumi.ResourceOption) (*LogOneagent, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ContainerTimezoneHeuristicEnabled == nil {
		return nil, errors.New("invalid value for required argument 'ContainerTimezoneHeuristicEnabled'")
	}
	if args.ContainersLogsDetectionEnabled == nil {
		return nil, errors.New("invalid value for required argument 'ContainersLogsDetectionEnabled'")
	}
	if args.DateSearchLimitBytes == nil {
		return nil, errors.New("invalid value for required argument 'DateSearchLimitBytes'")
	}
	if args.DefaultTimezone == nil {
		return nil, errors.New("invalid value for required argument 'DefaultTimezone'")
	}
	if args.EventLogQueryTimeoutSec == nil {
		return nil, errors.New("invalid value for required argument 'EventLogQueryTimeoutSec'")
	}
	if args.IisdetectionEnabled == nil {
		return nil, errors.New("invalid value for required argument 'IisdetectionEnabled'")
	}
	if args.LogScannerLinuxNfsEnabled == nil {
		return nil, errors.New("invalid value for required argument 'LogScannerLinuxNfsEnabled'")
	}
	if args.MaxLgisPerEntityCount == nil {
		return nil, errors.New("invalid value for required argument 'MaxLgisPerEntityCount'")
	}
	if args.MinBinaryDetectionLimitBytes == nil {
		return nil, errors.New("invalid value for required argument 'MinBinaryDetectionLimitBytes'")
	}
	if args.MonitorOwnLogsEnabled == nil {
		return nil, errors.New("invalid value for required argument 'MonitorOwnLogsEnabled'")
	}
	if args.OpenLogFilesDetectionEnabled == nil {
		return nil, errors.New("invalid value for required argument 'OpenLogFilesDetectionEnabled'")
	}
	if args.SeverityDetectionLimitBytes == nil {
		return nil, errors.New("invalid value for required argument 'SeverityDetectionLimitBytes'")
	}
	if args.SeverityDetectionLinesLimit == nil {
		return nil, errors.New("invalid value for required argument 'SeverityDetectionLinesLimit'")
	}
	if args.SystemLogsDetectionEnabled == nil {
		return nil, errors.New("invalid value for required argument 'SystemLogsDetectionEnabled'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource LogOneagent
	err := ctx.RegisterResource("dynatrace:index/logOneagent:LogOneagent", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogOneagent gets an existing LogOneagent resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogOneagent(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogOneagentState, opts ...pulumi.ResourceOption) (*LogOneagent, error) {
	var resource LogOneagent
	err := ctx.ReadResource("dynatrace:index/logOneagent:LogOneagent", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogOneagent resources.
type logOneagentState struct {
	// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
	ContainerTimezoneHeuristicEnabled *bool `pulumi:"containerTimezoneHeuristicEnabled"`
	// Allows detection of log messages written to the containerized application's stdout/stderr streams.
	ContainersLogsDetectionEnabled *bool `pulumi:"containersLogsDetectionEnabled"`
	// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimitBytes *int `pulumi:"dateSearchLimitBytes"`
	// Default timezone for agent if more specific configurations is not defined.
	DefaultTimezone *string `pulumi:"defaultTimezone"`
	// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
	EventLogQueryTimeoutSec *int `pulumi:"eventLogQueryTimeoutSec"`
	// Allows detection of logs and event logs written by IIS server.
	IisdetectionEnabled *bool `pulumi:"iisdetectionEnabled"`
	// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
	LogScannerLinuxNfsEnabled *bool `pulumi:"logScannerLinuxNfsEnabled"`
	// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
	MaxLgisPerEntityCount *int `pulumi:"maxLgisPerEntityCount"`
	// Defines the minimum number of bytes in log file required for binary detection.
	MinBinaryDetectionLimitBytes *int `pulumi:"minBinaryDetectionLimitBytes"`
	// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
	MonitorOwnLogsEnabled *bool `pulumi:"monitorOwnLogsEnabled"`
	// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
	OpenLogFilesDetectionEnabled *bool `pulumi:"openLogFilesDetectionEnabled"`
	// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
	SeverityDetectionLimitBytes *int `pulumi:"severityDetectionLimitBytes"`
	// Defines the number of the first lines of every log entry where severity is searched.
	SeverityDetectionLinesLimit *int `pulumi:"severityDetectionLinesLimit"`
	// Linux: syslog, message log Windows: system, application, security event logs
	SystemLogsDetectionEnabled *bool `pulumi:"systemLogsDetectionEnabled"`
}

type LogOneagentState struct {
	// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
	ContainerTimezoneHeuristicEnabled pulumi.BoolPtrInput
	// Allows detection of log messages written to the containerized application's stdout/stderr streams.
	ContainersLogsDetectionEnabled pulumi.BoolPtrInput
	// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimitBytes pulumi.IntPtrInput
	// Default timezone for agent if more specific configurations is not defined.
	DefaultTimezone pulumi.StringPtrInput
	// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
	EventLogQueryTimeoutSec pulumi.IntPtrInput
	// Allows detection of logs and event logs written by IIS server.
	IisdetectionEnabled pulumi.BoolPtrInput
	// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
	LogScannerLinuxNfsEnabled pulumi.BoolPtrInput
	// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
	MaxLgisPerEntityCount pulumi.IntPtrInput
	// Defines the minimum number of bytes in log file required for binary detection.
	MinBinaryDetectionLimitBytes pulumi.IntPtrInput
	// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
	MonitorOwnLogsEnabled pulumi.BoolPtrInput
	// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
	OpenLogFilesDetectionEnabled pulumi.BoolPtrInput
	// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
	SeverityDetectionLimitBytes pulumi.IntPtrInput
	// Defines the number of the first lines of every log entry where severity is searched.
	SeverityDetectionLinesLimit pulumi.IntPtrInput
	// Linux: syslog, message log Windows: system, application, security event logs
	SystemLogsDetectionEnabled pulumi.BoolPtrInput
}

func (LogOneagentState) ElementType() reflect.Type {
	return reflect.TypeOf((*logOneagentState)(nil)).Elem()
}

type logOneagentArgs struct {
	// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
	ContainerTimezoneHeuristicEnabled bool `pulumi:"containerTimezoneHeuristicEnabled"`
	// Allows detection of log messages written to the containerized application's stdout/stderr streams.
	ContainersLogsDetectionEnabled bool `pulumi:"containersLogsDetectionEnabled"`
	// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimitBytes int `pulumi:"dateSearchLimitBytes"`
	// Default timezone for agent if more specific configurations is not defined.
	DefaultTimezone string `pulumi:"defaultTimezone"`
	// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
	EventLogQueryTimeoutSec int `pulumi:"eventLogQueryTimeoutSec"`
	// Allows detection of logs and event logs written by IIS server.
	IisdetectionEnabled bool `pulumi:"iisdetectionEnabled"`
	// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
	LogScannerLinuxNfsEnabled bool `pulumi:"logScannerLinuxNfsEnabled"`
	// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
	MaxLgisPerEntityCount int `pulumi:"maxLgisPerEntityCount"`
	// Defines the minimum number of bytes in log file required for binary detection.
	MinBinaryDetectionLimitBytes int `pulumi:"minBinaryDetectionLimitBytes"`
	// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
	MonitorOwnLogsEnabled bool `pulumi:"monitorOwnLogsEnabled"`
	// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
	OpenLogFilesDetectionEnabled bool `pulumi:"openLogFilesDetectionEnabled"`
	// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
	SeverityDetectionLimitBytes int `pulumi:"severityDetectionLimitBytes"`
	// Defines the number of the first lines of every log entry where severity is searched.
	SeverityDetectionLinesLimit int `pulumi:"severityDetectionLinesLimit"`
	// Linux: syslog, message log Windows: system, application, security event logs
	SystemLogsDetectionEnabled bool `pulumi:"systemLogsDetectionEnabled"`
}

// The set of arguments for constructing a LogOneagent resource.
type LogOneagentArgs struct {
	// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
	ContainerTimezoneHeuristicEnabled pulumi.BoolInput
	// Allows detection of log messages written to the containerized application's stdout/stderr streams.
	ContainersLogsDetectionEnabled pulumi.BoolInput
	// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimitBytes pulumi.IntInput
	// Default timezone for agent if more specific configurations is not defined.
	DefaultTimezone pulumi.StringInput
	// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
	EventLogQueryTimeoutSec pulumi.IntInput
	// Allows detection of logs and event logs written by IIS server.
	IisdetectionEnabled pulumi.BoolInput
	// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
	LogScannerLinuxNfsEnabled pulumi.BoolInput
	// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
	MaxLgisPerEntityCount pulumi.IntInput
	// Defines the minimum number of bytes in log file required for binary detection.
	MinBinaryDetectionLimitBytes pulumi.IntInput
	// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
	MonitorOwnLogsEnabled pulumi.BoolInput
	// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
	OpenLogFilesDetectionEnabled pulumi.BoolInput
	// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
	SeverityDetectionLimitBytes pulumi.IntInput
	// Defines the number of the first lines of every log entry where severity is searched.
	SeverityDetectionLinesLimit pulumi.IntInput
	// Linux: syslog, message log Windows: system, application, security event logs
	SystemLogsDetectionEnabled pulumi.BoolInput
}

func (LogOneagentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logOneagentArgs)(nil)).Elem()
}

type LogOneagentInput interface {
	pulumi.Input

	ToLogOneagentOutput() LogOneagentOutput
	ToLogOneagentOutputWithContext(ctx context.Context) LogOneagentOutput
}

func (*LogOneagent) ElementType() reflect.Type {
	return reflect.TypeOf((**LogOneagent)(nil)).Elem()
}

func (i *LogOneagent) ToLogOneagentOutput() LogOneagentOutput {
	return i.ToLogOneagentOutputWithContext(context.Background())
}

func (i *LogOneagent) ToLogOneagentOutputWithContext(ctx context.Context) LogOneagentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogOneagentOutput)
}

// LogOneagentArrayInput is an input type that accepts LogOneagentArray and LogOneagentArrayOutput values.
// You can construct a concrete instance of `LogOneagentArrayInput` via:
//
//	LogOneagentArray{ LogOneagentArgs{...} }
type LogOneagentArrayInput interface {
	pulumi.Input

	ToLogOneagentArrayOutput() LogOneagentArrayOutput
	ToLogOneagentArrayOutputWithContext(context.Context) LogOneagentArrayOutput
}

type LogOneagentArray []LogOneagentInput

func (LogOneagentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LogOneagent)(nil)).Elem()
}

func (i LogOneagentArray) ToLogOneagentArrayOutput() LogOneagentArrayOutput {
	return i.ToLogOneagentArrayOutputWithContext(context.Background())
}

func (i LogOneagentArray) ToLogOneagentArrayOutputWithContext(ctx context.Context) LogOneagentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogOneagentArrayOutput)
}

// LogOneagentMapInput is an input type that accepts LogOneagentMap and LogOneagentMapOutput values.
// You can construct a concrete instance of `LogOneagentMapInput` via:
//
//	LogOneagentMap{ "key": LogOneagentArgs{...} }
type LogOneagentMapInput interface {
	pulumi.Input

	ToLogOneagentMapOutput() LogOneagentMapOutput
	ToLogOneagentMapOutputWithContext(context.Context) LogOneagentMapOutput
}

type LogOneagentMap map[string]LogOneagentInput

func (LogOneagentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LogOneagent)(nil)).Elem()
}

func (i LogOneagentMap) ToLogOneagentMapOutput() LogOneagentMapOutput {
	return i.ToLogOneagentMapOutputWithContext(context.Background())
}

func (i LogOneagentMap) ToLogOneagentMapOutputWithContext(ctx context.Context) LogOneagentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogOneagentMapOutput)
}

type LogOneagentOutput struct{ *pulumi.OutputState }

func (LogOneagentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LogOneagent)(nil)).Elem()
}

func (o LogOneagentOutput) ToLogOneagentOutput() LogOneagentOutput {
	return o
}

func (o LogOneagentOutput) ToLogOneagentOutputWithContext(ctx context.Context) LogOneagentOutput {
	return o
}

// Enables automatic detection of timezone in container's logs if it is not explicitly defined in content or configured.
func (o LogOneagentOutput) ContainerTimezoneHeuristicEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.ContainerTimezoneHeuristicEnabled }).(pulumi.BoolOutput)
}

// Allows detection of log messages written to the containerized application's stdout/stderr streams.
func (o LogOneagentOutput) ContainersLogsDetectionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.ContainersLogsDetectionEnabled }).(pulumi.BoolOutput)
}

// Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
func (o LogOneagentOutput) DateSearchLimitBytes() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.DateSearchLimitBytes }).(pulumi.IntOutput)
}

// Default timezone for agent if more specific configurations is not defined.
func (o LogOneagentOutput) DefaultTimezone() pulumi.StringOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.StringOutput { return v.DefaultTimezone }).(pulumi.StringOutput)
}

// Defines the maximum timeout value, in seconds, for the query extracting Windows Event Logs
func (o LogOneagentOutput) EventLogQueryTimeoutSec() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.EventLogQueryTimeoutSec }).(pulumi.IntOutput)
}

// Allows detection of logs and event logs written by IIS server.
func (o LogOneagentOutput) IisdetectionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.IisdetectionEnabled }).(pulumi.BoolOutput)
}

// Allows detection of logs written to mounted network storage drives. Applies only to Linux hosts. For other OSes it's always enabled.
func (o LogOneagentOutput) LogScannerLinuxNfsEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.LogScannerLinuxNfsEnabled }).(pulumi.BoolOutput)
}

// Defines the maximum number of log group instances per entity after which, the new automatic ones wouldn't be added.
func (o LogOneagentOutput) MaxLgisPerEntityCount() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.MaxLgisPerEntityCount }).(pulumi.IntOutput)
}

// Defines the minimum number of bytes in log file required for binary detection.
func (o LogOneagentOutput) MinBinaryDetectionLimitBytes() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.MinBinaryDetectionLimitBytes }).(pulumi.IntOutput)
}

// Enabling this option may affect your licensing costs. For more details, see [documentation](https://dt-url.net/4l02yi8).
func (o LogOneagentOutput) MonitorOwnLogsEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.MonitorOwnLogsEnabled }).(pulumi.BoolOutput)
}

// Automatically detect logs written by important processes. For more details, check our [documentation](https://dt-url.net/7v02z76)
func (o LogOneagentOutput) OpenLogFilesDetectionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.OpenLogFilesDetectionEnabled }).(pulumi.BoolOutput)
}

// The scope of this setting (HOST, KUBERNETES*CLUSTER, HOST*GROUP). Omit this property if you want to cover the whole environment.
func (o LogOneagentOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

// Defines the number of characters in every log line (starting from the first character in the line) where severity is searched.
func (o LogOneagentOutput) SeverityDetectionLimitBytes() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.SeverityDetectionLimitBytes }).(pulumi.IntOutput)
}

// Defines the number of the first lines of every log entry where severity is searched.
func (o LogOneagentOutput) SeverityDetectionLinesLimit() pulumi.IntOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.IntOutput { return v.SeverityDetectionLinesLimit }).(pulumi.IntOutput)
}

// Linux: syslog, message log Windows: system, application, security event logs
func (o LogOneagentOutput) SystemLogsDetectionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogOneagent) pulumi.BoolOutput { return v.SystemLogsDetectionEnabled }).(pulumi.BoolOutput)
}

type LogOneagentArrayOutput struct{ *pulumi.OutputState }

func (LogOneagentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LogOneagent)(nil)).Elem()
}

func (o LogOneagentArrayOutput) ToLogOneagentArrayOutput() LogOneagentArrayOutput {
	return o
}

func (o LogOneagentArrayOutput) ToLogOneagentArrayOutputWithContext(ctx context.Context) LogOneagentArrayOutput {
	return o
}

func (o LogOneagentArrayOutput) Index(i pulumi.IntInput) LogOneagentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LogOneagent {
		return vs[0].([]*LogOneagent)[vs[1].(int)]
	}).(LogOneagentOutput)
}

type LogOneagentMapOutput struct{ *pulumi.OutputState }

func (LogOneagentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LogOneagent)(nil)).Elem()
}

func (o LogOneagentMapOutput) ToLogOneagentMapOutput() LogOneagentMapOutput {
	return o
}

func (o LogOneagentMapOutput) ToLogOneagentMapOutputWithContext(ctx context.Context) LogOneagentMapOutput {
	return o
}

func (o LogOneagentMapOutput) MapIndex(k pulumi.StringInput) LogOneagentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LogOneagent {
		return vs[0].(map[string]*LogOneagent)[vs[1].(string)]
	}).(LogOneagentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LogOneagentInput)(nil)).Elem(), &LogOneagent{})
	pulumi.RegisterInputType(reflect.TypeOf((*LogOneagentArrayInput)(nil)).Elem(), LogOneagentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LogOneagentMapInput)(nil)).Elem(), LogOneagentMap{})
	pulumi.RegisterOutputType(LogOneagentOutput{})
	pulumi.RegisterOutputType(LogOneagentArrayOutput{})
	pulumi.RegisterOutputType(LogOneagentMapOutput{})
}
