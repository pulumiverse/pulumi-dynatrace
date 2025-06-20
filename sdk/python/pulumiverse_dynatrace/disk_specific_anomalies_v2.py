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

__all__ = ['DiskSpecificAnomaliesV2Args', 'DiskSpecificAnomaliesV2']

@pulumi.input_type
class DiskSpecificAnomaliesV2Args:
    def __init__(__self__, *,
                 disk_id: pulumi.Input[builtins.str],
                 override_disk_low_space_detection: pulumi.Input[builtins.bool],
                 override_low_inodes_detection: pulumi.Input[builtins.bool],
                 override_slow_writes_and_reads_detection: pulumi.Input[builtins.bool],
                 disk_low_inodes_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']] = None,
                 disk_low_space_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']] = None,
                 disk_slow_writes_and_reads_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']] = None):
        """
        The set of arguments for constructing a DiskSpecificAnomaliesV2 resource.
        :param pulumi.Input[builtins.str] disk_id: The id for the disk anomaly detection
        :param pulumi.Input[builtins.bool] override_disk_low_space_detection: Override low disk space detection settings
        :param pulumi.Input[builtins.bool] override_low_inodes_detection: Override low inodes detection settings
        :param pulumi.Input[builtins.bool] override_slow_writes_and_reads_detection: Override slow writes and reads detection settings
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs'] disk_low_inodes_detection: no documentation available
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs'] disk_low_space_detection: no documentation available
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs'] disk_slow_writes_and_reads_detection: no documentation available
        """
        pulumi.set(__self__, "disk_id", disk_id)
        pulumi.set(__self__, "override_disk_low_space_detection", override_disk_low_space_detection)
        pulumi.set(__self__, "override_low_inodes_detection", override_low_inodes_detection)
        pulumi.set(__self__, "override_slow_writes_and_reads_detection", override_slow_writes_and_reads_detection)
        if disk_low_inodes_detection is not None:
            pulumi.set(__self__, "disk_low_inodes_detection", disk_low_inodes_detection)
        if disk_low_space_detection is not None:
            pulumi.set(__self__, "disk_low_space_detection", disk_low_space_detection)
        if disk_slow_writes_and_reads_detection is not None:
            pulumi.set(__self__, "disk_slow_writes_and_reads_detection", disk_slow_writes_and_reads_detection)

    @property
    @pulumi.getter(name="diskId")
    def disk_id(self) -> pulumi.Input[builtins.str]:
        """
        The id for the disk anomaly detection
        """
        return pulumi.get(self, "disk_id")

    @disk_id.setter
    def disk_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "disk_id", value)

    @property
    @pulumi.getter(name="overrideDiskLowSpaceDetection")
    def override_disk_low_space_detection(self) -> pulumi.Input[builtins.bool]:
        """
        Override low disk space detection settings
        """
        return pulumi.get(self, "override_disk_low_space_detection")

    @override_disk_low_space_detection.setter
    def override_disk_low_space_detection(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "override_disk_low_space_detection", value)

    @property
    @pulumi.getter(name="overrideLowInodesDetection")
    def override_low_inodes_detection(self) -> pulumi.Input[builtins.bool]:
        """
        Override low inodes detection settings
        """
        return pulumi.get(self, "override_low_inodes_detection")

    @override_low_inodes_detection.setter
    def override_low_inodes_detection(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "override_low_inodes_detection", value)

    @property
    @pulumi.getter(name="overrideSlowWritesAndReadsDetection")
    def override_slow_writes_and_reads_detection(self) -> pulumi.Input[builtins.bool]:
        """
        Override slow writes and reads detection settings
        """
        return pulumi.get(self, "override_slow_writes_and_reads_detection")

    @override_slow_writes_and_reads_detection.setter
    def override_slow_writes_and_reads_detection(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "override_slow_writes_and_reads_detection", value)

    @property
    @pulumi.getter(name="diskLowInodesDetection")
    def disk_low_inodes_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_inodes_detection")

    @disk_low_inodes_detection.setter
    def disk_low_inodes_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']]):
        pulumi.set(self, "disk_low_inodes_detection", value)

    @property
    @pulumi.getter(name="diskLowSpaceDetection")
    def disk_low_space_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_space_detection")

    @disk_low_space_detection.setter
    def disk_low_space_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']]):
        pulumi.set(self, "disk_low_space_detection", value)

    @property
    @pulumi.getter(name="diskSlowWritesAndReadsDetection")
    def disk_slow_writes_and_reads_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_slow_writes_and_reads_detection")

    @disk_slow_writes_and_reads_detection.setter
    def disk_slow_writes_and_reads_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']]):
        pulumi.set(self, "disk_slow_writes_and_reads_detection", value)


