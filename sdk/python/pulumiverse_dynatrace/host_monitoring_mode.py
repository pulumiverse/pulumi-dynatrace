# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['HostMonitoringModeArgs', 'HostMonitoringMode']

@pulumi.input_type
class HostMonitoringModeArgs:
    def __init__(__self__, *,
                 host_id: pulumi.Input[str],
                 monitoring_mode: pulumi.Input[str]):
        """
        The set of arguments for constructing a HostMonitoringMode resource.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[str] monitoring_mode: Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        pulumi.set(__self__, "host_id", host_id)
        pulumi.set(__self__, "monitoring_mode", monitoring_mode)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Input[str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="monitoringMode")
    def monitoring_mode(self) -> pulumi.Input[str]:
        """
        Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        return pulumi.get(self, "monitoring_mode")

    @monitoring_mode.setter
    def monitoring_mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "monitoring_mode", value)


@pulumi.input_type
class _HostMonitoringModeState:
    def __init__(__self__, *,
                 host_id: Optional[pulumi.Input[str]] = None,
                 monitoring_mode: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering HostMonitoringMode resources.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[str] monitoring_mode: Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        if host_id is not None:
            pulumi.set(__self__, "host_id", host_id)
        if monitoring_mode is not None:
            pulumi.set(__self__, "monitoring_mode", monitoring_mode)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="monitoringMode")
    def monitoring_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        return pulumi.get(self, "monitoring_mode")

    @monitoring_mode.setter
    def monitoring_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "monitoring_mode", value)


class HostMonitoringMode(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 monitoring_mode: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a HostMonitoringMode resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[str] monitoring_mode: Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostMonitoringModeArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a HostMonitoringMode resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param HostMonitoringModeArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostMonitoringModeArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 monitoring_mode: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostMonitoringModeArgs.__new__(HostMonitoringModeArgs)

            if host_id is None and not opts.urn:
                raise TypeError("Missing required property 'host_id'")
            __props__.__dict__["host_id"] = host_id
            if monitoring_mode is None and not opts.urn:
                raise TypeError("Missing required property 'monitoring_mode'")
            __props__.__dict__["monitoring_mode"] = monitoring_mode
        super(HostMonitoringMode, __self__).__init__(
            'dynatrace:index/hostMonitoringMode:HostMonitoringMode',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            host_id: Optional[pulumi.Input[str]] = None,
            monitoring_mode: Optional[pulumi.Input[str]] = None) -> 'HostMonitoringMode':
        """
        Get an existing HostMonitoringMode resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[str] monitoring_mode: Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _HostMonitoringModeState.__new__(_HostMonitoringModeState)

        __props__.__dict__["host_id"] = host_id
        __props__.__dict__["monitoring_mode"] = monitoring_mode
        return HostMonitoringMode(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Output[str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @property
    @pulumi.getter(name="monitoringMode")
    def monitoring_mode(self) -> pulumi.Output[str]:
        """
        Possible Values: `DISCOVERY`, `FULL_STACK`, `INFRA_ONLY`
        """
        return pulumi.get(self, "monitoring_mode")
