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

__all__ = ['CustomServiceArgs', 'CustomService']

@pulumi.input_type
class CustomServiceArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[builtins.bool],
                 technology: pulumi.Input[builtins.str],
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 process_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 queue_entry_point: Optional[pulumi.Input[builtins.bool]] = None,
                 queue_entry_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a CustomService resource.
        :param pulumi.Input[builtins.bool] enabled: Custom service enabled/disabled
        :param pulumi.Input[builtins.str] technology: Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        :param pulumi.Input[builtins.str] name: The name of the custom service, displayed in the UI
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] process_groups: The list of process groups the custom service should belong to
        :param pulumi.Input[builtins.bool] queue_entry_point: The queue entry point flag. Set to `true` for custom messaging services
        :param pulumi.Input[builtins.str] queue_entry_point_type: The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        :param pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]] rules: The list of rules defining the custom service
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "technology", technology)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if process_groups is not None:
            pulumi.set(__self__, "process_groups", process_groups)
        if queue_entry_point is not None:
            pulumi.set(__self__, "queue_entry_point", queue_entry_point)
        if queue_entry_point_type is not None:
            pulumi.set(__self__, "queue_entry_point_type", queue_entry_point_type)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[builtins.bool]:
        """
        Custom service enabled/disabled
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def technology(self) -> pulumi.Input[builtins.str]:
        """
        Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        """
        return pulumi.get(self, "technology")

    @technology.setter
    def technology(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "technology", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the custom service, displayed in the UI
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="processGroups")
    def process_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        The list of process groups the custom service should belong to
        """
        return pulumi.get(self, "process_groups")

    @process_groups.setter
    def process_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "process_groups", value)

    @property
    @pulumi.getter(name="queueEntryPoint")
    def queue_entry_point(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The queue entry point flag. Set to `true` for custom messaging services
        """
        return pulumi.get(self, "queue_entry_point")

    @queue_entry_point.setter
    def queue_entry_point(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "queue_entry_point", value)

    @property
    @pulumi.getter(name="queueEntryPointType")
    def queue_entry_point_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        """
        return pulumi.get(self, "queue_entry_point_type")

    @queue_entry_point_type.setter
    def queue_entry_point_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "queue_entry_point_type", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]]:
        """
        The list of rules defining the custom service
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]]):
        pulumi.set(self, "rules", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "unknowns", value)


@pulumi.input_type
class _CustomServiceState:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 process_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 queue_entry_point: Optional[pulumi.Input[builtins.bool]] = None,
                 queue_entry_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]] = None,
                 technology: Optional[pulumi.Input[builtins.str]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering CustomService resources.
        :param pulumi.Input[builtins.bool] enabled: Custom service enabled/disabled
        :param pulumi.Input[builtins.str] name: The name of the custom service, displayed in the UI
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] process_groups: The list of process groups the custom service should belong to
        :param pulumi.Input[builtins.bool] queue_entry_point: The queue entry point flag. Set to `true` for custom messaging services
        :param pulumi.Input[builtins.str] queue_entry_point_type: The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        :param pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]] rules: The list of rules defining the custom service
        :param pulumi.Input[builtins.str] technology: Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if process_groups is not None:
            pulumi.set(__self__, "process_groups", process_groups)
        if queue_entry_point is not None:
            pulumi.set(__self__, "queue_entry_point", queue_entry_point)
        if queue_entry_point_type is not None:
            pulumi.set(__self__, "queue_entry_point_type", queue_entry_point_type)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)
        if technology is not None:
            pulumi.set(__self__, "technology", technology)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Custom service enabled/disabled
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the custom service, displayed in the UI
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="processGroups")
    def process_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        The list of process groups the custom service should belong to
        """
        return pulumi.get(self, "process_groups")

    @process_groups.setter
    def process_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "process_groups", value)

    @property
    @pulumi.getter(name="queueEntryPoint")
    def queue_entry_point(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The queue entry point flag. Set to `true` for custom messaging services
        """
        return pulumi.get(self, "queue_entry_point")

    @queue_entry_point.setter
    def queue_entry_point(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "queue_entry_point", value)

    @property
    @pulumi.getter(name="queueEntryPointType")
    def queue_entry_point_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        """
        return pulumi.get(self, "queue_entry_point_type")

    @queue_entry_point_type.setter
    def queue_entry_point_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "queue_entry_point_type", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]]:
        """
        The list of rules defining the custom service
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CustomServiceRuleArgs']]]]):
        pulumi.set(self, "rules", value)

    @property
    @pulumi.getter
    def technology(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        """
        return pulumi.get(self, "technology")

    @technology.setter
    def technology(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "technology", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "unknowns", value)