@pulumi.input_type
class _DiskSpecificAnomaliesV2State:
    def __init__(__self__, *,
                 disk_id: Optional[pulumi.Input[builtins.str]] = None,
                 disk_low_inodes_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']] = None,
                 disk_low_space_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']] = None,
                 disk_slow_writes_and_reads_detection: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']] = None,
                 override_disk_low_space_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_low_inodes_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_slow_writes_and_reads_detection: Optional[pulumi.Input[builtins.bool]] = None):
        """
        Input properties used for looking up and filtering DiskSpecificAnomaliesV2 resources.
        :param pulumi.Input[builtins.str] disk_id: The id for the disk anomaly detection
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs'] disk_low_inodes_detection: no documentation available
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs'] disk_low_space_detection: no documentation available
        :param pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs'] disk_slow_writes_and_reads_detection: no documentation available
        :param pulumi.Input[builtins.bool] override_disk_low_space_detection: Override low disk space detection settings
        :param pulumi.Input[builtins.bool] override_low_inodes_detection: Override low inodes detection settings
        :param pulumi.Input[builtins.bool] override_slow_writes_and_reads_detection: Override slow writes and reads detection settings
        """
        if disk_id is not None:
            pulumi.set(__self__, "disk_id", disk_id)
        if disk_low_inodes_detection is not None:
            pulumi.set(__self__, "disk_low_inodes_detection", disk_low_inodes_detection)
        if disk_low_space_detection is not None:
            pulumi.set(__self__, "disk_low_space_detection", disk_low_space_detection)
        if disk_slow_writes_and_reads_detection is not None:
            pulumi.set(__self__, "disk_slow_writes_and_reads_detection", disk_slow_writes_and_reads_detection)
        if override_disk_low_space_detection is not None:
            pulumi.set(__self__, "override_disk_low_space_detection", override_disk_low_space_detection)
        if override_low_inodes_detection is not None:
            pulumi.set(__self__, "override_low_inodes_detection", override_low_inodes_detection)
        if override_slow_writes_and_reads_detection is not None:
            pulumi.set(__self__, "override_slow_writes_and_reads_detection", override_slow_writes_and_reads_detection)

    @property
    @pulumi.getter(name="diskId")
    def disk_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The id for the disk anomaly detection
        """
        return pulumi.get(self, "disk_id")

    @disk_id.setter
    def disk_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "disk_id", value)

    @property
    @pulumi.getter(name="diskLowInodesDetection")
    def disk_low_inodes_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_inodes_detection")

    @disk_low_inodes_detection.setter
    def disk_low_inodes_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs']]):
        pulumi.set(self, "disk_low_inodes_detection", value)

    @property
    @pulumi.getter(name="diskLowSpaceDetection")
    def disk_low_space_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_space_detection")

    @disk_low_space_detection.setter
    def disk_low_space_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs']]):
        pulumi.set(self, "disk_low_space_detection", value)

    @property
    @pulumi.getter(name="diskSlowWritesAndReadsDetection")
    def disk_slow_writes_and_reads_detection(self) -> Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_slow_writes_and_reads_detection")

    @disk_slow_writes_and_reads_detection.setter
    def disk_slow_writes_and_reads_detection(self, value: Optional[pulumi.Input['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs']]):
        pulumi.set(self, "disk_slow_writes_and_reads_detection", value)

    @property
    @pulumi.getter(name="overrideDiskLowSpaceDetection")
    def override_disk_low_space_detection(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Override low disk space detection settings
        """
        return pulumi.get(self, "override_disk_low_space_detection")

    @override_disk_low_space_detection.setter
    def override_disk_low_space_detection(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "override_disk_low_space_detection", value)

    @property
    @pulumi.getter(name="overrideLowInodesDetection")
    def override_low_inodes_detection(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Override low inodes detection settings
        """
        return pulumi.get(self, "override_low_inodes_detection")

    @override_low_inodes_detection.setter
    def override_low_inodes_detection(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "override_low_inodes_detection", value)

    @property
    @pulumi.getter(name="overrideSlowWritesAndReadsDetection")
    def override_slow_writes_and_reads_detection(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Override slow writes and reads detection settings
        """
        return pulumi.get(self, "override_slow_writes_and_reads_detection")

    @override_slow_writes_and_reads_detection.setter
    def override_slow_writes_and_reads_detection(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "override_slow_writes_and_reads_detection", value)


@pulumi.type_token("dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2")
class DiskSpecificAnomaliesV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk_id: Optional[pulumi.Input[builtins.str]] = None,
                 disk_low_inodes_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowInodesDetectionArgsDict']]] = None,
                 disk_low_space_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgsDict']]] = None,
                 disk_slow_writes_and_reads_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs', 'DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgsDict']]] = None,
                 override_disk_low_space_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_low_inodes_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_slow_writes_and_reads_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        """
        Create a DiskSpecificAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] disk_id: The id for the disk anomaly detection
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowInodesDetectionArgsDict']] disk_low_inodes_detection: no documentation available
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgsDict']] disk_low_space_detection: no documentation available
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs', 'DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgsDict']] disk_slow_writes_and_reads_detection: no documentation available
        :param pulumi.Input[builtins.bool] override_disk_low_space_detection: Override low disk space detection settings
        :param pulumi.Input[builtins.bool] override_low_inodes_detection: Override low inodes detection settings
        :param pulumi.Input[builtins.bool] override_slow_writes_and_reads_detection: Override slow writes and reads detection settings
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DiskSpecificAnomaliesV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DiskSpecificAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DiskSpecificAnomaliesV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DiskSpecificAnomaliesV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk_id: Optional[pulumi.Input[builtins.str]] = None,
                 disk_low_inodes_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowInodesDetectionArgsDict']]] = None,
                 disk_low_space_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgsDict']]] = None,
                 disk_slow_writes_and_reads_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs', 'DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgsDict']]] = None,
                 override_disk_low_space_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_low_inodes_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 override_slow_writes_and_reads_detection: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DiskSpecificAnomaliesV2Args.__new__(DiskSpecificAnomaliesV2Args)

            if disk_id is None and not opts.urn:
                raise TypeError("Missing required property 'disk_id'")
            __props__.__dict__["disk_id"] = disk_id
            __props__.__dict__["disk_low_inodes_detection"] = disk_low_inodes_detection
            __props__.__dict__["disk_low_space_detection"] = disk_low_space_detection
            __props__.__dict__["disk_slow_writes_and_reads_detection"] = disk_slow_writes_and_reads_detection
            if override_disk_low_space_detection is None and not opts.urn:
                raise TypeError("Missing required property 'override_disk_low_space_detection'")
            __props__.__dict__["override_disk_low_space_detection"] = override_disk_low_space_detection
            if override_low_inodes_detection is None and not opts.urn:
                raise TypeError("Missing required property 'override_low_inodes_detection'")
            __props__.__dict__["override_low_inodes_detection"] = override_low_inodes_detection
            if override_slow_writes_and_reads_detection is None and not opts.urn:
                raise TypeError("Missing required property 'override_slow_writes_and_reads_detection'")
            __props__.__dict__["override_slow_writes_and_reads_detection"] = override_slow_writes_and_reads_detection
        super(DiskSpecificAnomaliesV2, __self__).__init__(
            'dynatrace:index/diskSpecificAnomaliesV2:DiskSpecificAnomaliesV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            disk_id: Optional[pulumi.Input[builtins.str]] = None,
            disk_low_inodes_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowInodesDetectionArgsDict']]] = None,
            disk_low_space_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgsDict']]] = None,
            disk_slow_writes_and_reads_detection: Optional[pulumi.Input[Union['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs', 'DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgsDict']]] = None,
            override_disk_low_space_detection: Optional[pulumi.Input[builtins.bool]] = None,
            override_low_inodes_detection: Optional[pulumi.Input[builtins.bool]] = None,
            override_slow_writes_and_reads_detection: Optional[pulumi.Input[builtins.bool]] = None) -> 'DiskSpecificAnomaliesV2':
        """
        Get an existing DiskSpecificAnomaliesV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] disk_id: The id for the disk anomaly detection
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowInodesDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowInodesDetectionArgsDict']] disk_low_inodes_detection: no documentation available
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgs', 'DiskSpecificAnomaliesV2DiskLowSpaceDetectionArgsDict']] disk_low_space_detection: no documentation available
        :param pulumi.Input[Union['DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgs', 'DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetectionArgsDict']] disk_slow_writes_and_reads_detection: no documentation available
        :param pulumi.Input[builtins.bool] override_disk_low_space_detection: Override low disk space detection settings
        :param pulumi.Input[builtins.bool] override_low_inodes_detection: Override low inodes detection settings
        :param pulumi.Input[builtins.bool] override_slow_writes_and_reads_detection: Override slow writes and reads detection settings
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DiskSpecificAnomaliesV2State.__new__(_DiskSpecificAnomaliesV2State)

        __props__.__dict__["disk_id"] = disk_id
        __props__.__dict__["disk_low_inodes_detection"] = disk_low_inodes_detection
        __props__.__dict__["disk_low_space_detection"] = disk_low_space_detection
        __props__.__dict__["disk_slow_writes_and_reads_detection"] = disk_slow_writes_and_reads_detection
        __props__.__dict__["override_disk_low_space_detection"] = override_disk_low_space_detection
        __props__.__dict__["override_low_inodes_detection"] = override_low_inodes_detection
        __props__.__dict__["override_slow_writes_and_reads_detection"] = override_slow_writes_and_reads_detection
        return DiskSpecificAnomaliesV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="diskId")
    def disk_id(self) -> pulumi.Output[builtins.str]:
        """
        The id for the disk anomaly detection
        """
        return pulumi.get(self, "disk_id")

    @property
    @pulumi.getter(name="diskLowInodesDetection")
    def disk_low_inodes_detection(self) -> pulumi.Output[Optional['outputs.DiskSpecificAnomaliesV2DiskLowInodesDetection']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_inodes_detection")

    @property
    @pulumi.getter(name="diskLowSpaceDetection")
    def disk_low_space_detection(self) -> pulumi.Output[Optional['outputs.DiskSpecificAnomaliesV2DiskLowSpaceDetection']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_low_space_detection")

    @property
    @pulumi.getter(name="diskSlowWritesAndReadsDetection")
    def disk_slow_writes_and_reads_detection(self) -> pulumi.Output[Optional['outputs.DiskSpecificAnomaliesV2DiskSlowWritesAndReadsDetection']]:
        """
        no documentation available
        """
        return pulumi.get(self, "disk_slow_writes_and_reads_detection")

    @property
    @pulumi.getter(name="overrideDiskLowSpaceDetection")
    def override_disk_low_space_detection(self) -> pulumi.Output[builtins.bool]:
        """
        Override low disk space detection settings
        """
        return pulumi.get(self, "override_disk_low_space_detection")

    @property
    @pulumi.getter(name="overrideLowInodesDetection")
    def override_low_inodes_detection(self) -> pulumi.Output[builtins.bool]:
        """
        Override low inodes detection settings
        """
        return pulumi.get(self, "override_low_inodes_detection")

    @property
    @pulumi.getter(name="overrideSlowWritesAndReadsDetection")
    def override_slow_writes_and_reads_detection(self) -> pulumi.Output[builtins.bool]:
        """
        Override slow writes and reads detection settings
        """
        return pulumi.get(self, "override_slow_writes_and_reads_detection")

