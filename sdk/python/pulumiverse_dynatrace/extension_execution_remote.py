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

__all__ = ['ExtensionExecutionRemoteArgs', 'ExtensionExecutionRemote']

@pulumi.input_type
class ExtensionExecutionRemoteArgs:
    def __init__(__self__, *,
                 performance_profile: pulumi.Input[builtins.str],
                 scope: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a ExtensionExecutionRemote resource.
        :param pulumi.Input[builtins.str] performance_profile: Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        :param pulumi.Input[builtins.str] scope: The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        pulumi.set(__self__, "performance_profile", performance_profile)
        pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="performanceProfile")
    def performance_profile(self) -> pulumi.Input[builtins.str]:
        """
        Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        """
        return pulumi.get(self, "performance_profile")

    @performance_profile.setter
    def performance_profile(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "performance_profile", value)

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Input[builtins.str]:
        """
        The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _ExtensionExecutionRemoteState:
    def __init__(__self__, *,
                 performance_profile: Optional[pulumi.Input[builtins.str]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering ExtensionExecutionRemote resources.
        :param pulumi.Input[builtins.str] performance_profile: Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        :param pulumi.Input[builtins.str] scope: The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        if performance_profile is not None:
            pulumi.set(__self__, "performance_profile", performance_profile)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="performanceProfile")
    def performance_profile(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        """
        return pulumi.get(self, "performance_profile")

    @performance_profile.setter
    def performance_profile(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "performance_profile", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)


@pulumi.type_token("dynatrace:index/extensionExecutionRemote:ExtensionExecutionRemote")
class ExtensionExecutionRemote(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 performance_profile: Optional[pulumi.Input[builtins.str]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a ExtensionExecutionRemote resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] performance_profile: Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        :param pulumi.Input[builtins.str] scope: The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ExtensionExecutionRemoteArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ExtensionExecutionRemote resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ExtensionExecutionRemoteArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ExtensionExecutionRemoteArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 performance_profile: Optional[pulumi.Input[builtins.str]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ExtensionExecutionRemoteArgs.__new__(ExtensionExecutionRemoteArgs)

            if performance_profile is None and not opts.urn:
                raise TypeError("Missing required property 'performance_profile'")
            __props__.__dict__["performance_profile"] = performance_profile
            if scope is None and not opts.urn:
                raise TypeError("Missing required property 'scope'")
            __props__.__dict__["scope"] = scope
        super(ExtensionExecutionRemote, __self__).__init__(
            'dynatrace:index/extensionExecutionRemote:ExtensionExecutionRemote',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            performance_profile: Optional[pulumi.Input[builtins.str]] = None,
            scope: Optional[pulumi.Input[builtins.str]] = None) -> 'ExtensionExecutionRemote':
        """
        Get an existing ExtensionExecutionRemote resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] performance_profile: Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        :param pulumi.Input[builtins.str] scope: The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ExtensionExecutionRemoteState.__new__(_ExtensionExecutionRemoteState)

        __props__.__dict__["performance_profile"] = performance_profile
        __props__.__dict__["scope"] = scope
        return ExtensionExecutionRemote(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="performanceProfile")
    def performance_profile(self) -> pulumi.Output[builtins.str]:
        """
        Select performance profile for Extension Execution Controller [Documentation](https://www.dynatrace.com/support/help/shortlink/extensions-concepts#resource-consumption)
        """
        return pulumi.get(self, "performance_profile")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[builtins.str]:
        """
        The scope of this setting (ENVIRONMENT*ACTIVE*GATE)
        """
        return pulumi.get(self, "scope")

