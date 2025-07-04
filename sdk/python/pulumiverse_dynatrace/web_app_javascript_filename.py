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

__all__ = ['WebAppJavascriptFilenameArgs', 'WebAppJavascriptFilename']

@pulumi.input_type
class WebAppJavascriptFilenameArgs:
    def __init__(__self__, *,
                 filename: pulumi.Input[builtins.str]):
        """
        The set of arguments for constructing a WebAppJavascriptFilename resource.
        :param pulumi.Input[builtins.str] filename: Custom filename prefix
        """
        pulumi.set(__self__, "filename", filename)

    @property
    @pulumi.getter
    def filename(self) -> pulumi.Input[builtins.str]:
        """
        Custom filename prefix
        """
        return pulumi.get(self, "filename")

    @filename.setter
    def filename(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "filename", value)


@pulumi.input_type
class _WebAppJavascriptFilenameState:
    def __init__(__self__, *,
                 filename: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering WebAppJavascriptFilename resources.
        :param pulumi.Input[builtins.str] filename: Custom filename prefix
        """
        if filename is not None:
            pulumi.set(__self__, "filename", filename)

    @property
    @pulumi.getter
    def filename(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Custom filename prefix
        """
        return pulumi.get(self, "filename")

    @filename.setter
    def filename(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "filename", value)


@pulumi.type_token("dynatrace:index/webAppJavascriptFilename:WebAppJavascriptFilename")
class WebAppJavascriptFilename(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filename: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        > This resource requires the API token scopes **Read settings** (`settings.read`) and **Write settings** (`settings.write`)

        ## Dynatrace Documentation

        - Web applications - https://docs.dynatrace.com/docs/platform-modules/digital-experience/web-applications

        - Settings API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/settings (schemaId: `builtin:rum.web.rum-javascript-file-name`)

        ## Resource Example Usage

        ```python
        import pulumi
        import pulumiverse_dynatrace as dynatrace

        _name_ = dynatrace.WebAppJavascriptFilename("#name#", filename="tf")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] filename: Custom filename prefix
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WebAppJavascriptFilenameArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        > This resource requires the API token scopes **Read settings** (`settings.read`) and **Write settings** (`settings.write`)

        ## Dynatrace Documentation

        - Web applications - https://docs.dynatrace.com/docs/platform-modules/digital-experience/web-applications

        - Settings API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/settings (schemaId: `builtin:rum.web.rum-javascript-file-name`)

        ## Resource Example Usage

        ```python
        import pulumi
        import pulumiverse_dynatrace as dynatrace

        _name_ = dynatrace.WebAppJavascriptFilename("#name#", filename="tf")
        ```

        :param str resource_name: The name of the resource.
        :param WebAppJavascriptFilenameArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WebAppJavascriptFilenameArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filename: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WebAppJavascriptFilenameArgs.__new__(WebAppJavascriptFilenameArgs)

            if filename is None and not opts.urn:
                raise TypeError("Missing required property 'filename'")
            __props__.__dict__["filename"] = filename
        super(WebAppJavascriptFilename, __self__).__init__(
            'dynatrace:index/webAppJavascriptFilename:WebAppJavascriptFilename',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            filename: Optional[pulumi.Input[builtins.str]] = None) -> 'WebAppJavascriptFilename':
        """
        Get an existing WebAppJavascriptFilename resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] filename: Custom filename prefix
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WebAppJavascriptFilenameState.__new__(_WebAppJavascriptFilenameState)

        __props__.__dict__["filename"] = filename
        return WebAppJavascriptFilename(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def filename(self) -> pulumi.Output[builtins.str]:
        """
        Custom filename prefix
        """
        return pulumi.get(self, "filename")

