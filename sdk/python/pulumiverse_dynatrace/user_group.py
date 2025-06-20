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

__all__ = ['UserGroupArgs', 'UserGroup']

@pulumi.input_type
class UserGroupArgs:
    def __init__(__self__, *,
                 access_account: Optional[pulumi.Input[builtins.bool]] = None,
                 cluster_admin: Optional[pulumi.Input[builtins.bool]] = None,
                 ldap_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 manage_account: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 permissions: Optional[pulumi.Input['UserGroupPermissionsArgs']] = None,
                 sso_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        The set of arguments for constructing a UserGroup resource.
        :param pulumi.Input[builtins.bool] access_account: If `true`, then the group has the access account rights
        :param pulumi.Input[builtins.bool] cluster_admin: If `true`, then the group has the cluster administrator rights
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] ldap_groups: LDAP group names
        :param pulumi.Input[builtins.bool] manage_account: If `true`, then the group has the manage account rights
        :param pulumi.Input[builtins.str] name: The name of the user group
        :param pulumi.Input['UserGroupPermissionsArgs'] permissions: Permissions for environments
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] sso_groups: SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        if access_account is not None:
            pulumi.set(__self__, "access_account", access_account)
        if cluster_admin is not None:
            pulumi.set(__self__, "cluster_admin", cluster_admin)
        if ldap_groups is not None:
            pulumi.set(__self__, "ldap_groups", ldap_groups)
        if manage_account is not None:
            pulumi.set(__self__, "manage_account", manage_account)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)
        if sso_groups is not None:
            pulumi.set(__self__, "sso_groups", sso_groups)

    @property
    @pulumi.getter(name="accessAccount")
    def access_account(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the access account rights
        """
        return pulumi.get(self, "access_account")

    @access_account.setter
    def access_account(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "access_account", value)

    @property
    @pulumi.getter(name="clusterAdmin")
    def cluster_admin(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the cluster administrator rights
        """
        return pulumi.get(self, "cluster_admin")

    @cluster_admin.setter
    def cluster_admin(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "cluster_admin", value)

    @property
    @pulumi.getter(name="ldapGroups")
    def ldap_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        LDAP group names
        """
        return pulumi.get(self, "ldap_groups")

    @ldap_groups.setter
    def ldap_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "ldap_groups", value)

    @property
    @pulumi.getter(name="manageAccount")
    def manage_account(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the manage account rights
        """
        return pulumi.get(self, "manage_account")

    @manage_account.setter
    def manage_account(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "manage_account", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the user group
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input['UserGroupPermissionsArgs']]:
        """
        Permissions for environments
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input['UserGroupPermissionsArgs']]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="ssoGroups")
    def sso_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        return pulumi.get(self, "sso_groups")

    @sso_groups.setter
    def sso_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "sso_groups", value)


@pulumi.input_type
class _UserGroupState:
    def __init__(__self__, *,
                 access_account: Optional[pulumi.Input[builtins.bool]] = None,
                 cluster_admin: Optional[pulumi.Input[builtins.bool]] = None,
                 ldap_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 manage_account: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 permissions: Optional[pulumi.Input['UserGroupPermissionsArgs']] = None,
                 sso_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        Input properties used for looking up and filtering UserGroup resources.
        :param pulumi.Input[builtins.bool] access_account: If `true`, then the group has the access account rights
        :param pulumi.Input[builtins.bool] cluster_admin: If `true`, then the group has the cluster administrator rights
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] ldap_groups: LDAP group names
        :param pulumi.Input[builtins.bool] manage_account: If `true`, then the group has the manage account rights
        :param pulumi.Input[builtins.str] name: The name of the user group
        :param pulumi.Input['UserGroupPermissionsArgs'] permissions: Permissions for environments
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] sso_groups: SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        if access_account is not None:
            pulumi.set(__self__, "access_account", access_account)
        if cluster_admin is not None:
            pulumi.set(__self__, "cluster_admin", cluster_admin)
        if ldap_groups is not None:
            pulumi.set(__self__, "ldap_groups", ldap_groups)
        if manage_account is not None:
            pulumi.set(__self__, "manage_account", manage_account)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)
        if sso_groups is not None:
            pulumi.set(__self__, "sso_groups", sso_groups)

    @property
    @pulumi.getter(name="accessAccount")
    def access_account(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the access account rights
        """
        return pulumi.get(self, "access_account")

    @access_account.setter
    def access_account(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "access_account", value)

    @property
    @pulumi.getter(name="clusterAdmin")
    def cluster_admin(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the cluster administrator rights
        """
        return pulumi.get(self, "cluster_admin")

    @cluster_admin.setter
    def cluster_admin(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "cluster_admin", value)

    @property
    @pulumi.getter(name="ldapGroups")
    def ldap_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        LDAP group names
        """
        return pulumi.get(self, "ldap_groups")

    @ldap_groups.setter
    def ldap_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "ldap_groups", value)

    @property
    @pulumi.getter(name="manageAccount")
    def manage_account(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        If `true`, then the group has the manage account rights
        """
        return pulumi.get(self, "manage_account")

    @manage_account.setter
    def manage_account(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "manage_account", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the user group
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input['UserGroupPermissionsArgs']]:
        """
        Permissions for environments
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input['UserGroupPermissionsArgs']]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="ssoGroups")
    def sso_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        return pulumi.get(self, "sso_groups")

    @sso_groups.setter
    def sso_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "sso_groups", value)


