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

__all__ = [
    'GetServiceResult',
    'AwaitableGetServiceResult',
    'get_service',
    'get_service_output',
]

@pulumi.output_type
class GetServiceResult:
    """
    A collection of values returned by getService.
    """
    def __init__(__self__, id=None, name=None, operator=None, tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if operator and not isinstance(operator, str):
            raise TypeError("Expected argument 'operator' to be a str")
        pulumi.set(__self__, "operator", operator)
        if tags and not isinstance(tags, list):
            raise TypeError("Expected argument 'tags' to be a list")
        pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def operator(self) -> Optional[builtins.str]:
        return pulumi.get(self, "operator")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Sequence[builtins.str]]:
        """
        Required tags of the service to find
        """
        return pulumi.get(self, "tags")


class AwaitableGetServiceResult(GetServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceResult(
            id=self.id,
            name=self.name,
            operator=self.operator,
            tags=self.tags)


def get_service(name: Optional[builtins.str] = None,
                operator: Optional[builtins.str] = None,
                tags: Optional[Sequence[builtins.str]] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetServiceResult:
    """
    !> The data source API endpoint has been deprecated, please use get_entity with entity type `SERVICE` instead.

    The service data source allows the service ID to be retrieved by its name and optionally tags / tag-value pairs.

    - `name` queries for all services with the specified name
    - `tags` (optional) refers to the tags that need to be present for the service (inclusive)

    If multiple services match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    test = dynatrace.get_service(name="Example",
        tags=[
            "TerraformKeyTest",
            "TerraformKeyValueTest=TestValue",
        ])
    _name_ = dynatrace.KeyRequests("#name#", service=test.id)
    ```


    :param Sequence[builtins.str] tags: Required tags of the service to find
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['operator'] = operator
    __args__['tags'] = tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getService:getService', __args__, opts=opts, typ=GetServiceResult).value

    return AwaitableGetServiceResult(
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        operator=pulumi.get(__ret__, 'operator'),
        tags=pulumi.get(__ret__, 'tags'))
def get_service_output(name: Optional[pulumi.Input[builtins.str]] = None,
                       operator: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                       tags: Optional[pulumi.Input[Optional[Sequence[builtins.str]]]] = None,
                       opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetServiceResult]:
    """
    !> The data source API endpoint has been deprecated, please use get_entity with entity type `SERVICE` instead.

    The service data source allows the service ID to be retrieved by its name and optionally tags / tag-value pairs.

    - `name` queries for all services with the specified name
    - `tags` (optional) refers to the tags that need to be present for the service (inclusive)

    If multiple services match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    test = dynatrace.get_service(name="Example",
        tags=[
            "TerraformKeyTest",
            "TerraformKeyValueTest=TestValue",
        ])
    _name_ = dynatrace.KeyRequests("#name#", service=test.id)
    ```


    :param Sequence[builtins.str] tags: Required tags of the service to find
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['operator'] = operator
    __args__['tags'] = tags
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getService:getService', __args__, opts=opts, typ=GetServiceResult)
    return __ret__.apply(lambda __response__: GetServiceResult(
        id=pulumi.get(__response__, 'id'),
        name=pulumi.get(__response__, 'name'),
        operator=pulumi.get(__response__, 'operator'),
        tags=pulumi.get(__response__, 'tags')))
