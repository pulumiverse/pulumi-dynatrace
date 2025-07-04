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

__all__ = ['ProcessGroupSimpleDetectionArgs', 'ProcessGroupSimpleDetection']

@pulumi.input_type
class ProcessGroupSimpleDetectionArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[builtins.bool],
                 group_identifier: pulumi.Input[builtins.str],
                 instance_identifier: pulumi.Input[builtins.str],
                 rule_type: pulumi.Input[builtins.str],
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 process_type: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a ProcessGroupSimpleDetection resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] group_identifier: If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        :param pulumi.Input[builtins.str] instance_identifier: Use a variable to identify instances within a process group.
        :param pulumi.Input[builtins.str] rule_type: Possible Values: `Prop`, `Env`
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] process_type: Note: Not all types can be detected at startup.
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "group_identifier", group_identifier)
        pulumi.set(__self__, "instance_identifier", instance_identifier)
        pulumi.set(__self__, "rule_type", rule_type)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if process_type is not None:
            pulumi.set(__self__, "process_type", process_type)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[builtins.bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="groupIdentifier")
    def group_identifier(self) -> pulumi.Input[builtins.str]:
        """
        If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        """
        return pulumi.get(self, "group_identifier")

    @group_identifier.setter
    def group_identifier(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "group_identifier", value)

    @property
    @pulumi.getter(name="instanceIdentifier")
    def instance_identifier(self) -> pulumi.Input[builtins.str]:
        """
        Use a variable to identify instances within a process group.
        """
        return pulumi.get(self, "instance_identifier")

    @instance_identifier.setter
    def instance_identifier(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "instance_identifier", value)

    @property
    @pulumi.getter(name="ruleType")
    def rule_type(self) -> pulumi.Input[builtins.str]:
        """
        Possible Values: `Prop`, `Env`
        """
        return pulumi.get(self, "rule_type")

    @rule_type.setter
    def rule_type(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "rule_type", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter(name="processType")
    def process_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Note: Not all types can be detected at startup.
        """
        return pulumi.get(self, "process_type")

    @process_type.setter
    def process_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "process_type", value)


@pulumi.input_type
class _ProcessGroupSimpleDetectionState:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 group_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 instance_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 process_type: Optional[pulumi.Input[builtins.str]] = None,
                 rule_type: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering ProcessGroupSimpleDetection resources.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] group_identifier: If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] instance_identifier: Use a variable to identify instances within a process group.
        :param pulumi.Input[builtins.str] process_type: Note: Not all types can be detected at startup.
        :param pulumi.Input[builtins.str] rule_type: Possible Values: `Prop`, `Env`
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if group_identifier is not None:
            pulumi.set(__self__, "group_identifier", group_identifier)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if instance_identifier is not None:
            pulumi.set(__self__, "instance_identifier", instance_identifier)
        if process_type is not None:
            pulumi.set(__self__, "process_type", process_type)
        if rule_type is not None:
            pulumi.set(__self__, "rule_type", rule_type)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="groupIdentifier")
    def group_identifier(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        """
        return pulumi.get(self, "group_identifier")

    @group_identifier.setter
    def group_identifier(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "group_identifier", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter(name="instanceIdentifier")
    def instance_identifier(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Use a variable to identify instances within a process group.
        """
        return pulumi.get(self, "instance_identifier")

    @instance_identifier.setter
    def instance_identifier(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "instance_identifier", value)

    @property
    @pulumi.getter(name="processType")
    def process_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Note: Not all types can be detected at startup.
        """
        return pulumi.get(self, "process_type")

    @process_type.setter
    def process_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "process_type", value)

    @property
    @pulumi.getter(name="ruleType")
    def rule_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Possible Values: `Prop`, `Env`
        """
        return pulumi.get(self, "rule_type")

    @rule_type.setter
    def rule_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "rule_type", value)


@pulumi.type_token("dynatrace:index/processGroupSimpleDetection:ProcessGroupSimpleDetection")
class ProcessGroupSimpleDetection(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 group_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 instance_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 process_type: Optional[pulumi.Input[builtins.str]] = None,
                 rule_type: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a ProcessGroupSimpleDetection resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] group_identifier: If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] instance_identifier: Use a variable to identify instances within a process group.
        :param pulumi.Input[builtins.str] process_type: Note: Not all types can be detected at startup.
        :param pulumi.Input[builtins.str] rule_type: Possible Values: `Prop`, `Env`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProcessGroupSimpleDetectionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ProcessGroupSimpleDetection resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ProcessGroupSimpleDetectionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProcessGroupSimpleDetectionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 group_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 instance_identifier: Optional[pulumi.Input[builtins.str]] = None,
                 process_type: Optional[pulumi.Input[builtins.str]] = None,
                 rule_type: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProcessGroupSimpleDetectionArgs.__new__(ProcessGroupSimpleDetectionArgs)

            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            if group_identifier is None and not opts.urn:
                raise TypeError("Missing required property 'group_identifier'")
            __props__.__dict__["group_identifier"] = group_identifier
            __props__.__dict__["insert_after"] = insert_after
            if instance_identifier is None and not opts.urn:
                raise TypeError("Missing required property 'instance_identifier'")
            __props__.__dict__["instance_identifier"] = instance_identifier
            __props__.__dict__["process_type"] = process_type
            if rule_type is None and not opts.urn:
                raise TypeError("Missing required property 'rule_type'")
            __props__.__dict__["rule_type"] = rule_type
        super(ProcessGroupSimpleDetection, __self__).__init__(
            'dynatrace:index/processGroupSimpleDetection:ProcessGroupSimpleDetection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            group_identifier: Optional[pulumi.Input[builtins.str]] = None,
            insert_after: Optional[pulumi.Input[builtins.str]] = None,
            instance_identifier: Optional[pulumi.Input[builtins.str]] = None,
            process_type: Optional[pulumi.Input[builtins.str]] = None,
            rule_type: Optional[pulumi.Input[builtins.str]] = None) -> 'ProcessGroupSimpleDetection':
        """
        Get an existing ProcessGroupSimpleDetection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] group_identifier: If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] instance_identifier: Use a variable to identify instances within a process group.
        :param pulumi.Input[builtins.str] process_type: Note: Not all types can be detected at startup.
        :param pulumi.Input[builtins.str] rule_type: Possible Values: `Prop`, `Env`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProcessGroupSimpleDetectionState.__new__(_ProcessGroupSimpleDetectionState)

        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["group_identifier"] = group_identifier
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["instance_identifier"] = instance_identifier
        __props__.__dict__["process_type"] = process_type
        __props__.__dict__["rule_type"] = rule_type
        return ProcessGroupSimpleDetection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[builtins.bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="groupIdentifier")
    def group_identifier(self) -> pulumi.Output[builtins.str]:
        """
        If Dynatrace detects this property at startup of a process, it will use its value to identify process groups more granular.
        """
        return pulumi.get(self, "group_identifier")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[builtins.str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter(name="instanceIdentifier")
    def instance_identifier(self) -> pulumi.Output[builtins.str]:
        """
        Use a variable to identify instances within a process group.
        """
        return pulumi.get(self, "instance_identifier")

    @property
    @pulumi.getter(name="processType")
    def process_type(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Note: Not all types can be detected at startup.
        """
        return pulumi.get(self, "process_type")

    @property
    @pulumi.getter(name="ruleType")
    def rule_type(self) -> pulumi.Output[builtins.str]:
        """
        Possible Values: `Prop`, `Env`
        """
        return pulumi.get(self, "rule_type")

