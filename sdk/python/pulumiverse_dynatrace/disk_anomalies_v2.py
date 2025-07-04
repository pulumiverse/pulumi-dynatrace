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
from . import outputs
from ._inputs import *

__all__ = ['DiskAnomaliesV2Args', 'DiskAnomaliesV2']

@pulumi.input_type
class DiskAnomaliesV2Args:
    def __init__(__self__, *,
                 disk: pulumi.Input['DiskAnomaliesV2DiskArgs'],
                 scope: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a DiskAnomaliesV2 resource.
        :param pulumi.Input['DiskAnomaliesV2DiskArgs'] disk: Disk
        :param pulumi.Input[builtins.str] scope: The scope for the disk anomaly detection
        """
        pulumi.set(__self__, "disk", disk)
        pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def disk(self) -> pulumi.Input['DiskAnomaliesV2DiskArgs']:
        """
        Disk
        """
        return pulumi.get(self, "disk")

    @disk.setter
    def disk(self, value: pulumi.Input['DiskAnomaliesV2DiskArgs']):
        pulumi.set(self, "disk", value)

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Input[builtins.str]:
        """
        The scope for the disk anomaly detection
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _DiskAnomaliesV2State:
    def __init__(__self__, *,
                 disk: Optional[pulumi.Input['DiskAnomaliesV2DiskArgs']] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering DiskAnomaliesV2 resources.
        :param pulumi.Input['DiskAnomaliesV2DiskArgs'] disk: Disk
        :param pulumi.Input[builtins.str] scope: The scope for the disk anomaly detection
        """
        if disk is not None:
            pulumi.set(__self__, "disk", disk)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def disk(self) -> Optional[pulumi.Input['DiskAnomaliesV2DiskArgs']]:
        """
        Disk
        """
        return pulumi.get(self, "disk")

    @disk.setter
    def disk(self, value: Optional[pulumi.Input['DiskAnomaliesV2DiskArgs']]):
        pulumi.set(self, "disk", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope for the disk anomaly detection
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)


@pulumi.type_token("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2")
class DiskAnomaliesV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk: Optional[pulumi.Input[Union['DiskAnomaliesV2DiskArgs', 'DiskAnomaliesV2DiskArgsDict']]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a DiskAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['DiskAnomaliesV2DiskArgs', 'DiskAnomaliesV2DiskArgsDict']] disk: Disk
        :param pulumi.Input[builtins.str] scope: The scope for the disk anomaly detection
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DiskAnomaliesV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DiskAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DiskAnomaliesV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DiskAnomaliesV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk: Optional[pulumi.Input[Union['DiskAnomaliesV2DiskArgs', 'DiskAnomaliesV2DiskArgsDict']]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DiskAnomaliesV2Args.__new__(DiskAnomaliesV2Args)

            if disk is None and not opts.urn:
                raise TypeError("Missing required property 'disk'")
            __props__.__dict__["disk"] = disk
            if scope is None and not opts.urn:
                raise TypeError("Missing required property 'scope'")
            __props__.__dict__["scope"] = scope
        super(DiskAnomaliesV2, __self__).__init__(
            'dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            disk: Optional[pulumi.Input[Union['DiskAnomaliesV2DiskArgs', 'DiskAnomaliesV2DiskArgsDict']]] = None,
            scope: Optional[pulumi.Input[builtins.str]] = None) -> 'DiskAnomaliesV2':
        """
        Get an existing DiskAnomaliesV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['DiskAnomaliesV2DiskArgs', 'DiskAnomaliesV2DiskArgsDict']] disk: Disk
        :param pulumi.Input[builtins.str] scope: The scope for the disk anomaly detection
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DiskAnomaliesV2State.__new__(_DiskAnomaliesV2State)

        __props__.__dict__["disk"] = disk
        __props__.__dict__["scope"] = scope
        return DiskAnomaliesV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def disk(self) -> pulumi.Output['outputs.DiskAnomaliesV2Disk']:
        """
        Disk
        """
        return pulumi.get(self, "disk")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[builtins.str]:
        """
        The scope for the disk anomaly detection
        """
        return pulumi.get(self, "scope")