@pulumi.type_token("dynatrace:index/customService:CustomService")
class CustomService(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 process_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 queue_entry_point: Optional[pulumi.Input[builtins.bool]] = None,
                 queue_entry_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input[Union['CustomServiceRuleArgs', 'CustomServiceRuleArgsDict']]]]] = None,
                 technology: Optional[pulumi.Input[builtins.str]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a CustomService resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: Custom service enabled/disabled
        :param pulumi.Input[builtins.str] name: The name of the custom service, displayed in the UI
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] process_groups: The list of process groups the custom service should belong to
        :param pulumi.Input[builtins.bool] queue_entry_point: The queue entry point flag. Set to `true` for custom messaging services
        :param pulumi.Input[builtins.str] queue_entry_point_type: The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        :param pulumi.Input[Sequence[pulumi.Input[Union['CustomServiceRuleArgs', 'CustomServiceRuleArgsDict']]]] rules: The list of rules defining the custom service
        :param pulumi.Input[builtins.str] technology: Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomServiceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CustomService resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CustomServiceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomServiceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 process_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 queue_entry_point: Optional[pulumi.Input[builtins.bool]] = None,
                 queue_entry_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input[Union['CustomServiceRuleArgs', 'CustomServiceRuleArgsDict']]]]] = None,
                 technology: Optional[pulumi.Input[builtins.str]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomServiceArgs.__new__(CustomServiceArgs)

            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["name"] = name
            __props__.__dict__["process_groups"] = process_groups
            __props__.__dict__["queue_entry_point"] = queue_entry_point
            __props__.__dict__["queue_entry_point_type"] = queue_entry_point_type
            __props__.__dict__["rules"] = rules
            if technology is None and not opts.urn:
                raise TypeError("Missing required property 'technology'")
            __props__.__dict__["technology"] = technology
            __props__.__dict__["unknowns"] = unknowns
        super(CustomService, __self__).__init__(
            'dynatrace:index/customService:CustomService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            process_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            queue_entry_point: Optional[pulumi.Input[builtins.bool]] = None,
            queue_entry_point_type: Optional[pulumi.Input[builtins.str]] = None,
            rules: Optional[pulumi.Input[Sequence[pulumi.Input[Union['CustomServiceRuleArgs', 'CustomServiceRuleArgsDict']]]]] = None,
            technology: Optional[pulumi.Input[builtins.str]] = None,
            unknowns: Optional[pulumi.Input[builtins.str]] = None) -> 'CustomService':
        """
        Get an existing CustomService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: Custom service enabled/disabled
        :param pulumi.Input[builtins.str] name: The name of the custom service, displayed in the UI
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] process_groups: The list of process groups the custom service should belong to
        :param pulumi.Input[builtins.bool] queue_entry_point: The queue entry point flag. Set to `true` for custom messaging services
        :param pulumi.Input[builtins.str] queue_entry_point_type: The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        :param pulumi.Input[Sequence[pulumi.Input[Union['CustomServiceRuleArgs', 'CustomServiceRuleArgsDict']]]] rules: The list of rules defining the custom service
        :param pulumi.Input[builtins.str] technology: Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CustomServiceState.__new__(_CustomServiceState)

        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["name"] = name
        __props__.__dict__["process_groups"] = process_groups
        __props__.__dict__["queue_entry_point"] = queue_entry_point
        __props__.__dict__["queue_entry_point_type"] = queue_entry_point_type
        __props__.__dict__["rules"] = rules
        __props__.__dict__["technology"] = technology
        __props__.__dict__["unknowns"] = unknowns
        return CustomService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[builtins.bool]:
        """
        Custom service enabled/disabled
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the custom service, displayed in the UI
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="processGroups")
    def process_groups(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        The list of process groups the custom service should belong to
        """
        return pulumi.get(self, "process_groups")

    @property
    @pulumi.getter(name="queueEntryPoint")
    def queue_entry_point(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        The queue entry point flag. Set to `true` for custom messaging services
        """
        return pulumi.get(self, "queue_entry_point")

    @property
    @pulumi.getter(name="queueEntryPointType")
    def queue_entry_point_type(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        """
        return pulumi.get(self, "queue_entry_point_type")

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Output[Optional[Sequence['outputs.CustomServiceRule']]]:
        """
        The list of rules defining the custom service
        """
        return pulumi.get(self, "rules")

    @property
    @pulumi.getter
    def technology(self) -> pulumi.Output[builtins.str]:
        """
        Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        """
        return pulumi.get(self, "technology")

    @property
    @pulumi.getter
    def unknowns(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

