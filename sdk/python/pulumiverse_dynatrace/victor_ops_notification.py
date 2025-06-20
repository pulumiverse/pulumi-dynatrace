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

__all__ = ['VictorOpsNotificationArgs', 'VictorOpsNotification']

@pulumi.input_type
class VictorOpsNotificationArgs:
    def __init__(__self__, *,
                 active: pulumi.Input[builtins.bool],
                 message: pulumi.Input[builtins.str],
                 profile: pulumi.Input[builtins.str],
                 routing_key: pulumi.Input[builtins.str],
                 api_key: Optional[pulumi.Input[builtins.str]] = None,
                 legacy_id: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a VictorOpsNotification resource.
        :param pulumi.Input[builtins.bool] active: The configuration is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] message: The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        :param pulumi.Input[builtins.str] profile: The ID of the associated alerting profile
        :param pulumi.Input[builtins.str] routing_key: The routing key, defining the group to be notified
        :param pulumi.Input[builtins.str] api_key: The API key for the target VictorOps account
        :param pulumi.Input[builtins.str] legacy_id: The ID of these settings when referred to from resources requiring the REST API V1 keys
        :param pulumi.Input[builtins.str] name: The name of the notification configuration
        """
        pulumi.set(__self__, "active", active)
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "profile", profile)
        pulumi.set(__self__, "routing_key", routing_key)
        if api_key is not None:
            pulumi.set(__self__, "api_key", api_key)
        if legacy_id is not None:
            pulumi.set(__self__, "legacy_id", legacy_id)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def active(self) -> pulumi.Input[builtins.bool]:
        """
        The configuration is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "active")

    @active.setter
    def active(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "active", value)

    @property
    @pulumi.getter
    def message(self) -> pulumi.Input[builtins.str]:
        """
        The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        """
        return pulumi.get(self, "message")

    @message.setter
    def message(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "message", value)

    @property
    @pulumi.getter
    def profile(self) -> pulumi.Input[builtins.str]:
        """
        The ID of the associated alerting profile
        """
        return pulumi.get(self, "profile")

    @profile.setter
    def profile(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "profile", value)

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> pulumi.Input[builtins.str]:
        """
        The routing key, defining the group to be notified
        """
        return pulumi.get(self, "routing_key")

    @routing_key.setter
    def routing_key(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "routing_key", value)

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The API key for the target VictorOps account
        """
        return pulumi.get(self, "api_key")

    @api_key.setter
    def api_key(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "api_key", value)

    @property
    @pulumi.getter(name="legacyId")
    def legacy_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The ID of these settings when referred to from resources requiring the REST API V1 keys
        """
        return pulumi.get(self, "legacy_id")

    @legacy_id.setter
    def legacy_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "legacy_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the notification configuration
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _VictorOpsNotificationState:
    def __init__(__self__, *,
                 active: Optional[pulumi.Input[builtins.bool]] = None,
                 api_key: Optional[pulumi.Input[builtins.str]] = None,
                 legacy_id: Optional[pulumi.Input[builtins.str]] = None,
                 message: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 profile: Optional[pulumi.Input[builtins.str]] = None,
                 routing_key: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering VictorOpsNotification resources.
        :param pulumi.Input[builtins.bool] active: The configuration is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] api_key: The API key for the target VictorOps account
        :param pulumi.Input[builtins.str] legacy_id: The ID of these settings when referred to from resources requiring the REST API V1 keys
        :param pulumi.Input[builtins.str] message: The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        :param pulumi.Input[builtins.str] name: The name of the notification configuration
        :param pulumi.Input[builtins.str] profile: The ID of the associated alerting profile
        :param pulumi.Input[builtins.str] routing_key: The routing key, defining the group to be notified
        """
        if active is not None:
            pulumi.set(__self__, "active", active)
        if api_key is not None:
            pulumi.set(__self__, "api_key", api_key)
        if legacy_id is not None:
            pulumi.set(__self__, "legacy_id", legacy_id)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if profile is not None:
            pulumi.set(__self__, "profile", profile)
        if routing_key is not None:
            pulumi.set(__self__, "routing_key", routing_key)

    @property
    @pulumi.getter
    def active(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The configuration is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "active")

    @active.setter
    def active(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "active", value)

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The API key for the target VictorOps account
        """
        return pulumi.get(self, "api_key")

    @api_key.setter
    def api_key(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "api_key", value)

    @property
    @pulumi.getter(name="legacyId")
    def legacy_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The ID of these settings when referred to from resources requiring the REST API V1 keys
        """
        return pulumi.get(self, "legacy_id")

    @legacy_id.setter
    def legacy_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "legacy_id", value)

    @property
    @pulumi.getter
    def message(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        """
        return pulumi.get(self, "message")

    @message.setter
    def message(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "message", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the notification configuration
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def profile(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The ID of the associated alerting profile
        """
        return pulumi.get(self, "profile")

    @profile.setter
    def profile(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "profile", value)

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The routing key, defining the group to be notified
        """
        return pulumi.get(self, "routing_key")

    @routing_key.setter
    def routing_key(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "routing_key", value)


@pulumi.type_token("dynatrace:index/victorOpsNotification:VictorOpsNotification")
class VictorOpsNotification(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active: Optional[pulumi.Input[builtins.bool]] = None,
                 api_key: Optional[pulumi.Input[builtins.str]] = None,
                 legacy_id: Optional[pulumi.Input[builtins.str]] = None,
                 message: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 profile: Optional[pulumi.Input[builtins.str]] = None,
                 routing_key: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a VictorOpsNotification resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] active: The configuration is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] api_key: The API key for the target VictorOps account
        :param pulumi.Input[builtins.str] legacy_id: The ID of these settings when referred to from resources requiring the REST API V1 keys
        :param pulumi.Input[builtins.str] message: The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        :param pulumi.Input[builtins.str] name: The name of the notification configuration
        :param pulumi.Input[builtins.str] profile: The ID of the associated alerting profile
        :param pulumi.Input[builtins.str] routing_key: The routing key, defining the group to be notified
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VictorOpsNotificationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a VictorOpsNotification resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param VictorOpsNotificationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VictorOpsNotificationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active: Optional[pulumi.Input[builtins.bool]] = None,
                 api_key: Optional[pulumi.Input[builtins.str]] = None,
                 legacy_id: Optional[pulumi.Input[builtins.str]] = None,
                 message: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 profile: Optional[pulumi.Input[builtins.str]] = None,
                 routing_key: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VictorOpsNotificationArgs.__new__(VictorOpsNotificationArgs)

            if active is None and not opts.urn:
                raise TypeError("Missing required property 'active'")
            __props__.__dict__["active"] = active
            __props__.__dict__["api_key"] = None if api_key is None else pulumi.Output.secret(api_key)
            __props__.__dict__["legacy_id"] = legacy_id
            if message is None and not opts.urn:
                raise TypeError("Missing required property 'message'")
            __props__.__dict__["message"] = message
            __props__.__dict__["name"] = name
            if profile is None and not opts.urn:
                raise TypeError("Missing required property 'profile'")
            __props__.__dict__["profile"] = profile
            if routing_key is None and not opts.urn:
                raise TypeError("Missing required property 'routing_key'")
            __props__.__dict__["routing_key"] = routing_key
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["apiKey"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(VictorOpsNotification, __self__).__init__(
            'dynatrace:index/victorOpsNotification:VictorOpsNotification',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            active: Optional[pulumi.Input[builtins.bool]] = None,
            api_key: Optional[pulumi.Input[builtins.str]] = None,
            legacy_id: Optional[pulumi.Input[builtins.str]] = None,
            message: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            profile: Optional[pulumi.Input[builtins.str]] = None,
            routing_key: Optional[pulumi.Input[builtins.str]] = None) -> 'VictorOpsNotification':
        """
        Get an existing VictorOpsNotification resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] active: The configuration is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] api_key: The API key for the target VictorOps account
        :param pulumi.Input[builtins.str] legacy_id: The ID of these settings when referred to from resources requiring the REST API V1 keys
        :param pulumi.Input[builtins.str] message: The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        :param pulumi.Input[builtins.str] name: The name of the notification configuration
        :param pulumi.Input[builtins.str] profile: The ID of the associated alerting profile
        :param pulumi.Input[builtins.str] routing_key: The routing key, defining the group to be notified
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VictorOpsNotificationState.__new__(_VictorOpsNotificationState)

        __props__.__dict__["active"] = active
        __props__.__dict__["api_key"] = api_key
        __props__.__dict__["legacy_id"] = legacy_id
        __props__.__dict__["message"] = message
        __props__.__dict__["name"] = name
        __props__.__dict__["profile"] = profile
        __props__.__dict__["routing_key"] = routing_key
        return VictorOpsNotification(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def active(self) -> pulumi.Output[builtins.bool]:
        """
        The configuration is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "active")

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The API key for the target VictorOps account
        """
        return pulumi.get(self, "api_key")

    @property
    @pulumi.getter(name="legacyId")
    def legacy_id(self) -> pulumi.Output[builtins.str]:
        """
        The ID of these settings when referred to from resources requiring the REST API V1 keys
        """
        return pulumi.get(self, "legacy_id")

    @property
    @pulumi.getter
    def message(self) -> pulumi.Output[builtins.str]:
        """
        The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the notification configuration
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def profile(self) -> pulumi.Output[builtins.str]:
        """
        The ID of the associated alerting profile
        """
        return pulumi.get(self, "profile")

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> pulumi.Output[builtins.str]:
        """
        The routing key, defining the group to be notified
        """
        return pulumi.get(self, "routing_key")

