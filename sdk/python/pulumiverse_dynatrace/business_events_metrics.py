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

__all__ = ['BusinessEventsMetricsArgs', 'BusinessEventsMetrics']

@pulumi.input_type
class BusinessEventsMetricsArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[builtins.bool],
                 key: pulumi.Input[builtins.str],
                 matcher: pulumi.Input[builtins.str],
                 measure: pulumi.Input[builtins.str],
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 measure_attribute: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a BusinessEventsMetrics resource.
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] key: Key
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] measure: Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dimensions: no documentation available
        :param pulumi.Input[builtins.str] measure_attribute: Attribute
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "matcher", matcher)
        pulumi.set(__self__, "measure", measure)
        if dimensions is not None:
            pulumi.set(__self__, "dimensions", dimensions)
        if measure_attribute is not None:
            pulumi.set(__self__, "measure_attribute", measure_attribute)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[builtins.bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[builtins.str]:
        """
        Key
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def matcher(self) -> pulumi.Input[builtins.str]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter
    def measure(self) -> pulumi.Input[builtins.str]:
        """
        Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        """
        return pulumi.get(self, "measure")

    @measure.setter
    def measure(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "measure", value)

    @property
    @pulumi.getter
    def dimensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        no documentation available
        """
        return pulumi.get(self, "dimensions")

    @dimensions.setter
    def dimensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dimensions", value)

    @property
    @pulumi.getter(name="measureAttribute")
    def measure_attribute(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Attribute
        """
        return pulumi.get(self, "measure_attribute")

    @measure_attribute.setter
    def measure_attribute(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "measure_attribute", value)


@pulumi.input_type
class _BusinessEventsMetricsState:
    def __init__(__self__, *,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 key: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 measure: Optional[pulumi.Input[builtins.str]] = None,
                 measure_attribute: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering BusinessEventsMetrics resources.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dimensions: no documentation available
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] key: Key
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] measure: Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        :param pulumi.Input[builtins.str] measure_attribute: Attribute
        """
        if dimensions is not None:
            pulumi.set(__self__, "dimensions", dimensions)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if matcher is not None:
            pulumi.set(__self__, "matcher", matcher)
        if measure is not None:
            pulumi.set(__self__, "measure", measure)
        if measure_attribute is not None:
            pulumi.set(__self__, "measure_attribute", measure_attribute)

    @property
    @pulumi.getter
    def dimensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        no documentation available
        """
        return pulumi.get(self, "dimensions")

    @dimensions.setter
    def dimensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dimensions", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Key
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def matcher(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter
    def measure(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        """
        return pulumi.get(self, "measure")

    @measure.setter
    def measure(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "measure", value)

    @property
    @pulumi.getter(name="measureAttribute")
    def measure_attribute(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Attribute
        """
        return pulumi.get(self, "measure_attribute")

    @measure_attribute.setter
    def measure_attribute(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "measure_attribute", value)


@pulumi.type_token("dynatrace:index/businessEventsMetrics:BusinessEventsMetrics")
class BusinessEventsMetrics(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 key: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 measure: Optional[pulumi.Input[builtins.str]] = None,
                 measure_attribute: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a BusinessEventsMetrics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dimensions: no documentation available
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] key: Key
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] measure: Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        :param pulumi.Input[builtins.str] measure_attribute: Attribute
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BusinessEventsMetricsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a BusinessEventsMetrics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param BusinessEventsMetricsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BusinessEventsMetricsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 key: Optional[pulumi.Input[builtins.str]] = None,
                 matcher: Optional[pulumi.Input[builtins.str]] = None,
                 measure: Optional[pulumi.Input[builtins.str]] = None,
                 measure_attribute: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BusinessEventsMetricsArgs.__new__(BusinessEventsMetricsArgs)

            __props__.__dict__["dimensions"] = dimensions
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            if key is None and not opts.urn:
                raise TypeError("Missing required property 'key'")
            __props__.__dict__["key"] = key
            if matcher is None and not opts.urn:
                raise TypeError("Missing required property 'matcher'")
            __props__.__dict__["matcher"] = matcher
            if measure is None and not opts.urn:
                raise TypeError("Missing required property 'measure'")
            __props__.__dict__["measure"] = measure
            __props__.__dict__["measure_attribute"] = measure_attribute
        super(BusinessEventsMetrics, __self__).__init__(
            'dynatrace:index/businessEventsMetrics:BusinessEventsMetrics',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            key: Optional[pulumi.Input[builtins.str]] = None,
            matcher: Optional[pulumi.Input[builtins.str]] = None,
            measure: Optional[pulumi.Input[builtins.str]] = None,
            measure_attribute: Optional[pulumi.Input[builtins.str]] = None) -> 'BusinessEventsMetrics':
        """
        Get an existing BusinessEventsMetrics resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dimensions: no documentation available
        :param pulumi.Input[builtins.bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] key: Key
        :param pulumi.Input[builtins.str] matcher: [See our documentation](https://dt-url.net/bp234rv)
        :param pulumi.Input[builtins.str] measure: Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        :param pulumi.Input[builtins.str] measure_attribute: Attribute
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BusinessEventsMetricsState.__new__(_BusinessEventsMetricsState)

        __props__.__dict__["dimensions"] = dimensions
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["key"] = key
        __props__.__dict__["matcher"] = matcher
        __props__.__dict__["measure"] = measure
        __props__.__dict__["measure_attribute"] = measure_attribute
        return BusinessEventsMetrics(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def dimensions(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        no documentation available
        """
        return pulumi.get(self, "dimensions")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[builtins.bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[builtins.str]:
        """
        Key
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def matcher(self) -> pulumi.Output[builtins.str]:
        """
        [See our documentation](https://dt-url.net/bp234rv)
        """
        return pulumi.get(self, "matcher")

    @property
    @pulumi.getter
    def measure(self) -> pulumi.Output[builtins.str]:
        """
        Possible Values: `ATTRIBUTE`, `OCCURRENCE`
        """
        return pulumi.get(self, "measure")

    @property
    @pulumi.getter(name="measureAttribute")
    def measure_attribute(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Attribute
        """
        return pulumi.get(self, "measure_attribute")

