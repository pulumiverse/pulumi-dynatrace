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

__all__ = ['RequestAttributeArgs', 'RequestAttribute']

@pulumi.input_type
class RequestAttributeArgs:
    def __init__(__self__, *,
                 aggregation: pulumi.Input[builtins.str],
                 data_type: pulumi.Input[builtins.str],
                 normalization: pulumi.Input[builtins.str],
                 confidential: Optional[pulumi.Input[builtins.bool]] = None,
                 data_sources: Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 skip_personal_data_masking: Optional[pulumi.Input[builtins.bool]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a RequestAttribute resource.
        :param pulumi.Input[builtins.str] aggregation: Aggregation type for the request values
        :param pulumi.Input[builtins.str] data_type: The data type of the request attribute
        :param pulumi.Input[builtins.str] normalization: String values transformation.   If the **dataType** is not `string`, set the `Original` here
        :param pulumi.Input[builtins.bool] confidential: Confidential data flag. Set `true` to treat the captured data as confidential
        :param pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]] data_sources: The list of data sources
        :param pulumi.Input[builtins.bool] enabled: The request attribute is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] name: The name of the request attribute
        :param pulumi.Input[builtins.bool] skip_personal_data_masking: Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        pulumi.set(__self__, "aggregation", aggregation)
        pulumi.set(__self__, "data_type", data_type)
        pulumi.set(__self__, "normalization", normalization)
        if confidential is not None:
            pulumi.set(__self__, "confidential", confidential)
        if data_sources is not None:
            pulumi.set(__self__, "data_sources", data_sources)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if skip_personal_data_masking is not None:
            pulumi.set(__self__, "skip_personal_data_masking", skip_personal_data_masking)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def aggregation(self) -> pulumi.Input[builtins.str]:
        """
        Aggregation type for the request values
        """
        return pulumi.get(self, "aggregation")

    @aggregation.setter
    def aggregation(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "aggregation", value)

    @property
    @pulumi.getter(name="dataType")
    def data_type(self) -> pulumi.Input[builtins.str]:
        """
        The data type of the request attribute
        """
        return pulumi.get(self, "data_type")

    @data_type.setter
    def data_type(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "data_type", value)

    @property
    @pulumi.getter
    def normalization(self) -> pulumi.Input[builtins.str]:
        """
        String values transformation.   If the **dataType** is not `string`, set the `Original` here
        """
        return pulumi.get(self, "normalization")

    @normalization.setter
    def normalization(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "normalization", value)

    @property
    @pulumi.getter
    def confidential(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Confidential data flag. Set `true` to treat the captured data as confidential
        """
        return pulumi.get(self, "confidential")

    @confidential.setter
    def confidential(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "confidential", value)

    @property
    @pulumi.getter(name="dataSources")
    def data_sources(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]]:
        """
        The list of data sources
        """
        return pulumi.get(self, "data_sources")

    @data_sources.setter
    def data_sources(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]]):
        pulumi.set(self, "data_sources", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The request attribute is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the request attribute
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="skipPersonalDataMasking")
    def skip_personal_data_masking(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        """
        return pulumi.get(self, "skip_personal_data_masking")

    @skip_personal_data_masking.setter
    def skip_personal_data_masking(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "skip_personal_data_masking", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "unknowns", value)


@pulumi.input_type
class _RequestAttributeState:
    def __init__(__self__, *,
                 aggregation: Optional[pulumi.Input[builtins.str]] = None,
                 confidential: Optional[pulumi.Input[builtins.bool]] = None,
                 data_sources: Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]] = None,
                 data_type: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 normalization: Optional[pulumi.Input[builtins.str]] = None,
                 skip_personal_data_masking: Optional[pulumi.Input[builtins.bool]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering RequestAttribute resources.
        :param pulumi.Input[builtins.str] aggregation: Aggregation type for the request values
        :param pulumi.Input[builtins.bool] confidential: Confidential data flag. Set `true` to treat the captured data as confidential
        :param pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]] data_sources: The list of data sources
        :param pulumi.Input[builtins.str] data_type: The data type of the request attribute
        :param pulumi.Input[builtins.bool] enabled: The request attribute is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] name: The name of the request attribute
        :param pulumi.Input[builtins.str] normalization: String values transformation.   If the **dataType** is not `string`, set the `Original` here
        :param pulumi.Input[builtins.bool] skip_personal_data_masking: Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        if aggregation is not None:
            pulumi.set(__self__, "aggregation", aggregation)
        if confidential is not None:
            pulumi.set(__self__, "confidential", confidential)
        if data_sources is not None:
            pulumi.set(__self__, "data_sources", data_sources)
        if data_type is not None:
            pulumi.set(__self__, "data_type", data_type)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if normalization is not None:
            pulumi.set(__self__, "normalization", normalization)
        if skip_personal_data_masking is not None:
            pulumi.set(__self__, "skip_personal_data_masking", skip_personal_data_masking)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def aggregation(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Aggregation type for the request values
        """
        return pulumi.get(self, "aggregation")

    @aggregation.setter
    def aggregation(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "aggregation", value)

    @property
    @pulumi.getter
    def confidential(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Confidential data flag. Set `true` to treat the captured data as confidential
        """
        return pulumi.get(self, "confidential")

    @confidential.setter
    def confidential(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "confidential", value)

    @property
    @pulumi.getter(name="dataSources")
    def data_sources(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]]:
        """
        The list of data sources
        """
        return pulumi.get(self, "data_sources")

    @data_sources.setter
    def data_sources(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RequestAttributeDataSourceArgs']]]]):
        pulumi.set(self, "data_sources", value)

    @property
    @pulumi.getter(name="dataType")
    def data_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The data type of the request attribute
        """
        return pulumi.get(self, "data_type")

    @data_type.setter
    def data_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "data_type", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        The request attribute is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The name of the request attribute
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def normalization(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        String values transformation.   If the **dataType** is not `string`, set the `Original` here
        """
        return pulumi.get(self, "normalization")

    @normalization.setter
    def normalization(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "normalization", value)

    @property
    @pulumi.getter(name="skipPersonalDataMasking")
    def skip_personal_data_masking(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        """
        return pulumi.get(self, "skip_personal_data_masking")

    @skip_personal_data_masking.setter
    def skip_personal_data_masking(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "skip_personal_data_masking", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "unknowns", value)


@pulumi.type_token("dynatrace:index/requestAttribute:RequestAttribute")
class RequestAttribute(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aggregation: Optional[pulumi.Input[builtins.str]] = None,
                 confidential: Optional[pulumi.Input[builtins.bool]] = None,
                 data_sources: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RequestAttributeDataSourceArgs', 'RequestAttributeDataSourceArgsDict']]]]] = None,
                 data_type: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 normalization: Optional[pulumi.Input[builtins.str]] = None,
                 skip_personal_data_masking: Optional[pulumi.Input[builtins.bool]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a RequestAttribute resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] aggregation: Aggregation type for the request values
        :param pulumi.Input[builtins.bool] confidential: Confidential data flag. Set `true` to treat the captured data as confidential
        :param pulumi.Input[Sequence[pulumi.Input[Union['RequestAttributeDataSourceArgs', 'RequestAttributeDataSourceArgsDict']]]] data_sources: The list of data sources
        :param pulumi.Input[builtins.str] data_type: The data type of the request attribute
        :param pulumi.Input[builtins.bool] enabled: The request attribute is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] name: The name of the request attribute
        :param pulumi.Input[builtins.str] normalization: String values transformation.   If the **dataType** is not `string`, set the `Original` here
        :param pulumi.Input[builtins.bool] skip_personal_data_masking: Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RequestAttributeArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a RequestAttribute resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param RequestAttributeArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RequestAttributeArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aggregation: Optional[pulumi.Input[builtins.str]] = None,
                 confidential: Optional[pulumi.Input[builtins.bool]] = None,
                 data_sources: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RequestAttributeDataSourceArgs', 'RequestAttributeDataSourceArgsDict']]]]] = None,
                 data_type: Optional[pulumi.Input[builtins.str]] = None,
                 enabled: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 normalization: Optional[pulumi.Input[builtins.str]] = None,
                 skip_personal_data_masking: Optional[pulumi.Input[builtins.bool]] = None,
                 unknowns: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RequestAttributeArgs.__new__(RequestAttributeArgs)

            if aggregation is None and not opts.urn:
                raise TypeError("Missing required property 'aggregation'")
            __props__.__dict__["aggregation"] = aggregation
            __props__.__dict__["confidential"] = confidential
            __props__.__dict__["data_sources"] = data_sources
            if data_type is None and not opts.urn:
                raise TypeError("Missing required property 'data_type'")
            __props__.__dict__["data_type"] = data_type
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["name"] = name
            if normalization is None and not opts.urn:
                raise TypeError("Missing required property 'normalization'")
            __props__.__dict__["normalization"] = normalization
            __props__.__dict__["skip_personal_data_masking"] = skip_personal_data_masking
            __props__.__dict__["unknowns"] = unknowns
        super(RequestAttribute, __self__).__init__(
            'dynatrace:index/requestAttribute:RequestAttribute',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            aggregation: Optional[pulumi.Input[builtins.str]] = None,
            confidential: Optional[pulumi.Input[builtins.bool]] = None,
            data_sources: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RequestAttributeDataSourceArgs', 'RequestAttributeDataSourceArgsDict']]]]] = None,
            data_type: Optional[pulumi.Input[builtins.str]] = None,
            enabled: Optional[pulumi.Input[builtins.bool]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            normalization: Optional[pulumi.Input[builtins.str]] = None,
            skip_personal_data_masking: Optional[pulumi.Input[builtins.bool]] = None,
            unknowns: Optional[pulumi.Input[builtins.str]] = None) -> 'RequestAttribute':
        """
        Get an existing RequestAttribute resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] aggregation: Aggregation type for the request values
        :param pulumi.Input[builtins.bool] confidential: Confidential data flag. Set `true` to treat the captured data as confidential
        :param pulumi.Input[Sequence[pulumi.Input[Union['RequestAttributeDataSourceArgs', 'RequestAttributeDataSourceArgsDict']]]] data_sources: The list of data sources
        :param pulumi.Input[builtins.str] data_type: The data type of the request attribute
        :param pulumi.Input[builtins.bool] enabled: The request attribute is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[builtins.str] name: The name of the request attribute
        :param pulumi.Input[builtins.str] normalization: String values transformation.   If the **dataType** is not `string`, set the `Original` here
        :param pulumi.Input[builtins.bool] skip_personal_data_masking: Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        :param pulumi.Input[builtins.str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RequestAttributeState.__new__(_RequestAttributeState)

        __props__.__dict__["aggregation"] = aggregation
        __props__.__dict__["confidential"] = confidential
        __props__.__dict__["data_sources"] = data_sources
        __props__.__dict__["data_type"] = data_type
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["name"] = name
        __props__.__dict__["normalization"] = normalization
        __props__.__dict__["skip_personal_data_masking"] = skip_personal_data_masking
        __props__.__dict__["unknowns"] = unknowns
        return RequestAttribute(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def aggregation(self) -> pulumi.Output[builtins.str]:
        """
        Aggregation type for the request values
        """
        return pulumi.get(self, "aggregation")

    @property
    @pulumi.getter
    def confidential(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        Confidential data flag. Set `true` to treat the captured data as confidential
        """
        return pulumi.get(self, "confidential")

    @property
    @pulumi.getter(name="dataSources")
    def data_sources(self) -> pulumi.Output[Optional[Sequence['outputs.RequestAttributeDataSource']]]:
        """
        The list of data sources
        """
        return pulumi.get(self, "data_sources")

    @property
    @pulumi.getter(name="dataType")
    def data_type(self) -> pulumi.Output[builtins.str]:
        """
        The data type of the request attribute
        """
        return pulumi.get(self, "data_type")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        The request attribute is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        The name of the request attribute
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def normalization(self) -> pulumi.Output[builtins.str]:
        """
        String values transformation.   If the **dataType** is not `string`, set the `Original` here
        """
        return pulumi.get(self, "normalization")

    @property
    @pulumi.getter(name="skipPersonalDataMasking")
    def skip_personal_data_masking(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        Personal data masking flag. Set `true` to skip masking.   Warning: This will potentially access personalized data
        """
        return pulumi.get(self, "skip_personal_data_masking")

    @property
    @pulumi.getter
    def unknowns(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

