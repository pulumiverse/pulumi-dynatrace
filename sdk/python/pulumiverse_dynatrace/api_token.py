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

__all__ = ['ApiTokenArgs', 'ApiToken']

@pulumi.input_type
class ApiTokenArgs:
    def __init__(__self__, *,
                 scopes: pulumi.Input[Sequence[pulumi.Input[builtins.str]]],
                 creation_date: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiration_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_ip_address: Optional[pulumi.Input[builtins.str]] = None,
                 modified_date: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner: Optional[pulumi.Input[builtins.str]] = None,
                 personal_access_token: Optional[pulumi.Input[builtins.bool]] = None):
        """
        The set of arguments for constructing a ApiToken resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] scopes: A list of the scopes to be assigned to the token.
        :param pulumi.Input[builtins.str] creation_date: Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.bool] enabled: The token is enabled (true) or disabled (false), default disabled (false).
        :param pulumi.Input[builtins.str] expiration_date: The expiration date of the token.
        :param pulumi.Input[builtins.str] last_used_date: Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.str] last_used_ip_address: Token last used IP address.
        :param pulumi.Input[builtins.str] modified_date: Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        :param pulumi.Input[builtins.str] name: The name of the token.
        :param pulumi.Input[builtins.str] owner: The owner of the token
        :param pulumi.Input[builtins.bool] personal_access_token: The token is a personal access token (true) or an API token (false).
        """
        pulumi.set(__self__, "scopes", scopes)
        if creation_date is not None:
            pulumi.set(__self__, "creation_date", creation_date)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if expiration_date is not None:
            pulumi.set(__self__, "expiration_date", expiration_date)
        if last_used_date is not None:
            pulumi.set(__self__, "last_used_date", last_used_date)
        if last_used_ip_address is not None:
            pulumi.set(__self__, "last_used_ip_address", last_used_ip_address)
        if modified_date is not None:
            pulumi.set(__self__, "modified_date", modified_date)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if personal_access_token is not None:
            pulumi.set(__self__, "personal_access_token", personal_access_token)

    @property
    @pulumi.getter
    def scopes(self) -> pulumi.Input[Sequence[pulumi.Input[builtins.str]]]:
        """
        A list of the scopes to be assigned to the token.
        """
        return pulumi.get(self, "scopes")

    @scopes.setter
    def scopes(self, value: pulumi.Input[Sequence[pulumi.Input[builtins.str]]]):
        pulumi.set(self, "scopes", value)

    @property
    @pulumi.getter(name="creationDate")
    def creation_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "creation_date")

    @creation_date.setter
    def creation_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "creation_date", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The token is enabled (true) or disabled (false), default disabled (false).
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The expiration date of the token.
        """
        return pulumi.get(self, "expiration_date")

    @expiration_date.setter
    def expiration_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "expiration_date", value)

    @property
    @pulumi.getter(name="lastUsedDate")
    def last_used_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "last_used_date")

    @last_used_date.setter
    def last_used_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "last_used_date", value)

    @property
    @pulumi.getter(name="lastUsedIpAddress")
    def last_used_ip_address(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last used IP address.
        """
        return pulumi.get(self, "last_used_ip_address")

    @last_used_ip_address.setter
    def last_used_ip_address(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "last_used_ip_address", value)

    @property
    @pulumi.getter(name="modifiedDate")
    def modified_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        """
        return pulumi.get(self, "modified_date")

    @modified_date.setter
    def modified_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "modified_date", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the token.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The owner of the token
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="personalAccessToken")
    def personal_access_token(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The token is a personal access token (true) or an API token (false).
        """
        return pulumi.get(self, "personal_access_token")

    @personal_access_token.setter
    def personal_access_token(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "personal_access_token", value)


