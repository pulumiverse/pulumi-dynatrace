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

__all__ = ['GithubConnectionArgs', 'GithubConnection']

@pulumi.input_type
class GithubConnectionArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[builtins.str],
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 token: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a GithubConnection resource.
        :param pulumi.Input[builtins.str] type: Possible Values: `pat`
        :param pulumi.Input[builtins.str] name: The name of the GitHub connection
        :param pulumi.Input[builtins.str] token: Token for the selected authentication type
        """
        pulumi.set(__self__, "type", type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if token is not None:
            pulumi.set(__self__, "token", token)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[builtins.str]:
        """
        Possible Values: `pat`
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the GitHub connection
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token for the selected authentication type
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "token", value)


@pulumi.input_type
class _GithubConnectionState:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 token: Optional[pulumi.Input[builtins.str]] = None,
                 type: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering GithubConnection resources.
        :param pulumi.Input[builtins.str] name: The name of the GitHub connection
        :param pulumi.Input[builtins.str] token: Token for the selected authentication type
        :param pulumi.Input[builtins.str] type: Possible Values: `pat`
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if token is not None:
            pulumi.set(__self__, "token", token)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the GitHub connection
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token for the selected authentication type
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "token", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Possible Values: `pat`
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "type", value)


@pulumi.type_token("dynatrace:index/githubConnection:GithubConnection")
class GithubConnection(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 token: Optional[pulumi.Input[builtins.str]] = None,
                 type: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a GithubConnection resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] name: The name of the GitHub connection
        :param pulumi.Input[builtins.str] token: Token for the selected authentication type
        :param pulumi.Input[builtins.str] type: Possible Values: `pat`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GithubConnectionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a GithubConnection resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param GithubConnectionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GithubConnectionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 token: Optional[pulumi.Input[builtins.str]] = None,
                 type: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GithubConnectionArgs.__new__(GithubConnectionArgs)

            __props__.__dict__["name"] = name
            __props__.__dict__["token"] = None if token is None else pulumi.Output.secret(token)
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["token"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(GithubConnection, __self__).__init__(
            'dynatrace:index/githubConnection:GithubConnection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            token: Optional[pulumi.Input[builtins.str]] = None,
            type: Optional[pulumi.Input[builtins.str]] = None) -> 'GithubConnection':
        """
        Get an existing GithubConnection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] name: The name of the GitHub connection
        :param pulumi.Input[builtins.str] token: Token for the selected authentication type
        :param pulumi.Input[builtins.str] type: Possible Values: `pat`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GithubConnectionState.__new__(_GithubConnectionState)

        __props__.__dict__["name"] = name
        __props__.__dict__["token"] = token
        __props__.__dict__["type"] = type
        return GithubConnection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the GitHub connection
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Token for the selected authentication type
        """
        return pulumi.get(self, "token")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[builtins.str]:
        """
        Possible Values: `pat`
        """
        return pulumi.get(self, "type")

