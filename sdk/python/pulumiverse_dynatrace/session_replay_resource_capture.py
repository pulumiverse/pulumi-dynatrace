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

__all__ = ['SessionReplayResourceCaptureArgs', 'SessionReplayResourceCapture']

@pulumi.input_type
class SessionReplayResourceCaptureArgs:
    def __init__(__self__, *,
                 enable_resource_capturing: pulumi.Input[builtins.bool],
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 resource_capture_url_exclusion_pattern_lists: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        The set of arguments for constructing a SessionReplayResourceCapture resource.
        :param pulumi.Input[builtins.bool] enable_resource_capturing: (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] resource_capture_url_exclusion_pattern_lists: (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        pulumi.set(__self__, "enable_resource_capturing", enable_resource_capturing)
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)
        if resource_capture_url_exclusion_pattern_lists is not None:
            pulumi.set(__self__, "resource_capture_url_exclusion_pattern_lists", resource_capture_url_exclusion_pattern_lists)

    @property
    @pulumi.getter(name="enableResourceCapturing")
    def enable_resource_capturing(self) -> pulumi.Input[builtins.bool]:
        """
        (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        """
        return pulumi.get(self, "enable_resource_capturing")

    @enable_resource_capturing.setter
    def enable_resource_capturing(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "enable_resource_capturing", value)

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
    @pulumi.getter(name="resourceCaptureUrlExclusionPatternLists")
    def resource_capture_url_exclusion_pattern_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        return pulumi.get(self, "resource_capture_url_exclusion_pattern_lists")

    @resource_capture_url_exclusion_pattern_lists.setter
    def resource_capture_url_exclusion_pattern_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "resource_capture_url_exclusion_pattern_lists", value)


@pulumi.input_type
class _SessionReplayResourceCaptureState:
    def __init__(__self__, *,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 enable_resource_capturing: Optional[pulumi.Input[builtins.bool]] = None,
                 resource_capture_url_exclusion_pattern_lists: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        Input properties used for looking up and filtering SessionReplayResourceCapture resources.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] enable_resource_capturing: (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] resource_capture_url_exclusion_pattern_lists: (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)
        if enable_resource_capturing is not None:
            pulumi.set(__self__, "enable_resource_capturing", enable_resource_capturing)
        if resource_capture_url_exclusion_pattern_lists is not None:
            pulumi.set(__self__, "resource_capture_url_exclusion_pattern_lists", resource_capture_url_exclusion_pattern_lists)

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
    @pulumi.getter(name="enableResourceCapturing")
    def enable_resource_capturing(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        """
        return pulumi.get(self, "enable_resource_capturing")

    @enable_resource_capturing.setter
    def enable_resource_capturing(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enable_resource_capturing", value)

    @property
    @pulumi.getter(name="resourceCaptureUrlExclusionPatternLists")
    def resource_capture_url_exclusion_pattern_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        return pulumi.get(self, "resource_capture_url_exclusion_pattern_lists")

    @resource_capture_url_exclusion_pattern_lists.setter
    def resource_capture_url_exclusion_pattern_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "resource_capture_url_exclusion_pattern_lists", value)


@pulumi.type_token("dynatrace:index/sessionReplayResourceCapture:SessionReplayResourceCapture")
class SessionReplayResourceCapture(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 enable_resource_capturing: Optional[pulumi.Input[builtins.bool]] = None,
                 resource_capture_url_exclusion_pattern_lists: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        """
        Create a SessionReplayResourceCapture resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] enable_resource_capturing: (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] resource_capture_url_exclusion_pattern_lists: (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SessionReplayResourceCaptureArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a SessionReplayResourceCapture resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param SessionReplayResourceCaptureArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SessionReplayResourceCaptureArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[builtins.str]] = None,
                 enable_resource_capturing: Optional[pulumi.Input[builtins.bool]] = None,
                 resource_capture_url_exclusion_pattern_lists: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SessionReplayResourceCaptureArgs.__new__(SessionReplayResourceCaptureArgs)

            __props__.__dict__["application_id"] = application_id
            if enable_resource_capturing is None and not opts.urn:
                raise TypeError("Missing required property 'enable_resource_capturing'")
            __props__.__dict__["enable_resource_capturing"] = enable_resource_capturing
            __props__.__dict__["resource_capture_url_exclusion_pattern_lists"] = resource_capture_url_exclusion_pattern_lists
        super(SessionReplayResourceCapture, __self__).__init__(
            'dynatrace:index/sessionReplayResourceCapture:SessionReplayResourceCapture',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            application_id: Optional[pulumi.Input[builtins.str]] = None,
            enable_resource_capturing: Optional[pulumi.Input[builtins.bool]] = None,
            resource_capture_url_exclusion_pattern_lists: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None) -> 'SessionReplayResourceCapture':
        """
        Get an existing SessionReplayResourceCapture resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] application_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[builtins.bool] enable_resource_capturing: (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] resource_capture_url_exclusion_pattern_lists: (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SessionReplayResourceCaptureState.__new__(_SessionReplayResourceCaptureState)

        __props__.__dict__["application_id"] = application_id
        __props__.__dict__["enable_resource_capturing"] = enable_resource_capturing
        __props__.__dict__["resource_capture_url_exclusion_pattern_lists"] = resource_capture_url_exclusion_pattern_lists
        return SessionReplayResourceCapture(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter(name="enableResourceCapturing")
    def enable_resource_capturing(self) -> pulumi.Output[builtins.bool]:
        """
        (Field has overlap with `WebApplication`) When turned on, Dynatrace captures resources for up to 0.1% of user sessions recorded with Session Replay. For details, see [Resource capture](https://dt-url.net/sr-resource-capturing).
        """
        return pulumi.get(self, "enable_resource_capturing")

    @property
    @pulumi.getter(name="resourceCaptureUrlExclusionPatternLists")
    def resource_capture_url_exclusion_pattern_lists(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        (Field has overlap with `WebApplication`) Add exclusion rules to avoid the capture of resources from certain pages.
        """
        return pulumi.get(self, "resource_capture_url_exclusion_pattern_lists")

