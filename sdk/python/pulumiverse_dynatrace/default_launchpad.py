# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

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

__all__ = ['DefaultLaunchpadArgs', 'DefaultLaunchpad']

@pulumi.input_type
class DefaultLaunchpadArgs:
    def __init__(__self__, *,
                 group_launchpads: Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']] = None):
        """
        The set of arguments for constructing a DefaultLaunchpad resource.
        :param pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs'] group_launchpads: Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        if group_launchpads is not None:
            pulumi.set(__self__, "group_launchpads", group_launchpads)

    @property
    @pulumi.getter(name="groupLaunchpads")
    def group_launchpads(self) -> Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']]:
        """
        Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        return pulumi.get(self, "group_launchpads")

    @group_launchpads.setter
    def group_launchpads(self, value: Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']]):
        pulumi.set(self, "group_launchpads", value)


@pulumi.input_type
class _DefaultLaunchpadState:
    def __init__(__self__, *,
                 group_launchpads: Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']] = None):
        """
        Input properties used for looking up and filtering DefaultLaunchpad resources.
        :param pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs'] group_launchpads: Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        if group_launchpads is not None:
            pulumi.set(__self__, "group_launchpads", group_launchpads)

    @property
    @pulumi.getter(name="groupLaunchpads")
    def group_launchpads(self) -> Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']]:
        """
        Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        return pulumi.get(self, "group_launchpads")

    @group_launchpads.setter
    def group_launchpads(self, value: Optional[pulumi.Input['DefaultLaunchpadGroupLaunchpadsArgs']]):
        pulumi.set(self, "group_launchpads", value)


class DefaultLaunchpad(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group_launchpads: Optional[pulumi.Input[Union['DefaultLaunchpadGroupLaunchpadsArgs', 'DefaultLaunchpadGroupLaunchpadsArgsDict']]] = None,
                 __props__=None):
        """
        Create a DefaultLaunchpad resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['DefaultLaunchpadGroupLaunchpadsArgs', 'DefaultLaunchpadGroupLaunchpadsArgsDict']] group_launchpads: Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[DefaultLaunchpadArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DefaultLaunchpad resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DefaultLaunchpadArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DefaultLaunchpadArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group_launchpads: Optional[pulumi.Input[Union['DefaultLaunchpadGroupLaunchpadsArgs', 'DefaultLaunchpadGroupLaunchpadsArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DefaultLaunchpadArgs.__new__(DefaultLaunchpadArgs)

            __props__.__dict__["group_launchpads"] = group_launchpads
        super(DefaultLaunchpad, __self__).__init__(
            'dynatrace:index/defaultLaunchpad:DefaultLaunchpad',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            group_launchpads: Optional[pulumi.Input[Union['DefaultLaunchpadGroupLaunchpadsArgs', 'DefaultLaunchpadGroupLaunchpadsArgsDict']]] = None) -> 'DefaultLaunchpad':
        """
        Get an existing DefaultLaunchpad resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['DefaultLaunchpadGroupLaunchpadsArgs', 'DefaultLaunchpadGroupLaunchpadsArgsDict']] group_launchpads: Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DefaultLaunchpadState.__new__(_DefaultLaunchpadState)

        __props__.__dict__["group_launchpads"] = group_launchpads
        return DefaultLaunchpad(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="groupLaunchpads")
    def group_launchpads(self) -> pulumi.Output[Optional['outputs.DefaultLaunchpadGroupLaunchpads']]:
        """
        Set default launchpads for user groups. The highest ranked will be shown to the user of a group.
        """
        return pulumi.get(self, "group_launchpads")
