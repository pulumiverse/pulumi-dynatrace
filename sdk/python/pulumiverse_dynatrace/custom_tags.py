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

__all__ = ['CustomTagsArgs', 'CustomTags']

@pulumi.input_type
class CustomTagsArgs:
    def __init__(__self__, *,
                 entity_selector: pulumi.Input[builtins.str],
                 tags: pulumi.Input['CustomTagsTagsArgs'],
                 current_state: Optional[pulumi.Input[builtins.str]] = None,
                 matched_entities: Optional[pulumi.Input[builtins.int]] = None):
        """
        The set of arguments for constructing a CustomTags resource.
        :param pulumi.Input[builtins.str] entity_selector: Specifies the entities where you want to update tags
        :param pulumi.Input['CustomTagsTagsArgs'] tags: Specifies the entities where you want to update tags
        :param pulumi.Input[builtins.str] current_state: For internal use: current state of tags in JSON format
        :param pulumi.Input[builtins.int] matched_entities: The number of monitored entities where the tags have been added.
        """
        pulumi.set(__self__, "entity_selector", entity_selector)
        pulumi.set(__self__, "tags", tags)
        if current_state is not None:
            pulumi.set(__self__, "current_state", current_state)
        if matched_entities is not None:
            pulumi.set(__self__, "matched_entities", matched_entities)

    @property
    @pulumi.getter(name="entitySelector")
    def entity_selector(self) -> pulumi.Input[builtins.str]:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "entity_selector")

    @entity_selector.setter
    def entity_selector(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "entity_selector", value)

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Input['CustomTagsTagsArgs']:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: pulumi.Input['CustomTagsTagsArgs']):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        For internal use: current state of tags in JSON format
        """
        return pulumi.get(self, "current_state")

    @current_state.setter
    def current_state(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "current_state", value)

    @property
    @pulumi.getter(name="matchedEntities")
    def matched_entities(self) -> Optional[pulumi.Input[builtins.int]]:
        """
        The number of monitored entities where the tags have been added.
        """
        return pulumi.get(self, "matched_entities")

    @matched_entities.setter
    def matched_entities(self, value: Optional[pulumi.Input[builtins.int]]):
        pulumi.set(self, "matched_entities", value)


@pulumi.input_type
class _CustomTagsState:
    def __init__(__self__, *,
                 current_state: Optional[pulumi.Input[builtins.str]] = None,
                 entity_selector: Optional[pulumi.Input[builtins.str]] = None,
                 matched_entities: Optional[pulumi.Input[builtins.int]] = None,
                 tags: Optional[pulumi.Input['CustomTagsTagsArgs']] = None):
        """
        Input properties used for looking up and filtering CustomTags resources.
        :param pulumi.Input[builtins.str] current_state: For internal use: current state of tags in JSON format
        :param pulumi.Input[builtins.str] entity_selector: Specifies the entities where you want to update tags
        :param pulumi.Input[builtins.int] matched_entities: The number of monitored entities where the tags have been added.
        :param pulumi.Input['CustomTagsTagsArgs'] tags: Specifies the entities where you want to update tags
        """
        if current_state is not None:
            pulumi.set(__self__, "current_state", current_state)
        if entity_selector is not None:
            pulumi.set(__self__, "entity_selector", entity_selector)
        if matched_entities is not None:
            pulumi.set(__self__, "matched_entities", matched_entities)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        For internal use: current state of tags in JSON format
        """
        return pulumi.get(self, "current_state")

    @current_state.setter
    def current_state(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "current_state", value)

    @property
    @pulumi.getter(name="entitySelector")
    def entity_selector(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "entity_selector")

    @entity_selector.setter
    def entity_selector(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "entity_selector", value)

    @property
    @pulumi.getter(name="matchedEntities")
    def matched_entities(self) -> Optional[pulumi.Input[builtins.int]]:
        """
        The number of monitored entities where the tags have been added.
        """
        return pulumi.get(self, "matched_entities")

    @matched_entities.setter
    def matched_entities(self, value: Optional[pulumi.Input[builtins.int]]):
        pulumi.set(self, "matched_entities", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input['CustomTagsTagsArgs']]:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input['CustomTagsTagsArgs']]):
        pulumi.set(self, "tags", value)


