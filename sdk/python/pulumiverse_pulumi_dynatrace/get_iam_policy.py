# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetIamPolicyResult',
    'AwaitableGetIamPolicyResult',
    'get_iam_policy',
    'get_iam_policy_output',
]

@pulumi.output_type
class GetIamPolicyResult:
    """
    A collection of values returned by getIamPolicy.
    """
    def __init__(__self__, account=None, environment=None, id=None, name=None, uuid=None):
        if account and not isinstance(account, str):
            raise TypeError("Expected argument 'account' to be a str")
        pulumi.set(__self__, "account", account)
        if environment and not isinstance(environment, str):
            raise TypeError("Expected argument 'environment' to be a str")
        pulumi.set(__self__, "environment", environment)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if uuid and not isinstance(uuid, str):
            raise TypeError("Expected argument 'uuid' to be a str")
        pulumi.set(__self__, "uuid", uuid)

    @property
    @pulumi.getter
    def account(self) -> Optional[str]:
        """
        The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
        """
        return pulumi.get(self, "account")

    @property
    @pulumi.getter
    def environment(self) -> Optional[str]:
        """
        The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
        """
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the policy
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def uuid(self) -> str:
        """
        The UUID of the policy
        """
        return pulumi.get(self, "uuid")


class AwaitableGetIamPolicyResult(GetIamPolicyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIamPolicyResult(
            account=self.account,
            environment=self.environment,
            id=self.id,
            name=self.name,
            uuid=self.uuid)


def get_iam_policy(account: Optional[str] = None,
                   environment: Optional[str] = None,
                   name: Optional[str] = None,
                   uuid: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIamPolicyResult:
    """
    The IAM policy data source allows the policy UUID to be retrieved by its name and account/environment (exclude for global).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    appengineadmin = dynatrace.get_iam_policy(name="AppEngine - Admin")
    pulumi.export("policies", appengineadmin)
    ```

    ## Example Output


    :param str account: The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
    :param str environment: The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
    :param str name: The name of the policy
    :param str uuid: The UUID of the policy
    """
    __args__ = dict()
    __args__['account'] = account
    __args__['environment'] = environment
    __args__['name'] = name
    __args__['uuid'] = uuid
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getIamPolicy:getIamPolicy', __args__, opts=opts, typ=GetIamPolicyResult).value

    return AwaitableGetIamPolicyResult(
        account=pulumi.get(__ret__, 'account'),
        environment=pulumi.get(__ret__, 'environment'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        uuid=pulumi.get(__ret__, 'uuid'))


@_utilities.lift_output_func(get_iam_policy)
def get_iam_policy_output(account: Optional[pulumi.Input[Optional[str]]] = None,
                          environment: Optional[pulumi.Input[Optional[str]]] = None,
                          name: Optional[pulumi.Input[str]] = None,
                          uuid: Optional[pulumi.Input[Optional[str]]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIamPolicyResult]:
    """
    The IAM policy data source allows the policy UUID to be retrieved by its name and account/environment (exclude for global).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    appengineadmin = dynatrace.get_iam_policy(name="AppEngine - Admin")
    pulumi.export("policies", appengineadmin)
    ```

    ## Example Output


    :param str account: The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
    :param str environment: The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
    :param str name: The name of the policy
    :param str uuid: The UUID of the policy
    """
    ...