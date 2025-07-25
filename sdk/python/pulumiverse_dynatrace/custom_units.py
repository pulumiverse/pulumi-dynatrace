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

__all__ = ['CustomUnitsArgs', 'CustomUnits']

@pulumi.input_type
class CustomUnitsArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[builtins.str],
                 plural_name: pulumi.Input[builtins.str],
                 symbol: pulumi.Input[builtins.str],
                 name: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a CustomUnits resource.
        :param pulumi.Input[builtins.str] description: Unit description should provide additional information about the new unit
        :param pulumi.Input[builtins.str] plural_name: Unit plural name represent the plural form of the unit name.
        :param pulumi.Input[builtins.str] symbol: Unit symbol has to be unique.
        :param pulumi.Input[builtins.str] name: Unit name has to be unique and is used as identifier.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "plural_name", plural_name)
        pulumi.set(__self__, "symbol", symbol)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[builtins.str]:
        """
        Unit description should provide additional information about the new unit
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="pluralName")
    def plural_name(self) -> pulumi.Input[builtins.str]:
        """
        Unit plural name represent the plural form of the unit name.
        """
        return pulumi.get(self, "plural_name")

    @plural_name.setter
    def plural_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "plural_name", value)

    @property
    @pulumi.getter
    def symbol(self) -> pulumi.Input[builtins.str]:
        """
        Unit symbol has to be unique.
        """
        return pulumi.get(self, "symbol")

    @symbol.setter
    def symbol(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "symbol", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unit name has to be unique and is used as identifier.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _CustomUnitsState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 plural_name: Optional[pulumi.Input[builtins.str]] = None,
                 symbol: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering CustomUnits resources.
        :param pulumi.Input[builtins.str] description: Unit description should provide additional information about the new unit
        :param pulumi.Input[builtins.str] name: Unit name has to be unique and is used as identifier.
        :param pulumi.Input[builtins.str] plural_name: Unit plural name represent the plural form of the unit name.
        :param pulumi.Input[builtins.str] symbol: Unit symbol has to be unique.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if plural_name is not None:
            pulumi.set(__self__, "plural_name", plural_name)
        if symbol is not None:
            pulumi.set(__self__, "symbol", symbol)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unit description should provide additional information about the new unit
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unit name has to be unique and is used as identifier.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="pluralName")
    def plural_name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unit plural name represent the plural form of the unit name.
        """
        return pulumi.get(self, "plural_name")

    @plural_name.setter
    def plural_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "plural_name", value)

    @property
    @pulumi.getter
    def symbol(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Unit symbol has to be unique.
        """
        return pulumi.get(self, "symbol")

    @symbol.setter
    def symbol(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "symbol", value)


@pulumi.type_token("dynatrace:index/customUnits:CustomUnits")
class CustomUnits(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 plural_name: Optional[pulumi.Input[builtins.str]] = None,
                 symbol: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a CustomUnits resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Unit description should provide additional information about the new unit
        :param pulumi.Input[builtins.str] name: Unit name has to be unique and is used as identifier.
        :param pulumi.Input[builtins.str] plural_name: Unit plural name represent the plural form of the unit name.
        :param pulumi.Input[builtins.str] symbol: Unit symbol has to be unique.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomUnitsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CustomUnits resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CustomUnitsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomUnitsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 plural_name: Optional[pulumi.Input[builtins.str]] = None,
                 symbol: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomUnitsArgs.__new__(CustomUnitsArgs)

            if description is None and not opts.urn:
                raise TypeError("Missing required property 'description'")
            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            if plural_name is None and not opts.urn:
                raise TypeError("Missing required property 'plural_name'")
            __props__.__dict__["plural_name"] = plural_name
            if symbol is None and not opts.urn:
                raise TypeError("Missing required property 'symbol'")
            __props__.__dict__["symbol"] = symbol
        super(CustomUnits, __self__).__init__(
            'dynatrace:index/customUnits:CustomUnits',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            plural_name: Optional[pulumi.Input[builtins.str]] = None,
            symbol: Optional[pulumi.Input[builtins.str]] = None) -> 'CustomUnits':
        """
        Get an existing CustomUnits resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Unit description should provide additional information about the new unit
        :param pulumi.Input[builtins.str] name: Unit name has to be unique and is used as identifier.
        :param pulumi.Input[builtins.str] plural_name: Unit plural name represent the plural form of the unit name.
        :param pulumi.Input[builtins.str] symbol: Unit symbol has to be unique.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CustomUnitsState.__new__(_CustomUnitsState)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        __props__.__dict__["plural_name"] = plural_name
        __props__.__dict__["symbol"] = symbol
        return CustomUnits(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[builtins.str]:
        """
        Unit description should provide additional information about the new unit
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        Unit name has to be unique and is used as identifier.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="pluralName")
    def plural_name(self) -> pulumi.Output[builtins.str]:
        """
        Unit plural name represent the plural form of the unit name.
        """
        return pulumi.get(self, "plural_name")

    @property
    @pulumi.getter
    def symbol(self) -> pulumi.Output[builtins.str]:
        """
        Unit symbol has to be unique.
        """
        return pulumi.get(self, "symbol")

