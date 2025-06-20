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

__all__ = ['ActivegateTokenArgs', 'ActivegateToken']

@pulumi.input_type
class ActivegateTokenArgs:
    def __init__(__self__, *,
                 auth_token_enforcement_manually_enabled: pulumi.Input[builtins.bool],
                 expiring_token_notifications_enabled: pulumi.Input[builtins.bool]):
        """
        The set of arguments for constructing a ActivegateToken resource.
        :param pulumi.Input[builtins.bool] auth_token_enforcement_manually_enabled: Manually enforce ActiveGate token authentication
        :param pulumi.Input[builtins.bool] expiring_token_notifications_enabled: Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        pulumi.set(__self__, "auth_token_enforcement_manually_enabled", auth_token_enforcement_manually_enabled)
        pulumi.set(__self__, "expiring_token_notifications_enabled", expiring_token_notifications_enabled)

    @property
    @pulumi.getter(name="authTokenEnforcementManuallyEnabled")
    def auth_token_enforcement_manually_enabled(self) -> pulumi.Input[builtins.bool]:
        """
        Manually enforce ActiveGate token authentication
        """
        return pulumi.get(self, "auth_token_enforcement_manually_enabled")

    @auth_token_enforcement_manually_enabled.setter
    def auth_token_enforcement_manually_enabled(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "auth_token_enforcement_manually_enabled", value)

    @property
    @pulumi.getter(name="expiringTokenNotificationsEnabled")
    def expiring_token_notifications_enabled(self) -> pulumi.Input[builtins.bool]:
        """
        Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        return pulumi.get(self, "expiring_token_notifications_enabled")

    @expiring_token_notifications_enabled.setter
    def expiring_token_notifications_enabled(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "expiring_token_notifications_enabled", value)


@pulumi.input_type
class _ActivegateTokenState:
    def __init__(__self__, *,
                 auth_token_enforcement_manually_enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiring_token_notifications_enabled: Optional[pulumi.Input[builtins.bool]] = None):
        """
        Input properties used for looking up and filtering ActivegateToken resources.
        :param pulumi.Input[builtins.bool] auth_token_enforcement_manually_enabled: Manually enforce ActiveGate token authentication
        :param pulumi.Input[builtins.bool] expiring_token_notifications_enabled: Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        if auth_token_enforcement_manually_enabled is not None:
            pulumi.set(__self__, "auth_token_enforcement_manually_enabled", auth_token_enforcement_manually_enabled)
        if expiring_token_notifications_enabled is not None:
            pulumi.set(__self__, "expiring_token_notifications_enabled", expiring_token_notifications_enabled)

    @property
    @pulumi.getter(name="authTokenEnforcementManuallyEnabled")
    def auth_token_enforcement_manually_enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Manually enforce ActiveGate token authentication
        """
        return pulumi.get(self, "auth_token_enforcement_manually_enabled")

    @auth_token_enforcement_manually_enabled.setter
    def auth_token_enforcement_manually_enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "auth_token_enforcement_manually_enabled", value)

    @property
    @pulumi.getter(name="expiringTokenNotificationsEnabled")
    def expiring_token_notifications_enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        return pulumi.get(self, "expiring_token_notifications_enabled")

    @expiring_token_notifications_enabled.setter
    def expiring_token_notifications_enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "expiring_token_notifications_enabled", value)


@pulumi.type_token("dynatrace:index/activegateToken:ActivegateToken")
class ActivegateToken(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth_token_enforcement_manually_enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiring_token_notifications_enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        """
        Create a ActivegateToken resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] auth_token_enforcement_manually_enabled: Manually enforce ActiveGate token authentication
        :param pulumi.Input[builtins.bool] expiring_token_notifications_enabled: Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ActivegateTokenArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ActivegateToken resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ActivegateTokenArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ActivegateTokenArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth_token_enforcement_manually_enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiring_token_notifications_enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ActivegateTokenArgs.__new__(ActivegateTokenArgs)

            if auth_token_enforcement_manually_enabled is None and not opts.urn:
                raise TypeError("Missing required property 'auth_token_enforcement_manually_enabled'")
            __props__.__dict__["auth_token_enforcement_manually_enabled"] = auth_token_enforcement_manually_enabled
            if expiring_token_notifications_enabled is None and not opts.urn:
                raise TypeError("Missing required property 'expiring_token_notifications_enabled'")
            __props__.__dict__["expiring_token_notifications_enabled"] = expiring_token_notifications_enabled
        super(ActivegateToken, __self__).__init__(
            'dynatrace:index/activegateToken:ActivegateToken',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            auth_token_enforcement_manually_enabled: Optional[pulumi.Input[builtins.bool]] = None,
            expiring_token_notifications_enabled: Optional[pulumi.Input[builtins.bool]] = None) -> 'ActivegateToken':
        """
        Get an existing ActivegateToken resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] auth_token_enforcement_manually_enabled: Manually enforce ActiveGate token authentication
        :param pulumi.Input[builtins.bool] expiring_token_notifications_enabled: Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ActivegateTokenState.__new__(_ActivegateTokenState)

        __props__.__dict__["auth_token_enforcement_manually_enabled"] = auth_token_enforcement_manually_enabled
        __props__.__dict__["expiring_token_notifications_enabled"] = expiring_token_notifications_enabled
        return ActivegateToken(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="authTokenEnforcementManuallyEnabled")
    def auth_token_enforcement_manually_enabled(self) -> pulumi.Output[builtins.bool]:
        """
        Manually enforce ActiveGate token authentication
        """
        return pulumi.get(self, "auth_token_enforcement_manually_enabled")

    @property
    @pulumi.getter(name="expiringTokenNotificationsEnabled")
    def expiring_token_notifications_enabled(self) -> pulumi.Output[builtins.bool]:
        """
        Note: ActiveGate tokens notifications are sent only when you deployed ActiveGate tokens with expiration dates in your environment and notifications are defined ([see notification settings](https://www.terraform.io/ui/settings/builtin:problem.notifications))
        """
        return pulumi.get(self, "expiring_token_notifications_enabled")

