# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetIamPoliciesResult',
    'AwaitableGetIamPoliciesResult',
    'get_iam_policies',
    'get_iam_policies_output',
]

@pulumi.output_type
class GetIamPoliciesResult:
    """
    A collection of values returned by getIamPolicies.
    """
    def __init__(__self__, accounts=None, environments=None, global_=None, id=None, policies=None):
        if accounts and not isinstance(accounts, list):
            raise TypeError("Expected argument 'accounts' to be a list")
        pulumi.set(__self__, "accounts", accounts)
        if environments and not isinstance(environments, list):
            raise TypeError("Expected argument 'environments' to be a list")
        pulumi.set(__self__, "environments", environments)
        if global_ and not isinstance(global_, bool):
            raise TypeError("Expected argument 'global_' to be a bool")
        pulumi.set(__self__, "global_", global_)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if policies and not isinstance(policies, list):
            raise TypeError("Expected argument 'policies' to be a list")
        pulumi.set(__self__, "policies", policies)

    @property
    @pulumi.getter
    def accounts(self) -> Optional[Sequence[str]]:
        """
        The results will contain policies defined for the given accountID. If one of the entries contains `*` the results will contain policies for all accounts
        """
        return pulumi.get(self, "accounts")

    @property
    @pulumi.getter
    def environments(self) -> Optional[Sequence[str]]:
        """
        The results will contain policies defined for the given environments. If one of the entries contains `*` the results will contain policies for all environments
        """
        return pulumi.get(self, "environments")

    @property
    @pulumi.getter(name="global")
    def global_(self) -> Optional[bool]:
        """
        If `true` the results will contain global policies
        """
        return pulumi.get(self, "global_")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def policies(self) -> Sequence['outputs.GetIamPoliciesPolicyResult']:
        return pulumi.get(self, "policies")


class AwaitableGetIamPoliciesResult(GetIamPoliciesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIamPoliciesResult(
            accounts=self.accounts,
            environments=self.environments,
            global_=self.global_,
            id=self.id,
            policies=self.policies)


def get_iam_policies(accounts: Optional[Sequence[str]] = None,
                     environments: Optional[Sequence[str]] = None,
                     global_: Optional[bool] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIamPoliciesResult:
    """
    You can use the attributes `environments`, `accounts` and `globals` to refine which policies you want to query for.
    * The attribute `global` indicates whether the results should also contain global (Dynatrace defined) policies
    * The attribute `environment` is an array of environment IDs.
    * The results won't contain any environment specific policies if the attribute `environments` has been omitted
    * The results will contain policies for all environments reachable via the given credentials if `environments` is set to `["*"]`
    * The attribute `accounts` is an array of accounts UUIDs. Set this to `["*"]` if you want to receive account specific policies.
    * The results won't contain any account specific policies if the attribute `accounts` has been omitted
    ## Example Usage

    The following example queries for polices of all environments reachable via the given credentials, all accounts and all global policies.
    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(accounts=["*"],
        environments=["*"],
        global_=True)
    ```
    The following example queries for policies that are defined for the environment with the id `abce234`. No account specific or global policies will be included.
    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(environments=["abce234"],
        global_=False)
    ```

    ## Example Output

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(environments=["*"],
        accounts=["*"],
        global_=True)
    pulumi.export("policies", all.policies)
    ```


    :param Sequence[str] accounts: The results will contain policies defined for the given accountID. If one of the entries contains `*` the results will contain policies for all accounts
    :param Sequence[str] environments: The results will contain policies defined for the given environments. If one of the entries contains `*` the results will contain policies for all environments
    :param bool global_: If `true` the results will contain global policies
    """
    __args__ = dict()
    __args__['accounts'] = accounts
    __args__['environments'] = environments
    __args__['global'] = global_
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getIamPolicies:getIamPolicies', __args__, opts=opts, typ=GetIamPoliciesResult).value

    return AwaitableGetIamPoliciesResult(
        accounts=pulumi.get(__ret__, 'accounts'),
        environments=pulumi.get(__ret__, 'environments'),
        global_=pulumi.get(__ret__, 'global_'),
        id=pulumi.get(__ret__, 'id'),
        policies=pulumi.get(__ret__, 'policies'))


@_utilities.lift_output_func(get_iam_policies)
def get_iam_policies_output(accounts: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                            environments: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                            global_: Optional[pulumi.Input[Optional[bool]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIamPoliciesResult]:
    """
    You can use the attributes `environments`, `accounts` and `globals` to refine which policies you want to query for.
    * The attribute `global` indicates whether the results should also contain global (Dynatrace defined) policies
    * The attribute `environment` is an array of environment IDs.
    * The results won't contain any environment specific policies if the attribute `environments` has been omitted
    * The results will contain policies for all environments reachable via the given credentials if `environments` is set to `["*"]`
    * The attribute `accounts` is an array of accounts UUIDs. Set this to `["*"]` if you want to receive account specific policies.
    * The results won't contain any account specific policies if the attribute `accounts` has been omitted
    ## Example Usage

    The following example queries for polices of all environments reachable via the given credentials, all accounts and all global policies.
    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(accounts=["*"],
        environments=["*"],
        global_=True)
    ```
    The following example queries for policies that are defined for the environment with the id `abce234`. No account specific or global policies will be included.
    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(environments=["abce234"],
        global_=False)
    ```

    ## Example Output

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    all = dynatrace.get_iam_policies(environments=["*"],
        accounts=["*"],
        global_=True)
    pulumi.export("policies", all.policies)
    ```


    :param Sequence[str] accounts: The results will contain policies defined for the given accountID. If one of the entries contains `*` the results will contain policies for all accounts
    :param Sequence[str] environments: The results will contain policies defined for the given environments. If one of the entries contains `*` the results will contain policies for all environments
    :param bool global_: If `true` the results will contain global policies
    """
    ...