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

__all__ = ['BusinessEventsProcessingArgs', 'BusinessEventsProcessing']

@pulumi.input_type
class BusinessEventsProcessingArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[builtins.bool],
                 matcher: pulumi.Input[builtins.str],
                 rule_name: pulumi.Input[builtins.str],
                 rule_testing: pulumi.Input['BusinessEventsProcessingRuleTestingArgs'],
                 script: pulumi.Input[builtins.str],
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 transformation_fields: Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']] = None):
        """
        The set of arguments for constructing a BusinessEventsProcessing resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        :param pulumi.Input['BusinessEventsProcessingRuleTestingArgs'] rule_testing: ## Rule testing ### 1. Paste an event sample
        :param pulumi.Input[builtins.str] script: [See our documentation](https://dt-url.net/pz030w5)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs'] transformation_fields: Transformation fields
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "matcher", matcher)
        pulumi.set(__self__, "rule_name", rule_name)
        pulumi.set(__self__, "rule_testing", rule_testing)
        pulumi.set(__self__, "script", script)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if transformation_fields is not None:
            pulumi.set(__self__, "transformation_fields", transformation_fields)

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
    @pulumi.getter
    def matcher(self) -> pulumi.Input[builtins.str]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> pulumi.Input[builtins.str]:
        """
        Rule name
        """
        return pulumi.get(self, "rule_name")

    @rule_name.setter
    def rule_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "rule_name", value)

    @property
    @pulumi.getter(name="ruleTesting")
    def rule_testing(self) -> pulumi.Input['BusinessEventsProcessingRuleTestingArgs']:
        """
        ## Rule testing ### 1. Paste an event sample
        """
        return pulumi.get(self, "rule_testing")

    @rule_testing.setter
    def rule_testing(self, value: pulumi.Input['BusinessEventsProcessingRuleTestingArgs']):
        pulumi.set(self, "rule_testing", value)

    @property
    @pulumi.getter
    def script(self) -> pulumi.Input[builtins.str]:
        """
        [See our documentation](https://dt-url.net/pz030w5)
        """
        return pulumi.get(self, "script")

    @script.setter
    def script(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "script", value)

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
    @pulumi.getter(name="transformationFields")
    def transformation_fields(self) -> Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']]:
        """
        Transformation fields
        """
        return pulumi.get(self, "transformation_fields")

    @transformation_fields.setter
    def transformation_fields(self, value: Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']]):
        pulumi.set(self, "transformation_fields", value)


@pulumi.input_type
class _BusinessEventsProcessingState:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None,
                 rule_testing: Optional[pulumi.Input['BusinessEventsProcessingRuleTestingArgs']] = None,
                 script: Optional[pulumi.Input[builtins.str]] = None,
                 transformation_fields: Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']] = None):
        """
        Input properties used for looking up and filtering BusinessEventsProcessing resources.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        :param pulumi.Input['BusinessEventsProcessingRuleTestingArgs'] rule_testing: ## Rule testing ### 1. Paste an event sample
        :param pulumi.Input[builtins.str] script: [See our documentation](https://dt-url.net/pz030w5)
        :param pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs'] transformation_fields: Transformation fields
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if matcher is not None:
            pulumi.set(__self__, "matcher", matcher)
        if rule_name is not None:
            pulumi.set(__self__, "rule_name", rule_name)
        if rule_testing is not None:
            pulumi.set(__self__, "rule_testing", rule_testing)
        if script is not None:
            pulumi.set(__self__, "script", script)
        if transformation_fields is not None:
            pulumi.set(__self__, "transformation_fields", transformation_fields)

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
    @pulumi.getter
    def matcher(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Rule name
        """
        return pulumi.get(self, "rule_name")

    @rule_name.setter
    def rule_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "rule_name", value)

    @property
    @pulumi.getter(name="ruleTesting")
    def rule_testing(self) -> Optional[pulumi.Input['BusinessEventsProcessingRuleTestingArgs']]:
        """
        ## Rule testing ### 1. Paste an event sample
        """
        return pulumi.get(self, "rule_testing")

    @rule_testing.setter
    def rule_testing(self, value: Optional[pulumi.Input['BusinessEventsProcessingRuleTestingArgs']]):
        pulumi.set(self, "rule_testing", value)

    @property
    @pulumi.getter
    def script(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        [See our documentation](https://dt-url.net/pz030w5)
        """
        return pulumi.get(self, "script")

    @script.setter
    def script(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "script", value)

    @property
    @pulumi.getter(name="transformationFields")
    def transformation_fields(self) -> Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']]:
        """
        Transformation fields
        """
        return pulumi.get(self, "transformation_fields")

    @transformation_fields.setter
    def transformation_fields(self, value: Optional[pulumi.Input['BusinessEventsProcessingTransformationFieldsArgs']]):
        pulumi.set(self, "transformation_fields", value)


@pulumi.type_token("dynatrace:index/businessEventsProcessing:BusinessEventsProcessing")
class BusinessEventsProcessing(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None,
                 rule_testing: Optional[pulumi.Input[Union['BusinessEventsProcessingRuleTestingArgs', 'BusinessEventsProcessingRuleTestingArgsDict']]] = None,
                 script: Optional[pulumi.Input[builtins.str]] = None,
                 transformation_fields: Optional[pulumi.Input[Union['BusinessEventsProcessingTransformationFieldsArgs', 'BusinessEventsProcessingTransformationFieldsArgsDict']]] = None,
                 __props__=None):
        """
        Create a BusinessEventsProcessing resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        :param pulumi.Input[Union['BusinessEventsProcessingRuleTestingArgs', 'BusinessEventsProcessingRuleTestingArgsDict']] rule_testing: ## Rule testing ### 1. Paste an event sample
        :param pulumi.Input[builtins.str] script: [See our documentation](https://dt-url.net/pz030w5)
        :param pulumi.Input[Union['BusinessEventsProcessingTransformationFieldsArgs', 'BusinessEventsProcessingTransformationFieldsArgsDict']] transformation_fields: Transformation fields
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BusinessEventsProcessingArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a BusinessEventsProcessing resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param BusinessEventsProcessingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BusinessEventsProcessingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None,
                 rule_testing: Optional[pulumi.Input[Union['BusinessEventsProcessingRuleTestingArgs', 'BusinessEventsProcessingRuleTestingArgsDict']]] = None,
                 script: Optional[pulumi.Input[builtins.str]] = None,
                 transformation_fields: Optional[pulumi.Input[Union['BusinessEventsProcessingTransformationFieldsArgs', 'BusinessEventsProcessingTransformationFieldsArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BusinessEventsProcessingArgs.__new__(BusinessEventsProcessingArgs)

            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["insert_after"] = insert_after
            if matcher is None and not opts.urn:
                raise TypeError("Missing required property 'matcher'")
            __props__.__dict__["matcher"] = matcher
            if rule_name is None and not opts.urn:
                raise TypeError("Missing required property 'rule_name'")
            __props__.__dict__["rule_name"] = rule_name
            if rule_testing is None and not opts.urn:
                raise TypeError("Missing required property 'rule_testing'")
            __props__.__dict__["rule_testing"] = rule_testing
            if script is None and not opts.urn:
                raise TypeError("Missing required property 'script'")
            __props__.__dict__["script"] = script
            __props__.__dict__["transformation_fields"] = transformation_fields
        super(BusinessEventsProcessing, __self__).__init__(
            'dynatrace:index/businessEventsProcessing:BusinessEventsProcessing',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            insert_after: Optional[pulumi.Input[builtins.str]] = None,
            matcher: Optional[pulumi.Input[builtins.str]] = None,
            rule_name: Optional[pulumi.Input[builtins.str]] = None,
            rule_testing: Optional[pulumi.Input[Union['BusinessEventsProcessingRuleTestingArgs', 'BusinessEventsProcessingRuleTestingArgsDict']]] = None,
            script: Optional[pulumi.Input[builtins.str]] = None,
            transformation_fields: Optional[pulumi.Input[Union['BusinessEventsProcessingTransformationFieldsArgs', 'BusinessEventsProcessingTransformationFieldsArgsDict']]] = None) -> 'BusinessEventsProcessing':
        """
        Get an existing BusinessEventsProcessing resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
               instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
               specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        :param pulumi.Input[Union['BusinessEventsProcessingRuleTestingArgs', 'BusinessEventsProcessingRuleTestingArgsDict']] rule_testing: ## Rule testing ### 1. Paste an event sample
        :param pulumi.Input[builtins.str] script: [See our documentation](https://dt-url.net/pz030w5)
        :param pulumi.Input[Union['BusinessEventsProcessingTransformationFieldsArgs', 'BusinessEventsProcessingTransformationFieldsArgsDict']] transformation_fields: Transformation fields
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BusinessEventsProcessingState.__new__(_BusinessEventsProcessingState)

        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["matcher"] = matcher
        __props__.__dict__["rule_name"] = rule_name
        __props__.__dict__["rule_testing"] = rule_testing
        __props__.__dict__["script"] = script
        __props__.__dict__["transformation_fields"] = transformation_fields
        return BusinessEventsProcessing(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[builtins.bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

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
    @pulumi.getter
    def matcher(self) -> pulumi.Output[builtins.str]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> pulumi.Output[builtins.str]:
        """
        Rule name
        """
        return pulumi.get(self, "rule_name")

    @property
    @pulumi.getter(name="ruleTesting")
    def rule_testing(self) -> pulumi.Output['outputs.BusinessEventsProcessingRuleTesting']:
        """
        ## Rule testing ### 1. Paste an event sample
        """
        return pulumi.get(self, "rule_testing")

    @property
    @pulumi.getter
    def script(self) -> pulumi.Output[builtins.str]:
        """
        [See our documentation](https://dt-url.net/pz030w5)
        """
        return pulumi.get(self, "script")

    @property
    @pulumi.getter(name="transformationFields")
    def transformation_fields(self) -> pulumi.Output[Optional['outputs.BusinessEventsProcessingTransformationFields']]:
        """
        Transformation fields
        """
        return pulumi.get(self, "transformation_fields")

