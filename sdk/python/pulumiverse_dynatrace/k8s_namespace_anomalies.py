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
from ._inputs import *

__all__ = ['K8sNamespaceAnomaliesArgs', 'K8sNamespaceAnomalies']

@pulumi.input_type
class K8sNamespaceAnomaliesArgs:
    def __init__(__self__, *,
                 cpu_limits_quota_saturation: pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs'],
                 cpu_requests_quota_saturation: pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs'],
                 memory_limits_quota_saturation: pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs'],
                 memory_requests_quota_saturation: pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs'],
                 pods_quota_saturation: pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs'],
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a K8sNamespaceAnomalies resource.
        :param pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs'] cpu_limits_quota_saturation: Alerts if almost no CPU-limit quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs'] cpu_requests_quota_saturation: Alerts if almost no CPU-request quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs'] memory_limits_quota_saturation: Alerts if almost no memory-limit quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs'] memory_requests_quota_saturation: Alerts if almost no memory-request quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs'] pods_quota_saturation: Alerts if almost no pod quota left in namespace
        :param pulumi.Input[str] scope: The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "cpu_limits_quota_saturation", cpu_limits_quota_saturation)
        pulumi.set(__self__, "cpu_requests_quota_saturation", cpu_requests_quota_saturation)
        pulumi.set(__self__, "memory_limits_quota_saturation", memory_limits_quota_saturation)
        pulumi.set(__self__, "memory_requests_quota_saturation", memory_requests_quota_saturation)
        pulumi.set(__self__, "pods_quota_saturation", pods_quota_saturation)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="cpuLimitsQuotaSaturation")
    def cpu_limits_quota_saturation(self) -> pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']:
        """
        Alerts if almost no CPU-limit quota left in namespace
        """
        return pulumi.get(self, "cpu_limits_quota_saturation")

    @cpu_limits_quota_saturation.setter
    def cpu_limits_quota_saturation(self, value: pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']):
        pulumi.set(self, "cpu_limits_quota_saturation", value)

    @property
    @pulumi.getter(name="cpuRequestsQuotaSaturation")
    def cpu_requests_quota_saturation(self) -> pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']:
        """
        Alerts if almost no CPU-request quota left in namespace
        """
        return pulumi.get(self, "cpu_requests_quota_saturation")

    @cpu_requests_quota_saturation.setter
    def cpu_requests_quota_saturation(self, value: pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']):
        pulumi.set(self, "cpu_requests_quota_saturation", value)

    @property
    @pulumi.getter(name="memoryLimitsQuotaSaturation")
    def memory_limits_quota_saturation(self) -> pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']:
        """
        Alerts if almost no memory-limit quota left in namespace
        """
        return pulumi.get(self, "memory_limits_quota_saturation")

    @memory_limits_quota_saturation.setter
    def memory_limits_quota_saturation(self, value: pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']):
        pulumi.set(self, "memory_limits_quota_saturation", value)

    @property
    @pulumi.getter(name="memoryRequestsQuotaSaturation")
    def memory_requests_quota_saturation(self) -> pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']:
        """
        Alerts if almost no memory-request quota left in namespace
        """
        return pulumi.get(self, "memory_requests_quota_saturation")

    @memory_requests_quota_saturation.setter
    def memory_requests_quota_saturation(self, value: pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']):
        pulumi.set(self, "memory_requests_quota_saturation", value)

    @property
    @pulumi.getter(name="podsQuotaSaturation")
    def pods_quota_saturation(self) -> pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']:
        """
        Alerts if almost no pod quota left in namespace
        """
        return pulumi.get(self, "pods_quota_saturation")

    @pods_quota_saturation.setter
    def pods_quota_saturation(self, value: pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']):
        pulumi.set(self, "pods_quota_saturation", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _K8sNamespaceAnomaliesState:
    def __init__(__self__, *,
                 cpu_limits_quota_saturation: Optional[pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']] = None,
                 cpu_requests_quota_saturation: Optional[pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']] = None,
                 memory_limits_quota_saturation: Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']] = None,
                 memory_requests_quota_saturation: Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']] = None,
                 pods_quota_saturation: Optional[pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering K8sNamespaceAnomalies resources.
        :param pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs'] cpu_limits_quota_saturation: Alerts if almost no CPU-limit quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs'] cpu_requests_quota_saturation: Alerts if almost no CPU-request quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs'] memory_limits_quota_saturation: Alerts if almost no memory-limit quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs'] memory_requests_quota_saturation: Alerts if almost no memory-request quota left in namespace
        :param pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs'] pods_quota_saturation: Alerts if almost no pod quota left in namespace
        :param pulumi.Input[str] scope: The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        if cpu_limits_quota_saturation is not None:
            pulumi.set(__self__, "cpu_limits_quota_saturation", cpu_limits_quota_saturation)
        if cpu_requests_quota_saturation is not None:
            pulumi.set(__self__, "cpu_requests_quota_saturation", cpu_requests_quota_saturation)
        if memory_limits_quota_saturation is not None:
            pulumi.set(__self__, "memory_limits_quota_saturation", memory_limits_quota_saturation)
        if memory_requests_quota_saturation is not None:
            pulumi.set(__self__, "memory_requests_quota_saturation", memory_requests_quota_saturation)
        if pods_quota_saturation is not None:
            pulumi.set(__self__, "pods_quota_saturation", pods_quota_saturation)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="cpuLimitsQuotaSaturation")
    def cpu_limits_quota_saturation(self) -> Optional[pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']]:
        """
        Alerts if almost no CPU-limit quota left in namespace
        """
        return pulumi.get(self, "cpu_limits_quota_saturation")

    @cpu_limits_quota_saturation.setter
    def cpu_limits_quota_saturation(self, value: Optional[pulumi.Input['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']]):
        pulumi.set(self, "cpu_limits_quota_saturation", value)

    @property
    @pulumi.getter(name="cpuRequestsQuotaSaturation")
    def cpu_requests_quota_saturation(self) -> Optional[pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']]:
        """
        Alerts if almost no CPU-request quota left in namespace
        """
        return pulumi.get(self, "cpu_requests_quota_saturation")

    @cpu_requests_quota_saturation.setter
    def cpu_requests_quota_saturation(self, value: Optional[pulumi.Input['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']]):
        pulumi.set(self, "cpu_requests_quota_saturation", value)

    @property
    @pulumi.getter(name="memoryLimitsQuotaSaturation")
    def memory_limits_quota_saturation(self) -> Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']]:
        """
        Alerts if almost no memory-limit quota left in namespace
        """
        return pulumi.get(self, "memory_limits_quota_saturation")

    @memory_limits_quota_saturation.setter
    def memory_limits_quota_saturation(self, value: Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']]):
        pulumi.set(self, "memory_limits_quota_saturation", value)

    @property
    @pulumi.getter(name="memoryRequestsQuotaSaturation")
    def memory_requests_quota_saturation(self) -> Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']]:
        """
        Alerts if almost no memory-request quota left in namespace
        """
        return pulumi.get(self, "memory_requests_quota_saturation")

    @memory_requests_quota_saturation.setter
    def memory_requests_quota_saturation(self, value: Optional[pulumi.Input['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']]):
        pulumi.set(self, "memory_requests_quota_saturation", value)

    @property
    @pulumi.getter(name="podsQuotaSaturation")
    def pods_quota_saturation(self) -> Optional[pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']]:
        """
        Alerts if almost no pod quota left in namespace
        """
        return pulumi.get(self, "pods_quota_saturation")

    @pods_quota_saturation.setter
    def pods_quota_saturation(self, value: Optional[pulumi.Input['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']]):
        pulumi.set(self, "pods_quota_saturation", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


class K8sNamespaceAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cpu_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']]] = None,
                 cpu_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']]] = None,
                 memory_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']]] = None,
                 memory_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']]] = None,
                 pods_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a K8sNamespaceAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']] cpu_limits_quota_saturation: Alerts if almost no CPU-limit quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']] cpu_requests_quota_saturation: Alerts if almost no CPU-request quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']] memory_limits_quota_saturation: Alerts if almost no memory-limit quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']] memory_requests_quota_saturation: Alerts if almost no memory-request quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']] pods_quota_saturation: Alerts if almost no pod quota left in namespace
        :param pulumi.Input[str] scope: The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: K8sNamespaceAnomaliesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a K8sNamespaceAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param K8sNamespaceAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(K8sNamespaceAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cpu_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']]] = None,
                 cpu_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']]] = None,
                 memory_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']]] = None,
                 memory_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']]] = None,
                 pods_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = K8sNamespaceAnomaliesArgs.__new__(K8sNamespaceAnomaliesArgs)

            if cpu_limits_quota_saturation is None and not opts.urn:
                raise TypeError("Missing required property 'cpu_limits_quota_saturation'")
            __props__.__dict__["cpu_limits_quota_saturation"] = cpu_limits_quota_saturation
            if cpu_requests_quota_saturation is None and not opts.urn:
                raise TypeError("Missing required property 'cpu_requests_quota_saturation'")
            __props__.__dict__["cpu_requests_quota_saturation"] = cpu_requests_quota_saturation
            if memory_limits_quota_saturation is None and not opts.urn:
                raise TypeError("Missing required property 'memory_limits_quota_saturation'")
            __props__.__dict__["memory_limits_quota_saturation"] = memory_limits_quota_saturation
            if memory_requests_quota_saturation is None and not opts.urn:
                raise TypeError("Missing required property 'memory_requests_quota_saturation'")
            __props__.__dict__["memory_requests_quota_saturation"] = memory_requests_quota_saturation
            if pods_quota_saturation is None and not opts.urn:
                raise TypeError("Missing required property 'pods_quota_saturation'")
            __props__.__dict__["pods_quota_saturation"] = pods_quota_saturation
            __props__.__dict__["scope"] = scope
        super(K8sNamespaceAnomalies, __self__).__init__(
            'dynatrace:index/k8sNamespaceAnomalies:K8sNamespaceAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cpu_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']]] = None,
            cpu_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']]] = None,
            memory_limits_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']]] = None,
            memory_requests_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']]] = None,
            pods_quota_saturation: Optional[pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']]] = None,
            scope: Optional[pulumi.Input[str]] = None) -> 'K8sNamespaceAnomalies':
        """
        Get an existing K8sNamespaceAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuLimitsQuotaSaturationArgs']] cpu_limits_quota_saturation: Alerts if almost no CPU-limit quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesCpuRequestsQuotaSaturationArgs']] cpu_requests_quota_saturation: Alerts if almost no CPU-request quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationArgs']] memory_limits_quota_saturation: Alerts if almost no memory-limit quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesMemoryRequestsQuotaSaturationArgs']] memory_requests_quota_saturation: Alerts if almost no memory-request quota left in namespace
        :param pulumi.Input[pulumi.InputType['K8sNamespaceAnomaliesPodsQuotaSaturationArgs']] pods_quota_saturation: Alerts if almost no pod quota left in namespace
        :param pulumi.Input[str] scope: The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _K8sNamespaceAnomaliesState.__new__(_K8sNamespaceAnomaliesState)

        __props__.__dict__["cpu_limits_quota_saturation"] = cpu_limits_quota_saturation
        __props__.__dict__["cpu_requests_quota_saturation"] = cpu_requests_quota_saturation
        __props__.__dict__["memory_limits_quota_saturation"] = memory_limits_quota_saturation
        __props__.__dict__["memory_requests_quota_saturation"] = memory_requests_quota_saturation
        __props__.__dict__["pods_quota_saturation"] = pods_quota_saturation
        __props__.__dict__["scope"] = scope
        return K8sNamespaceAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cpuLimitsQuotaSaturation")
    def cpu_limits_quota_saturation(self) -> pulumi.Output['outputs.K8sNamespaceAnomaliesCpuLimitsQuotaSaturation']:
        """
        Alerts if almost no CPU-limit quota left in namespace
        """
        return pulumi.get(self, "cpu_limits_quota_saturation")

    @property
    @pulumi.getter(name="cpuRequestsQuotaSaturation")
    def cpu_requests_quota_saturation(self) -> pulumi.Output['outputs.K8sNamespaceAnomaliesCpuRequestsQuotaSaturation']:
        """
        Alerts if almost no CPU-request quota left in namespace
        """
        return pulumi.get(self, "cpu_requests_quota_saturation")

    @property
    @pulumi.getter(name="memoryLimitsQuotaSaturation")
    def memory_limits_quota_saturation(self) -> pulumi.Output['outputs.K8sNamespaceAnomaliesMemoryLimitsQuotaSaturation']:
        """
        Alerts if almost no memory-limit quota left in namespace
        """
        return pulumi.get(self, "memory_limits_quota_saturation")

    @property
    @pulumi.getter(name="memoryRequestsQuotaSaturation")
    def memory_requests_quota_saturation(self) -> pulumi.Output['outputs.K8sNamespaceAnomaliesMemoryRequestsQuotaSaturation']:
        """
        Alerts if almost no memory-request quota left in namespace
        """
        return pulumi.get(self, "memory_requests_quota_saturation")

    @property
    @pulumi.getter(name="podsQuotaSaturation")
    def pods_quota_saturation(self) -> pulumi.Output['outputs.K8sNamespaceAnomaliesPodsQuotaSaturation']:
        """
        Alerts if almost no pod quota left in namespace
        """
        return pulumi.get(self, "pods_quota_saturation")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this setting (CLOUD*APPLICATION*NAMESPACE, KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")
