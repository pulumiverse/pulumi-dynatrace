# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['HistogramMetricsArgs', 'HistogramMetrics']

@pulumi.input_type
class HistogramMetricsArgs:
    def __init__(__self__, *,
                 enable_histogram_bucket_ingest: pulumi.Input[bool]):
        """
        The set of arguments for constructing a HistogramMetrics resource.
        :param pulumi.Input[bool] enable_histogram_bucket_ingest: When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
               Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
               When disabled, only your histograms' sum and count metrics will be ingested.
        """
        pulumi.set(__self__, "enable_histogram_bucket_ingest", enable_histogram_bucket_ingest)

    @property
    @pulumi.getter(name="enableHistogramBucketIngest")
    def enable_histogram_bucket_ingest(self) -> pulumi.Input[bool]:
        """
        When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
        Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
        When disabled, only your histograms' sum and count metrics will be ingested.
        """
        return pulumi.get(self, "enable_histogram_bucket_ingest")

    @enable_histogram_bucket_ingest.setter
    def enable_histogram_bucket_ingest(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enable_histogram_bucket_ingest", value)


@pulumi.input_type
class _HistogramMetricsState:
    def __init__(__self__, *,
                 enable_histogram_bucket_ingest: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering HistogramMetrics resources.
        :param pulumi.Input[bool] enable_histogram_bucket_ingest: When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
               Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
               When disabled, only your histograms' sum and count metrics will be ingested.
        """
        if enable_histogram_bucket_ingest is not None:
            pulumi.set(__self__, "enable_histogram_bucket_ingest", enable_histogram_bucket_ingest)

    @property
    @pulumi.getter(name="enableHistogramBucketIngest")
    def enable_histogram_bucket_ingest(self) -> Optional[pulumi.Input[bool]]:
        """
        When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
        Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
        When disabled, only your histograms' sum and count metrics will be ingested.
        """
        return pulumi.get(self, "enable_histogram_bucket_ingest")

    @enable_histogram_bucket_ingest.setter
    def enable_histogram_bucket_ingest(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_histogram_bucket_ingest", value)


class HistogramMetrics(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_histogram_bucket_ingest: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Create a HistogramMetrics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_histogram_bucket_ingest: When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
               Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
               When disabled, only your histograms' sum and count metrics will be ingested.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HistogramMetricsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a HistogramMetrics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param HistogramMetricsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HistogramMetricsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_histogram_bucket_ingest: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HistogramMetricsArgs.__new__(HistogramMetricsArgs)

            if enable_histogram_bucket_ingest is None and not opts.urn:
                raise TypeError("Missing required property 'enable_histogram_bucket_ingest'")
            __props__.__dict__["enable_histogram_bucket_ingest"] = enable_histogram_bucket_ingest
        super(HistogramMetrics, __self__).__init__(
            'dynatrace:index/histogramMetrics:HistogramMetrics',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enable_histogram_bucket_ingest: Optional[pulumi.Input[bool]] = None) -> 'HistogramMetrics':
        """
        Get an existing HistogramMetrics resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_histogram_bucket_ingest: When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
               Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
               When disabled, only your histograms' sum and count metrics will be ingested.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _HistogramMetricsState.__new__(_HistogramMetricsState)

        __props__.__dict__["enable_histogram_bucket_ingest"] = enable_histogram_bucket_ingest
        return HistogramMetrics(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="enableHistogramBucketIngest")
    def enable_histogram_bucket_ingest(self) -> pulumi.Output[bool]:
        """
        When enabled, you can ingest the `le` dimension, representing explicit histogram buckets.\\
        Enable this if you are using OpenTelemetry histograms or Prometheus histogram metrics.\\
        When disabled, only your histograms' sum and count metrics will be ingested.
        """
        return pulumi.get(self, "enable_histogram_bucket_ingest")
