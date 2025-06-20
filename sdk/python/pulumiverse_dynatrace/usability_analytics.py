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

__all__ = ['UsabilityAnalyticsArgs', 'UsabilityAnalytics']

@pulumi.input_type
class UsabilityAnalyticsArgs:
    def __init__(__self__, *,
                 detect_rage_clicks: pulumi.Input[builtins.bool],
                 application_id: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a UsabilityAnalytics resource.
        :param pulumi.Input[builtins.bool] detect_rage_clicks: Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
               With this setting enabled, a rage click count is compiled for each monitored user session.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        pulumi.set(__self__, "detect_rage_clicks", detect_rage_clicks)
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)

    @property
    @pulumi.getter(name="detectRageClicks")
    def detect_rage_clicks(self) -> pulumi.Input[builtins.bool]:
        """
        Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
        With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        return pulumi.get(self, "detect_rage_clicks")

    @detect_rage_clicks.setter
    def detect_rage_clicks(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "detect_rage_clicks", value)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "application_id", value)


@pulumi.input_type
class _UsabilityAnalyticsState:
    def __init__(__self__, *,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 detect_rage_clicks: Optional[pulumi.Input[builtins.bool]] = None):
        """
        Input properties used for looking up and filtering UsabilityAnalytics resources.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] detect_rage_clicks: Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
               With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)
        if detect_rage_clicks is not None:
            pulumi.set(__self__, "detect_rage_clicks", detect_rage_clicks)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "application_id", value)

    @property
    @pulumi.getter(name="detectRageClicks")
    def detect_rage_clicks(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
        With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        return pulumi.get(self, "detect_rage_clicks")

    @detect_rage_clicks.setter
    def detect_rage_clicks(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "detect_rage_clicks", value)


@pulumi.type_token("dynatrace:index/usabilityAnalytics:UsabilityAnalytics")
class UsabilityAnalytics(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 detect_rage_clicks: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        """
        Create a UsabilityAnalytics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] detect_rage_clicks: Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
               With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: UsabilityAnalyticsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a UsabilityAnalytics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param UsabilityAnalyticsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UsabilityAnalyticsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 detect_rage_clicks: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UsabilityAnalyticsArgs.__new__(UsabilityAnalyticsArgs)

            __props__.__dict__["application_id"] = application_id
            if detect_rage_clicks is None and not opts.urn:
                raise TypeError("Missing required property 'detect_rage_clicks'")
            __props__.__dict__["detect_rage_clicks"] = detect_rage_clicks
        super(UsabilityAnalytics, __self__).__init__(
            'dynatrace:index/usabilityAnalytics:UsabilityAnalytics',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            application_id: Optional[pulumi.Input[builtins.str]] = None,
            detect_rage_clicks: Optional[pulumi.Input[builtins.bool]] = None) -> 'UsabilityAnalytics':
        """
        Get an existing UsabilityAnalytics resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] detect_rage_clicks: Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
               With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UsabilityAnalyticsState.__new__(_UsabilityAnalyticsState)

        __props__.__dict__["application_id"] = application_id
        __props__.__dict__["detect_rage_clicks"] = detect_rage_clicks
        return UsabilityAnalytics(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter(name="detectRageClicks")
    def detect_rage_clicks(self) -> pulumi.Output[builtins.bool]:
        """
        Three or more rapid clicks within the same area of a web page are considered to be rage clicks. Rage clicks commonly reflect slow-loading or failed page resources. Rage click counts are compiled for each session and considered in the [User Experience Score](https://dt-url.net/39034wt) .
        With this setting enabled, a rage click count is compiled for each monitored user session.
        """
        return pulumi.get(self, "detect_rage_clicks")

