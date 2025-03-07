# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

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

__all__ = ['UrlBasedSamplingArgs', 'UrlBasedSampling']

@pulumi.input_type
class UrlBasedSamplingArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[bool],
                 http_method_any: pulumi.Input[bool],
                 ignore: pulumi.Input[bool],
                 factor: Optional[pulumi.Input[str]] = None,
                 http_methods: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 path: Optional[pulumi.Input[str]] = None,
                 path_comparison_type: Optional[pulumi.Input[str]] = None,
                 query_parameters: Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a UrlBasedSampling resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[bool] http_method_any: The scaling factor for the defined URL will be applied to any HTTP method.
        :param pulumi.Input[bool] ignore: The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        :param pulumi.Input[str] factor: Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        :param pulumi.Input[Sequence[pulumi.Input[str]]] http_methods: Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] path: Path of the URL.
        :param pulumi.Input[str] path_comparison_type: Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        :param pulumi.Input['UrlBasedSamplingQueryParametersArgs'] query_parameters: Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        :param pulumi.Input[str] scope: The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "http_method_any", http_method_any)
        pulumi.set(__self__, "ignore", ignore)
        if factor is not None:
            pulumi.set(__self__, "factor", factor)
        if http_methods is not None:
            pulumi.set(__self__, "http_methods", http_methods)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if path is not None:
            pulumi.set(__self__, "path", path)
        if path_comparison_type is not None:
            pulumi.set(__self__, "path_comparison_type", path_comparison_type)
        if query_parameters is not None:
            pulumi.set(__self__, "query_parameters", query_parameters)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="httpMethodAny")
    def http_method_any(self) -> pulumi.Input[bool]:
        """
        The scaling factor for the defined URL will be applied to any HTTP method.
        """
        return pulumi.get(self, "http_method_any")

    @http_method_any.setter
    def http_method_any(self, value: pulumi.Input[bool]):
        pulumi.set(self, "http_method_any", value)

    @property
    @pulumi.getter
    def ignore(self) -> pulumi.Input[bool]:
        """
        The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        """
        return pulumi.get(self, "ignore")

    @ignore.setter
    def ignore(self, value: pulumi.Input[bool]):
        pulumi.set(self, "ignore", value)

    @property
    @pulumi.getter
    def factor(self) -> Optional[pulumi.Input[str]]:
        """
        Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        """
        return pulumi.get(self, "factor")

    @factor.setter
    def factor(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "factor", value)

    @property
    @pulumi.getter(name="httpMethods")
    def http_methods(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        """
        return pulumi.get(self, "http_methods")

    @http_methods.setter
    def http_methods(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "http_methods", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter
    def path(self) -> Optional[pulumi.Input[str]]:
        """
        Path of the URL.
        """
        return pulumi.get(self, "path")

    @path.setter
    def path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path", value)

    @property
    @pulumi.getter(name="pathComparisonType")
    def path_comparison_type(self) -> Optional[pulumi.Input[str]]:
        """
        Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        """
        return pulumi.get(self, "path_comparison_type")

    @path_comparison_type.setter
    def path_comparison_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path_comparison_type", value)

    @property
    @pulumi.getter(name="queryParameters")
    def query_parameters(self) -> Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']]:
        """
        Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        """
        return pulumi.get(self, "query_parameters")

    @query_parameters.setter
    def query_parameters(self, value: Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']]):
        pulumi.set(self, "query_parameters", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _UrlBasedSamplingState:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 factor: Optional[pulumi.Input[str]] = None,
                 http_method_any: Optional[pulumi.Input[bool]] = None,
                 http_methods: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 ignore: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 path: Optional[pulumi.Input[str]] = None,
                 path_comparison_type: Optional[pulumi.Input[str]] = None,
                 query_parameters: Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering UrlBasedSampling resources.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] factor: Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        :param pulumi.Input[bool] http_method_any: The scaling factor for the defined URL will be applied to any HTTP method.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] http_methods: Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        :param pulumi.Input[bool] ignore: The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] path: Path of the URL.
        :param pulumi.Input[str] path_comparison_type: Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        :param pulumi.Input['UrlBasedSamplingQueryParametersArgs'] query_parameters: Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        :param pulumi.Input[str] scope: The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if factor is not None:
            pulumi.set(__self__, "factor", factor)
        if http_method_any is not None:
            pulumi.set(__self__, "http_method_any", http_method_any)
        if http_methods is not None:
            pulumi.set(__self__, "http_methods", http_methods)
        if ignore is not None:
            pulumi.set(__self__, "ignore", ignore)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if path is not None:
            pulumi.set(__self__, "path", path)
        if path_comparison_type is not None:
            pulumi.set(__self__, "path_comparison_type", path_comparison_type)
        if query_parameters is not None:
            pulumi.set(__self__, "query_parameters", query_parameters)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def factor(self) -> Optional[pulumi.Input[str]]:
        """
        Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        """
        return pulumi.get(self, "factor")

    @factor.setter
    def factor(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "factor", value)

    @property
    @pulumi.getter(name="httpMethodAny")
    def http_method_any(self) -> Optional[pulumi.Input[bool]]:
        """
        The scaling factor for the defined URL will be applied to any HTTP method.
        """
        return pulumi.get(self, "http_method_any")

    @http_method_any.setter
    def http_method_any(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "http_method_any", value)

    @property
    @pulumi.getter(name="httpMethods")
    def http_methods(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        """
        return pulumi.get(self, "http_methods")

    @http_methods.setter
    def http_methods(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "http_methods", value)

    @property
    @pulumi.getter
    def ignore(self) -> Optional[pulumi.Input[bool]]:
        """
        The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        """
        return pulumi.get(self, "ignore")

    @ignore.setter
    def ignore(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "ignore", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter
    def path(self) -> Optional[pulumi.Input[str]]:
        """
        Path of the URL.
        """
        return pulumi.get(self, "path")

    @path.setter
    def path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path", value)

    @property
    @pulumi.getter(name="pathComparisonType")
    def path_comparison_type(self) -> Optional[pulumi.Input[str]]:
        """
        Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        """
        return pulumi.get(self, "path_comparison_type")

    @path_comparison_type.setter
    def path_comparison_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path_comparison_type", value)

    @property
    @pulumi.getter(name="queryParameters")
    def query_parameters(self) -> Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']]:
        """
        Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        """
        return pulumi.get(self, "query_parameters")

    @query_parameters.setter
    def query_parameters(self, value: Optional[pulumi.Input['UrlBasedSamplingQueryParametersArgs']]):
        pulumi.set(self, "query_parameters", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


class UrlBasedSampling(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 factor: Optional[pulumi.Input[str]] = None,
                 http_method_any: Optional[pulumi.Input[bool]] = None,
                 http_methods: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 ignore: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 path: Optional[pulumi.Input[str]] = None,
                 path_comparison_type: Optional[pulumi.Input[str]] = None,
                 query_parameters: Optional[pulumi.Input[Union['UrlBasedSamplingQueryParametersArgs', 'UrlBasedSamplingQueryParametersArgsDict']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a UrlBasedSampling resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] factor: Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        :param pulumi.Input[bool] http_method_any: The scaling factor for the defined URL will be applied to any HTTP method.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] http_methods: Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        :param pulumi.Input[bool] ignore: The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] path: Path of the URL.
        :param pulumi.Input[str] path_comparison_type: Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        :param pulumi.Input[Union['UrlBasedSamplingQueryParametersArgs', 'UrlBasedSamplingQueryParametersArgsDict']] query_parameters: Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        :param pulumi.Input[str] scope: The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: UrlBasedSamplingArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a UrlBasedSampling resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param UrlBasedSamplingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UrlBasedSamplingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 factor: Optional[pulumi.Input[str]] = None,
                 http_method_any: Optional[pulumi.Input[bool]] = None,
                 http_methods: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 ignore: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 path: Optional[pulumi.Input[str]] = None,
                 path_comparison_type: Optional[pulumi.Input[str]] = None,
                 query_parameters: Optional[pulumi.Input[Union['UrlBasedSamplingQueryParametersArgs', 'UrlBasedSamplingQueryParametersArgsDict']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UrlBasedSamplingArgs.__new__(UrlBasedSamplingArgs)

            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["factor"] = factor
            if http_method_any is None and not opts.urn:
                raise TypeError("Missing required property 'http_method_any'")
            __props__.__dict__["http_method_any"] = http_method_any
            __props__.__dict__["http_methods"] = http_methods
            if ignore is None and not opts.urn:
                raise TypeError("Missing required property 'ignore'")
            __props__.__dict__["ignore"] = ignore
            __props__.__dict__["insert_after"] = insert_after
            __props__.__dict__["path"] = path
            __props__.__dict__["path_comparison_type"] = path_comparison_type
            __props__.__dict__["query_parameters"] = query_parameters
            __props__.__dict__["scope"] = scope
        super(UrlBasedSampling, __self__).__init__(
            'dynatrace:index/urlBasedSampling:UrlBasedSampling',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            factor: Optional[pulumi.Input[str]] = None,
            http_method_any: Optional[pulumi.Input[bool]] = None,
            http_methods: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            ignore: Optional[pulumi.Input[bool]] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            path: Optional[pulumi.Input[str]] = None,
            path_comparison_type: Optional[pulumi.Input[str]] = None,
            query_parameters: Optional[pulumi.Input[Union['UrlBasedSamplingQueryParametersArgs', 'UrlBasedSamplingQueryParametersArgsDict']]] = None,
            scope: Optional[pulumi.Input[str]] = None) -> 'UrlBasedSampling':
        """
        Get an existing UrlBasedSampling resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] factor: Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        :param pulumi.Input[bool] http_method_any: The scaling factor for the defined URL will be applied to any HTTP method.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] http_methods: Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        :param pulumi.Input[bool] ignore: The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] path: Path of the URL.
        :param pulumi.Input[str] path_comparison_type: Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        :param pulumi.Input[Union['UrlBasedSamplingQueryParametersArgs', 'UrlBasedSamplingQueryParametersArgsDict']] query_parameters: Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        :param pulumi.Input[str] scope: The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UrlBasedSamplingState.__new__(_UrlBasedSamplingState)

        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["factor"] = factor
        __props__.__dict__["http_method_any"] = http_method_any
        __props__.__dict__["http_methods"] = http_methods
        __props__.__dict__["ignore"] = ignore
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["path"] = path
        __props__.__dict__["path_comparison_type"] = path_comparison_type
        __props__.__dict__["query_parameters"] = query_parameters
        __props__.__dict__["scope"] = scope
        return UrlBasedSampling(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def factor(self) -> pulumi.Output[Optional[str]]:
        """
        Select the scaling factor for the current sampling rate of the system. Possible values: `IncreaseCapturing128Times`, `IncreaseCapturing64Times`, `IncreaseCapturing32Times`, `IncreaseCapturing16Times`, `IncreaseCapturing8Times`, `IncreaseCapturing4Times`, `IncreaseCapturing2Times`, `ReduceCapturingByFactor2`, `ReduceCapturingByFactor4`, `ReduceCapturingByFactor8`, `ReduceCapturingByFactor16`, `ReduceCapturingByFactor32`, `ReduceCapturingByFactor64`, `ReduceCapturingByFactor128`
        """
        return pulumi.get(self, "factor")

    @property
    @pulumi.getter(name="httpMethodAny")
    def http_method_any(self) -> pulumi.Output[bool]:
        """
        The scaling factor for the defined URL will be applied to any HTTP method.
        """
        return pulumi.get(self, "http_method_any")

    @property
    @pulumi.getter(name="httpMethods")
    def http_methods(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Possible values: `GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`
        """
        return pulumi.get(self, "http_methods")

    @property
    @pulumi.getter
    def ignore(self) -> pulumi.Output[bool]:
        """
        The matching URLs will always be ignored, also if Adaptive Traffic Management is not active.
        """
        return pulumi.get(self, "ignore")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter
    def path(self) -> pulumi.Output[Optional[str]]:
        """
        Path of the URL.
        """
        return pulumi.get(self, "path")

    @property
    @pulumi.getter(name="pathComparisonType")
    def path_comparison_type(self) -> pulumi.Output[Optional[str]]:
        """
        Path comparison condition. Possible values: `EQUALS`, `DOES_NOT_EQUAL`, `CONTAINS`, `DOES_NOT_CONTAIN`, `STARTS_WITH`, `DOES_NOT_START_WITH`, `ENDS_WITH`, `DOES_NOT_END_WITH`
        """
        return pulumi.get(self, "path_comparison_type")

    @property
    @pulumi.getter(name="queryParameters")
    def query_parameters(self) -> pulumi.Output[Optional['outputs.UrlBasedSamplingQueryParameters']]:
        """
        Add URL parameters in any order. **All** specified parameters must be present in the query of an URL to get a match.
        """
        return pulumi.get(self, "query_parameters")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this setting (PROCESS*GROUP*INSTANCE, PROCESS_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