@pulumi.type_token("dynatrace:index/customTags:CustomTags")
class CustomTags(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 current_state: Optional[pulumi.Input[builtins.str]] = None,
                 entity_selector: Optional[pulumi.Input[builtins.str]] = None,
                 matched_entities: Optional[pulumi.Input[builtins.int]] = None,
                 tags: Optional[pulumi.Input[Union['CustomTagsTagsArgs', 'CustomTagsTagsArgsDict']]] = None,
                 __props__=None):
        """
        Create a CustomTags resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] current_state: For internal use: current state of tags in JSON format
        :param pulumi.Input[builtins.str] entity_selector: Specifies the entities where you want to update tags
        :param pulumi.Input[builtins.int] matched_entities: The number of monitored entities where the tags have been added.
        :param pulumi.Input[Union['CustomTagsTagsArgs', 'CustomTagsTagsArgsDict']] tags: Specifies the entities where you want to update tags
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomTagsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CustomTags resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CustomTagsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomTagsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 current_state: Optional[pulumi.Input[builtins.str]] = None,
                 entity_selector: Optional[pulumi.Input[builtins.str]] = None,
                 matched_entities: Optional[pulumi.Input[builtins.int]] = None,
                 tags: Optional[pulumi.Input[Union['CustomTagsTagsArgs', 'CustomTagsTagsArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomTagsArgs.__new__(CustomTagsArgs)

            __props__.__dict__["current_state"] = current_state
            if entity_selector is None and not opts.urn:
                raise TypeError("Missing required property 'entity_selector'")
            __props__.__dict__["entity_selector"] = entity_selector
            __props__.__dict__["matched_entities"] = matched_entities
            if tags is None and not opts.urn:
                raise TypeError("Missing required property 'tags'")
            __props__.__dict__["tags"] = tags
        super(CustomTags, __self__).__init__(
            'dynatrace:index/customTags:CustomTags',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            current_state: Optional[pulumi.Input[builtins.str]] = None,
            entity_selector: Optional[pulumi.Input[builtins.str]] = None,
            matched_entities: Optional[pulumi.Input[builtins.int]] = None,
            tags: Optional[pulumi.Input[Union['CustomTagsTagsArgs', 'CustomTagsTagsArgsDict']]] = None) -> 'CustomTags':
        """
        Get an existing CustomTags resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] current_state: For internal use: current state of tags in JSON format
        :param pulumi.Input[builtins.str] entity_selector: Specifies the entities where you want to update tags
        :param pulumi.Input[builtins.int] matched_entities: The number of monitored entities where the tags have been added.
        :param pulumi.Input[Union['CustomTagsTagsArgs', 'CustomTagsTagsArgsDict']] tags: Specifies the entities where you want to update tags
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CustomTagsState.__new__(_CustomTagsState)

        __props__.__dict__["current_state"] = current_state
        __props__.__dict__["entity_selector"] = entity_selector
        __props__.__dict__["matched_entities"] = matched_entities
        __props__.__dict__["tags"] = tags
        return CustomTags(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> pulumi.Output[builtins.str]:
        """
        For internal use: current state of tags in JSON format
        """
        return pulumi.get(self, "current_state")

    @property
    @pulumi.getter(name="entitySelector")
    def entity_selector(self) -> pulumi.Output[builtins.str]:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "entity_selector")

    @property
    @pulumi.getter(name="matchedEntities")
    def matched_entities(self) -> pulumi.Output[builtins.int]:
        """
        The number of monitored entities where the tags have been added.
        """
        return pulumi.get(self, "matched_entities")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output['outputs.CustomTagsTags']:
        """
        Specifies the entities where you want to update tags
        """
        return pulumi.get(self, "tags")

