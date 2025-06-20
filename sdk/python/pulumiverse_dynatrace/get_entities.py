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
    'GetEntitiesResult',
    'AwaitableGetEntitiesResult',
    'get_entities',
    'get_entities_output',
]

@pulumi.output_type
class GetEntitiesResult:
    """
    A collection of values returned by getEntities.
    """
    def __init__(__self__, entities=None, entity_selector=None, from_=None, id=None, to=None, type=None):
        if entities and not isinstance(entities, list):
            raise TypeError("Expected argument 'entities' to be a list")
        pulumi.set(__self__, "entities", entities)
        if entity_selector and not isinstance(entity_selector, str):
            raise TypeError("Expected argument 'entity_selector' to be a str")
        pulumi.set(__self__, "entity_selector", entity_selector)
        if from_ and not isinstance(from_, str):
            raise TypeError("Expected argument 'from_' to be a str")
        pulumi.set(__self__, "from_", from_)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if to and not isinstance(to, str):
            raise TypeError("Expected argument 'to' to be a str")
        pulumi.set(__self__, "to", to)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def entities(self) -> Sequence['outputs.GetEntitiesEntityResult']:
        return pulumi.get(self, "entities")

    @property
    @pulumi.getter(name="entitySelector")
    def entity_selector(self) -> Optional[builtins.str]:
        return pulumi.get(self, "entity_selector")

    @property
    @pulumi.getter(name="from")
    def from_(self) -> Optional[builtins.str]:
        return pulumi.get(self, "from_")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def to(self) -> Optional[builtins.str]:
        return pulumi.get(self, "to")

    @property
    @pulumi.getter
    def type(self) -> Optional[builtins.str]:
        return pulumi.get(self, "type")


class AwaitableGetEntitiesResult(GetEntitiesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetEntitiesResult(
            entities=self.entities,
            entity_selector=self.entity_selector,
            from_=self.from_,
            id=self.id,
            to=self.to,
            type=self.type)


def get_entities(entity_selector: Optional[builtins.str] = None,
                 from_: Optional[builtins.str] = None,
                 to: Optional[builtins.str] = None,
                 type: Optional[builtins.str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetEntitiesResult:
    """
    The entities data source allows all entities to be retrieved by its type.

    - `type` (String) Type of the entity, e.g. SERVICE. All available entity types can be retrieved with [/api/v2/entityTypes](https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2/get-all-entity-types).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    test = dynatrace.get_entities(type="SERVICE")
    pulumi.export("serviceList", test.entities)
    ```
    """
    __args__ = dict()
    __args__['entitySelector'] = entity_selector
    __args__['from'] = from_
    __args__['to'] = to
    __args__['type'] = type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getEntities:getEntities', __args__, opts=opts, typ=GetEntitiesResult).value

    return AwaitableGetEntitiesResult(
        entities=pulumi.get(__ret__, 'entities'),
        entity_selector=pulumi.get(__ret__, 'entity_selector'),
        from_=pulumi.get(__ret__, 'from_'),
        id=pulumi.get(__ret__, 'id'),
        to=pulumi.get(__ret__, 'to'),
        type=pulumi.get(__ret__, 'type'))
def get_entities_output(entity_selector: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                        from_: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                        to: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                        type: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                        opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetEntitiesResult]:
    """
    The entities data source allows all entities to be retrieved by its type.

    - `type` (String) Type of the entity, e.g. SERVICE. All available entity types can be retrieved with [/api/v2/entityTypes](https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2/get-all-entity-types).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    test = dynatrace.get_entities(type="SERVICE")
    pulumi.export("serviceList", test.entities)
    ```
    """
    __args__ = dict()
    __args__['entitySelector'] = entity_selector
    __args__['from'] = from_
    __args__['to'] = to
    __args__['type'] = type
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getEntities:getEntities', __args__, opts=opts, typ=GetEntitiesResult)
    return __ret__.apply(lambda __response__: GetEntitiesResult(
        entities=pulumi.get(__response__, 'entities'),
        entity_selector=pulumi.get(__response__, 'entity_selector'),
        from_=pulumi.get(__response__, 'from_'),
        id=pulumi.get(__response__, 'id'),
        to=pulumi.get(__response__, 'to'),
        type=pulumi.get(__response__, 'type')))
