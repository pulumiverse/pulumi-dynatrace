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

__all__ = [
    'GetHubItemsResult',
    'AwaitableGetHubItemsResult',
    'get_hub_items',
    'get_hub_items_output',
]

@pulumi.output_type
class GetHubItemsResult:
    """
    A collection of values returned by getHubItems.
    """
    def __init__(__self__, artifacts=None, id=None, items=None, type=None):
        if artifacts and not isinstance(artifacts, dict):
            raise TypeError("Expected argument 'artifacts' to be a dict")
        pulumi.set(__self__, "artifacts", artifacts)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if items and not isinstance(items, list):
            raise TypeError("Expected argument 'items' to be a list")
        pulumi.set(__self__, "items", items)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def artifacts(self) -> Mapping[str, builtins.str]:
        """
        The fully qualified names of the items as a map
        """
        return pulumi.get(self, "artifacts")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def items(self) -> Sequence['outputs.GetHubItemsItemResult']:
        """
        The items within this list
        """
        return pulumi.get(self, "items")

    @property
    @pulumi.getter
    def type(self) -> Optional[builtins.str]:
        """
        Represents the type of item. It can be `TECHNOLOGY`, `EXTENSION1` or `EXTENSION2`. If not specified, no restriction regarding type happens
        """
        return pulumi.get(self, "type")


class AwaitableGetHubItemsResult(GetHubItemsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetHubItemsResult(
            artifacts=self.artifacts,
            id=self.id,
            items=self.items,
            type=self.type)


def get_hub_items(type: Optional[builtins.str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetHubItemsResult:
    """
    > This data source requires the API token scope `hub.read`)

    - `type` (String) The type of hub item you are interested in. Possible values are `TECHNOLOGY`, `EXTENSION1` or `EXTENSION2`. If not specified, no restriction regarding type happens

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    extension_20_items = dynatrace.get_hub_items(type="EXTENSION2")
    pulumi.export("artifact-ids", extension_20_items.artifacts)
    pulumi.export("hub-items", extension_20_items.items)
    ```


    :param builtins.str type: Represents the type of item. It can be `TECHNOLOGY`, `EXTENSION1` or `EXTENSION2`. If not specified, no restriction regarding type happens
    """
    __args__ = dict()
    __args__['type'] = type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getHubItems:getHubItems', __args__, opts=opts, typ=GetHubItemsResult).value

    return AwaitableGetHubItemsResult(
        artifacts=pulumi.get(__ret__, 'artifacts'),
        id=pulumi.get(__ret__, 'id'),
        items=pulumi.get(__ret__, 'items'),
        type=pulumi.get(__ret__, 'type'))
def get_hub_items_output(type: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                         opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetHubItemsResult]:
    """
    > This data source requires the API token scope `hub.read`)

    - `type` (String) The type of hub item you are interested in. Possible values are `TECHNOLOGY`, `EXTENSION1` or `EXTENSION2`. If not specified, no restriction regarding type happens

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    extension_20_items = dynatrace.get_hub_items(type="EXTENSION2")
    pulumi.export("artifact-ids", extension_20_items.artifacts)
    pulumi.export("hub-items", extension_20_items.items)
    ```


    :param builtins.str type: Represents the type of item. It can be `TECHNOLOGY`, `EXTENSION1` or `EXTENSION2`. If not specified, no restriction regarding type happens
    """
    __args__ = dict()
    __args__['type'] = type
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getHubItems:getHubItems', __args__, opts=opts, typ=GetHubItemsResult)
    return __ret__.apply(lambda __response__: GetHubItemsResult(
        artifacts=pulumi.get(__response__, 'artifacts'),
        id=pulumi.get(__response__, 'id'),
        items=pulumi.get(__response__, 'items'),
        type=pulumi.get(__response__, 'type')))
