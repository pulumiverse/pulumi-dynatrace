# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities

__all__ = ['HostProcessGroupMonitoringArgs', 'HostProcessGroupMonitoring']

@pulumi.input_type
class HostProcessGroupMonitoringArgs:
    def __init__(__self__, *,
                 host_id: pulumi.Input[builtins.str],
                 monitoring_state: pulumi.Input[builtins.str],
                 process_group: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a HostProcessGroupMonitoring resource.
        :param pulumi.Input[builtins.str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.str] monitoring_state: Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        :param pulumi.Input[builtins.str] process_group: Process group
        """
        pulumi.set(__self__, "host_id", host_id)
        pulumi.set(__self__, "monitoring_state", monitoring_state)
        pulumi.set(__self__, "process_group", process_group)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Input[builtins.str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="monitoringState")
    def monitoring_state(self) -> pulumi.Input[builtins.str]:
        """
        Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        """
        return pulumi.get(self, "monitoring_state")

    @monitoring_state.setter
    def monitoring_state(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "monitoring_state", value)

    @property
    @pulumi.getter(name="processGroup")
    def process_group(self) -> pulumi.Input[builtins.str]:
        """
        Process group
        """
        return pulumi.get(self, "process_group")

    @process_group.setter
    def process_group(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "process_group", value)


@pulumi.input_type
class _HostProcessGroupMonitoringState:
    def __init__(__self__, *,
                 host_id: Optional[pulumi.Input[builtins.str]] = None,
                 monitoring_state: Optional[pulumi.Input[builtins.str]] = None,
                 process_group: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering HostProcessGroupMonitoring resources.
        :param pulumi.Input[builtins.str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.str] monitoring_state: Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        :param pulumi.Input[builtins.str] process_group: Process group
        """
        if host_id is not None:
            pulumi.set(__self__, "host_id", host_id)
        if monitoring_state is not None:
            pulumi.set(__self__, "monitoring_state", monitoring_state)
        if process_group is not None:
            pulumi.set(__self__, "process_group", process_group)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="monitoringState")
    def monitoring_state(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        """
        return pulumi.get(self, "monitoring_state")

    @monitoring_state.setter
    def monitoring_state(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "monitoring_state", value)

    @property
    @pulumi.getter(name="processGroup")
    def process_group(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Process group
        """
        return pulumi.get(self, "process_group")

    @process_group.setter
    def process_group(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "process_group", value)


@pulumi.type_token("dynatrace:index/hostProcessGroupMonitoring:HostProcessGroupMonitoring")
class HostProcessGroupMonitoring(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host_id: Optional[pulumi.Input[builtins.str]] = None,
                 monitoring_state: Optional[pulumi.Input[builtins.str]] = None,
                 process_group: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a HostProcessGroupMonitoring resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.str] monitoring_state: Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        :param pulumi.Input[builtins.str] process_group: Process group
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostProcessGroupMonitoringArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a HostProcessGroupMonitoring resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param HostProcessGroupMonitoringArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostProcessGroupMonitoringArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host_id: Optional[pulumi.Input[builtins.str]] = None,
                 monitoring_state: Optional[pulumi.Input[builtins.str]] = None,
                 process_group: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostProcessGroupMonitoringArgs.__new__(HostProcessGroupMonitoringArgs)

            if host_id is None and not opts.urn:
                raise TypeError("Missing required property 'host_id'")
            __props__.__dict__["host_id"] = host_id
            if monitoring_state is None and not opts.urn:
                raise TypeError("Missing required property 'monitoring_state'")
            __props__.__dict__["monitoring_state"] = monitoring_state
            if process_group is None and not opts.urn:
                raise TypeError("Missing required property 'process_group'")
            __props__.__dict__["process_group"] = process_group
        super(HostProcessGroupMonitoring, __self__).__init__(
            'dynatrace:index/hostProcessGroupMonitoring:HostProcessGroupMonitoring',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            host_id: Optional[pulumi.Input[builtins.str]] = None,
            monitoring_state: Optional[pulumi.Input[builtins.str]] = None,
            process_group: Optional[pulumi.Input[builtins.str]] = None) -> 'HostProcessGroupMonitoring':
        """
        Get an existing HostProcessGroupMonitoring resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.str] monitoring_state: Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        :param pulumi.Input[builtins.str] process_group: Process group
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _HostProcessGroupMonitoringState.__new__(_HostProcessGroupMonitoringState)

        __props__.__dict__["host_id"] = host_id
        __props__.__dict__["monitoring_state"] = monitoring_state
        __props__.__dict__["process_group"] = process_group
        return HostProcessGroupMonitoring(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Output[builtins.str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @property
    @pulumi.getter(name="monitoringState")
    def monitoring_state(self) -> pulumi.Output[builtins.str]:
        """
        Possible Values: `DEFAULT`, `MONITORING_OFF`, `MONITORING_ON`
        """
        return pulumi.get(self, "monitoring_state")

    @property
    @pulumi.getter(name="processGroup")
    def process_group(self) -> pulumi.Output[builtins.str]:
        """
        Process group
        """
        return pulumi.get(self, "process_group")

