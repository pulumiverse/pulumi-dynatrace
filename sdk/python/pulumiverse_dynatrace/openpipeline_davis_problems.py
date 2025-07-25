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

__all__ = ['OpenpipelineDavisProblemsArgs', 'OpenpipelineDavisProblems']

@pulumi.input_type
class OpenpipelineDavisProblemsArgs:
    def __init__(__self__, *,
                 endpoints: Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']] = None,
                 pipelines: Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']] = None,
                 routing: Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']] = None):
        """
        The set of arguments for constructing a OpenpipelineDavisProblems resource.
        :param pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs'] endpoints: List of all ingest sources of the configuration
        :param pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs'] pipelines: List of all pipelines of the configuration
        :param pulumi.Input['OpenpipelineDavisProblemsRoutingArgs'] routing: Dynamic routing definition
        """
        if endpoints is not None:
            pulumi.set(__self__, "endpoints", endpoints)
        if pipelines is not None:
            pulumi.set(__self__, "pipelines", pipelines)
        if routing is not None:
            pulumi.set(__self__, "routing", routing)

    @property
    @pulumi.getter
    def endpoints(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']]:
        """
        List of all ingest sources of the configuration
        """
        return pulumi.get(self, "endpoints")

    @endpoints.setter
    def endpoints(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']]):
        pulumi.set(self, "endpoints", value)

    @property
    @pulumi.getter
    def pipelines(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']]:
        """
        List of all pipelines of the configuration
        """
        return pulumi.get(self, "pipelines")

    @pipelines.setter
    def pipelines(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']]):
        pulumi.set(self, "pipelines", value)

    @property
    @pulumi.getter
    def routing(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']]:
        """
        Dynamic routing definition
        """
        return pulumi.get(self, "routing")

    @routing.setter
    def routing(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']]):
        pulumi.set(self, "routing", value)


@pulumi.input_type
class _OpenpipelineDavisProblemsState:
    def __init__(__self__, *,
                 endpoints: Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']] = None,
                 pipelines: Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']] = None,
                 routing: Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']] = None):
        """
        Input properties used for looking up and filtering OpenpipelineDavisProblems resources.
        :param pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs'] endpoints: List of all ingest sources of the configuration
        :param pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs'] pipelines: List of all pipelines of the configuration
        :param pulumi.Input['OpenpipelineDavisProblemsRoutingArgs'] routing: Dynamic routing definition
        """
        if endpoints is not None:
            pulumi.set(__self__, "endpoints", endpoints)
        if pipelines is not None:
            pulumi.set(__self__, "pipelines", pipelines)
        if routing is not None:
            pulumi.set(__self__, "routing", routing)

    @property
    @pulumi.getter
    def endpoints(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']]:
        """
        List of all ingest sources of the configuration
        """
        return pulumi.get(self, "endpoints")

    @endpoints.setter
    def endpoints(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsEndpointsArgs']]):
        pulumi.set(self, "endpoints", value)

    @property
    @pulumi.getter
    def pipelines(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']]:
        """
        List of all pipelines of the configuration
        """
        return pulumi.get(self, "pipelines")

    @pipelines.setter
    def pipelines(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsPipelinesArgs']]):
        pulumi.set(self, "pipelines", value)

    @property
    @pulumi.getter
    def routing(self) -> Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']]:
        """
        Dynamic routing definition
        """
        return pulumi.get(self, "routing")

    @routing.setter
    def routing(self, value: Optional[pulumi.Input['OpenpipelineDavisProblemsRoutingArgs']]):
        pulumi.set(self, "routing", value)


@pulumi.type_token("dynatrace:index/openpipelineDavisProblems:OpenpipelineDavisProblems")
class OpenpipelineDavisProblems(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 endpoints: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsEndpointsArgs', 'OpenpipelineDavisProblemsEndpointsArgsDict']]] = None,
                 pipelines: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsPipelinesArgs', 'OpenpipelineDavisProblemsPipelinesArgsDict']]] = None,
                 routing: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsRoutingArgs', 'OpenpipelineDavisProblemsRoutingArgsDict']]] = None,
                 __props__=None):
        """
        Create a OpenpipelineDavisProblems resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['OpenpipelineDavisProblemsEndpointsArgs', 'OpenpipelineDavisProblemsEndpointsArgsDict']] endpoints: List of all ingest sources of the configuration
        :param pulumi.Input[Union['OpenpipelineDavisProblemsPipelinesArgs', 'OpenpipelineDavisProblemsPipelinesArgsDict']] pipelines: List of all pipelines of the configuration
        :param pulumi.Input[Union['OpenpipelineDavisProblemsRoutingArgs', 'OpenpipelineDavisProblemsRoutingArgsDict']] routing: Dynamic routing definition
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[OpenpipelineDavisProblemsArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a OpenpipelineDavisProblems resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param OpenpipelineDavisProblemsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OpenpipelineDavisProblemsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 endpoints: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsEndpointsArgs', 'OpenpipelineDavisProblemsEndpointsArgsDict']]] = None,
                 pipelines: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsPipelinesArgs', 'OpenpipelineDavisProblemsPipelinesArgsDict']]] = None,
                 routing: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsRoutingArgs', 'OpenpipelineDavisProblemsRoutingArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OpenpipelineDavisProblemsArgs.__new__(OpenpipelineDavisProblemsArgs)

            __props__.__dict__["endpoints"] = endpoints
            __props__.__dict__["pipelines"] = pipelines
            __props__.__dict__["routing"] = routing
        super(OpenpipelineDavisProblems, __self__).__init__(
            'dynatrace:index/openpipelineDavisProblems:OpenpipelineDavisProblems',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            endpoints: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsEndpointsArgs', 'OpenpipelineDavisProblemsEndpointsArgsDict']]] = None,
            pipelines: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsPipelinesArgs', 'OpenpipelineDavisProblemsPipelinesArgsDict']]] = None,
            routing: Optional[pulumi.Input[Union['OpenpipelineDavisProblemsRoutingArgs', 'OpenpipelineDavisProblemsRoutingArgsDict']]] = None) -> 'OpenpipelineDavisProblems':
        """
        Get an existing OpenpipelineDavisProblems resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['OpenpipelineDavisProblemsEndpointsArgs', 'OpenpipelineDavisProblemsEndpointsArgsDict']] endpoints: List of all ingest sources of the configuration
        :param pulumi.Input[Union['OpenpipelineDavisProblemsPipelinesArgs', 'OpenpipelineDavisProblemsPipelinesArgsDict']] pipelines: List of all pipelines of the configuration
        :param pulumi.Input[Union['OpenpipelineDavisProblemsRoutingArgs', 'OpenpipelineDavisProblemsRoutingArgsDict']] routing: Dynamic routing definition
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _OpenpipelineDavisProblemsState.__new__(_OpenpipelineDavisProblemsState)

        __props__.__dict__["endpoints"] = endpoints
        __props__.__dict__["pipelines"] = pipelines
        __props__.__dict__["routing"] = routing
        return OpenpipelineDavisProblems(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def endpoints(self) -> pulumi.Output[Optional['outputs.OpenpipelineDavisProblemsEndpoints']]:
        """
        List of all ingest sources of the configuration
        """
        return pulumi.get(self, "endpoints")

    @property
    @pulumi.getter
    def pipelines(self) -> pulumi.Output[Optional['outputs.OpenpipelineDavisProblemsPipelines']]:
        """
        List of all pipelines of the configuration
        """
        return pulumi.get(self, "pipelines")

    @property
    @pulumi.getter
    def routing(self) -> pulumi.Output[Optional['outputs.OpenpipelineDavisProblemsRouting']]:
        """
        Dynamic routing definition
        """
        return pulumi.get(self, "routing")

