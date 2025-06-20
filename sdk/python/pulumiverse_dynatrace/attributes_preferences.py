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

__all__ = ['AttributesPreferencesArgs', 'AttributesPreferences']

@pulumi.input_type
class AttributesPreferencesArgs:
    def __init__(__self__, *,
                 persistence_mode: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a AttributesPreferences resource.
        :param pulumi.Input[builtins.str] persistence_mode: Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        pulumi.set(__self__, "persistence_mode", persistence_mode)

    @property
    @pulumi.getter(name="persistenceMode")
    def persistence_mode(self) -> pulumi.Input[builtins.str]:
        """
        Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        return pulumi.get(self, "persistence_mode")

    @persistence_mode.setter
    def persistence_mode(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "persistence_mode", value)


@pulumi.input_type
class _AttributesPreferencesState:
    def __init__(__self__, *,
                 persistence_mode: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering AttributesPreferences resources.
        :param pulumi.Input[builtins.str] persistence_mode: Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        if persistence_mode is not None:
            pulumi.set(__self__, "persistence_mode", persistence_mode)

    @property
    @pulumi.getter(name="persistenceMode")
    def persistence_mode(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        return pulumi.get(self, "persistence_mode")

    @persistence_mode.setter
    def persistence_mode(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "persistence_mode", value)


@pulumi.type_token("dynatrace:index/attributesPreferences:AttributesPreferences")
class AttributesPreferences(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 persistence_mode: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a AttributesPreferences resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] persistence_mode: Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AttributesPreferencesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AttributesPreferences resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AttributesPreferencesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AttributesPreferencesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 persistence_mode: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AttributesPreferencesArgs.__new__(AttributesPreferencesArgs)

            if persistence_mode is None and not opts.urn:
                raise TypeError("Missing required property 'persistence_mode'")
            __props__.__dict__["persistence_mode"] = persistence_mode
        super(AttributesPreferences, __self__).__init__(
            'dynatrace:index/attributesPreferences:AttributesPreferences',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            persistence_mode: Optional[pulumi.Input[builtins.str]] = None) -> 'AttributesPreferences':
        """
        Get an existing AttributesPreferences resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] persistence_mode: Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AttributesPreferencesState.__new__(_AttributesPreferencesState)

        __props__.__dict__["persistence_mode"] = persistence_mode
        return AttributesPreferences(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="persistenceMode")
    def persistence_mode(self) -> pulumi.Output[builtins.str]:
        """
        Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        """
        return pulumi.get(self, "persistence_mode")