@pulumi.input_type
class _ApiTokenState:
    def __init__(__self__, *,
                 creation_date: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiration_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_ip_address: Optional[pulumi.Input[builtins.str]] = None,
                 modified_date: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner: Optional[pulumi.Input[builtins.str]] = None,
                 personal_access_token: Optional[pulumi.Input[builtins.bool]] = None,
                 scopes: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 token: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering ApiToken resources.
        :param pulumi.Input[builtins.str] creation_date: Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.bool] enabled: The token is enabled (true) or disabled (false), default disabled (false).
        :param pulumi.Input[builtins.str] expiration_date: The expiration date of the token.
        :param pulumi.Input[builtins.str] last_used_date: Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.str] last_used_ip_address: Token last used IP address.
        :param pulumi.Input[builtins.str] modified_date: Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        :param pulumi.Input[builtins.str] name: The name of the token.
        :param pulumi.Input[builtins.str] owner: The owner of the token
        :param pulumi.Input[builtins.bool] personal_access_token: The token is a personal access token (true) or an API token (false).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] scopes: A list of the scopes to be assigned to the token.
        :param pulumi.Input[builtins.str] token: The secret of the token.
        """
        if creation_date is not None:
            pulumi.set(__self__, "creation_date", creation_date)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if expiration_date is not None:
            pulumi.set(__self__, "expiration_date", expiration_date)
        if last_used_date is not None:
            pulumi.set(__self__, "last_used_date", last_used_date)
        if last_used_ip_address is not None:
            pulumi.set(__self__, "last_used_ip_address", last_used_ip_address)
        if modified_date is not None:
            pulumi.set(__self__, "modified_date", modified_date)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if personal_access_token is not None:
            pulumi.set(__self__, "personal_access_token", personal_access_token)
        if scopes is not None:
            pulumi.set(__self__, "scopes", scopes)
        if token is not None:
            pulumi.set(__self__, "token", token)

    @property
    @pulumi.getter(name="creationDate")
    def creation_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "creation_date")

    @creation_date.setter
    def creation_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "creation_date", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The token is enabled (true) or disabled (false), default disabled (false).
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The expiration date of the token.
        """
        return pulumi.get(self, "expiration_date")

    @expiration_date.setter
    def expiration_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "expiration_date", value)

    @property
    @pulumi.getter(name="lastUsedDate")
    def last_used_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "last_used_date")

    @last_used_date.setter
    def last_used_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "last_used_date", value)

    @property
    @pulumi.getter(name="lastUsedIpAddress")
    def last_used_ip_address(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last used IP address.
        """
        return pulumi.get(self, "last_used_ip_address")

    @last_used_ip_address.setter
    def last_used_ip_address(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "last_used_ip_address", value)

    @property
    @pulumi.getter(name="modifiedDate")
    def modified_date(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        """
        return pulumi.get(self, "modified_date")

    @modified_date.setter
    def modified_date(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "modified_date", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the token.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The owner of the token
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="personalAccessToken")
    def personal_access_token(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The token is a personal access token (true) or an API token (false).
        """
        return pulumi.get(self, "personal_access_token")

    @personal_access_token.setter
    def personal_access_token(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "personal_access_token", value)

    @property
    @pulumi.getter
    def scopes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        A list of the scopes to be assigned to the token.
        """
        return pulumi.get(self, "scopes")

    @scopes.setter
    def scopes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "scopes", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The secret of the token.
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "token", value)


@pulumi.type_token("dynatrace:index/apiToken:ApiToken")
class ApiToken(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_date: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiration_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_ip_address: Optional[pulumi.Input[builtins.str]] = None,
                 modified_date: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner: Optional[pulumi.Input[builtins.str]] = None,
                 personal_access_token: Optional[pulumi.Input[builtins.bool]] = None,
                 scopes: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        """
        Create a ApiToken resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] creation_date: Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.bool] enabled: The token is enabled (true) or disabled (false), default disabled (false).
        :param pulumi.Input[builtins.str] expiration_date: The expiration date of the token.
        :param pulumi.Input[builtins.str] last_used_date: Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.str] last_used_ip_address: Token last used IP address.
        :param pulumi.Input[builtins.str] modified_date: Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        :param pulumi.Input[builtins.str] name: The name of the token.
        :param pulumi.Input[builtins.str] owner: The owner of the token
        :param pulumi.Input[builtins.bool] personal_access_token: The token is a personal access token (true) or an API token (false).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] scopes: A list of the scopes to be assigned to the token.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApiTokenArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ApiToken resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ApiTokenArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApiTokenArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_date: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 expiration_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_date: Optional[pulumi.Input[builtins.str]] = None,
                 last_used_ip_address: Optional[pulumi.Input[builtins.str]] = None,
                 modified_date: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner: Optional[pulumi.Input[builtins.str]] = None,
                 personal_access_token: Optional[pulumi.Input[builtins.bool]] = None,
                 scopes: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApiTokenArgs.__new__(ApiTokenArgs)

            __props__.__dict__["creation_date"] = creation_date
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["expiration_date"] = expiration_date
            __props__.__dict__["last_used_date"] = last_used_date
            __props__.__dict__["last_used_ip_address"] = last_used_ip_address
            __props__.__dict__["modified_date"] = modified_date
            __props__.__dict__["name"] = name
            __props__.__dict__["owner"] = owner
            __props__.__dict__["personal_access_token"] = personal_access_token
            if scopes is None and not opts.urn:
                raise TypeError("Missing required property 'scopes'")
            __props__.__dict__["scopes"] = scopes
            __props__.__dict__["token"] = None
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["token"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(ApiToken, __self__).__init__(
            'dynatrace:index/apiToken:ApiToken',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            creation_date: Optional[pulumi.Input[builtins.str]] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            expiration_date: Optional[pulumi.Input[builtins.str]] = None,
            last_used_date: Optional[pulumi.Input[builtins.str]] = None,
            last_used_ip_address: Optional[pulumi.Input[builtins.str]] = None,
            modified_date: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            owner: Optional[pulumi.Input[builtins.str]] = None,
            personal_access_token: Optional[pulumi.Input[builtins.bool]] = None,
            scopes: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            token: Optional[pulumi.Input[builtins.str]] = None) -> 'ApiToken':
        """
        Get an existing ApiToken resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] creation_date: Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.bool] enabled: The token is enabled (true) or disabled (false), default disabled (false).
        :param pulumi.Input[builtins.str] expiration_date: The expiration date of the token.
        :param pulumi.Input[builtins.str] last_used_date: Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        :param pulumi.Input[builtins.str] last_used_ip_address: Token last used IP address.
        :param pulumi.Input[builtins.str] modified_date: Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        :param pulumi.Input[builtins.str] name: The name of the token.
        :param pulumi.Input[builtins.str] owner: The owner of the token
        :param pulumi.Input[builtins.bool] personal_access_token: The token is a personal access token (true) or an API token (false).
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] scopes: A list of the scopes to be assigned to the token.
        :param pulumi.Input[builtins.str] token: The secret of the token.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApiTokenState.__new__(_ApiTokenState)

        __props__.__dict__["creation_date"] = creation_date
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["expiration_date"] = expiration_date
        __props__.__dict__["last_used_date"] = last_used_date
        __props__.__dict__["last_used_ip_address"] = last_used_ip_address
        __props__.__dict__["modified_date"] = modified_date
        __props__.__dict__["name"] = name
        __props__.__dict__["owner"] = owner
        __props__.__dict__["personal_access_token"] = personal_access_token
        __props__.__dict__["scopes"] = scopes
        __props__.__dict__["token"] = token
        return ApiToken(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationDate")
    def creation_date(self) -> pulumi.Output[builtins.str]:
        """
        Token creation date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "creation_date")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        The token is enabled (true) or disabled (false), default disabled (false).
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The expiration date of the token.
        """
        return pulumi.get(self, "expiration_date")

    @property
    @pulumi.getter(name="lastUsedDate")
    def last_used_date(self) -> pulumi.Output[builtins.str]:
        """
        Token last used date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z')
        """
        return pulumi.get(self, "last_used_date")

    @property
    @pulumi.getter(name="lastUsedIpAddress")
    def last_used_ip_address(self) -> pulumi.Output[builtins.str]:
        """
        Token last used IP address.
        """
        return pulumi.get(self, "last_used_ip_address")

    @property
    @pulumi.getter(name="modifiedDate")
    def modified_date(self) -> pulumi.Output[builtins.str]:
        """
        Token last modified date in ISO 8601 format (yyyy-MM-dd'T'HH:mm:ss.SSS'Z').
        """
        return pulumi.get(self, "modified_date")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the token.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[builtins.str]:
        """
        The owner of the token
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="personalAccessToken")
    def personal_access_token(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        The token is a personal access token (true) or an API token (false).
        """
        return pulumi.get(self, "personal_access_token")

    @property
    @pulumi.getter
    def scopes(self) -> pulumi.Output[Sequence[builtins.str]]:
        """
        A list of the scopes to be assigned to the token.
        """
        return pulumi.get(self, "scopes")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[builtins.str]:
        """
        The secret of the token.
        """
        return pulumi.get(self, "token")

