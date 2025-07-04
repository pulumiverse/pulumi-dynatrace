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
    'GetProcessGroupResult',
    'AwaitableGetProcessGroupResult',
    'get_process_group',
    'get_process_group_output',
]

@pulumi.output_type
class GetProcessGroupResult:
    """
    A collection of values returned by getProcessGroup.
    """
    def __init__(__self__, id=None, name=None, tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
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
    def tags(self) -> Optional[Sequence[builtins.str]]:
        """
        Required tags of the process group to find
        """
        return pulumi.get(self, "tags")


class AwaitableGetProcessGroupResult(GetProcessGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProcessGroupResult(
            id=self.id,
            name=self.name,
            tags=self.tags)


def get_process_group(name: Optional[builtins.str] = None,
                      tags: Optional[Sequence[builtins.str]] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProcessGroupResult:
    """
    !> The data source API endpoint has been deprecated, please use get_entity with entity type `PROCESS_GROUP` instead.

    The process group data source allows the process group ID to be retrieved by its name and optionally tags / tag-value pairs.

    - `name` queries for all process groups with the specified name
    - `tags` (optional) refers to the tags that need to be present for the process group (inclusive)

    If multiple process groups match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    test = dynatrace.get_process_group(name="Example",
        tags=[
            "TerraformKeyTest",
            "TerraformKeyValueTest=TestValue",
        ])
    _name_ = dynatrace.ManagementZone("#name#", entity_selector_based_rules=[{
        "enabled": True,
        "selector": f"type(\\"process_group\\"),entityId(\\"{test.id}\\")",
    }])
    ```


    :param Sequence[builtins.str] tags: Required tags of the process group to find
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['tags'] = tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getProcessGroup:getProcessGroup', __args__, opts=opts, typ=GetProcessGroupResult).value

    return AwaitableGetProcessGroupResult(
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        tags=pulumi.get(__ret__, 'tags'))
def get_process_group_output(name: Optional[pulumi.Input[builtins.str]] = None,
                             tags: Optional[pulumi.Input[Optional[Sequence[builtins.str]]]] = None,
                             opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetProcessGroupResult]:
    """
    !> The data source API endpoint has been deprecated, please use get_entity with entity type `PROCESS_GROUP` instead.

    The process group data source allows the process group ID to be retrieved by its name and optionally tags / tag-value pairs.

    - `name` queries for all process groups with the specified name
    - `tags` (optional) refers to the tags that need to be present for the process group (inclusive)

    If multiple process groups match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    test = dynatrace.get_process_group(name="Example",
        tags=[
            "TerraformKeyTest",
            "TerraformKeyValueTest=TestValue",
        ])
    _name_ = dynatrace.ManagementZone("#name#", entity_selector_based_rules=[{
        "enabled": True,
        "selector": f"type(\\"process_group\\"),entityId(\\"{test.id}\\")",
    }])
    ```


    :param Sequence[builtins.str] tags: Required tags of the process group to find
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['tags'] = tags
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getProcessGroup:getProcessGroup', __args__, opts=opts, typ=GetProcessGroupResult)
    return __ret__.apply(lambda __response__: GetProcessGroupResult(
        id=pulumi.get(__response__, 'id'),
        name=pulumi.get(__response__, 'name'),
        tags=pulumi.get(__response__, 'tags')))