@pulumi.type_token("dynatrace:index/userGroup:UserGroup")
class UserGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_account: Optional[pulumi.Input[builtins.bool]] = None,
                 cluster_admin: Optional[pulumi.Input[builtins.bool]] = None,
                 ldap_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 manage_account: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 permissions: Optional[pulumi.Input[Union['UserGroupPermissionsArgs', 'UserGroupPermissionsArgsDict']]] = None,
                 sso_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        """
        Create a UserGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] access_account: If `true`, then the group has the access account rights
        :param pulumi.Input[builtins.bool] cluster_admin: If `true`, then the group has the cluster administrator rights
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] ldap_groups: LDAP group names
        :param pulumi.Input[builtins.bool] manage_account: If `true`, then the group has the manage account rights
        :param pulumi.Input[builtins.str] name: The name of the user group
        :param pulumi.Input[Union['UserGroupPermissionsArgs', 'UserGroupPermissionsArgsDict']] permissions: Permissions for environments
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] sso_groups: SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[UserGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a UserGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param UserGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UserGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_account: Optional[pulumi.Input[builtins.bool]] = None,
                 cluster_admin: Optional[pulumi.Input[builtins.bool]] = None,
                 ldap_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 manage_account: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 permissions: Optional[pulumi.Input[Union['UserGroupPermissionsArgs', 'UserGroupPermissionsArgsDict']]] = None,
                 sso_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UserGroupArgs.__new__(UserGroupArgs)

            __props__.__dict__["access_account"] = access_account
            __props__.__dict__["cluster_admin"] = cluster_admin
            __props__.__dict__["ldap_groups"] = ldap_groups
            __props__.__dict__["manage_account"] = manage_account
            __props__.__dict__["name"] = name
            __props__.__dict__["permissions"] = permissions
            __props__.__dict__["sso_groups"] = sso_groups
        super(UserGroup, __self__).__init__(
            'dynatrace:index/userGroup:UserGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_account: Optional[pulumi.Input[builtins.bool]] = None,
            cluster_admin: Optional[pulumi.Input[builtins.bool]] = None,
            ldap_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            manage_account: Optional[pulumi.Input[builtins.bool]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            permissions: Optional[pulumi.Input[Union['UserGroupPermissionsArgs', 'UserGroupPermissionsArgsDict']]] = None,
            sso_groups: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None) -> 'UserGroup':
        """
        Get an existing UserGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] access_account: If `true`, then the group has the access account rights
        :param pulumi.Input[builtins.bool] cluster_admin: If `true`, then the group has the cluster administrator rights
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] ldap_groups: LDAP group names
        :param pulumi.Input[builtins.bool] manage_account: If `true`, then the group has the manage account rights
        :param pulumi.Input[builtins.str] name: The name of the user group
        :param pulumi.Input[Union['UserGroupPermissionsArgs', 'UserGroupPermissionsArgsDict']] permissions: Permissions for environments
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] sso_groups: SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UserGroupState.__new__(_UserGroupState)

        __props__.__dict__["access_account"] = access_account
        __props__.__dict__["cluster_admin"] = cluster_admin
        __props__.__dict__["ldap_groups"] = ldap_groups
        __props__.__dict__["manage_account"] = manage_account
        __props__.__dict__["name"] = name
        __props__.__dict__["permissions"] = permissions
        __props__.__dict__["sso_groups"] = sso_groups
        return UserGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessAccount")
    def access_account(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If `true`, then the group has the access account rights
        """
        return pulumi.get(self, "access_account")

    @property
    @pulumi.getter(name="clusterAdmin")
    def cluster_admin(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If `true`, then the group has the cluster administrator rights
        """
        return pulumi.get(self, "cluster_admin")

    @property
    @pulumi.getter(name="ldapGroups")
    def ldap_groups(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        LDAP group names
        """
        return pulumi.get(self, "ldap_groups")

    @property
    @pulumi.getter(name="manageAccount")
    def manage_account(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        If `true`, then the group has the manage account rights
        """
        return pulumi.get(self, "manage_account")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the user group
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Optional['outputs.UserGroupPermissions']]:
        """
        Permissions for environments
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter(name="ssoGroups")
    def sso_groups(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        SSO group names. If defined it's used to map SSO group name to Dynatrace group name, otherwise mapping is done by group name
        """
        return pulumi.get(self, "sso_groups")

