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

__all__ = ['AutotagV2Args', 'AutotagV2']

@pulumi.input_type
class AutotagV2Args:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input['AutotagV2RulesArgs']] = None,
                 rules_maintained_externally: Optional[pulumi.Input[builtins.bool]] = None):
        """
        The set of arguments for constructing a AutotagV2 resource.
        :param pulumi.Input[builtins.str] description: Description
        :param pulumi.Input[builtins.str] name: Tag name
        :param pulumi.Input['AutotagV2RulesArgs'] rules: Rules
        :param pulumi.Input[builtins.bool] rules_maintained_externally: If `true` this resource will not
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)
        if rules_maintained_externally is not None:
            pulumi.set(__self__, "rules_maintained_externally", rules_maintained_externally)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Tag name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input['AutotagV2RulesArgs']]:
        """
        Rules
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input['AutotagV2RulesArgs']]):
        pulumi.set(self, "rules", value)

    @property
    @pulumi.getter(name="rulesMaintainedExternally")
    def rules_maintained_externally(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true` this resource will not
        """
        return pulumi.get(self, "rules_maintained_externally")

    @rules_maintained_externally.setter
    def rules_maintained_externally(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "rules_maintained_externally", value)


@pulumi.input_type
class _AutotagV2State:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input['AutotagV2RulesArgs']] = None,
                 rules_maintained_externally: Optional[pulumi.Input[builtins.bool]] = None):
        """
        Input properties used for looking up and filtering AutotagV2 resources.
        :param pulumi.Input[builtins.str] description: Description
        :param pulumi.Input[builtins.str] name: Tag name
        :param pulumi.Input['AutotagV2RulesArgs'] rules: Rules
        :param pulumi.Input[builtins.bool] rules_maintained_externally: If `true` this resource will not
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)
        if rules_maintained_externally is not None:
            pulumi.set(__self__, "rules_maintained_externally", rules_maintained_externally)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Tag name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input['AutotagV2RulesArgs']]:
        """
        Rules
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input['AutotagV2RulesArgs']]):
        pulumi.set(self, "rules", value)

    @property
    @pulumi.getter(name="rulesMaintainedExternally")
    def rules_maintained_externally(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true` this resource will not
        """
        return pulumi.get(self, "rules_maintained_externally")

    @rules_maintained_externally.setter
    def rules_maintained_externally(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "rules_maintained_externally", value)


@pulumi.type_token("dynatrace:index/autotagV2:AutotagV2")
class AutotagV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Union['AutotagV2RulesArgs', 'AutotagV2RulesArgsDict']]] = None,
                 rules_maintained_externally: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        """
        Create a AutotagV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Description
        :param pulumi.Input[builtins.str] name: Tag name
        :param pulumi.Input[Union['AutotagV2RulesArgs', 'AutotagV2RulesArgsDict']] rules: Rules
        :param pulumi.Input[builtins.bool] rules_maintained_externally: If `true` this resource will not
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[AutotagV2Args] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AutotagV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AutotagV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AutotagV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Union['AutotagV2RulesArgs', 'AutotagV2RulesArgsDict']]] = None,
                 rules_maintained_externally: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AutotagV2Args.__new__(AutotagV2Args)

            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            __props__.__dict__["rules"] = rules
            __props__.__dict__["rules_maintained_externally"] = rules_maintained_externally
        super(AutotagV2, __self__).__init__(
            'dynatrace:index/autotagV2:AutotagV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            rules: Optional[pulumi.Input[Union['AutotagV2RulesArgs', 'AutotagV2RulesArgsDict']]] = None,
            rules_maintained_externally: Optional[pulumi.Input[builtins.bool]] = None) -> 'AutotagV2':
        """
        Get an existing AutotagV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Description
        :param pulumi.Input[builtins.str] name: Tag name
        :param pulumi.Input[Union['AutotagV2RulesArgs', 'AutotagV2RulesArgsDict']] rules: Rules
        :param pulumi.Input[builtins.bool] rules_maintained_externally: If `true` this resource will not
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AutotagV2State.__new__(_AutotagV2State)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        __props__.__dict__["rules"] = rules
        __props__.__dict__["rules_maintained_externally"] = rules_maintained_externally
        return AutotagV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        Tag name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Output[Optional['outputs.AutotagV2Rules']]:
        """
        Rules
        """
        return pulumi.get(self, "rules")

    @property
    @pulumi.getter(name="rulesMaintainedExternally")
    def rules_maintained_externally(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If `true` this resource will not
        """
        return pulumi.get(self, "rules_maintained_externally")

