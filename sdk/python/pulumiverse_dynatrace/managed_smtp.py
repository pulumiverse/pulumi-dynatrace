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

__all__ = ['ManagedSmtpArgs', 'ManagedSmtp']

@pulumi.input_type
class ManagedSmtpArgs:
    def __init__(__self__, *,
                 host_name: pulumi.Input[builtins.str],
                 password: pulumi.Input[builtins.str],
                 sender_email_address: pulumi.Input[builtins.str],
                 user_name: pulumi.Input[builtins.str],
                 allow_fallback_via_mission_control: Optional[pulumi.Input[builtins.bool]] = None,
                 connection_security: Optional[pulumi.Input[builtins.str]] = None,
                 is_password_configured: Optional[pulumi.Input[builtins.bool]] = None,
                 port: Optional[pulumi.Input[builtins.int]] = None,
                 use_smtp_server: Optional[pulumi.Input[builtins.bool]] = None):
        """
        The set of arguments for constructing a ManagedSmtp resource.
        :param pulumi.Input[builtins.str] host_name: Host Name
        :param pulumi.Input[builtins.str] password: Password
        :param pulumi.Input[builtins.str] sender_email_address: Sender email address
        :param pulumi.Input[builtins.str] user_name: User Name
        :param pulumi.Input[builtins.bool] allow_fallback_via_mission_control: If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        :param pulumi.Input[builtins.str] connection_security: Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        :param pulumi.Input[builtins.bool] is_password_configured: If true, a password has been configured. Default: `false`.
        :param pulumi.Input[builtins.int] port: Integer value of port. Default: `25`
        :param pulumi.Input[builtins.bool] use_smtp_server: If true, we will send e-mails via SMTP server.
        """
        pulumi.set(__self__, "host_name", host_name)
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "sender_email_address", sender_email_address)
        pulumi.set(__self__, "user_name", user_name)
        if allow_fallback_via_mission_control is not None:
            pulumi.set(__self__, "allow_fallback_via_mission_control", allow_fallback_via_mission_control)
        if connection_security is not None:
            pulumi.set(__self__, "connection_security", connection_security)
        if is_password_configured is not None:
            pulumi.set(__self__, "is_password_configured", is_password_configured)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if use_smtp_server is not None:
            pulumi.set(__self__, "use_smtp_server", use_smtp_server)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Input[builtins.str]:
        """
        Host Name
        """
        return pulumi.get(self, "host_name")

    @host_name.setter
    def host_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "host_name", value)

    @property
    @pulumi.getter
    def password(self) -> pulumi.Input[builtins.str]:
        """
        Password
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter(name="senderEmailAddress")
    def sender_email_address(self) -> pulumi.Input[builtins.str]:
        """
        Sender email address
        """
        return pulumi.get(self, "sender_email_address")

    @sender_email_address.setter
    def sender_email_address(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "sender_email_address", value)

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> pulumi.Input[builtins.str]:
        """
        User Name
        """
        return pulumi.get(self, "user_name")

    @user_name.setter
    def user_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "user_name", value)

    @property
    @pulumi.getter(name="allowFallbackViaMissionControl")
    def allow_fallback_via_mission_control(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        """
        return pulumi.get(self, "allow_fallback_via_mission_control")

    @allow_fallback_via_mission_control.setter
    def allow_fallback_via_mission_control(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "allow_fallback_via_mission_control", value)

    @property
    @pulumi.getter(name="connectionSecurity")
    def connection_security(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        """
        return pulumi.get(self, "connection_security")

    @connection_security.setter
    def connection_security(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "connection_security", value)

    @property
    @pulumi.getter(name="isPasswordConfigured")
    def is_password_configured(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, a password has been configured. Default: `false`.
        """
        return pulumi.get(self, "is_password_configured")

    @is_password_configured.setter
    def is_password_configured(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "is_password_configured", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[builtins.int]]:
        """
        Integer value of port. Default: `25`
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[builtins.int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="useSmtpServer")
    def use_smtp_server(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, we will send e-mails via SMTP server.
        """
        return pulumi.get(self, "use_smtp_server")

    @use_smtp_server.setter
    def use_smtp_server(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "use_smtp_server", value)


@pulumi.input_type
class _ManagedSmtpState:
    def __init__(__self__, *,
                 allow_fallback_via_mission_control: Optional[pulumi.Input[builtins.bool]] = None,
                 connection_security: Optional[pulumi.Input[builtins.str]] = None,
                 host_name: Optional[pulumi.Input[builtins.str]] = None,
                 is_password_configured: Optional[pulumi.Input[builtins.bool]] = None,
                 password: Optional[pulumi.Input[builtins.str]] = None,
                 port: Optional[pulumi.Input[builtins.int]] = None,
                 sender_email_address: Optional[pulumi.Input[builtins.str]] = None,
                 use_smtp_server: Optional[pulumi.Input[builtins.bool]] = None,
                 user_name: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering ManagedSmtp resources.
        :param pulumi.Input[builtins.bool] allow_fallback_via_mission_control: If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        :param pulumi.Input[builtins.str] connection_security: Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        :param pulumi.Input[builtins.str] host_name: Host Name
        :param pulumi.Input[builtins.bool] is_password_configured: If true, a password has been configured. Default: `false`.
        :param pulumi.Input[builtins.str] password: Password
        :param pulumi.Input[builtins.int] port: Integer value of port. Default: `25`
        :param pulumi.Input[builtins.str] sender_email_address: Sender email address
        :param pulumi.Input[builtins.bool] use_smtp_server: If true, we will send e-mails via SMTP server.
        :param pulumi.Input[builtins.str] user_name: User Name
        """
        if allow_fallback_via_mission_control is not None:
            pulumi.set(__self__, "allow_fallback_via_mission_control", allow_fallback_via_mission_control)
        if connection_security is not None:
            pulumi.set(__self__, "connection_security", connection_security)
        if host_name is not None:
            pulumi.set(__self__, "host_name", host_name)
        if is_password_configured is not None:
            pulumi.set(__self__, "is_password_configured", is_password_configured)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if sender_email_address is not None:
            pulumi.set(__self__, "sender_email_address", sender_email_address)
        if use_smtp_server is not None:
            pulumi.set(__self__, "use_smtp_server", use_smtp_server)
        if user_name is not None:
            pulumi.set(__self__, "user_name", user_name)

    @property
    @pulumi.getter(name="allowFallbackViaMissionControl")
    def allow_fallback_via_mission_control(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        """
        return pulumi.get(self, "allow_fallback_via_mission_control")

    @allow_fallback_via_mission_control.setter
    def allow_fallback_via_mission_control(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "allow_fallback_via_mission_control", value)

    @property
    @pulumi.getter(name="connectionSecurity")
    def connection_security(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        """
        return pulumi.get(self, "connection_security")

    @connection_security.setter
    def connection_security(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "connection_security", value)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Host Name
        """
        return pulumi.get(self, "host_name")

    @host_name.setter
    def host_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "host_name", value)

    @property
    @pulumi.getter(name="isPasswordConfigured")
    def is_password_configured(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, a password has been configured. Default: `false`.
        """
        return pulumi.get(self, "is_password_configured")

    @is_password_configured.setter
    def is_password_configured(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "is_password_configured", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Password
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[builtins.int]]:
        """
        Integer value of port. Default: `25`
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[builtins.int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="senderEmailAddress")
    def sender_email_address(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Sender email address
        """
        return pulumi.get(self, "sender_email_address")

    @sender_email_address.setter
    def sender_email_address(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "sender_email_address", value)

    @property
    @pulumi.getter(name="useSmtpServer")
    def use_smtp_server(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If true, we will send e-mails via SMTP server.
        """
        return pulumi.get(self, "use_smtp_server")

    @use_smtp_server.setter
    def use_smtp_server(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "use_smtp_server", value)

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        User Name
        """
        return pulumi.get(self, "user_name")

    @user_name.setter
    def user_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "user_name", value)


@pulumi.type_token("dynatrace:index/managedSmtp:ManagedSmtp")
class ManagedSmtp(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allow_fallback_via_mission_control: Optional[pulumi.Input[builtins.bool]] = None,
                 connection_security: Optional[pulumi.Input[builtins.str]] = None,
                 host_name: Optional[pulumi.Input[builtins.str]] = None,
                 is_password_configured: Optional[pulumi.Input[builtins.bool]] = None,
                 password: Optional[pulumi.Input[builtins.str]] = None,
                 port: Optional[pulumi.Input[builtins.int]] = None,
                 sender_email_address: Optional[pulumi.Input[builtins.str]] = None,
                 use_smtp_server: Optional[pulumi.Input[builtins.bool]] = None,
                 user_name: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a ManagedSmtp resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] allow_fallback_via_mission_control: If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        :param pulumi.Input[builtins.str] connection_security: Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        :param pulumi.Input[builtins.str] host_name: Host Name
        :param pulumi.Input[builtins.bool] is_password_configured: If true, a password has been configured. Default: `false`.
        :param pulumi.Input[builtins.str] password: Password
        :param pulumi.Input[builtins.int] port: Integer value of port. Default: `25`
        :param pulumi.Input[builtins.str] sender_email_address: Sender email address
        :param pulumi.Input[builtins.bool] use_smtp_server: If true, we will send e-mails via SMTP server.
        :param pulumi.Input[builtins.str] user_name: User Name
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ManagedSmtpArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ManagedSmtp resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ManagedSmtpArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ManagedSmtpArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allow_fallback_via_mission_control: Optional[pulumi.Input[builtins.bool]] = None,
                 connection_security: Optional[pulumi.Input[builtins.str]] = None,
                 host_name: Optional[pulumi.Input[builtins.str]] = None,
                 is_password_configured: Optional[pulumi.Input[builtins.bool]] = None,
                 password: Optional[pulumi.Input[builtins.str]] = None,
                 port: Optional[pulumi.Input[builtins.int]] = None,
                 sender_email_address: Optional[pulumi.Input[builtins.str]] = None,
                 use_smtp_server: Optional[pulumi.Input[builtins.bool]] = None,
                 user_name: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ManagedSmtpArgs.__new__(ManagedSmtpArgs)

            __props__.__dict__["allow_fallback_via_mission_control"] = allow_fallback_via_mission_control
            __props__.__dict__["connection_security"] = connection_security
            if host_name is None and not opts.urn:
                raise TypeError("Missing required property 'host_name'")
            __props__.__dict__["host_name"] = host_name
            __props__.__dict__["is_password_configured"] = is_password_configured
            if password is None and not opts.urn:
                raise TypeError("Missing required property 'password'")
            __props__.__dict__["password"] = None if password is None else pulumi.Output.secret(password)
            __props__.__dict__["port"] = port
            if sender_email_address is None and not opts.urn:
                raise TypeError("Missing required property 'sender_email_address'")
            __props__.__dict__["sender_email_address"] = sender_email_address
            __props__.__dict__["use_smtp_server"] = use_smtp_server
            if user_name is None and not opts.urn:
                raise TypeError("Missing required property 'user_name'")
            __props__.__dict__["user_name"] = user_name
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["password"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(ManagedSmtp, __self__).__init__(
            'dynatrace:index/managedSmtp:ManagedSmtp',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            allow_fallback_via_mission_control: Optional[pulumi.Input[builtins.bool]] = None,
            connection_security: Optional[pulumi.Input[builtins.str]] = None,
            host_name: Optional[pulumi.Input[builtins.str]] = None,
            is_password_configured: Optional[pulumi.Input[builtins.bool]] = None,
            password: Optional[pulumi.Input[builtins.str]] = None,
            port: Optional[pulumi.Input[builtins.int]] = None,
            sender_email_address: Optional[pulumi.Input[builtins.str]] = None,
            use_smtp_server: Optional[pulumi.Input[builtins.bool]] = None,
            user_name: Optional[pulumi.Input[builtins.str]] = None) -> 'ManagedSmtp':
        """
        Get an existing ManagedSmtp resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] allow_fallback_via_mission_control: If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        :param pulumi.Input[builtins.str] connection_security: Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        :param pulumi.Input[builtins.str] host_name: Host Name
        :param pulumi.Input[builtins.bool] is_password_configured: If true, a password has been configured. Default: `false`.
        :param pulumi.Input[builtins.str] password: Password
        :param pulumi.Input[builtins.int] port: Integer value of port. Default: `25`
        :param pulumi.Input[builtins.str] sender_email_address: Sender email address
        :param pulumi.Input[builtins.bool] use_smtp_server: If true, we will send e-mails via SMTP server.
        :param pulumi.Input[builtins.str] user_name: User Name
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ManagedSmtpState.__new__(_ManagedSmtpState)

        __props__.__dict__["allow_fallback_via_mission_control"] = allow_fallback_via_mission_control
        __props__.__dict__["connection_security"] = connection_security
        __props__.__dict__["host_name"] = host_name
        __props__.__dict__["is_password_configured"] = is_password_configured
        __props__.__dict__["password"] = password
        __props__.__dict__["port"] = port
        __props__.__dict__["sender_email_address"] = sender_email_address
        __props__.__dict__["use_smtp_server"] = use_smtp_server
        __props__.__dict__["user_name"] = user_name
        return ManagedSmtp(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allowFallbackViaMissionControl")
    def allow_fallback_via_mission_control(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        """
        return pulumi.get(self, "allow_fallback_via_mission_control")

    @property
    @pulumi.getter(name="connectionSecurity")
    def connection_security(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        """
        return pulumi.get(self, "connection_security")

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Output[builtins.str]:
        """
        Host Name
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter(name="isPasswordConfigured")
    def is_password_configured(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If true, a password has been configured. Default: `false`.
        """
        return pulumi.get(self, "is_password_configured")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[builtins.str]:
        """
        Password
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[builtins.int]]:
        """
        Integer value of port. Default: `25`
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="senderEmailAddress")
    def sender_email_address(self) -> pulumi.Output[builtins.str]:
        """
        Sender email address
        """
        return pulumi.get(self, "sender_email_address")

    @property
    @pulumi.getter(name="useSmtpServer")
    def use_smtp_server(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If true, we will send e-mails via SMTP server.
        """
        return pulumi.get(self, "use_smtp_server")

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> pulumi.Output[builtins.str]:
        """
        User Name
        """
        return pulumi.get(self, "user_name")

