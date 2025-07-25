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

__all__ = ['VmwareAnomaliesArgs', 'VmwareAnomalies']

@pulumi.input_type
class VmwareAnomaliesArgs:
    def __init__(__self__, *,
                 dropped_packets_detection: pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs'],
                 esxi_high_cpu_detection: pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs'],
                 esxi_high_memory_detection: pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs'],
                 guest_cpu_limit_detection: pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs'],
                 low_datastore_space_detection: pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs'],
                 overloaded_storage_detection: pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs'],
                 slow_physical_storage_detection: pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs'],
                 undersized_storage_detection: pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']):
        """
        The set of arguments for constructing a VmwareAnomalies resource.
        :param pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs'] dropped_packets_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs'] esxi_high_cpu_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs'] esxi_high_memory_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs'] guest_cpu_limit_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs'] low_datastore_space_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs'] overloaded_storage_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs'] slow_physical_storage_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs'] undersized_storage_detection: no documentation available
        """
        pulumi.set(__self__, "dropped_packets_detection", dropped_packets_detection)
        pulumi.set(__self__, "esxi_high_cpu_detection", esxi_high_cpu_detection)
        pulumi.set(__self__, "esxi_high_memory_detection", esxi_high_memory_detection)
        pulumi.set(__self__, "guest_cpu_limit_detection", guest_cpu_limit_detection)
        pulumi.set(__self__, "low_datastore_space_detection", low_datastore_space_detection)
        pulumi.set(__self__, "overloaded_storage_detection", overloaded_storage_detection)
        pulumi.set(__self__, "slow_physical_storage_detection", slow_physical_storage_detection)
        pulumi.set(__self__, "undersized_storage_detection", undersized_storage_detection)

    @property
    @pulumi.getter(name="droppedPacketsDetection")
    def dropped_packets_detection(self) -> pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "dropped_packets_detection")

    @dropped_packets_detection.setter
    def dropped_packets_detection(self, value: pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs']):
        pulumi.set(self, "dropped_packets_detection", value)

    @property
    @pulumi.getter(name="esxiHighCpuDetection")
    def esxi_high_cpu_detection(self) -> pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_cpu_detection")

    @esxi_high_cpu_detection.setter
    def esxi_high_cpu_detection(self, value: pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs']):
        pulumi.set(self, "esxi_high_cpu_detection", value)

    @property
    @pulumi.getter(name="esxiHighMemoryDetection")
    def esxi_high_memory_detection(self) -> pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_memory_detection")

    @esxi_high_memory_detection.setter
    def esxi_high_memory_detection(self, value: pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs']):
        pulumi.set(self, "esxi_high_memory_detection", value)

    @property
    @pulumi.getter(name="guestCpuLimitDetection")
    def guest_cpu_limit_detection(self) -> pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "guest_cpu_limit_detection")

    @guest_cpu_limit_detection.setter
    def guest_cpu_limit_detection(self, value: pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs']):
        pulumi.set(self, "guest_cpu_limit_detection", value)

    @property
    @pulumi.getter(name="lowDatastoreSpaceDetection")
    def low_datastore_space_detection(self) -> pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "low_datastore_space_detection")

    @low_datastore_space_detection.setter
    def low_datastore_space_detection(self, value: pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs']):
        pulumi.set(self, "low_datastore_space_detection", value)

    @property
    @pulumi.getter(name="overloadedStorageDetection")
    def overloaded_storage_detection(self) -> pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "overloaded_storage_detection")

    @overloaded_storage_detection.setter
    def overloaded_storage_detection(self, value: pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs']):
        pulumi.set(self, "overloaded_storage_detection", value)

    @property
    @pulumi.getter(name="slowPhysicalStorageDetection")
    def slow_physical_storage_detection(self) -> pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "slow_physical_storage_detection")

    @slow_physical_storage_detection.setter
    def slow_physical_storage_detection(self, value: pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs']):
        pulumi.set(self, "slow_physical_storage_detection", value)

    @property
    @pulumi.getter(name="undersizedStorageDetection")
    def undersized_storage_detection(self) -> pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "undersized_storage_detection")

    @undersized_storage_detection.setter
    def undersized_storage_detection(self, value: pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']):
        pulumi.set(self, "undersized_storage_detection", value)


@pulumi.input_type
class _VmwareAnomaliesState:
    def __init__(__self__, *,
                 dropped_packets_detection: Optional[pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs']] = None,
                 esxi_high_cpu_detection: Optional[pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs']] = None,
                 esxi_high_memory_detection: Optional[pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs']] = None,
                 guest_cpu_limit_detection: Optional[pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs']] = None,
                 low_datastore_space_detection: Optional[pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs']] = None,
                 overloaded_storage_detection: Optional[pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs']] = None,
                 slow_physical_storage_detection: Optional[pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs']] = None,
                 undersized_storage_detection: Optional[pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']] = None):
        """
        Input properties used for looking up and filtering VmwareAnomalies resources.
        :param pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs'] dropped_packets_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs'] esxi_high_cpu_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs'] esxi_high_memory_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs'] guest_cpu_limit_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs'] low_datastore_space_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs'] overloaded_storage_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs'] slow_physical_storage_detection: no documentation available
        :param pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs'] undersized_storage_detection: no documentation available
        """
        if dropped_packets_detection is not None:
            pulumi.set(__self__, "dropped_packets_detection", dropped_packets_detection)
        if esxi_high_cpu_detection is not None:
            pulumi.set(__self__, "esxi_high_cpu_detection", esxi_high_cpu_detection)
        if esxi_high_memory_detection is not None:
            pulumi.set(__self__, "esxi_high_memory_detection", esxi_high_memory_detection)
        if guest_cpu_limit_detection is not None:
            pulumi.set(__self__, "guest_cpu_limit_detection", guest_cpu_limit_detection)
        if low_datastore_space_detection is not None:
            pulumi.set(__self__, "low_datastore_space_detection", low_datastore_space_detection)
        if overloaded_storage_detection is not None:
            pulumi.set(__self__, "overloaded_storage_detection", overloaded_storage_detection)
        if slow_physical_storage_detection is not None:
            pulumi.set(__self__, "slow_physical_storage_detection", slow_physical_storage_detection)
        if undersized_storage_detection is not None:
            pulumi.set(__self__, "undersized_storage_detection", undersized_storage_detection)

    @property
    @pulumi.getter(name="droppedPacketsDetection")
    def dropped_packets_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "dropped_packets_detection")

    @dropped_packets_detection.setter
    def dropped_packets_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesDroppedPacketsDetectionArgs']]):
        pulumi.set(self, "dropped_packets_detection", value)

    @property
    @pulumi.getter(name="esxiHighCpuDetection")
    def esxi_high_cpu_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_cpu_detection")

    @esxi_high_cpu_detection.setter
    def esxi_high_cpu_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesEsxiHighCpuDetectionArgs']]):
        pulumi.set(self, "esxi_high_cpu_detection", value)

    @property
    @pulumi.getter(name="esxiHighMemoryDetection")
    def esxi_high_memory_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_memory_detection")

    @esxi_high_memory_detection.setter
    def esxi_high_memory_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesEsxiHighMemoryDetectionArgs']]):
        pulumi.set(self, "esxi_high_memory_detection", value)

    @property
    @pulumi.getter(name="guestCpuLimitDetection")
    def guest_cpu_limit_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "guest_cpu_limit_detection")

    @guest_cpu_limit_detection.setter
    def guest_cpu_limit_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesGuestCpuLimitDetectionArgs']]):
        pulumi.set(self, "guest_cpu_limit_detection", value)

    @property
    @pulumi.getter(name="lowDatastoreSpaceDetection")
    def low_datastore_space_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "low_datastore_space_detection")

    @low_datastore_space_detection.setter
    def low_datastore_space_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesLowDatastoreSpaceDetectionArgs']]):
        pulumi.set(self, "low_datastore_space_detection", value)

    @property
    @pulumi.getter(name="overloadedStorageDetection")
    def overloaded_storage_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "overloaded_storage_detection")

    @overloaded_storage_detection.setter
    def overloaded_storage_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesOverloadedStorageDetectionArgs']]):
        pulumi.set(self, "overloaded_storage_detection", value)

    @property
    @pulumi.getter(name="slowPhysicalStorageDetection")
    def slow_physical_storage_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "slow_physical_storage_detection")

    @slow_physical_storage_detection.setter
    def slow_physical_storage_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesSlowPhysicalStorageDetectionArgs']]):
        pulumi.set(self, "slow_physical_storage_detection", value)

    @property
    @pulumi.getter(name="undersizedStorageDetection")
    def undersized_storage_detection(self) -> Optional[pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "undersized_storage_detection")

    @undersized_storage_detection.setter
    def undersized_storage_detection(self, value: Optional[pulumi.Input['VmwareAnomaliesUndersizedStorageDetectionArgs']]):
        pulumi.set(self, "undersized_storage_detection", value)


@pulumi.type_token("dynatrace:index/vmwareAnomalies:VmwareAnomalies")
class VmwareAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dropped_packets_detection: Optional[pulumi.Input[Union['VmwareAnomaliesDroppedPacketsDetectionArgs', 'VmwareAnomaliesDroppedPacketsDetectionArgsDict']]] = None,
                 esxi_high_cpu_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighCpuDetectionArgs', 'VmwareAnomaliesEsxiHighCpuDetectionArgsDict']]] = None,
                 esxi_high_memory_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighMemoryDetectionArgs', 'VmwareAnomaliesEsxiHighMemoryDetectionArgsDict']]] = None,
                 guest_cpu_limit_detection: Optional[pulumi.Input[Union['VmwareAnomaliesGuestCpuLimitDetectionArgs', 'VmwareAnomaliesGuestCpuLimitDetectionArgsDict']]] = None,
                 low_datastore_space_detection: Optional[pulumi.Input[Union['VmwareAnomaliesLowDatastoreSpaceDetectionArgs', 'VmwareAnomaliesLowDatastoreSpaceDetectionArgsDict']]] = None,
                 overloaded_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesOverloadedStorageDetectionArgs', 'VmwareAnomaliesOverloadedStorageDetectionArgsDict']]] = None,
                 slow_physical_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesSlowPhysicalStorageDetectionArgs', 'VmwareAnomaliesSlowPhysicalStorageDetectionArgsDict']]] = None,
                 undersized_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesUndersizedStorageDetectionArgs', 'VmwareAnomaliesUndersizedStorageDetectionArgsDict']]] = None,
                 __props__=None):
        """
        Create a VmwareAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['VmwareAnomaliesDroppedPacketsDetectionArgs', 'VmwareAnomaliesDroppedPacketsDetectionArgsDict']] dropped_packets_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesEsxiHighCpuDetectionArgs', 'VmwareAnomaliesEsxiHighCpuDetectionArgsDict']] esxi_high_cpu_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesEsxiHighMemoryDetectionArgs', 'VmwareAnomaliesEsxiHighMemoryDetectionArgsDict']] esxi_high_memory_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesGuestCpuLimitDetectionArgs', 'VmwareAnomaliesGuestCpuLimitDetectionArgsDict']] guest_cpu_limit_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesLowDatastoreSpaceDetectionArgs', 'VmwareAnomaliesLowDatastoreSpaceDetectionArgsDict']] low_datastore_space_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesOverloadedStorageDetectionArgs', 'VmwareAnomaliesOverloadedStorageDetectionArgsDict']] overloaded_storage_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesSlowPhysicalStorageDetectionArgs', 'VmwareAnomaliesSlowPhysicalStorageDetectionArgsDict']] slow_physical_storage_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesUndersizedStorageDetectionArgs', 'VmwareAnomaliesUndersizedStorageDetectionArgsDict']] undersized_storage_detection: no documentation available
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VmwareAnomaliesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a VmwareAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param VmwareAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VmwareAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dropped_packets_detection: Optional[pulumi.Input[Union['VmwareAnomaliesDroppedPacketsDetectionArgs', 'VmwareAnomaliesDroppedPacketsDetectionArgsDict']]] = None,
                 esxi_high_cpu_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighCpuDetectionArgs', 'VmwareAnomaliesEsxiHighCpuDetectionArgsDict']]] = None,
                 esxi_high_memory_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighMemoryDetectionArgs', 'VmwareAnomaliesEsxiHighMemoryDetectionArgsDict']]] = None,
                 guest_cpu_limit_detection: Optional[pulumi.Input[Union['VmwareAnomaliesGuestCpuLimitDetectionArgs', 'VmwareAnomaliesGuestCpuLimitDetectionArgsDict']]] = None,
                 low_datastore_space_detection: Optional[pulumi.Input[Union['VmwareAnomaliesLowDatastoreSpaceDetectionArgs', 'VmwareAnomaliesLowDatastoreSpaceDetectionArgsDict']]] = None,
                 overloaded_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesOverloadedStorageDetectionArgs', 'VmwareAnomaliesOverloadedStorageDetectionArgsDict']]] = None,
                 slow_physical_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesSlowPhysicalStorageDetectionArgs', 'VmwareAnomaliesSlowPhysicalStorageDetectionArgsDict']]] = None,
                 undersized_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesUndersizedStorageDetectionArgs', 'VmwareAnomaliesUndersizedStorageDetectionArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VmwareAnomaliesArgs.__new__(VmwareAnomaliesArgs)

            if dropped_packets_detection is None and not opts.urn:
                raise TypeError("Missing required property 'dropped_packets_detection'")
            __props__.__dict__["dropped_packets_detection"] = dropped_packets_detection
            if esxi_high_cpu_detection is None and not opts.urn:
                raise TypeError("Missing required property 'esxi_high_cpu_detection'")
            __props__.__dict__["esxi_high_cpu_detection"] = esxi_high_cpu_detection
            if esxi_high_memory_detection is None and not opts.urn:
                raise TypeError("Missing required property 'esxi_high_memory_detection'")
            __props__.__dict__["esxi_high_memory_detection"] = esxi_high_memory_detection
            if guest_cpu_limit_detection is None and not opts.urn:
                raise TypeError("Missing required property 'guest_cpu_limit_detection'")
            __props__.__dict__["guest_cpu_limit_detection"] = guest_cpu_limit_detection
            if low_datastore_space_detection is None and not opts.urn:
                raise TypeError("Missing required property 'low_datastore_space_detection'")
            __props__.__dict__["low_datastore_space_detection"] = low_datastore_space_detection
            if overloaded_storage_detection is None and not opts.urn:
                raise TypeError("Missing required property 'overloaded_storage_detection'")
            __props__.__dict__["overloaded_storage_detection"] = overloaded_storage_detection
            if slow_physical_storage_detection is None and not opts.urn:
                raise TypeError("Missing required property 'slow_physical_storage_detection'")
            __props__.__dict__["slow_physical_storage_detection"] = slow_physical_storage_detection
            if undersized_storage_detection is None and not opts.urn:
                raise TypeError("Missing required property 'undersized_storage_detection'")
            __props__.__dict__["undersized_storage_detection"] = undersized_storage_detection
        super(VmwareAnomalies, __self__).__init__(
            'dynatrace:index/vmwareAnomalies:VmwareAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dropped_packets_detection: Optional[pulumi.Input[Union['VmwareAnomaliesDroppedPacketsDetectionArgs', 'VmwareAnomaliesDroppedPacketsDetectionArgsDict']]] = None,
            esxi_high_cpu_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighCpuDetectionArgs', 'VmwareAnomaliesEsxiHighCpuDetectionArgsDict']]] = None,
            esxi_high_memory_detection: Optional[pulumi.Input[Union['VmwareAnomaliesEsxiHighMemoryDetectionArgs', 'VmwareAnomaliesEsxiHighMemoryDetectionArgsDict']]] = None,
            guest_cpu_limit_detection: Optional[pulumi.Input[Union['VmwareAnomaliesGuestCpuLimitDetectionArgs', 'VmwareAnomaliesGuestCpuLimitDetectionArgsDict']]] = None,
            low_datastore_space_detection: Optional[pulumi.Input[Union['VmwareAnomaliesLowDatastoreSpaceDetectionArgs', 'VmwareAnomaliesLowDatastoreSpaceDetectionArgsDict']]] = None,
            overloaded_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesOverloadedStorageDetectionArgs', 'VmwareAnomaliesOverloadedStorageDetectionArgsDict']]] = None,
            slow_physical_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesSlowPhysicalStorageDetectionArgs', 'VmwareAnomaliesSlowPhysicalStorageDetectionArgsDict']]] = None,
            undersized_storage_detection: Optional[pulumi.Input[Union['VmwareAnomaliesUndersizedStorageDetectionArgs', 'VmwareAnomaliesUndersizedStorageDetectionArgsDict']]] = None) -> 'VmwareAnomalies':
        """
        Get an existing VmwareAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['VmwareAnomaliesDroppedPacketsDetectionArgs', 'VmwareAnomaliesDroppedPacketsDetectionArgsDict']] dropped_packets_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesEsxiHighCpuDetectionArgs', 'VmwareAnomaliesEsxiHighCpuDetectionArgsDict']] esxi_high_cpu_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesEsxiHighMemoryDetectionArgs', 'VmwareAnomaliesEsxiHighMemoryDetectionArgsDict']] esxi_high_memory_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesGuestCpuLimitDetectionArgs', 'VmwareAnomaliesGuestCpuLimitDetectionArgsDict']] guest_cpu_limit_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesLowDatastoreSpaceDetectionArgs', 'VmwareAnomaliesLowDatastoreSpaceDetectionArgsDict']] low_datastore_space_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesOverloadedStorageDetectionArgs', 'VmwareAnomaliesOverloadedStorageDetectionArgsDict']] overloaded_storage_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesSlowPhysicalStorageDetectionArgs', 'VmwareAnomaliesSlowPhysicalStorageDetectionArgsDict']] slow_physical_storage_detection: no documentation available
        :param pulumi.Input[Union['VmwareAnomaliesUndersizedStorageDetectionArgs', 'VmwareAnomaliesUndersizedStorageDetectionArgsDict']] undersized_storage_detection: no documentation available
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VmwareAnomaliesState.__new__(_VmwareAnomaliesState)

        __props__.__dict__["dropped_packets_detection"] = dropped_packets_detection
        __props__.__dict__["esxi_high_cpu_detection"] = esxi_high_cpu_detection
        __props__.__dict__["esxi_high_memory_detection"] = esxi_high_memory_detection
        __props__.__dict__["guest_cpu_limit_detection"] = guest_cpu_limit_detection
        __props__.__dict__["low_datastore_space_detection"] = low_datastore_space_detection
        __props__.__dict__["overloaded_storage_detection"] = overloaded_storage_detection
        __props__.__dict__["slow_physical_storage_detection"] = slow_physical_storage_detection
        __props__.__dict__["undersized_storage_detection"] = undersized_storage_detection
        return VmwareAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="droppedPacketsDetection")
    def dropped_packets_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesDroppedPacketsDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "dropped_packets_detection")

    @property
    @pulumi.getter(name="esxiHighCpuDetection")
    def esxi_high_cpu_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesEsxiHighCpuDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_cpu_detection")

    @property
    @pulumi.getter(name="esxiHighMemoryDetection")
    def esxi_high_memory_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesEsxiHighMemoryDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "esxi_high_memory_detection")

    @property
    @pulumi.getter(name="guestCpuLimitDetection")
    def guest_cpu_limit_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesGuestCpuLimitDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "guest_cpu_limit_detection")

    @property
    @pulumi.getter(name="lowDatastoreSpaceDetection")
    def low_datastore_space_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesLowDatastoreSpaceDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "low_datastore_space_detection")

    @property
    @pulumi.getter(name="overloadedStorageDetection")
    def overloaded_storage_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesOverloadedStorageDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "overloaded_storage_detection")

    @property
    @pulumi.getter(name="slowPhysicalStorageDetection")
    def slow_physical_storage_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesSlowPhysicalStorageDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "slow_physical_storage_detection")

    @property
    @pulumi.getter(name="undersizedStorageDetection")
    def undersized_storage_detection(self) -> pulumi.Output['outputs.VmwareAnomaliesUndersizedStorageDetection']:
        """
        no documentation available
        """
        return pulumi.get(self, "undersized_storage_detection")

