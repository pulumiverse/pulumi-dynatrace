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

__all__ = ['ApplicationAnomaliesArgs', 'ApplicationAnomalies']

@pulumi.input_type
class ApplicationAnomaliesArgs:
    def __init__(__self__, *,
                 failure_rate: Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']] = None,
                 response_time: Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']] = None,
                 traffic: Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']] = None):
        """
        The set of arguments for constructing a ApplicationAnomalies resource.
        :param pulumi.Input['ApplicationAnomaliesFailureRateArgs'] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input['ApplicationAnomaliesResponseTimeArgs'] response_time: Configuration of response time degradation detection
        :param pulumi.Input['ApplicationAnomaliesTrafficArgs'] traffic: Configuration for anomalies regarding traffic
        """
        if failure_rate is not None:
            pulumi.set(__self__, "failure_rate", failure_rate)
        if response_time is not None:
            pulumi.set(__self__, "response_time", response_time)
        if traffic is not None:
            pulumi.set(__self__, "traffic", traffic)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def traffic(self) -> Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']]:
        """
        Configuration for anomalies regarding traffic
        """
        return pulumi.get(self, "traffic")

    @traffic.setter
    def traffic(self, value: Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']]):
        pulumi.set(self, "traffic", value)


@pulumi.input_type
class _ApplicationAnomaliesState:
    def __init__(__self__, *,
                 failure_rate: Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']] = None,
                 response_time: Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']] = None,
                 traffic: Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']] = None):
        """
        Input properties used for looking up and filtering ApplicationAnomalies resources.
        :param pulumi.Input['ApplicationAnomaliesFailureRateArgs'] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input['ApplicationAnomaliesResponseTimeArgs'] response_time: Configuration of response time degradation detection
        :param pulumi.Input['ApplicationAnomaliesTrafficArgs'] traffic: Configuration for anomalies regarding traffic
        """
        if failure_rate is not None:
            pulumi.set(__self__, "failure_rate", failure_rate)
        if response_time is not None:
            pulumi.set(__self__, "response_time", response_time)
        if traffic is not None:
            pulumi.set(__self__, "traffic", traffic)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['ApplicationAnomaliesFailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['ApplicationAnomaliesResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def traffic(self) -> Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']]:
        """
        Configuration for anomalies regarding traffic
        """
        return pulumi.get(self, "traffic")

    @traffic.setter
    def traffic(self, value: Optional[pulumi.Input['ApplicationAnomaliesTrafficArgs']]):
        pulumi.set(self, "traffic", value)


@pulumi.type_token("dynatrace:index/applicationAnomalies:ApplicationAnomalies")
class ApplicationAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rate: Optional[pulumi.Input[Union['ApplicationAnomaliesFailureRateArgs', 'ApplicationAnomaliesFailureRateArgsDict']]] = None,
                 response_time: Optional[pulumi.Input[Union['ApplicationAnomaliesResponseTimeArgs', 'ApplicationAnomaliesResponseTimeArgsDict']]] = None,
                 traffic: Optional[pulumi.Input[Union['ApplicationAnomaliesTrafficArgs', 'ApplicationAnomaliesTrafficArgsDict']]] = None,
                 __props__=None):
        """
        Create a ApplicationAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['ApplicationAnomaliesFailureRateArgs', 'ApplicationAnomaliesFailureRateArgsDict']] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input[Union['ApplicationAnomaliesResponseTimeArgs', 'ApplicationAnomaliesResponseTimeArgsDict']] response_time: Configuration of response time degradation detection
        :param pulumi.Input[Union['ApplicationAnomaliesTrafficArgs', 'ApplicationAnomaliesTrafficArgsDict']] traffic: Configuration for anomalies regarding traffic
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ApplicationAnomaliesArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ApplicationAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ApplicationAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApplicationAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rate: Optional[pulumi.Input[Union['ApplicationAnomaliesFailureRateArgs', 'ApplicationAnomaliesFailureRateArgsDict']]] = None,
                 response_time: Optional[pulumi.Input[Union['ApplicationAnomaliesResponseTimeArgs', 'ApplicationAnomaliesResponseTimeArgsDict']]] = None,
                 traffic: Optional[pulumi.Input[Union['ApplicationAnomaliesTrafficArgs', 'ApplicationAnomaliesTrafficArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApplicationAnomaliesArgs.__new__(ApplicationAnomaliesArgs)

            __props__.__dict__["failure_rate"] = failure_rate
            __props__.__dict__["response_time"] = response_time
            __props__.__dict__["traffic"] = traffic
        super(ApplicationAnomalies, __self__).__init__(
            'dynatrace:index/applicationAnomalies:ApplicationAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            failure_rate: Optional[pulumi.Input[Union['ApplicationAnomaliesFailureRateArgs', 'ApplicationAnomaliesFailureRateArgsDict']]] = None,
            response_time: Optional[pulumi.Input[Union['ApplicationAnomaliesResponseTimeArgs', 'ApplicationAnomaliesResponseTimeArgsDict']]] = None,
            traffic: Optional[pulumi.Input[Union['ApplicationAnomaliesTrafficArgs', 'ApplicationAnomaliesTrafficArgsDict']]] = None) -> 'ApplicationAnomalies':
        """
        Get an existing ApplicationAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['ApplicationAnomaliesFailureRateArgs', 'ApplicationAnomaliesFailureRateArgsDict']] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input[Union['ApplicationAnomaliesResponseTimeArgs', 'ApplicationAnomaliesResponseTimeArgsDict']] response_time: Configuration of response time degradation detection
        :param pulumi.Input[Union['ApplicationAnomaliesTrafficArgs', 'ApplicationAnomaliesTrafficArgsDict']] traffic: Configuration for anomalies regarding traffic
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApplicationAnomaliesState.__new__(_ApplicationAnomaliesState)

        __props__.__dict__["failure_rate"] = failure_rate
        __props__.__dict__["response_time"] = response_time
        __props__.__dict__["traffic"] = traffic
        return ApplicationAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Output[Optional['outputs.ApplicationAnomaliesFailureRate']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Output[Optional['outputs.ApplicationAnomaliesResponseTime']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")

    @property
    @pulumi.getter
    def traffic(self) -> pulumi.Output[Optional['outputs.ApplicationAnomaliesTraffic']]:
        """
        Configuration for anomalies regarding traffic
        """
        return pulumi.get(self, "traffic")

