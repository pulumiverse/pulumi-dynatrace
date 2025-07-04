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

__all__ = ['LogBucketsArgs', 'LogBuckets']

@pulumi.input_type
class LogBucketsArgs:
    def __init__(__self__, *,
                 bucket_name: pulumi.Input[builtins.str],
                 enabled: pulumi.Input[builtins.bool],
                 matcher: pulumi.Input[builtins.str],
                 rule_name: pulumi.Input[builtins.str],
                 insert_after: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a LogBuckets resource.
        :param pulumi.Input[builtins.str] bucket_name: A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] matcher: Matcher (DQL)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        pulumi.set(__self__, "bucket_name", bucket_name)
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "matcher", matcher)
        pulumi.set(__self__, "rule_name", rule_name)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> pulumi.Input[builtins.str]:
        """
        A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        """
        return pulumi.get(self, "bucket_name")

    @bucket_name.setter
    def bucket_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "bucket_name", value)

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
        Matcher (DQL)
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
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "insert_after", value)


@pulumi.input_type
class _LogBucketsState:
    def __init__(__self__, *,
                 bucket_name: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering LogBuckets resources.
        :param pulumi.Input[builtins.str] bucket_name: A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: Matcher (DQL)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        """
        if bucket_name is not None:
            pulumi.set(__self__, "bucket_name", bucket_name)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if matcher is not None:
            pulumi.set(__self__, "matcher", matcher)
        if rule_name is not None:
            pulumi.set(__self__, "rule_name", rule_name)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        """
        return pulumi.get(self, "bucket_name")

    @bucket_name.setter
    def bucket_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "bucket_name", value)

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
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter
    def matcher(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Matcher (DQL)
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


@pulumi.type_token("dynatrace:index/logBuckets:LogBuckets")
class LogBuckets(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket_name: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a LogBuckets resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] bucket_name: A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: Matcher (DQL)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LogBucketsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a LogBuckets resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param LogBucketsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LogBucketsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket_name: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 insert_after: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 rule_name: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LogBucketsArgs.__new__(LogBucketsArgs)

            if bucket_name is None and not opts.urn:
                raise TypeError("Missing required property 'bucket_name'")
            __props__.__dict__["bucket_name"] = bucket_name
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
        super(LogBuckets, __self__).__init__(
            'dynatrace:index/logBuckets:LogBuckets',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bucket_name: Optional[pulumi.Input[builtins.str]] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            insert_after: Optional[pulumi.Input[builtins.str]] = None,
            matcher: Optional[pulumi.Input[builtins.str]] = None,
            rule_name: Optional[pulumi.Input[builtins.str]] = None) -> 'LogBuckets':
        """
        Get an existing LogBuckets resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] bucket_name: A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[builtins.str] matcher: Matcher (DQL)
        :param pulumi.Input[builtins.str] rule_name: Rule name
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LogBucketsState.__new__(_LogBucketsState)

        __props__.__dict__["bucket_name"] = bucket_name
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["matcher"] = matcher
        __props__.__dict__["rule_name"] = rule_name
        return LogBuckets(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> pulumi.Output[builtins.str]:
        """
        A 'bucket' is the length of time your logs will be stored. Select the bucket that's best for you.
        """
        return pulumi.get(self, "bucket_name")

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
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter
    def matcher(self) -> pulumi.Output[builtins.str]:
        """
        Matcher (DQL)
        """
        return pulumi.get(self, "matcher")

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> pulumi.Output[builtins.str]:
        """
        Rule name
        """
        return pulumi.get(self, "rule_name")

