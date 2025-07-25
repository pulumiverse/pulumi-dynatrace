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

__all__ = ['LogAgentFeatureFlagsArgs', 'LogAgentFeatureFlags']

@pulumi.input_type
class LogAgentFeatureFlagsArgs:
    def __init__(__self__, *,
                 new_container_log_detector: pulumi.Input[builtins.bool],
                 journald_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 user_and_event_data: Optional[pulumi.Input[builtins.bool]] = None):
        """
        The set of arguments for constructing a LogAgentFeatureFlags resource.
        :param pulumi.Input[builtins.bool] new_container_log_detector: Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
               collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
               processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
               * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
               configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
               more details, check our [documentation](https://dt-url.net/jn02ey0).
        :param pulumi.Input[builtins.bool] journald_log_detector: Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
               ingested matching ingest rule is required.
        :param pulumi.Input[builtins.str] scope: The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
               environment.
        :param pulumi.Input[builtins.bool] user_and_event_data: Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        pulumi.set(__self__, "new_container_log_detector", new_container_log_detector)
        if journald_log_detector is not None:
            pulumi.set(__self__, "journald_log_detector", journald_log_detector)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if user_and_event_data is not None:
            pulumi.set(__self__, "user_and_event_data", user_and_event_data)

    @property
    @pulumi.getter(name="newContainerLogDetector")
    def new_container_log_detector(self) -> pulumi.Input[builtins.bool]:
        """
        Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
        collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
        processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
        * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
        configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
        more details, check our [documentation](https://dt-url.net/jn02ey0).
        """
        return pulumi.get(self, "new_container_log_detector")

    @new_container_log_detector.setter
    def new_container_log_detector(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "new_container_log_detector", value)

    @property
    @pulumi.getter(name="journaldLogDetector")
    def journald_log_detector(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
        ingested matching ingest rule is required.
        """
        return pulumi.get(self, "journald_log_detector")

    @journald_log_detector.setter
    def journald_log_detector(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "journald_log_detector", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
        environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter(name="userAndEventData")
    def user_and_event_data(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        return pulumi.get(self, "user_and_event_data")

    @user_and_event_data.setter
    def user_and_event_data(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "user_and_event_data", value)


@pulumi.input_type
class _LogAgentFeatureFlagsState:
    def __init__(__self__, *,
                 journald_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 new_container_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 user_and_event_data: Optional[pulumi.Input[builtins.bool]] = None):
        """
        Input properties used for looking up and filtering LogAgentFeatureFlags resources.
        :param pulumi.Input[builtins.bool] journald_log_detector: Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
               ingested matching ingest rule is required.
        :param pulumi.Input[builtins.bool] new_container_log_detector: Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
               collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
               processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
               * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
               configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
               more details, check our [documentation](https://dt-url.net/jn02ey0).
        :param pulumi.Input[builtins.str] scope: The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
               environment.
        :param pulumi.Input[builtins.bool] user_and_event_data: Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        if journald_log_detector is not None:
            pulumi.set(__self__, "journald_log_detector", journald_log_detector)
        if new_container_log_detector is not None:
            pulumi.set(__self__, "new_container_log_detector", new_container_log_detector)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if user_and_event_data is not None:
            pulumi.set(__self__, "user_and_event_data", user_and_event_data)

    @property
    @pulumi.getter(name="journaldLogDetector")
    def journald_log_detector(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
        ingested matching ingest rule is required.
        """
        return pulumi.get(self, "journald_log_detector")

    @journald_log_detector.setter
    def journald_log_detector(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "journald_log_detector", value)

    @property
    @pulumi.getter(name="newContainerLogDetector")
    def new_container_log_detector(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
        collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
        processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
        * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
        configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
        more details, check our [documentation](https://dt-url.net/jn02ey0).
        """
        return pulumi.get(self, "new_container_log_detector")

    @new_container_log_detector.setter
    def new_container_log_detector(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "new_container_log_detector", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
        environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter(name="userAndEventData")
    def user_and_event_data(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        return pulumi.get(self, "user_and_event_data")

    @user_and_event_data.setter
    def user_and_event_data(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "user_and_event_data", value)


@pulumi.type_token("dynatrace:index/logAgentFeatureFlags:LogAgentFeatureFlags")
class LogAgentFeatureFlags(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 journald_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 new_container_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 user_and_event_data: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        """
        Create a LogAgentFeatureFlags resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] journald_log_detector: Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
               ingested matching ingest rule is required.
        :param pulumi.Input[builtins.bool] new_container_log_detector: Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
               collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
               processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
               * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
               configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
               more details, check our [documentation](https://dt-url.net/jn02ey0).
        :param pulumi.Input[builtins.str] scope: The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
               environment.
        :param pulumi.Input[builtins.bool] user_and_event_data: Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LogAgentFeatureFlagsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a LogAgentFeatureFlags resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param LogAgentFeatureFlagsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LogAgentFeatureFlagsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 journald_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 new_container_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
                 scope: Optional[pulumi.Input[builtins.str]] = None,
                 user_and_event_data: Optional[pulumi.Input[builtins.bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LogAgentFeatureFlagsArgs.__new__(LogAgentFeatureFlagsArgs)

            __props__.__dict__["journald_log_detector"] = journald_log_detector
            if new_container_log_detector is None and not opts.urn:
                raise TypeError("Missing required property 'new_container_log_detector'")
            __props__.__dict__["new_container_log_detector"] = new_container_log_detector
            __props__.__dict__["scope"] = scope
            __props__.__dict__["user_and_event_data"] = user_and_event_data
        super(LogAgentFeatureFlags, __self__).__init__(
            'dynatrace:index/logAgentFeatureFlags:LogAgentFeatureFlags',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            journald_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
            new_container_log_detector: Optional[pulumi.Input[builtins.bool]] = None,
            scope: Optional[pulumi.Input[builtins.str]] = None,
            user_and_event_data: Optional[pulumi.Input[builtins.bool]] = None) -> 'LogAgentFeatureFlags':
        """
        Get an existing LogAgentFeatureFlags resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.bool] journald_log_detector: Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
               ingested matching ingest rule is required.
        :param pulumi.Input[builtins.bool] new_container_log_detector: Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
               collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
               processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
               * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
               configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
               more details, check our [documentation](https://dt-url.net/jn02ey0).
        :param pulumi.Input[builtins.str] scope: The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
               environment.
        :param pulumi.Input[builtins.bool] user_and_event_data: Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LogAgentFeatureFlagsState.__new__(_LogAgentFeatureFlagsState)

        __props__.__dict__["journald_log_detector"] = journald_log_detector
        __props__.__dict__["new_container_log_detector"] = new_container_log_detector
        __props__.__dict__["scope"] = scope
        __props__.__dict__["user_and_event_data"] = user_and_event_data
        return LogAgentFeatureFlags(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="journaldLogDetector")
    def journald_log_detector(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        Enable OneAgent to collect logs from Journald on Linux systems. This setting enables: * Detection and to have logs
        ingested matching ingest rule is required.
        """
        return pulumi.get(self, "journald_log_detector")

    @property
    @pulumi.getter(name="newContainerLogDetector")
    def new_container_log_detector(self) -> pulumi.Output[builtins.bool]:
        """
        Enable OneAgent to collect all container logs in Kubernetes environments. This setting enables: * Detection and
        collection of logs from short-lived containers and processes in Kubernetes. * Detection and collection of logs from any
        processes in containers in Kubernetes. Up until now only processes detected by OneAgent are covered with the Log module.
        * Log events decoration according to semantic dictionary. **Note:** The matcher "Deployment name" in the log sources
        configuration will be ignored and needs to be replaced with "Workload name", requires **Dynatrace Operator 1.4.2+**. For
        more details, check our [documentation](https://dt-url.net/jn02ey0).
        """
        return pulumi.get(self, "new_container_log_detector")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The scope of this setting (HOST, KUBERNETES_CLUSTER, HOST_GROUP). Omit this property if you want to cover the whole
        environment.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter(name="userAndEventData")
    def user_and_event_data(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        Enable OneAgent to collect data from Event Logs in the User Data and Event Data sections.
        """
        return pulumi.get(self, "user_and_event_data")

