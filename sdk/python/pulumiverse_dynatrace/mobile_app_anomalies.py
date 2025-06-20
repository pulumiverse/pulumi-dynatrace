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

__all__ = ['MobileAppAnomaliesArgs', 'MobileAppAnomalies']

@pulumi.input_type
class MobileAppAnomaliesArgs:
    def __init__(__self__, *,
                 error_rate_increase: pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs'],
                 slow_user_actions: pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs'],
                 unexpected_high_load: pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs'],
                 unexpected_low_load: pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs'],
                 scope: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a MobileAppAnomalies resource.
        :param pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs'] error_rate_increase: Error rate increase
        :param pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs'] slow_user_actions: Slow user actions
        :param pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs'] unexpected_high_load: Unexpected high load
        :param pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs'] unexpected_low_load: Unexpected low load
        :param pulumi.Input[builtins.str] scope: The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "error_rate_increase", error_rate_increase)
        pulumi.set(__self__, "slow_user_actions", slow_user_actions)
        pulumi.set(__self__, "unexpected_high_load", unexpected_high_load)
        pulumi.set(__self__, "unexpected_low_load", unexpected_low_load)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="errorRateIncrease")
    def error_rate_increase(self) -> pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs']:
        """
        Error rate increase
        """
        return pulumi.get(self, "error_rate_increase")

    @error_rate_increase.setter
    def error_rate_increase(self, value: pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs']):
        pulumi.set(self, "error_rate_increase", value)

    @property
    @pulumi.getter(name="slowUserActions")
    def slow_user_actions(self) -> pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs']:
        """
        Slow user actions
        """
        return pulumi.get(self, "slow_user_actions")

    @slow_user_actions.setter
    def slow_user_actions(self, value: pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs']):
        pulumi.set(self, "slow_user_actions", value)

    @property
    @pulumi.getter(name="unexpectedHighLoad")
    def unexpected_high_load(self) -> pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs']:
        """
        Unexpected high load
        """
        return pulumi.get(self, "unexpected_high_load")

    @unexpected_high_load.setter
    def unexpected_high_load(self, value: pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs']):
        pulumi.set(self, "unexpected_high_load", value)

    @property
    @pulumi.getter(name="unexpectedLowLoad")
    def unexpected_low_load(self) -> pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs']:
        """
        Unexpected low load
        """
        return pulumi.get(self, "unexpected_low_load")

    @unexpected_low_load.setter
    def unexpected_low_load(self, value: pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs']):
        pulumi.set(self, "unexpected_low_load", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _MobileAppAnomaliesState:
    def __init__(__self__, *,
                 error_rate_increase: Optional[pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs']] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 slow_user_actions: Optional[pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs']] = None,
                 unexpected_high_load: Optional[pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs']] = None,
                 unexpected_low_load: Optional[pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs']] = None):
        """
        Input properties used for looking up and filtering MobileAppAnomalies resources.
        :param pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs'] error_rate_increase: Error rate increase
        :param pulumi.Input[builtins.str] scope: The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        :param pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs'] slow_user_actions: Slow user actions
        :param pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs'] unexpected_high_load: Unexpected high load
        :param pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs'] unexpected_low_load: Unexpected low load
        """
        if error_rate_increase is not None:
            pulumi.set(__self__, "error_rate_increase", error_rate_increase)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if slow_user_actions is not None:
            pulumi.set(__self__, "slow_user_actions", slow_user_actions)
        if unexpected_high_load is not None:
            pulumi.set(__self__, "unexpected_high_load", unexpected_high_load)
        if unexpected_low_load is not None:
            pulumi.set(__self__, "unexpected_low_load", unexpected_low_load)

    @property
    @pulumi.getter(name="errorRateIncrease")
    def error_rate_increase(self) -> Optional[pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs']]:
        """
        Error rate increase
        """
        return pulumi.get(self, "error_rate_increase")

    @error_rate_increase.setter
    def error_rate_increase(self, value: Optional[pulumi.Input['MobileAppAnomaliesErrorRateIncreaseArgs']]):
        pulumi.set(self, "error_rate_increase", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter(name="slowUserActions")
    def slow_user_actions(self) -> Optional[pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs']]:
        """
        Slow user actions
        """
        return pulumi.get(self, "slow_user_actions")

    @slow_user_actions.setter
    def slow_user_actions(self, value: Optional[pulumi.Input['MobileAppAnomaliesSlowUserActionsArgs']]):
        pulumi.set(self, "slow_user_actions", value)

    @property
    @pulumi.getter(name="unexpectedHighLoad")
    def unexpected_high_load(self) -> Optional[pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs']]:
        """
        Unexpected high load
        """
        return pulumi.get(self, "unexpected_high_load")

    @unexpected_high_load.setter
    def unexpected_high_load(self, value: Optional[pulumi.Input['MobileAppAnomaliesUnexpectedHighLoadArgs']]):
        pulumi.set(self, "unexpected_high_load", value)

    @property
    @pulumi.getter(name="unexpectedLowLoad")
    def unexpected_low_load(self) -> Optional[pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs']]:
        """
        Unexpected low load
        """
        return pulumi.get(self, "unexpected_low_load")

    @unexpected_low_load.setter
    def unexpected_low_load(self, value: Optional[pulumi.Input['MobileAppAnomaliesUnexpectedLowLoadArgs']]):
        pulumi.set(self, "unexpected_low_load", value)


@pulumi.type_token("dynatrace:index/mobileAppAnomalies:MobileAppAnomalies")
class MobileAppAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 error_rate_increase: Optional[pulumi.Input[Union['MobileAppAnomaliesErrorRateIncreaseArgs', 'MobileAppAnomaliesErrorRateIncreaseArgsDict']]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 slow_user_actions: Optional[pulumi.Input[Union['MobileAppAnomaliesSlowUserActionsArgs', 'MobileAppAnomaliesSlowUserActionsArgsDict']]] = None,
                 unexpected_high_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedHighLoadArgs', 'MobileAppAnomaliesUnexpectedHighLoadArgsDict']]] = None,
                 unexpected_low_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedLowLoadArgs', 'MobileAppAnomaliesUnexpectedLowLoadArgsDict']]] = None,
                 __props__=None):
        """
        Create a MobileAppAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['MobileAppAnomaliesErrorRateIncreaseArgs', 'MobileAppAnomaliesErrorRateIncreaseArgsDict']] error_rate_increase: Error rate increase
        :param pulumi.Input[builtins.str] scope: The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        :param pulumi.Input[Union['MobileAppAnomaliesSlowUserActionsArgs', 'MobileAppAnomaliesSlowUserActionsArgsDict']] slow_user_actions: Slow user actions
        :param pulumi.Input[Union['MobileAppAnomaliesUnexpectedHighLoadArgs', 'MobileAppAnomaliesUnexpectedHighLoadArgsDict']] unexpected_high_load: Unexpected high load
        :param pulumi.Input[Union['MobileAppAnomaliesUnexpectedLowLoadArgs', 'MobileAppAnomaliesUnexpectedLowLoadArgsDict']] unexpected_low_load: Unexpected low load
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MobileAppAnomaliesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a MobileAppAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param MobileAppAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MobileAppAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 error_rate_increase: Optional[pulumi.Input[Union['MobileAppAnomaliesErrorRateIncreaseArgs', 'MobileAppAnomaliesErrorRateIncreaseArgsDict']]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 slow_user_actions: Optional[pulumi.Input[Union['MobileAppAnomaliesSlowUserActionsArgs', 'MobileAppAnomaliesSlowUserActionsArgsDict']]] = None,
                 unexpected_high_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedHighLoadArgs', 'MobileAppAnomaliesUnexpectedHighLoadArgsDict']]] = None,
                 unexpected_low_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedLowLoadArgs', 'MobileAppAnomaliesUnexpectedLowLoadArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MobileAppAnomaliesArgs.__new__(MobileAppAnomaliesArgs)

            if error_rate_increase is None and not opts.urn:
                raise TypeError("Missing required property 'error_rate_increase'")
            __props__.__dict__["error_rate_increase"] = error_rate_increase
            __props__.__dict__["scope"] = scope
            if slow_user_actions is None and not opts.urn:
                raise TypeError("Missing required property 'slow_user_actions'")
            __props__.__dict__["slow_user_actions"] = slow_user_actions
            if unexpected_high_load is None and not opts.urn:
                raise TypeError("Missing required property 'unexpected_high_load'")
            __props__.__dict__["unexpected_high_load"] = unexpected_high_load
            if unexpected_low_load is None and not opts.urn:
                raise TypeError("Missing required property 'unexpected_low_load'")
            __props__.__dict__["unexpected_low_load"] = unexpected_low_load
        super(MobileAppAnomalies, __self__).__init__(
            'dynatrace:index/mobileAppAnomalies:MobileAppAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            error_rate_increase: Optional[pulumi.Input[Union['MobileAppAnomaliesErrorRateIncreaseArgs', 'MobileAppAnomaliesErrorRateIncreaseArgsDict']]] = None,
            scope: Optional[pulumi.Input[builtins.str]] = None,
            slow_user_actions: Optional[pulumi.Input[Union['MobileAppAnomaliesSlowUserActionsArgs', 'MobileAppAnomaliesSlowUserActionsArgsDict']]] = None,
            unexpected_high_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedHighLoadArgs', 'MobileAppAnomaliesUnexpectedHighLoadArgsDict']]] = None,
            unexpected_low_load: Optional[pulumi.Input[Union['MobileAppAnomaliesUnexpectedLowLoadArgs', 'MobileAppAnomaliesUnexpectedLowLoadArgsDict']]] = None) -> 'MobileAppAnomalies':
        """
        Get an existing MobileAppAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['MobileAppAnomaliesErrorRateIncreaseArgs', 'MobileAppAnomaliesErrorRateIncreaseArgsDict']] error_rate_increase: Error rate increase
        :param pulumi.Input[builtins.str] scope: The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        :param pulumi.Input[Union['MobileAppAnomaliesSlowUserActionsArgs', 'MobileAppAnomaliesSlowUserActionsArgsDict']] slow_user_actions: Slow user actions
        :param pulumi.Input[Union['MobileAppAnomaliesUnexpectedHighLoadArgs', 'MobileAppAnomaliesUnexpectedHighLoadArgsDict']] unexpected_high_load: Unexpected high load
        :param pulumi.Input[Union['MobileAppAnomaliesUnexpectedLowLoadArgs', 'MobileAppAnomaliesUnexpectedLowLoadArgsDict']] unexpected_low_load: Unexpected low load
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MobileAppAnomaliesState.__new__(_MobileAppAnomaliesState)

        __props__.__dict__["error_rate_increase"] = error_rate_increase
        __props__.__dict__["scope"] = scope
        __props__.__dict__["slow_user_actions"] = slow_user_actions
        __props__.__dict__["unexpected_high_load"] = unexpected_high_load
        __props__.__dict__["unexpected_low_load"] = unexpected_low_load
        return MobileAppAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="errorRateIncrease")
    def error_rate_increase(self) -> pulumi.Output['outputs.MobileAppAnomaliesErrorRateIncrease']:
        """
        Error rate increase
        """
        return pulumi.get(self, "error_rate_increase")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The scope of this setting (DEVICE*APPLICATION*METHOD, MOBILE_APPLICATION). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter(name="slowUserActions")
    def slow_user_actions(self) -> pulumi.Output['outputs.MobileAppAnomaliesSlowUserActions']:
        """
        Slow user actions
        """
        return pulumi.get(self, "slow_user_actions")

    @property
    @pulumi.getter(name="unexpectedHighLoad")
    def unexpected_high_load(self) -> pulumi.Output['outputs.MobileAppAnomaliesUnexpectedHighLoad']:
        """
        Unexpected high load
        """
        return pulumi.get(self, "unexpected_high_load")

    @property
    @pulumi.getter(name="unexpectedLowLoad")
    def unexpected_low_load(self) -> pulumi.Output['outputs.MobileAppAnomaliesUnexpectedLowLoad']:
        """
        Unexpected low load
        """
        return pulumi.get(self, "unexpected_low_load")

